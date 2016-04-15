using System;
using System.Collections.Generic;
using AsmJit.AssemblerContext;
using AsmJit.Common;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext.CodeTree;

namespace AsmJit.CompilerContext
{
	internal sealed class Fetcher
	{
		private enum Result
		{
			//			Switch,
			Do,
			Break,
			Done,
			NextGroup
		}

		private static long _indexMask = Utils.Bits(Cpu.Info.RegisterCount.Gp) & ~Utils.Mask(4, 12);

		private Compiler _compiler;

		private FunctionNode _functionNode;
		private CodeNode _stopNode;
		private int _jLinkIndex;
		private CodeNode _node;
		private CodeNode _next;
		private VariableContext _variableContext;
		private FunctionDeclaration _functionDeclaration;
		private SArgData[] _sArgDatas;
		private List<CodeNode> _unreachableList;

		internal Fetcher(Compiler compiler, FunctionNode func)
		{
			_compiler = compiler;
			_functionNode = func;
			_stopNode = func.End.Next;

			_variableContext = new VariableContext();

			_functionNode.FunctionFlags &= ~(FunctionNodeFlags.IsNaked | FunctionNodeFlags.X86Emms | FunctionNodeFlags.X86SFence | FunctionNodeFlags.X86LFence);

			if (_functionNode.HasHint(FuncionNodeHints.Naked))
			{
				_functionNode.FunctionFlags |= FunctionNodeFlags.IsNaked;
			}
			if (_functionNode.HasHint(FuncionNodeHints.Compact))
			{
				_functionNode.FunctionFlags |= FunctionNodeFlags.X86Leave;
			}
			if (_functionNode.HasHint(FuncionNodeHints.X86Emms))
			{
				_functionNode.FunctionFlags |= FunctionNodeFlags.X86Emms;
			}
			if (_functionNode.HasHint(FuncionNodeHints.X86SFence))
			{
				_functionNode.FunctionFlags |= FunctionNodeFlags.X86SFence;
			}
			if (_functionNode.HasHint(FuncionNodeHints.X86LFence))
			{
				_functionNode.FunctionFlags |= FunctionNodeFlags.X86LFence;
			}

			if (!_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsNaked))
			{
				_variableContext.GaRegs[RegisterClass.Gp] &= ~Utils.Mask(RegisterIndex.Bp);
			}

			_functionDeclaration = _functionNode.FunctionDeclaration;
			_unreachableList = new List<CodeNode>();
			_sArgDatas = new SArgData[80].InitializeWith(() => new SArgData());

			_jLinkIndex = -1;
		}

		internal VariableContext Run()
		{
			var flowId = 0;

			_next = null;
			_node = _functionNode;

			var result = Result.Do;
			do
			{
				if (result == Result.Done) break;

				if (GoTo(@do: result != Result.NextGroup) == Result.Done) break;

				flowId++;

				_next = _node.Next;
				_node.FlowId = flowId;

				switch (_node.Type)
				{
					case CodeNodeType.None:
					case CodeNodeType.Data:
					case CodeNodeType.Alignment:
					case CodeNodeType.Comment:
					case CodeNodeType.CallArgument:
						break;
					case CodeNodeType.Label:
						result = OnFetchLabel();
						break;
					case CodeNodeType.Sentinel:
						result = OnFetchSentinel();
						break;
					case CodeNodeType.Instruction:
						result = OnFetchInstruction();
						break;
					case CodeNodeType.Hint:
						result = OnFetchHint();
						break;
					case CodeNodeType.Function:
						result = OnFetchFunction();
						break;
					case CodeNodeType.Return:
						result = OnFetchReturn();
						break;
					case CodeNodeType.Call:
						result = OnFetchCall();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
				if (result == Result.Do || result == Result.NextGroup || result == Result.Done) continue;
				_node = _next;
			} while (_node != _stopNode);
			// Mark exit label and end node as fetched, otherwise they can be removed by
			// `removeUnreachableCode()`, which would lead to crash in some later step.
			_node = _functionNode.End;
			if (_node.IsFetched())
			{
				RemoveUnreachableCode();

				return _variableContext;
			}
			_functionNode.Exit.FlowId = ++flowId;
			_node.FlowId = ++flowId;

			RemoveUnreachableCode();

			return _variableContext;
		}

		private Result OnFetchLabel()
		{
			var node = _node.As<LabelNode>();
			if (node != _functionNode.Exit)
			{
				return Result.Break;
			}
			_variableContext.ReturningList.Add(node);
			return Result.NextGroup;
		}

		private Result OnFetchSentinel()
		{
			_variableContext.ReturningList.Add(_node);
			return Result.NextGroup;
		}

		private Result OnFetchFunction()
		{
			_variableContext.Begin();

			for (int i = 0, argCount = _functionDeclaration.ArgumentCount; i < argCount; i++)
			{
				var arg = _functionDeclaration.GetArgument(i);
				var vd = _functionNode.GetArgument(i);

				if (vd == null) continue;

				// Overlapped function arguments.
				if (vd.Attributes != null)
				{
					throw new ArgumentException("Overlapped function arguments");
				}
				var va = _variableContext.Add(vd, 0, 0);

				var aType = arg.VariableType;
				var vType = vd.Type;

				if (arg.RegisterIndex != RegisterIndex.Invalid)
				{
					if (aType.GetRegisterClass() == vd.Info.RegisterClass)
					{
						va.Flags |= VariableFlags.WReg;
						va.OutRegIndex = arg.RegisterIndex;
					}
					else
					{
						va.Flags |= VariableFlags.WConv;
					}
				}
				else
				{
					if ((aType.GetRegisterClass() == vd.Info.RegisterClass) || (vType == VariableType.XmmSs && aType == VariableType.Fp32) || (vType == VariableType.XmmSd && aType == VariableType.Fp64))
					{
						va.Flags |= VariableFlags.WMem;
					}
					else
					{
						// TODO: [COMPILER] Not implemented.
					}
				}
			}

			_variableContext.End(_node);
			return Result.Break;
		}

		private Result OnFetchHint()
		{
			var node = _node.As<HintNode>();

			_variableContext.Begin();

			if (node.Hint == VariableHint.Alloc)
			{
				var remain = new Dictionary<RegisterClass, int>();
				var cur = node;

				remain[RegisterClass.Gp] = Cpu.Info.RegisterCount.Gp - 1 - _functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsNaked).AsInt();
				remain[RegisterClass.Mm] = Cpu.Info.RegisterCount.Mm;
				remain[RegisterClass.K] = Cpu.Info.RegisterCount.K;
				remain[RegisterClass.Xyz] = Cpu.Info.RegisterCount.Xyz;

				// Merge as many alloc-hints as possible.
				for (; ; )
				{
					var vd = cur.Data;
					var va = vd.Attributes;

					var regClass = vd.Info.RegisterClass;
					var regIndex = cur.Value;
					var regMask = 0;

					// We handle both kInvalidReg and kInvalidValue.
					if (regIndex != RegisterIndex.Invalid)
					{
						regMask = Utils.Mask(regIndex);
					}

					if (va == null)
					{
						if (_variableContext.InRegs.Has(regClass, regMask)) break;
						if (remain[regClass] == 0) break;

						va = _variableContext.Add(vd, VariableFlags.RReg, _variableContext.GaRegs[regClass]);

						if (regMask != 0)
						{
							_variableContext.InRegs.Xor(regClass, regMask);
							va.InRegs = regMask;
							va.InRegIndex = regIndex;
						}

						remain[regClass]--;
					}
					else if (regMask != 0)
					{
						if (_variableContext.InRegs.Has(regClass, regMask) && va.InRegIndex != regMask) break;

						_variableContext.InRegs.Xor(regClass, va.InRegIndex | regMask);
						va.InRegs = regMask;
						va.InRegIndex = regIndex;
					}

					if (cur != node)
					{
						_compiler.RemoveNode(cur);
					}

					if (node.Next == null || node.Next.Type != CodeNodeType.Hint || node.Next.As<HintNode>().Hint != VariableHint.Alloc) break;
					cur = node.Next.As<HintNode>();
				}
				_next = _node.Next;
			}
			else
			{
				var hnode = _node.As<HintNode>();
				var vd = hnode.Data;

				VariableFlags uflags = 0;

				switch (hnode.Hint)
				{
					case VariableHint.Spill:
						uflags = VariableFlags.RMem | VariableFlags.Spill;
						break;
					case VariableHint.Save:
						uflags = VariableFlags.RMem;
						break;
					case VariableHint.SaveAndUnuse:
						uflags = VariableFlags.RMem | VariableFlags.Unuse;
						break;
					case VariableHint.Unuse:
						uflags = VariableFlags.Unuse;
						break;
				}

				_variableContext.Add(vd, uflags, 0);
			}
			_variableContext.End(_node);
			return Result.Break;
		}

		private Result OnFetchReturn()
		{
			var retn = _node.As<ReturnNode>();
			_variableContext.ReturningList.Add(retn);

			if (_functionDeclaration.ReturnCount != 0)
			{
				var ret = _functionDeclaration.GetReturn(0);
				var retClass = ret.VariableType.GetRegisterClass();

				_variableContext.Begin();

				for (var i = 0; i < 2; i++)
				{
					var op = retn.Operands[i];
					if (!op.IsVariable()) continue;
					var vd = _compiler.GetVariableData(op.Id);

					var va = _variableContext.Merge(vd, 0, 0);

					if (retClass == vd.Info.RegisterClass)
					{
						// TODO: [COMPILER] Fix HLRet fetch.
						va.Flags |= VariableFlags.RReg;
						va.InRegs = i == 0 ? Utils.Mask(RegisterIndex.Ax) : Utils.Mask(RegisterIndex.Dx);
						_variableContext.InRegs.Or(retClass, va.InRegs);
					}
					else if (retClass == RegisterClass.Fp)
					{
						var fldFlag = ret.VariableType == VariableType.Fp32 ? VariableFlags.X86Fld4 : VariableFlags.X86Fld8;
						va.Flags |= VariableFlags.RMem | fldFlag;
					}
					else
					{
						// TODO: Fix possible other return type conversions.
					}
				}
				_variableContext.End(_node);
			}
			if (_next.IsFetched())
			{
				return Result.Break;
			}
			_unreachableList.Add(_next);
			return Result.NextGroup;
		}

		private Result OnFetchCall()
		{
			var call = _node.As<CallNode>();
			var cdecl = call.FunctionDeclaration;

			var target = call.Target;
			var args = call.Arguments;
			var rets = call.Return;

			_functionNode.FunctionFlags |= FunctionNodeFlags.IsCaller;
			_functionNode.MergeCallStackSize(cdecl.ArgumentsStackSize);

			int i;
			var argCount = cdecl.ArgumentCount;
			var sArgCount = 0;
			var gpAllocableMask = _variableContext.GaRegs[RegisterClass.Gp] & ~call.UsedArgs.Get(RegisterClass.Gp);

			VariableData vd;
			VariableAttributes va;

			_variableContext.Begin();
			// Function-call operand.
			if (target.IsVariable())
			{
				vd = _compiler.GetVariableData(target.Id);
				va = _variableContext.Merge(vd, 0, 0);

				va.Flags |= VariableFlags.RReg | VariableFlags.RCall;
				if (va.InRegs == 0)
				{
					va.AllocableRegs |= gpAllocableMask;
				}
			}
			else if (target.IsMemory())
			{
				var m = target.As<Memory>();

				if (m.Base.IsVariableId() && m.IsBaseIndexType())
				{
					vd = _compiler.GetVariableData(m.Base);
					if (!vd.IsStack)
					{
						va = _variableContext.Merge(vd, 0, 0);
						if (m.MemoryType == MemoryType.BaseIndex)
						{
							va.Flags |= VariableFlags.RReg | VariableFlags.RCall;
							if (va.InRegs == 0)
							{
								va.AllocableRegs |= gpAllocableMask;
							}
						}
						else
						{
							va.Flags |= VariableFlags.RMem | VariableFlags.RCall;
						}
					}
				}

				if (m.Index.IsVariableId())
				{
					// Restrict allocation to all registers except ESP/RSP/R12.
					vd = _compiler.GetVariableData(m.Index);
					va = _variableContext.Merge(vd, 0, 0);

					va.Flags |= VariableFlags.RReg | VariableFlags.RCall;
					if ((va.InRegs & ~_indexMask) == 0)
					{
						va.AllocableRegs |= (int)(gpAllocableMask & _indexMask);
					}
				}
			}

			// Function-call arguments.
			for (i = 0; i < argCount; i++)
			{
				var op = args[i];
				if (!op.IsVariable()) continue;

				vd = _compiler.GetVariableData(op.Id);
				var arg = cdecl.GetArgument(i);

				if (arg.RegisterIndex != RegisterIndex.Invalid)
				{
					va = _variableContext.Merge(vd, 0, 0);

					var argType = arg.VariableType;
					var argClass = argType.GetRegisterClass();

					if (vd.Info.RegisterClass == argClass)
					{
						va.InRegs |= Utils.Mask(arg.RegisterIndex);
						va.Flags |= VariableFlags.RReg | VariableFlags.RFunc;
					}
					else
					{
						va.Flags |= VariableFlags.RConv | VariableFlags.RFunc;
					}
				}
				// If this is a stack-based argument we insert HLCallArg instead of
				// using VarAttr. It improves the code, because the argument can be
				// moved onto stack as soon as it is ready and the register used by
				// the variable can be reused for something else. It is also much
				// easier to handle argument conversions, because there will be at
				// most only one node per conversion.
				else
				{
					InsertCallArgument(call, vd, arg, i, ref _sArgDatas, ref sArgCount);
				}
			}

			// Function-call return(s).
			for (i = 0; i < 2; i++)
			{
				var op = rets[i];
				if (!op.IsVariable()) continue;

				var ret = cdecl.GetReturn(i);
				if (ret.RegisterIndex == RegisterIndex.Invalid) continue;
				var retType = ret.VariableType;
				var retClass = retType.GetRegisterClass();

				vd = _compiler.GetVariableData(op.Id);
				va = _variableContext.Merge(vd, 0, 0);

				if (vd.Info.RegisterClass == retClass)
				{
					va.OutRegIndex = ret.RegisterIndex;
					va.Flags |= VariableFlags.WReg | VariableFlags.WFunc;
				}
				else
				{
					va.Flags |= VariableFlags.WConv | VariableFlags.WFunc;
				}
			}

			// Init clobbered.
			_variableContext.ClobberedRegs.Set(RegisterClass.Gp, (int)(Utils.Bits(Cpu.Info.RegisterCount.Gp) & ~cdecl.Preserved.Get(RegisterClass.Gp)));
			_variableContext.ClobberedRegs.Set(RegisterClass.Mm, (int)(Utils.Bits(Cpu.Info.RegisterCount.Mm) & ~cdecl.Preserved.Get(RegisterClass.Mm)));
			_variableContext.ClobberedRegs.Set(RegisterClass.K, (int)(Utils.Bits(Cpu.Info.RegisterCount.K) & ~cdecl.Preserved.Get(RegisterClass.K)));
			_variableContext.ClobberedRegs.Set(RegisterClass.Xyz, (int)(Utils.Bits(Cpu.Info.RegisterCount.Xyz) & ~cdecl.Preserved.Get(RegisterClass.Xyz)));

			_variableContext.End(_node);

			return Result.Break;
		}

		private Result OnFetchInstruction()
		{
			var flowId = _node.FlowId;
			var node = _node.As<InstructionNode>();
			var instId = node.InstructionId;
			var flags = node.Flags;
			var opList = node.Operands;
			var opCount = opList.Length;
			if (opCount > 0)
			{
				var extendedInfo = instId.GetExtendedInfo();
				SpecialInstruction[] special = null;

				_variableContext.Begin();

				// Collect instruction flags and merge all 'VarAttr's.
				if (extendedInfo.IsFp())
				{
					flags |= CodeNodeFlags.Fp;
				}

				if (extendedInfo.IsSpecial() && (special = instId.GetSpecialInstructions(opList)) != null)
				{
					flags |= CodeNodeFlags.Special;
				}
				var gpAllowedMask = Constants.InvalidValue;
				for (var i = 0; i < opCount; i++)
				{
					var op = opList[i];
					VariableData vd;
					VariableAttributes va;
					if (op.IsVariable())
					{
						vd = _compiler.GetVariableData(op.Id);

						va = _variableContext.Merge(vd, 0, _variableContext.GaRegs[vd.Info.RegisterClass] & gpAllowedMask);

						var opv = op.As<Variable>();
						if (opv.IsGpb())
						{
							va.Flags |= opv.IsGpbLo() ? VariableFlags.X86GpbLo : VariableFlags.X86GpbHi;

							if (Constants.X64)
							{
								// It's fine if lo-byte register is accessed in 64-bit mode;
								// however, hi-byte has to be checked and if it's used all
								// registers (Gp/Xmm) could be only allocated in the lower eight
								// half. To do that, we patch 'allocableRegs' of all variables
								// we collected until now and change the allocable restriction
								// for variables that come after.
								if (opv.IsGpbHi())
								{
									va.AllocableRegs &= 0x0F;
									if (gpAllowedMask != 0xFF)
									{
										for (var j = 0; j < i; j++)
										{
											_variableContext[j].AllocableRegs &= _variableContext[j].Flags.IsSet(VariableFlags.X86GpbHi) ? 0x0F : 0xFF;
										}
										gpAllowedMask = 0xFF;
									}
								}
							}
							else
							{
								// If a byte register is accessed in 32-bit mode we have to limit
								// all allocable registers for that variable to eax/ebx/ecx/edx.
								// Other variables are not affected.
								va.AllocableRegs &= 0x0F;
							}
						}
						if (special != null)
						{
							var inReg = special[i].InReg;
							var outReg = special[i].OutReg;
							var c = op.As<Register>().IsGp() ? RegisterClass.Gp : RegisterClass.Xyz;

							if (inReg != RegisterIndex.Invalid)
							{
								var mask = Utils.Mask(inReg);
								_variableContext.InRegs.Or(c, mask);
								va.InRegs |= mask;
							}

							if (outReg != RegisterIndex.Invalid)
							{
								var mask = Utils.Mask(outReg);
								_variableContext.OutRegs.Or(c, mask);
								va.OutRegIndex = outReg;
							}

							va.Flags |= special[i].Flags;
						}
						else
						{
							VariableFlags combinedFlags;
							if (i == 0)
							{
								// Read/Write is usualy the combination of the first operand.
								combinedFlags = VariableFlags.RReg | VariableFlags.WReg;

								// Handle overwrite option.
								if (node.InstructionOptions.IsSet(InstructionOptions.Overwrite))
								{
									combinedFlags = VariableFlags.WReg;
								}
								// Move instructions typically overwrite the first operand,
								// but there are some exceptions based on the operands' size
								// and type.
								else if (extendedInfo.IsMove())
								{
									var movSize = extendedInfo.WriteSize;
									var varSize = vd.Info.Size;

									// Exception - If the source operand is a memory location
									// promote move size into 16 bytes.
									if (extendedInfo.IsZeroIfMem() && opList[1].IsMemory())
									{
										movSize = 16;
									}
									if (op.As<Variable>().IsGp())
									{
										var opSize = op.As<Variable>().Size;

										// Move size is zero in case that it should be determined
										// from the destination register.
										if (movSize == 0)
										{
											movSize = opSize;
										}

										// Handle the case that a 32-bit operation in 64-bit mode
										// always zeroes the rest of the destination register and
										// the case that move size is actually greater than or
										// equal to the size of the variable.
										if (movSize >= 4 || movSize >= varSize)
											combinedFlags = VariableFlags.WReg;
									}
									else if (movSize >= varSize)
									{
										// If move size is greater than or equal to the size of
										// the variable there is nothing to do, because the move
										// will overwrite the variable in all cases.
										combinedFlags = VariableFlags.WReg;
									}
								}
								// Comparison/Test instructions don't modify any operand.
								else if (extendedInfo.IsTest())
								{
									combinedFlags = VariableFlags.RReg;
								}
								// Imul.
								else if (instId == InstructionId.Imul && opCount == 3)
								{
									combinedFlags = VariableFlags.WReg;
								}
							}
							else
							{
								// Read-Only is usualy the combination of the second/third/fourth operands.
								combinedFlags = VariableFlags.RReg;

								// Idiv is a special instruction, never handled here.
								if (!(instId != InstructionId.Idiv)) { throw new ArgumentException(); }

								// Xchg/Xadd/Imul.
								if (extendedInfo.IsXchg() || (instId == InstructionId.Imul && opCount == 3 && i == 1))
								{
									combinedFlags = VariableFlags.RReg | VariableFlags.WReg;
								}
							}
							va.Flags |= combinedFlags;
						}
					}
					else if (op.IsMemory())
					{
						var m = op.As<Memory>();
						node.MemoryOperandIndex = i;
						if (m.Base.IsVariableId() && m.IsBaseIndexType())
						{
							vd = _compiler.GetVariableData(m.Base);
							if (!vd.IsStack)
							{
								va = _variableContext.Merge(vd, 0, _variableContext.GaRegs[vd.Info.RegisterClass] & gpAllowedMask);

								if (m.MemoryType == MemoryType.BaseIndex)
								{
									va.Flags |= VariableFlags.RReg;
								}
								else
								{
									const VariableFlags inFlags = VariableFlags.RMem;
									const VariableFlags outFlags = VariableFlags.WMem;
									VariableFlags combinedFlags;

									if (i == 0)
									{
										// Default for the first operand.
										combinedFlags = inFlags | outFlags;

										// Move to memory - setting the right flags is important
										// as if it's just move to the register. It's just a bit
										// simpler as there are no special cases.
										if (extendedInfo.IsMove())
										{
											var movSize = Math.Max(extendedInfo.WriteSize, m.Size);
											var varSize = vd.Info.Size;

											if (movSize >= varSize)
												combinedFlags = outFlags;
										}
										// Comparison/Test instructions don't modify any operand.
										else if (extendedInfo.IsTest())
										{
											combinedFlags = inFlags;
										}
									}
									else
									{
										// Default for the second operand.
										combinedFlags = inFlags;

										// Handle Xchg instruction (modifies both operands).
										if (extendedInfo.IsXchg())
										{
											combinedFlags = inFlags | outFlags;
										}
									}

									va.Flags |= combinedFlags;
								}
							}
						}

						if (m.Index.IsVariableId())
						{
							vd = _compiler.GetVariableData(m.Index);

							// Restrict allocation to all registers except ESP/RSP/R12.
							va = _variableContext.Merge(vd, 0, _variableContext.GaRegs[RegisterClass.Gp] & gpAllowedMask);

							va.AllocableRegs &= (int)_indexMask;
							va.Flags |= VariableFlags.RReg;
						}
					}
				}
				node.Flags = flags;
				if (_variableContext.VariableCount != 0)
				{
					// Handle instructions which result in zeros/ones or nop if used with the
					// same destination and source operand.
					if (_variableContext.VariableCount == 1 && opCount >= 2 && opList[0].IsVariable() && opList[1].IsVariable() && node.MemoryOperandIndex == Constants.InvalidValue)
					{
						PrepareSingleVariableInstruction(instId, _variableContext[0]);
					}
				}

				//VI_END
				_variableContext.End(_node);
			}
			if (!node.IsJmpOrJcc())
			{
				return Result.Break;
			}
			var jNode = node.As<JumpNode>();
			var jTarget = jNode.Target;

			// If this jump is unconditional we put next node to unreachable node
			// list so we can eliminate possible dead code. We have to do this in
			// all cases since we are unable to translate without fetch() step.
			//
			// We also advance our node pointer to the target node to simulate
			// natural flow of the function.
			if (jNode.IsJmp())
			{
				if (!_next.IsFetched())
				{
					_unreachableList.Add(_next);
				}

				// Jump not followed.
				if (jTarget == null)
				{
					_variableContext.ReturningList.Add(jNode);
					return Result.NextGroup;
				}

				_node = jTarget;
				return Result.Do;
			}
			// Jump not followed.
			if (jTarget == null)
			{
				return Result.Break;
			}

			if (jTarget.IsFetched())
			{
				var jTargetFlowId = jTarget.FlowId;

				// Update kHLNodeFlagIsTaken flag to true if this is a conditional
				// backward jump. This behavior can be overridden by using
				// `kInstOptionTaken` when the instruction is created.
				if (!jNode.Flags.IsSet(CodeNodeFlags.Taken) && opCount == 1 && jTargetFlowId <= flowId)
				{
					jNode.Flags |= CodeNodeFlags.Taken;
				}
			}
			else if (_next.IsFetched())
			{
				_node = jTarget;
				return Result.Do;
			}
			else
			{
				_variableContext.JccList.Add(jNode);
				_node = GetJccFlow(jNode);
				return Result.Do;
			}
			return Result.Break;
		}

		private Result GoTo(bool @do)
		{
			if (!@do || _node.IsFetched())
			{
				if (_jLinkIndex == -1)
				{
					_jLinkIndex = 0;
				}
				else
				{
					_jLinkIndex++;
				}
				if (_jLinkIndex >= _variableContext.JccList.Count)
				{
					_node = null;
					return Result.Done;
				}
				_node = GetOppositeJccFlow(_variableContext.JccList[_jLinkIndex].As<JumpNode>());
			}
			return Result.Break;
		}
		//
		//		private Result NextGroup(Result result)
		//		{
		//			for (;;)
		//			{
		//				if ((result == Result.Do || result == Result.Break) && !_node.IsFetched())
		//				{
		//					break;
		//				}
		//				if (!CheckNextGroup())
		//				{
		//					return Result.Done;
		//				}
		//				_node = GetOppositeJccFlow(_variableContext.JccList[_jLinkIndex].As<JumpNode>());
		//				result = Result.Do;
		//			}
		//			return Result.Switch;
		//		}
		//
		//		private bool CheckNextGroup()
		//		{
		//			if (_jLinkIndex == -1)
		//			{
		//				_jLinkIndex = 0;
		//			}
		//			else
		//			{
		//				_jLinkIndex++;
		//			}			
		//			if (_jLinkIndex >= _variableContext.JccList.Count)
		//			{
		//				_node = null;
		//				return false;
		//			}
		//			_node = GetOppositeJccFlow(_variableContext.JccList[_jLinkIndex].As<JumpNode>());
		//			return true;
		//		}

		private static CodeNode GetOppositeJccFlow(JumpNode jump)
		{
			return jump.Flags.IsSet(CodeNodeFlags.Taken) ? jump.Next : jump.Target;
		}

		private static CodeNode GetJccFlow(JumpNode jump)
		{
			return jump.Flags.IsSet(CodeNodeFlags.Taken) ? jump.Target : jump.Next;
		}

		private void RemoveUnreachableCode()
		{
			var link = 0;
			while (link < _unreachableList.Count)
			{
				var node = _unreachableList[link];
				if (node != null && node.Previous != null && node != _stopNode)
				{
					var first = node;
					// Locate all unreachable nodes.
					do
					{
						if (node.IsFetched()) break;
						node = node.Next;
					} while (node != _stopNode);

					// Remove unreachable nodes that are neither informative nor directives.
					if (node != first)
					{
						var end = node;
						node = first;
						bool removeEverything = true;
						do
						{
							var next = node.Next;
							bool remove = node.IsRemovable();
							if (!remove)
							{
								if (node.Type == CodeNodeType.Label)
								{
									removeEverything = false;
								}
								remove = removeEverything;
							}

							if (remove)
							{
								_compiler.RemoveNode(node);
							}
							node = next;
						} while (node != end);
					}
				}
				link++;
			}
		}

		private void InsertCallArgument(CallNode call, VariableData sVd, FunctionInOut arg, int argIndex, ref SArgData[] sArgList, ref int sArgCount)
		{
			int i;

			var aType = arg.VariableType;
			var sType = sVd.Type;

			// First locate or create sArgBase.
			for (i = 0; i < sArgCount; i++)
			{
				if (sArgList[i].Svd == sVd && sArgList[i].Cvd == null) break;
			}

			var sArgData = sArgList[i];

			if (i == sArgCount)
			{
				sArgData.Svd = sVd;
				sArgData.Cvd = null;
				sArgData.Arg = null;
				sArgData.Type = VariableType.Invalid;
				sArgCount++;
			}

			var sInfo = sType.GetVariableInfo();
			var sClass = sInfo.RegisterClass;
			if (SArgData.MustConvertSArg(aType, sType))
			{
				var cType = SArgData.TypeOfConvertedSArg(aType, sType);
				var cInfo = cType.GetVariableInfo();
				var cClass = cInfo.RegisterClass;
				while (++i < sArgCount)
				{
					sArgData = sArgList[i];
					if (sArgData.Svd != sVd) break;

					if (sArgData.Cvd.Type != cType || sArgData.Type != aType) continue;

					sArgData.Arg.AffectedArguments |= Utils.Mask(argIndex);
					return;
				}

				var cVd = _compiler.CreateVariableData(cType, cInfo, null);
				var sArg = new CallArgumentNode(call, sVd, cVd);
				var map = new VariableMap(2);

				_variableContext.RegisterContextVariable(cVd);
				_variableContext.RegisterContextVariable(sVd);

				map.Count.Add(sClass);
				map.Count.Add(cClass);

				if (sClass <= cClass)
				{
					map.Attributes[0].Setup(sVd, VariableFlags.RReg, 0, _variableContext.GaRegs[sClass]);
					map.Attributes[1].Setup(cVd, VariableFlags.WReg, 0, _variableContext.GaRegs[cClass]);
					map.Start.Set(cClass, (sClass != cClass).AsInt());
				}
				else
				{
					map.Attributes[0].Setup(cVd, VariableFlags.WReg, 0, _variableContext.GaRegs[cClass]);
					map.Attributes[1].Setup(sVd, VariableFlags.RReg, 0, _variableContext.GaRegs[sClass]);
					map.Start.Set(sClass, 1);
				}

				sArg.VariableMap = map;
				sArg.AffectedArguments |= Utils.Mask(argIndex);

				_compiler.AddNodeBefore(sArg, call);
				//::memmove(sArgData + 1, sArgData, (sArgCount - i) * sizeof(SArgData));

				var tmp = new SArgData[sArgCount + 1];
				Array.Copy(sArgList, 0, tmp, 0, i);
				Array.Copy(sArgList, i + 1, tmp, i + 1, sArgCount - i);

				sArgList = tmp;

				sArgData.Svd = sVd;
				sArgData.Cvd = cVd;
				sArgData.Arg = sArg;
				sArgData.Type = aType;

				sArgCount++;
			}
			else
			{
				var sArg = sArgData.Arg;
				_variableContext.RegisterContextVariable(sVd);

				if (sArg == null)
				{
					sArg = new CallArgumentNode(call, sVd, null);

					var map = new VariableMap(1);

					map.Count.Add(sClass);
					map.Attributes[0].Setup(sVd, VariableFlags.RReg, 0, _variableContext.GaRegs[sClass]);

					sArg.VariableMap = map;
					sArgData.Arg = sArg;

					_compiler.AddNodeBefore(sArg, call);
				}

				sArg.AffectedArguments |= Utils.Mask(argIndex);
			}
		}

		private static void PrepareSingleVariableInstruction(InstructionId instId, VariableAttributes va)
		{
			switch (instId)
			{
				// - andn     reg, reg ; Set all bits in reg to 0.
				// - xor/pxor reg, reg ; Set all bits in reg to 0.
				// - sub/psub reg, reg ; Set all bits in reg to 0.
				// - pcmpgt   reg, reg ; Set all bits in reg to 0.
				// - pcmpeq   reg, reg ; Set all bits in reg to 1.
				case InstructionId.Pandn:
				case InstructionId.Xor:
				case InstructionId.Xorpd:
				case InstructionId.Xorps:
				case InstructionId.Pxor:
				case InstructionId.Sub:
				case InstructionId.Psubb:
				case InstructionId.Psubw:
				case InstructionId.Psubd:
				case InstructionId.Psubq:
				case InstructionId.Psubsb:
				case InstructionId.Psubsw:
				case InstructionId.Psubusb:
				case InstructionId.Psubusw:
				case InstructionId.Pcmpeqb:
				case InstructionId.Pcmpeqw:
				case InstructionId.Pcmpeqd:
				case InstructionId.Pcmpeqq:
				case InstructionId.Pcmpgtb:
				case InstructionId.Pcmpgtw:
				case InstructionId.Pcmpgtd:
				case InstructionId.Pcmpgtq:
					va.Flags &= ~VariableFlags.RReg;
					break;

				// - and      reg, reg ; Nop.
				// - or       reg, reg ; Nop.
				// - xchg     reg, reg ; Nop.
				case InstructionId.And:
				case InstructionId.Andpd:
				case InstructionId.Andps:
				case InstructionId.Pand:
				case InstructionId.Or:
				case InstructionId.Orpd:
				case InstructionId.Orps:
				case InstructionId.Por:
				case InstructionId.Xchg:
					va.Flags &= ~VariableFlags.WReg;
					break;
			}
		}
	}
}
