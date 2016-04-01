using System;
using System.ComponentModel;
using System.Diagnostics;
using AsmJit.AssemblerContext;
using AsmJit.Common;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext.CodeTree;

namespace AsmJit.CompilerContext
{
	internal sealed class Translator
	{
		private enum Result
		{
			NextGroup,
			Done,
			Break
		}

		private const int ArgActualDisp = 0;
		private const int VarActualDisp = 0;

		private CodeNode _node;
		private CodeNode _next;
		private CodeNode _stopNode;
		private Assembler _assembler;
		private Compiler _compiler;
		private CodeContext _codeContext;
		private FunctionNode _functionNode;
		private CodeNode _extraBlock;
		private VariableContext _variableContext;
		private VariableCell _memVarCells;
		private VariableCell _memStackCells;
		private int _mem1ByteVarsUsed;
		private int _mem2ByteVarsUsed;
		private int _mem4ByteVarsUsed;
		private int _mem8ByteVarsUsed;
		private int _mem16ByteVarsUsed;
		private int _mem32ByteVarsUsed;
		private int _mem64ByteVarsUsed;
		private int _memMaxAlign;
		private int _memAllTotal;
		private Memory _memSlot;
		private VariableCell _stackFrameCell;
		private int _argBaseReg;
		private int _varBaseReg;
		private int _argBaseOffset;
		private int _varBaseOffset;
		private int _jLinkIndex;
		private VariableAllocator _variableAllocator;
		private CallAllocator _callAllocator;

		public Translator(Assembler assembler, Compiler compiler, CodeContext codeContext, FunctionNode func, VariableContext ctx)
		{
			_assembler = assembler;
			_compiler = compiler;
			_codeContext = codeContext;
			_functionNode = func;
			_variableContext = ctx;
			_memSlot = new Memory(MemoryType.StackIndex);
			_memSlot.SetGpdBase(Constants.X64 ? 0 : 1);
		}

		public void Run()
		{
			_extraBlock = _functionNode.End;
			_node = _functionNode;
			_next = null;
			_stopNode = _functionNode.End.Next;
			var result = Result.Break;
			_variableAllocator = new VariableAllocator(_assembler, _compiler, _codeContext, this, _variableContext);
			_callAllocator = new CallAllocator(_assembler, _compiler, _codeContext, this, _variableContext);
			while (true)
			{
				if(result == Result.Done) break;

				if (GoTo(nextGroup: result == Result.NextGroup) == Result.Done) break;

				_next = _node.Next;
				_node.Flags |= CodeNodeFlags.Translated;

				switch (_node.Type)
				{
					case CodeNodeType.None:
					case CodeNodeType.Data:
					case CodeNodeType.Alignment:					
					case CodeNodeType.Comment:
						break;
					case CodeNodeType.Label:
						result = OnTranslateLabel();
						break;
					case CodeNodeType.Sentinel:
						result = OnTranslateSentinel();
						break;
					case CodeNodeType.Function:
						result = OnTranslateFunction();
						break;
					case CodeNodeType.Return:
					case CodeNodeType.Hint:
						result = OnTranslateReturnOrHint();
						break;
					case CodeNodeType.Call:
					case CodeNodeType.CallArgument:
					case CodeNodeType.Instruction:
						result = OnTranslateInstructionOrCallOrCallArgument();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
				if (result == Result.NextGroup || result == Result.Done) continue;
				if (_next == _stopNode)
				{
					result = Result.NextGroup;
					continue;
				}
				_node = _next;
			}
			InitFunction();
			PatchFunctionMemory();
			TranslatePrologEpilog();
		}

		private Result OnTranslateLabel()
		{
			var node = _node.As<LabelNode>();
			if (node.VariableState != null)
			{
				throw new ArgumentException();
			}
			node.VariableState = SaveState();
			return Result.Break;
		}

		private Result OnTranslateSentinel()
		{
			return Result.NextGroup;
		}

		private Result OnTranslateFunction()
		{
			var decl = _functionNode.FunctionDeclaration;
			var map = _functionNode.VariableMap;
			if (map == null)
			{
				return Result.Break;
			}
			var argCount = decl.ArgumentCount;
			for (var i = 0; i < argCount; i++)
			{
				var arg = decl.GetArgument(i);
				var vd = _functionNode.GetArgument(i);
				if (vd == null) continue;

				var va = map.FindAttributes(vd);
				if (va == null)
				{
					throw new ArgumentException();
				}

				if (va.Flags.IsSet(VariableFlags.Unuse)) continue;

				var regIndex = va.OutRegIndex;
				if (regIndex != RegisterIndex.Invalid && !va.Flags.IsSet(VariableFlags.WConv))
				{
					switch (vd.Info.RegisterClass)
					{
						case RegisterClass.Gp:
							Attach(vd, RegisterClass.Gp, regIndex, true);
							break;
						case RegisterClass.Mm:
							Attach(vd, RegisterClass.Mm, regIndex, true);
							break;
						case RegisterClass.Xyz:
							Attach(vd, RegisterClass.Xyz, regIndex, true);
							break;
					}
				}
				else if (va.Flags.IsSet(VariableFlags.WConv))
				{
					// TODO: [COMPILER] Function Argument Conversion.
					//									ASMJIT_NOT_REACHED();
				}
				else
				{
					vd.IsMemoryArgument = true;
					vd.MemoryOffset = arg.StackOffset;
					vd.State = VariableUsage.Mem;
				}
			}
			return Result.Break;
		}

		private Result OnTranslateInstructionOrCallOrCallArgument()
		{
			// Update VarAttr's unuse flags based on liveness of the next node.
			if (!_node.Flags.IsSet(CodeNodeFlags.Jcc))
			{
				var map = _node.VariableMap;
				BitArray liveness;

				if (map != null && _next != null && (liveness = _next.Liveness) != null)
				{
					var vaList = map.Attributes;

					foreach (var va in vaList)
					{
						var vd = va.VariableData;

						if (liveness.GetBit(vd.LocalId) == 0)
						{
							va.Flags |= VariableFlags.Unuse;
						}
					}
				}
			}
			if (_node.Type != CodeNodeType.Call)
			{
				return OnTranslateReturnOrHint();
			}
			_callAllocator.Run(_node.As<CallNode>());
			return Result.Break;
		}

		private Result OnTranslateReturnOrHint()
		{
			_variableAllocator.Run(_node);
			if (_node.IsJmpOrJcc())
			{
				var njump = _node.As<JumpNode>();
				var jTarget = njump.Target;

				// Target not followed.
				if (jTarget == null)
				{
					return Result.NextGroup;
				}
				if (njump.IsJmp())
				{
					if (jTarget.VariableState != null)
					{
						_compiler.SetCurrentNode(njump.Previous);
						SwitchState(jTarget.VariableState);
						return Result.NextGroup;
					}
					_next = jTarget;
				}
				else
				{
					var jNext = njump.Next;

					if (jTarget.IsTranslated())
					{
						if (jNext.IsTranslated())
						{
							if (jNext.Type != CodeNodeType.Label)
							{
								throw new ArgumentException();
							}
							_compiler.SetCurrentNode(njump.Previous);
							IntersectStates(jTarget.VariableState, jNext.VariableState);
						}

						var savedState = SaveState();
						njump.VariableState = savedState;

						TranslateJump(njump, jTarget);
						_next = jNext;
					}
					else if (jNext.IsTranslated())
					{
						if (jNext.Type != CodeNodeType.Label)
						{
							throw new ArgumentException();
						}

						var savedState = SaveState();
						njump.VariableState = savedState;

						_compiler.SetCurrentNode(njump);
						SwitchState(jNext.As<LabelNode>().VariableState);
						_next = jTarget;
					}
					else
					{
						var savedState = SaveState();
						njump.VariableState = savedState;
						_next = GetJccFlow(njump);
					}
				}
			}
			else if (_node.IsRet())
			{
				TranslateRet(_node.As<ReturnNode>(), _functionNode.Exit);
			}
			return Result.Break;
		}

		private Result GoTo(bool nextGroup)
		{
			while (_node.IsTranslated())
			{
				if (!nextGroup)
				{
					// Switch state if we went to the already translated node.
					if (_node.Type == CodeNodeType.Label)
					{
						var node = _node.As<LabelNode>();
						_compiler.SetCurrentNode(node.Previous);
						SwitchState(node.VariableState);
					}
				}

				if (_jLinkIndex >= _variableContext.JccList.Count)
				{
					return Result.Done;
				}
				_node = _variableContext.JccList[_jLinkIndex++];

				var jFlow = GetOppositeJccFlow(_node.As<JumpNode>());
				LoadState(_node.VariableState);

				if (jFlow.VariableState != null)
				{
					TranslateJump(_node.As<JumpNode>(), jFlow.As<LabelNode>());

					_node = jFlow;
					if (_node.IsTranslated())
					{
						nextGroup = true;
						continue;
					}
				}
				else
				{
					_node = jFlow;
				}
				break;
			}
			return Result.Break;
		}

		private void InitFunction()
		{
			var decl = _functionNode.FunctionDeclaration;

			// Setup "Save-Restore" registers.
			_functionNode.SaveRestoreRegs.Set(RegisterClass.Gp, _variableContext.ClobberedRegs.Get(RegisterClass.Gp) & decl.Preserved.Get(RegisterClass.Gp));
			_functionNode.SaveRestoreRegs.Set(RegisterClass.Mm, _variableContext.ClobberedRegs.Get(RegisterClass.Mm) & decl.Preserved.Get(RegisterClass.Mm));
			_functionNode.SaveRestoreRegs.Set(RegisterClass.K, 0);
			_functionNode.SaveRestoreRegs.Set(RegisterClass.Xyz, _variableContext.ClobberedRegs.Get(RegisterClass.Xyz) & decl.Preserved.Get(RegisterClass.Xyz));

			if (_functionNode.SaveRestoreRegs.Has(RegisterClass.Gp, Utils.Mask(RegisterIndex.Sp)))
			{
				throw new ArgumentException();
			}

			// Setup required stack alignment and kFuncFlagIsStackMisaligned.
			{
				var requiredStackAlignment = Math.Max(_memMaxAlign, Cpu.Info.RegisterSize);

				if (requiredStackAlignment < 16)
				{
					// Require 16-byte alignment if 8-byte vars are used.
					if (_mem8ByteVarsUsed != 0)
					{
						requiredStackAlignment = 16;
					}
					else if (_functionNode.SaveRestoreRegs.Get(RegisterClass.Mm) != 0 || _functionNode.SaveRestoreRegs.Get(RegisterClass.Xyz) != 0)
					{
						requiredStackAlignment = 16;
					}
					else if (_functionNode.RequiredStackAlignment.Between(8, 16))
					{
						requiredStackAlignment = 16;
					}
				}

				if (_functionNode.RequiredStackAlignment < requiredStackAlignment)
					_functionNode.RequiredStackAlignment = requiredStackAlignment;

				_functionNode.UpdateRequiredStackAlignment();
			}

			// Adjust stack pointer if function is caller.
			if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsCaller))
			{
				_functionNode.FunctionFlags |= FunctionNodeFlags.IsStackAdjusted;
				_functionNode.CallStackSize = _functionNode.CallStackSize.AlignTo(_functionNode.RequiredStackAlignment);
			}

			// Adjust stack pointer if manual stack alignment is needed.
			if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsStackMisaligned) && _functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsNaked))
			{
				// Get a memory cell where the original stack frame will be stored.
				var cell = CreateStackCell(Cpu.Info.RegisterSize, Cpu.Info.RegisterSize);
				//			if (cell == null)
				//				return self->getLastError(); // The error has already been set.

				_functionNode.FunctionFlags |= FunctionNodeFlags.IsStackAdjusted;
				_stackFrameCell = cell;

				if (decl.ArgumentsStackSize > 0)
				{
					_functionNode.FunctionFlags |= FunctionNodeFlags.X86MoveArgs;
					_functionNode.ExtraStackSize = decl.ArgumentsStackSize;
				}

				// Get temporary register which will be used to align the stack frame.
				var fRegMask = (int)Utils.Bits(Cpu.Info.RegisterCount.Get(RegisterClass.Gp));


				fRegMask &= ~(decl.Used.Get(RegisterClass.Gp) | Utils.Mask(RegisterIndex.Sp));
				var stackFrameCopyRegs = fRegMask;

				// Try to remove modified registers from the mask.
				var tRegMask = fRegMask & ~_variableContext.ClobberedRegs.Get(RegisterClass.Gp);
				if (tRegMask != 0)
				{
					fRegMask = tRegMask;
				}

				// Try to remove preserved registers from the mask.
				tRegMask = fRegMask & ~decl.Preserved.Get(RegisterClass.Gp);
				if (tRegMask != 0)
				{
					fRegMask = tRegMask;
				}

				if (fRegMask == 0)
				{
					throw new ArgumentException();
				}

				var fRegIndex = fRegMask.FindFirstBit();
				_functionNode.StackFrameRegIndex = fRegIndex;

				// We have to save the register on the stack (it will be the part of prolog
				// and epilog), however we shouldn't save it twice, so we will remove it
				// from '_saveRestoreRegs' in case that it is preserved.
				fRegMask = Utils.Mask(fRegIndex);
				if ((fRegMask & decl.Preserved.Get(RegisterClass.Gp)) != 0)
				{
					_functionNode.SaveRestoreRegs.AndNot(RegisterClass.Gp, fRegMask);
					_functionNode.IsStackFrameRegPreserved = true;
				}

				if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.X86MoveArgs))
				{
					var maxRegs = (decl.ArgumentsStackSize + Cpu.Info.RegisterSize - 1) / Cpu.Info.RegisterSize;
					stackFrameCopyRegs &= ~fRegMask;

					tRegMask = stackFrameCopyRegs & _variableContext.ClobberedRegs.Get(RegisterClass.Gp);
					var tRegCnt = ((long)tRegMask).BitCount();

					if (tRegCnt > 1 || (tRegCnt > 0 && tRegCnt <= maxRegs))
					{
						stackFrameCopyRegs = tRegMask;
					}
					else
					{
						stackFrameCopyRegs = stackFrameCopyRegs.KeepNOnesFromRight(Math.Min(maxRegs, 2));
					}

					_functionNode.SaveRestoreRegs.Or(RegisterClass.Gp, stackFrameCopyRegs & decl.Preserved.Get(RegisterClass.Gp));
					_functionNode.StackFrameCopyGpIndex.IndexNOnesFromRight(stackFrameCopyRegs, maxRegs);
				}
			}
			// If function is not naked we generate standard "EBP/RBP" stack frame.
			else if (!_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsNaked))
			{
				_functionNode.StackFrameRegIndex = RegisterIndex.Bp;
				_functionNode.IsStackFrameRegPreserved = true;
			}

			ResolveCellOffsets();

			// Adjust stack pointer if requested memory can't fit into "Red Zone" or "Spill Zone".
			if (_memAllTotal > Math.Max(decl.RedZoneSize, decl.SpillZoneSize))
			{
				_functionNode.FunctionFlags |= FunctionNodeFlags.IsStackAdjusted;
			}

			// Setup stack size used to save preserved registers.
			{
				var memGpSize = ((long)_functionNode.SaveRestoreRegs.Get(RegisterClass.Gp)).BitCount() * Cpu.Info.RegisterSize;
				var memMmSize = ((long)_functionNode.SaveRestoreRegs.Get(RegisterClass.Mm)).BitCount() * 8;
				var memXmmSize = ((long)_functionNode.SaveRestoreRegs.Get(RegisterClass.Xyz)).BitCount() * 16;

				_functionNode.PushPopStackSize = memGpSize;
				_functionNode.MoveStackSize = memXmmSize + memMmSize.AlignTo(16);
			}

			if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsStackMisaligned))
			{
				_functionNode.AlignStackSize = 0;
			}
			else
			{
				// If function is aligned, the RETURN address is stored in the aligned
				// [ZSP - PtrSize] which makes current ZSP unaligned.
				var v = Cpu.Info.RegisterSize;

				// If we have to store function frame pointer we have to count it as well,
				// because it is the first thing pushed on the stack.
				if (_functionNode.StackFrameRegIndex != RegisterIndex.Invalid && _functionNode.IsStackFrameRegPreserved)
				{
					v += Cpu.Info.RegisterSize;
				}

				// Count push/pop sequence.
				v += _functionNode.PushPopStackSize;

				// Count save/restore sequence for XMM registers (should be already aligned).
				v += _functionNode.MoveStackSize;

				// Maximum memory required to call all functions within this function.
				v += _functionNode.CallStackSize;

				// Calculate the final offset to keep stack alignment.
				_functionNode.AlignStackSize = v.AlignDiff(_functionNode.RequiredStackAlignment);
			}

			// Memory stack size.
			_functionNode.MemStackSize = _memAllTotal;
			_functionNode.AlignedMemStackSize = _functionNode.MemStackSize.AlignTo(_functionNode.RequiredStackAlignment);

			if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsNaked))
			{
				_argBaseReg = RegisterIndex.Sp;

				if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsStackAdjusted))
				{
					if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsStackMisaligned))
					{
						_argBaseOffset = _functionNode.CallStackSize + _functionNode.AlignedMemStackSize + _functionNode.MoveStackSize + _functionNode.AlignStackSize;
						_argBaseOffset -= Cpu.Info.RegisterSize;
					}
					else
					{
						_argBaseOffset = _functionNode.CallStackSize + _functionNode.AlignedMemStackSize + _functionNode.MoveStackSize + _functionNode.PushPopStackSize + _functionNode.ExtraStackSize + _functionNode.AlignStackSize;
					}
				}
				else
				{
					_argBaseOffset = _functionNode.PushPopStackSize;
				}
			}
			else
			{
				_argBaseReg = RegisterIndex.Bp;
				// Caused by "push zbp".
				_argBaseOffset = Cpu.Info.RegisterSize;
			}

			_varBaseReg = RegisterIndex.Sp;
			_varBaseOffset = _functionNode.CallStackSize;

			if (!_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsStackAdjusted))
			{
				_varBaseOffset = -(_functionNode.AlignStackSize + _functionNode.AlignedMemStackSize + _functionNode.MoveStackSize);
			}
		}

		private void ResolveCellOffsets()
		{
			var varCell = _memVarCells;
			var stackCell = _memStackCells;

			var stackAlignment = 0;
			if (stackCell != null)
			{
				stackAlignment = stackCell.Alignment;
			}

			var pos64 = 0;
			var pos32 = pos64 + _mem64ByteVarsUsed * 64;
			var pos16 = pos32 + _mem32ByteVarsUsed * 32;
			var pos8 = pos16 + _mem16ByteVarsUsed * 16;
			var pos4 = pos8 + _mem8ByteVarsUsed * 8;
			var pos2 = pos4 + _mem4ByteVarsUsed * 4;
			var pos1 = pos2 + _mem2ByteVarsUsed * 2;

			var stackPos = pos1 + _mem1ByteVarsUsed;

			var gapAlignment = stackAlignment;
			var gapSize = 0;

			// TODO: Not used!
			if (gapAlignment != 0)
			{
				stackPos.AlignDiff(gapAlignment);
			}
			stackPos += gapSize;

			var gapPos = stackPos;
			var allTotal = stackPos;

			// Vars - Allocated according to alignment/width.
			while (varCell != null)
			{
				var size = varCell.Size;
				int offset;

				switch (size)
				{
					case 1:
						offset = pos1;
						pos1 += 1;
						break;
					case 2:
						offset = pos2;
						pos2 += 2;
						break;
					case 4:
						offset = pos4;
						pos4 += 4;
						break;
					case 8:
						offset = pos8;
						pos8 += 8;
						break;
					case 16:
						offset = pos16;
						pos16 += 16;
						break;
					case 32:
						offset = pos32;
						pos32 += 32;
						break;
					case 64:
						offset = pos64;
						pos64 += 64;
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				varCell.Offset = offset;
				varCell = varCell.Next;
			}

			// Stack - Allocated according to alignment/width.
			while (stackCell != null)
			{
				var size = stackCell.Size;
				var alignment = stackCell.Alignment;
				int offset;

				// Try to fill the gap between variables/stack first.
				if (size <= gapSize && alignment <= gapAlignment)
				{
					offset = gapPos;

					gapSize -= size;
					gapPos -= size;

					if (alignment < gapAlignment)
						gapAlignment = alignment;
				}
				else
				{
					offset = stackPos;

					stackPos += size;
					allTotal += size;
				}

				stackCell.Offset = offset;
				stackCell = stackCell.Next;
			}
			_memAllTotal = allTotal;
		}

		private void PatchFunctionMemory()
		{
			CodeNode node = _functionNode;

			do
			{
				if (node.Type == CodeNodeType.Instruction)
				{
					var iNode = node.As<InstructionNode>();

					if (iNode.MemoryOperandIndex != RegisterIndex.Invalid)
					{
						var m = iNode.Operands[iNode.MemoryOperandIndex].As<Memory>();

						if (m.MemoryType == MemoryType.StackIndex && m.Base.IsVariableId())
						{
							var vd = _compiler.GetVariableData(m.Base);
							if (vd == null)
							{
								throw new ArgumentException();
							}

							if (vd.IsMemoryArgument)
							{
								m.Base = _argBaseReg;
								m.Adjust(_argBaseOffset + vd.MemoryOffset);
							}
							else
							{
								var cell = vd.MemoryCell;
								if (cell == null)
								{
									throw new ArgumentException();
								}
								m.Base = _varBaseReg;
								m.Adjust(_varBaseOffset + cell.Offset);
							}
						}
					}
				}

				node = node.Next;
			} while (node != _stopNode);
		}

		private void TranslatePrologEpilog()
		{
			var decl = _functionNode.FunctionDeclaration;

			var stackSize = _functionNode.AlignStackSize + _functionNode.CallStackSize + _functionNode.AlignedMemStackSize + _functionNode.MoveStackSize + _functionNode.ExtraStackSize;
			var stackAlignment = _functionNode.RequiredStackAlignment;

			int stackBase;

//			if (func.FunctionFlags.IsSet(FunctionNodeFlags.IsStackAdjusted))
//			{
//				stackBase = func.CallStackSize + func.AlignedMemStackSize;
//			}
//			else
//			{
//				stackBase = -(func.AlignedMemStackSize + func.AlignStackSize + func.ExtraStackSize);
//			}

			int i, mask;
			var regsGp = _functionNode.SaveRestoreRegs.Get(RegisterClass.Gp);
			var regsMm = _functionNode.SaveRestoreRegs.Get(RegisterClass.Mm);
			var regsXmm = _functionNode.SaveRestoreRegs.Get(RegisterClass.Xyz);

			var earlyPushPop = false;
			var useLeaEpilog = false;

			//			var gpReg = new GpRegister(_assembler.Zsp);
			var fpReg = new GpRegister(_assembler.Zbp);

			// [Prolog]

			var fpOffset = new Memory();

			_compiler.SetCurrentNode(_functionNode.Entry);

			// Entry.
			if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsNaked))
			{
				if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsStackMisaligned))
				{
					fpReg = new GpRegister((GpRegisterType) _assembler.Zsp.RegisterType, _functionNode.StackFrameRegIndex);
					fpOffset = Memory.Ptr(_assembler.Zsp, _varBaseOffset + _stackFrameCell.Offset);//new Memory(_assembler.Zsp, _varBaseOffset + _stackFrameCell.Offset);

					earlyPushPop = true;
					EmitPushSequence(regsGp);

					if (_functionNode.IsStackFrameRegPreserved)
					{
						_compiler.Emit(InstructionId.Push, fpReg);
					}

					_compiler.Emit(InstructionId.Mov, fpReg, _assembler.Zsp);
				}
			}
			else
			{
				_compiler.Emit(InstructionId.Push, fpReg);
				_compiler.Emit(InstructionId.Mov, fpReg, _assembler.Zsp);
			}

			if (!earlyPushPop)
			{
				EmitPushSequence(regsGp);
				if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsStackMisaligned) && regsGp != 0)
				{
					useLeaEpilog = true;
				}
			}

			// Adjust stack pointer.
			if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsStackAdjusted))
			{
				stackBase = _functionNode.AlignedMemStackSize + _functionNode.CallStackSize;

				if (stackSize != 0)
				{
					_compiler.Emit(InstructionId.Sub, _assembler.Zsp, stackSize);
				}

				if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsStackMisaligned))
				{
					_compiler.Emit(InstructionId.And, _assembler.Zsp, -stackAlignment);
				}

				if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsStackMisaligned) && _functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsNaked))
				{
					_compiler.Emit(InstructionId.Mov, fpOffset, fpReg);
				}
			}
			else
			{
				stackBase = -(_functionNode.AlignStackSize + _functionNode.MoveStackSize);
			}

			// Save Xmm/Mm/Gp (Mov).
			var stackPtr = stackBase;
			for (i = 0, mask = regsXmm; mask != 0; i++, mask >>= 1)
			{
				if (!mask.IsSet(0x1)) continue;
				_compiler.Emit(InstructionId.Movaps, Memory.OWordPtr(_assembler.Zsp, stackPtr), Compiler.Xmm(i));
				stackPtr += 16;
			}

			for (i = 0, mask = regsMm; mask != 0; i++, mask >>= 1)
			{
				if (!mask.IsSet(0x1)) continue;
				_compiler.Emit(InstructionId.Movq, Memory.QWord(_assembler.Zsp, stackPtr), Compiler.Mm(i));
				stackPtr += 8;
			}

			// [Move-Args]

			if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.X86MoveArgs))
			{
				var argStackSize = decl.ArgumentsStackSize;

				var moveIndex = 0;
				var moveCount = (argStackSize + Cpu.Info.RegisterSize - 1) / Cpu.Info.RegisterSize;

				var r = new GpRegister[8];
				var numRegs = 0;

				for (i = 0; i < _functionNode.StackFrameCopyGpIndex.Length; i++)
				{
					if (_functionNode.StackFrameCopyGpIndex[i] != RegisterIndex.Invalid)
					{
						r[numRegs++] = new GpRegister((GpRegisterType) _assembler.Zsp.RegisterType, _functionNode.StackFrameCopyGpIndex[i]);
					}
				}
				if (numRegs <= 0)
				{
					throw new ArgumentOutOfRangeException();
				}

				var dSrc = _functionNode.PushPopStackSize + Cpu.Info.RegisterSize;
				var dDst = _functionNode.AlignStackSize + _functionNode.CallStackSize + _functionNode.AlignedMemStackSize + _functionNode.MoveStackSize;

				if (_functionNode.IsStackFrameRegPreserved)
				{
					dSrc += Cpu.Info.RegisterSize;
				}

				var mSrc = Memory.Ptr(fpReg, dSrc);
				var mDst = Memory.Ptr(_assembler.Zsp, dDst);

				while (moveIndex < moveCount)
				{
					var numMovs = Math.Min(moveCount - moveIndex, numRegs);

					for (i = 0; i < numMovs; i++)
					{
						_compiler.Emit(InstructionId.Mov, r[i], new Memory(mSrc).Adjust((moveIndex + i) * Cpu.Info.RegisterSize));
					}
					for (i = 0; i < numMovs; i++)
					{
						_compiler.Emit(InstructionId.Mov, new Memory(mDst).Adjust((moveIndex + i) * Cpu.Info.RegisterSize), r[i]);
					}

					moveIndex += numMovs;
				}
			}

			// [Epilog]

			_compiler.SetCurrentNode(_functionNode.Exit);

			// Restore Xmm/Mm/Gp (Mov).
			stackPtr = stackBase;
			for (i = 0, mask = regsXmm; mask != 0; i++, mask >>= 1)
			{
				if (!mask.IsSet(0x1)) continue;
				_compiler.Emit(InstructionId.Movaps, Compiler.Xmm(i), Memory.OWordPtr(_assembler.Zsp, stackPtr));
				stackPtr += 16;
			}

			for (i = 0, mask = regsMm; mask != 0; i++, mask >>= 1)
			{
				if (!mask.IsSet(0x1)) continue;
				_compiler.Emit(InstructionId.Movq, Compiler.Mm(i), Memory.QWord(_assembler.Zsp, stackPtr));
				stackPtr += 8;
			}

			// Adjust stack.
			if (useLeaEpilog)
			{
				_compiler.Emit(InstructionId.Lea, _assembler.Zsp, Memory.Ptr(fpReg, -_functionNode.PushPopStackSize));
			}
			else if (!_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsStackMisaligned))
			{
				if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsStackAdjusted) && stackSize != 0)
				{
					_compiler.Emit(InstructionId.Add, _assembler.Zsp, stackSize);
				}
			}

			// Restore Gp (Push/Pop).
			if (!earlyPushPop)
			{
				EmitPopSequence(regsGp);
			}

			// Emms.
			if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.X86Emms))
			{
				_compiler.Emit(InstructionId.Emms);
			}

			// MFence/SFence/LFence.
			if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.X86SFence) & _functionNode.FunctionFlags.IsSet(FunctionNodeFlags.X86LFence))
			{
				_compiler.Emit(InstructionId.Mfence);
			}
			else if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.X86SFence))
			{
				_compiler.Emit(InstructionId.Sfence);
			}
			else if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.X86LFence))
			{
				_compiler.Emit(InstructionId.Lfence);
			}

			// Leave.
			if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsNaked))
			{
				if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.IsStackMisaligned))
				{
					_compiler.Emit(InstructionId.Mov, _assembler.Zsp, fpOffset);

					if (_functionNode.IsStackFrameRegPreserved)
					{
						_compiler.Emit(InstructionId.Pop, fpReg);
					}

					if (earlyPushPop)
					{
						EmitPopSequence(regsGp);
					}
				}
			}
			else
			{
				if (useLeaEpilog)
				{
					_compiler.Emit(InstructionId.Pop, fpReg);
				}
				else if (_functionNode.FunctionFlags.IsSet(FunctionNodeFlags.X86Leave))
				{
					_compiler.Emit(InstructionId.Leave);
				}
				else
				{
					_compiler.Emit(InstructionId.Mov, _assembler.Zsp, fpReg);
					_compiler.Emit(InstructionId.Pop, fpReg);
				}
			}

			// Emit return.
			if (decl.CalleePopsStack)
			{
				_compiler.Emit(InstructionId.Ret, decl.ArgumentsStackSize);
			}
			else
			{
				_compiler.Emit(InstructionId.Ret);
			}
		}

		private VariableState SaveState()
		{
			var cur = _variableContext.State;
			var dst = new VariableState(_variableContext.ContextVd.Count, cur);

			// Store masks.
			dst.Occupied.CopyFrom(cur.Occupied);
			dst.Modified.CopyFrom(cur.Modified);

			// Store cells.
			for (var i = 0; i < _variableContext.ContextVd.Count; i++)
			{
				var vd = _variableContext.ContextVd[i];
				var cell = dst.Cells[i];

				cell.Value1 = false;
				cell.Value0 = vd.State;

				dst.Cells[i] = cell;
			}

			return dst;
		}

		private void LoadState(VariableState src)
		{
			var cur = _variableContext.State;

			// Load allocated variables.
			LoadState(src, RegisterClass.Gp);
			LoadState(src, RegisterClass.Mm);
			LoadState(src, RegisterClass.Xyz);

			// Load masks.
			cur.Occupied.CopyFrom(src.Occupied);
			cur.Modified.CopyFrom(src.Modified);

			// Load states of other variables and clear their 'Modified' flags.
			for (var i = 0; i < _variableContext.ContextVd.Count; i++)
			{
				var vState = src.Cells[i].Value0;

				if (vState == VariableUsage.Reg) continue;

				_variableContext.ContextVd[i].State = vState;
				_variableContext.ContextVd[i].RegisterIndex = RegisterIndex.Invalid;
				_variableContext.ContextVd[i].IsModified = false;
			}
		}

		private void LoadState(VariableState src, RegisterClass @class)
		{
			var cur = _variableContext.State;

			var cVars = cur.GetListByClass(@class);
			var sVars = src.GetListByClass(@class);

			int regIndex;
			var modified = src.Modified.Get(@class);
			var regCount = Cpu.Info.RegisterCount.Get(@class);

			for (regIndex = 0; regIndex < regCount; regIndex++, modified >>= 1)
			{
				var vd = sVars[regIndex];
				cVars[regIndex] = vd;

				if (vd == null) continue;

				vd.State = VariableUsage.Reg;
				vd.RegisterIndex = regIndex;
				vd.IsModified = modified.IsSet(0x1);
			}
		}

		private void SwitchState(VariableState state)
		{
			var cur = _variableContext.State;
			var src = state;
			if (cur == src) return;
			SwitchState(src, RegisterClass.Gp);
			SwitchState(src, RegisterClass.Mm);
			SwitchState(src, RegisterClass.Xyz);

			var cells = src.Cells;
			for (var i = 0; i < _variableContext.ContextVd.Count; i++)
			{
				var vd = _variableContext.ContextVd[i];
				var cell = cells[i];
				var vState = cell.Value0;

				if (vState == VariableUsage.Reg) continue;
				vd.State = vState;
				vd.IsModified = false;
			}
		}

		private void SwitchState(VariableState src, RegisterClass @class)
		{
			var dst = _variableContext.State;
			var dVars = dst.GetListByClass(@class);
			var sVars = src.GetListByClass(@class);
			var cells = src.Cells;
			var regCount = Cpu.Info.RegisterCount.Get(@class);

			bool didWork;
			do
			{
				didWork = false;
				for (var regIndex = 0; regIndex < regCount; regIndex++)
				{
					var dVd = dVars[regIndex];
					var sVd = sVars[regIndex];

					if (dVd == sVd) continue;

					if (dVd != null)
					{
						var cell = cells[dVd.LocalId];

						if (cell.Value0 != VariableUsage.Reg)
						{
							if (cell.Value0 == VariableUsage.Mem)
							{
								Spill(dVd, @class);
							}
							else
							{
								Unuse(dVd, @class);
							}

							dVd = null;
							didWork = true;

							if (sVd == null) continue;
						}
					}

					if (dVd == null && sVd != null)
					{
						didWork = MoveOrLoad(sVd, @class, regIndex);
						continue;
					}

					if (dVd == null) continue;
					{
						var cell = cells[dVd.LocalId];
						if (sVd == null)
						{
							switch (cell.Value0)
							{
								case VariableUsage.Reg:
									continue;
								case VariableUsage.Mem:
									Spill(dVd, @class);
									break;
								default:
									Unuse(dVd, @class);
									break;
							}

							didWork = true;
						}
						else
						{
							switch (cell.Value0)
							{
								case VariableUsage.Reg:
									if (dVd.RegisterIndex != RegisterIndex.Invalid && sVd.RegisterIndex != RegisterIndex.Invalid)
									{
										if (@class == RegisterClass.Gp)
										{
											SwapGp(dVd, sVd);
										}
										else
										{
											Spill(dVd, @class);
											Move(sVd, @class, regIndex);
										}

										didWork = true;
										continue;
									}
									didWork = true;
									continue;
								case VariableUsage.Mem:
									Spill(dVd, @class);
									break;
								default:
									Unuse(dVd, @class);
									break;
							}

							didWork = MoveOrLoad(sVd, @class, regIndex);
						}
					}
				}
			} while (didWork);

			var dModified = dst.Modified.Get(@class);
			var sModified = src.Modified.Get(@class);

			if (dModified == sModified) return;
			{
				for (int regIndex = 0, regMask = 0x1; regIndex < regCount; regIndex++, regMask <<= 1)
				{
					var vd = dVars[regIndex];

					if (vd == null) continue;

					if (dModified.IsSet(regMask) && !sModified.IsSet(regMask))
					{
						Save(vd, @class);
						continue;
					}

					if (!dModified.IsSet(regMask) && sModified.IsSet(regMask))
					{
						Modify(vd, @class);
					}
				}
			}
		}

		private void IntersectStates(VariableState a, VariableState b)
		{
			if (a == null || b == null)
			{
				throw new ArgumentException();
			}

			IntersectStates(a, b, RegisterClass.Gp);
			IntersectStates(a, b, RegisterClass.Mm);
			IntersectStates(a, b, RegisterClass.Xyz);
		}

		private void IntersectStates(VariableState a, VariableState b, RegisterClass @class)
		{
			var dst = _variableContext.State;

			var dVars = dst.GetListByClass(@class);
			var aVars = a.GetListByClass(@class);
			//			var bVars = b.GetListByClass(@class);

			var aCells = a.Cells;
			var bCells = b.Cells;

			var regCount = Cpu.Info.RegisterCount.Get(@class);
			bool didWork;

			do
			{
				didWork = false;

				for (int regIndex = 0; regIndex < regCount; regIndex++)
				{
					var dVd = dVars[regIndex];

					var aVd = aVars[regIndex];
					//					var bVd = bVars[regIndex];

					if (dVd == aVd) continue;

					if (dVd != null)
					{
						var aCell = aCells[dVd.LocalId];
						var bCell = bCells[dVd.LocalId];

						if (aCell.Value0 != VariableUsage.Reg && bCell.Value0 != VariableUsage.Reg)
						{
							if (aCell.Value0 == VariableUsage.Mem || bCell.Value0 == VariableUsage.Mem)
							{
								Spill(dVd, @class);
							}
							else
							{
								Unuse(dVd, @class);
							}

							dVd = null;
							didWork = true;

							if (aVd == null) continue;
						}
					}

					if (dVd == null && aVd != null)
					{
						if (aVd.RegisterIndex != RegisterIndex.Invalid)
						{
							Move(aVd, @class, regIndex);
						}
						else
						{
							Load(aVd, @class, regIndex);
						}

						didWork = true;
						continue;
					}

					if (dVd == null) continue;
					{
						var aCell = aCells[dVd.LocalId];
						var bCell = bCells[dVd.LocalId];

						if (aVd == null)
						{
							if (aCell.Value0 == VariableUsage.Reg || bCell.Value0 == VariableUsage.Reg) continue;

							if (aCell.Value0 == VariableUsage.Mem || bCell.Value0 == VariableUsage.Mem)
							{
								Spill(dVd, @class);
							}
							else
							{
								Unuse(dVd, @class);
							}

							didWork = true;
							continue;
						}
						if (@class != RegisterClass.Gp) continue;
						if (aCell.Value0 != VariableUsage.Reg) continue;
						if (dVd.RegisterIndex == RegisterIndex.Invalid || aVd.RegisterIndex == RegisterIndex.Invalid) continue;
						SwapGp(dVd, aVd);

						didWork = true;
					}
				}
			} while (didWork);

			var dModified = dst.Modified.Get(@class);
			var aModified = a.Modified.Get(@class);

			if (dModified == aModified) return;
			{
				for (int regIndex = 0, regMask = 0x1; regIndex < regCount; regIndex++, regMask <<= 1)
				{
					var vd = dVars[regIndex];

					if (vd == null) continue;

					var aCell = aCells[vd.LocalId];
					if (dModified.IsSet(regMask) && !aModified.IsSet(regMask) && aCell.Value0 == VariableUsage.Reg)
					{
						Save(vd, @class);
					}
				}
			}
		}

		private void TranslateJump(JumpNode jNode, LabelNode jTarget)
		{
			var extNode = _extraBlock;

			_compiler.SetCurrentNode(extNode);
			SwitchState(jTarget.VariableState);

			// If one or more instruction has been added during switchState() it will be
			// moved at the end of the function body.
			if (_compiler.GetCurrentNode() != extNode)
			{
				// TODO: Can fail.
				var jTrampolineTarget = _compiler.CreateLabelNode();

				// Add the jump to the target.
				_codeContext.Jmp(new Label(jTarget.LabelId));

				// Add the trampoline-label we jump to change the state.
				extNode = _compiler.SetCurrentNode(extNode);
				_compiler.AddNode(jTrampolineTarget);

				// Finally, patch the jump target.
				if (jNode.Operands.Length == 0)
				{
					throw new ArgumentException();
				}
				jNode.Operands[0] = new Label(jTrampolineTarget.LabelId);
				jNode.Target = jTrampolineTarget;
			}

			// Store the `extNode` and load the state back.
			_extraBlock = extNode;
			LoadState(jNode.VariableState);
		}

		private bool MoveOrLoad(VariableData vd, RegisterClass @class, int regIndex)
		{
			if (vd.RegisterIndex != RegisterIndex.Invalid)
			{
				Move(vd, @class, regIndex);
			}
			else
			{
				Load(vd, @class, regIndex);
			}

			return true;
		}

		internal void SwapGp(VariableData aVd, VariableData bVd)
		{
			if (aVd == bVd || aVd.Info.RegisterClass != RegisterClass.Gp || aVd.State != VariableUsage.Reg || aVd.RegisterIndex == RegisterIndex.Invalid)
			{
				throw new ArgumentException();
			}
			if (bVd.Info.RegisterClass != RegisterClass.Gp || bVd.State != VariableUsage.Reg || bVd.RegisterIndex == RegisterIndex.Invalid)
			{
				throw new ArgumentException();
			}

			var aIndex = aVd.RegisterIndex;
			var bIndex = bVd.RegisterIndex;

			EmitSwapGp(aVd, bVd, aIndex, bIndex);

			aVd.RegisterIndex = bIndex;
			bVd.RegisterIndex = aIndex;

			_variableContext.State.GetListByClass(RegisterClass.Gp)[aIndex] = bVd;
			_variableContext.State.GetListByClass(RegisterClass.Gp)[bIndex] = aVd;

			var m = aVd.IsModified.AsInt() ^ bVd.IsModified.AsInt();
			_variableContext.State.Modified.Xor(RegisterClass.Gp, (m << aIndex) | (m << bIndex));
		}

		internal void Spill(VariableData vd, RegisterClass @class)
		{
			if (vd.Info.RegisterClass != @class)
			{
				throw new ArgumentException();
			}

			if (vd.State != VariableUsage.Reg) return;
			var regIndex = vd.RegisterIndex;
			if (regIndex == RegisterIndex.Invalid || _variableContext.State.GetListByClass(@class)[regIndex] != vd)
			{
				throw new ArgumentException();
			}
			if (vd.IsModified)
			{
				EmitSave(vd, regIndex);
			}
			Detach(vd, @class, regIndex, VariableUsage.Mem);
		}

		internal void Unuse(VariableData vd, RegisterClass @class, VariableUsage vState = VariableUsage.None)
		{
			if (vd.Info.RegisterClass != @class || vState == VariableUsage.Reg)
			{
				throw new ArgumentException();
			}

			var regIndex = vd.RegisterIndex;
			if (regIndex != RegisterIndex.Invalid)
			{
				Detach(vd, @class, regIndex, vState);
			}
			else
			{
				vd.State = vState;
			}
		}

		internal void Alloc(VariableData vd, RegisterClass @class, int regIndex)
		{
			if (vd.Info.RegisterClass != @class || regIndex == RegisterIndex.Invalid)
			{
				throw new ArgumentException();
			}

			var oldRegIndex = vd.RegisterIndex;
			var oldState = vd.State;
			var regMask = Utils.Mask(regIndex);

			if (_variableContext.State.GetListByClass(@class)[regIndex] != null && regIndex != oldRegIndex)
			{
				throw new ArgumentException();
			}

			if (oldState != VariableUsage.Reg)
			{
				if (oldState == VariableUsage.Mem)
				{
					EmitLoad(vd, regIndex);
				}
				vd.IsModified = false;
			}
			else if (oldRegIndex != regIndex)
			{
				EmitMove(vd, regIndex, oldRegIndex);

				_variableContext.State.GetListByClass(@class)[oldRegIndex] = null;
				regMask ^= Utils.Mask(oldRegIndex);
			}
			else
			{
				return;
			}

			vd.State = VariableUsage.Reg;
			vd.RegisterIndex = regIndex;
			vd.HomeMask |= Utils.Mask(regIndex);

			_variableContext.State.GetListByClass(@class)[regIndex] = vd;
			_variableContext.State.Occupied.Xor(@class, regMask);
			_variableContext.State.Modified.Xor(@class, regMask & -vd.IsModified.AsInt());
		}

		private void Load(VariableData vd, RegisterClass @class, int regIndex)
		{
			if (vd.Info.RegisterClass != @class || vd.State == VariableUsage.Reg || vd.RegisterIndex != RegisterIndex.Invalid)
			{
				throw new ArgumentException();
			}

			EmitLoad(vd, regIndex);
			Attach(vd, @class, regIndex, false);
		}

		internal void Save(VariableData vd, RegisterClass @class)
		{
			if (vd.Info.RegisterClass != @class || vd.State != VariableUsage.Reg || vd.RegisterIndex == RegisterIndex.Invalid)
			{
				throw new ArgumentException();
			}

			var regIndex = vd.RegisterIndex;
			var regMask = Utils.Mask(regIndex);

			EmitSave(vd, regIndex);

			vd.IsModified = false;
			_variableContext.State.Modified.AndNot(@class, regMask);
		}

		private void Modify(VariableData vd, RegisterClass @class)
		{
			if (vd.Info.RegisterClass != @class)
			{
				throw new ArgumentException();
			}

			var regIndex = vd.RegisterIndex;
			var regMask = Utils.Mask(regIndex);

			vd.IsModified = true;
			_variableContext.State.Modified.Or(@class, regMask);
		}

		internal void Move(VariableData vd, RegisterClass @class, int regIndex)
		{
			if (vd.Info.RegisterClass != @class || vd.State != VariableUsage.Reg || vd.RegisterIndex == RegisterIndex.Invalid)
			{
				throw new ArgumentException();
			}

			var oldIndex = vd.RegisterIndex;
			if (regIndex == oldIndex) return;
			EmitMove(vd, regIndex, oldIndex);
			Rebase(vd, @class, regIndex, oldIndex);
		}

		private void Rebase(VariableData vd, RegisterClass @class, int newRegIndex, int oldRegIndex)
		{
			if (vd.Info.RegisterClass != @class)
			{
				throw new ArgumentException();
			}

			var newRegMask = Utils.Mask(newRegIndex);
			var oldRegMask = Utils.Mask(oldRegIndex);
			var bothRegMask = newRegMask ^ oldRegMask;

			vd.RegisterIndex = newRegIndex;

			_variableContext.State.GetListByClass(@class)[oldRegIndex] = null;
			_variableContext.State.GetListByClass(@class)[newRegIndex] = vd;

			_variableContext.State.Occupied.Xor(@class, bothRegMask);
			_variableContext.State.Modified.Xor(@class, bothRegMask & -vd.IsModified.AsInt());
		}

		internal void Attach(VariableData vd, RegisterClass @class, int regIndex, bool modified)
		{
			if (vd.Info.RegisterClass != @class || regIndex == RegisterIndex.Invalid || (regIndex == RegisterIndex.Sp && @class == RegisterClass.Gp))
			{
				throw new ArgumentException();
			}

			var regMask = Utils.Mask(regIndex);

			vd.State = VariableUsage.Reg;
			vd.RegisterIndex = regIndex;
			vd.HomeMask |= Utils.Mask(regIndex);
			vd.IsModified = modified;

			_variableContext.State.GetListByClass(@class)[regIndex] = vd;
			_variableContext.State.Occupied.Or(@class, regMask);
			_variableContext.State.Modified.Or(@class, modified.AsInt() << regIndex);
		}

		private void Detach(VariableData vd, RegisterClass @class, int regIndex, VariableUsage vState)
		{
			if (vd.Info.RegisterClass != @class || vd.RegisterIndex != regIndex || vState == VariableUsage.Reg)
			{
				throw new ArgumentException();
			}

			var regMask = Utils.Mask(regIndex);

			vd.State = vState;
			vd.RegisterIndex = RegisterIndex.Invalid;
			vd.IsModified = false;

			_variableContext.State.GetListByClass(@class)[regIndex] = null;
			_variableContext.State.Occupied.AndNot(@class, regMask);
			_variableContext.State.Modified.AndNot(@class, regMask);
		}

		private void EmitSwapGp(VariableData aVd, VariableData bVd, int aIndex, int bIndex)
		{
			if (aIndex == RegisterIndex.Invalid || bIndex == RegisterIndex.Invalid)
			{
				throw new ArgumentException();
			}

			if (Constants.X64)
			{
				var vType = (VariableType)Math.Max((int)aVd.Type, (int)bVd.Type);
				if (vType == VariableType.Int64 || vType == VariableType.UInt64)
				{
					_compiler.Emit(InstructionId.Xchg, Compiler.Gpq(aIndex), Compiler.Gpq(bIndex));
				}
				else
				{
					_compiler.Emit(InstructionId.Xchg, Compiler.Gpd(aIndex), Compiler.Gpd(bIndex));
				}
			}
			else
			{
				_assembler.Emit(InstructionId.Xchg, Compiler.Gpd(aIndex), Compiler.Gpd(bIndex));
			}
		}

		private void EmitSave(VariableData vd, int regIndex)
		{
			var m = GetVarMem(vd);
			switch (vd.Type)
			{
				case VariableType.Invalid:
					break;
				case VariableType.Int8:
				case VariableType.UInt8:
					_compiler.Emit(InstructionId.Mov, m, Compiler.GpbLo(regIndex));
					break;
				case VariableType.Int16:
				case VariableType.UInt16:
					_compiler.Emit(InstructionId.Mov, m, Compiler.Gpw(regIndex));
					break;
				case VariableType.Int32:
				case VariableType.UInt32:
					_compiler.Emit(InstructionId.Mov, m, Compiler.Gpd(regIndex));
					break;
				case VariableType.Int64:
				case VariableType.UInt64:
					if (Constants.X64)
					{
						_compiler.Emit(InstructionId.Mov, m, Compiler.Gpq(regIndex));
					}
					else
					{
						throw new InvalidEnumArgumentException();
					}
					break;
				case VariableType.Mm:
					_compiler.Emit(InstructionId.Movq, m, Compiler.Mm(regIndex));
					break;
				case VariableType.Xmm:
					_compiler.Emit(InstructionId.Movdqa, m, Compiler.Xmm(regIndex));
					break;
				case VariableType.XmmSs:
					_compiler.Emit(InstructionId.Movss, m, Compiler.Xmm(regIndex));
					break;
				case VariableType.XmmPs:
					_compiler.Emit(InstructionId.Movaps, m, Compiler.Xmm(regIndex));
					break;
				case VariableType.XmmSd:
					_compiler.Emit(InstructionId.Movsd, m, Compiler.Xmm(regIndex));
					break;
				case VariableType.XmmPd:
					_compiler.Emit(InstructionId.Movapd, m, Compiler.Xmm(regIndex));
					break;
				default:
					throw new InvalidEnumArgumentException();
			}
		}

		private void EmitLoad(VariableData vd, int regIndex)
		{
			var m = GetVarMem(vd);
			switch (vd.Type)
			{
				case VariableType.Invalid:
					break;
				case VariableType.Int8:
				case VariableType.UInt8:
					_compiler.Emit(InstructionId.Mov, Compiler.GpbLo(regIndex), m);
					break;
				case VariableType.Int16:
				case VariableType.UInt16:
					_compiler.Emit(InstructionId.Mov, Compiler.Gpw(regIndex), m);
					break;
				case VariableType.Int32:
				case VariableType.UInt32:
					_compiler.Emit(InstructionId.Mov, Compiler.Gpd(regIndex), m);
					break;
				case VariableType.Int64:
				case VariableType.UInt64:
					if (Constants.X64)
					{
						_compiler.Emit(InstructionId.Mov, Compiler.Gpq(regIndex), m);
					}
					else
					{
						throw new InvalidEnumArgumentException();
					}
					break;
				case VariableType.Mm:
					_compiler.Emit(InstructionId.Movq, Compiler.Mm(regIndex), m);
					break;
				case VariableType.Xmm:
					_compiler.Emit(InstructionId.Movdqa, Compiler.Xmm(regIndex), m);
					break;
				case VariableType.XmmSs:
					_compiler.Emit(InstructionId.Movss, Compiler.Xmm(regIndex), m);
					break;
				case VariableType.XmmPs:
					_compiler.Emit(InstructionId.Movaps, Compiler.Xmm(regIndex), m);
					break;
				case VariableType.XmmSd:
					_compiler.Emit(InstructionId.Movsd, Compiler.Xmm(regIndex), m);
					break;
				case VariableType.XmmPd:
					_compiler.Emit(InstructionId.Movapd, Compiler.Xmm(regIndex), m);
					break;
				default:
					throw new InvalidEnumArgumentException();
			}
		}

		internal void EmitMove(VariableData vd, int toRegIndex, int fromRegIndex)
		{
			if (toRegIndex == RegisterIndex.Invalid || fromRegIndex == RegisterIndex.Invalid)
			{
				throw new ArgumentException();
			}

			switch (vd.Type)
			{
				case VariableType.Invalid:
					break;
				case VariableType.Int8:
				case VariableType.UInt8:
				case VariableType.Int16:
				case VariableType.UInt16:
				case VariableType.Int32:
				case VariableType.UInt32:
					_compiler.Emit(InstructionId.Mov, Compiler.Gpd(toRegIndex), Compiler.Gpd(fromRegIndex));
					break;
				case VariableType.Int64:
				case VariableType.UInt64:
					if (Constants.X64)
					{
						_compiler.Emit(InstructionId.Mov, Compiler.Gpq(toRegIndex), Compiler.Gpq(fromRegIndex));
					}
					else
					{
						throw new InvalidEnumArgumentException();
					}
					break;
				case VariableType.Mm:
					_compiler.Emit(InstructionId.Movq, Compiler.Mm(toRegIndex), Compiler.Mm(fromRegIndex));
					break;
				case VariableType.Xmm:
					_compiler.Emit(InstructionId.Movdqa, Compiler.Xmm(toRegIndex), Compiler.Xmm(fromRegIndex));
					break;
				case VariableType.XmmSs:
					_compiler.Emit(InstructionId.Movss, Compiler.Xmm(toRegIndex), Compiler.Xmm(fromRegIndex));
					break;
				case VariableType.XmmPs:
					_compiler.Emit(InstructionId.Movaps, Compiler.Xmm(toRegIndex), Compiler.Xmm(fromRegIndex));
					break;
				case VariableType.XmmSd:
					_compiler.Emit(InstructionId.Movsd, Compiler.Xmm(toRegIndex), Compiler.Xmm(fromRegIndex));
					break;
				case VariableType.XmmPd:
					_compiler.Emit(InstructionId.Movapd, Compiler.Xmm(toRegIndex), Compiler.Xmm(fromRegIndex));
					break;
				default:
					throw new InvalidEnumArgumentException();
			}
		}

		internal void EmitMoveImmOnStack(VariableType dstType, Memory dst, Immediate src)
		{
			var mem = new Memory(dst, Cpu.Info.RegisterSize);
			var imm = new Immediate(src);

			switch (dstType)
			{
				case VariableType.Invalid:
					break;
				case VariableType.Int8:
				case VariableType.UInt8:
					imm.TruncateTo8Bits();
					imm.TruncateTo32Bits();
					_compiler.Emit(InstructionId.Mov, mem, imm);
					break;
				case VariableType.Int16:
				case VariableType.UInt16:
					imm.TruncateTo16Bits();
					imm.TruncateTo32Bits();
					_compiler.Emit(InstructionId.Mov, mem, imm);
					break;
				case VariableType.Int32:
				case VariableType.UInt32:
					imm.TruncateTo32Bits();
					_compiler.Emit(InstructionId.Mov, mem, imm);
					break;
				case VariableType.Int64:
				case VariableType.UInt64:
					if (Constants.X64)
					{
						_compiler.Emit(InstructionId.Mov, mem, imm);
					}
					else
					{
						var hi0 = imm.UInt32Hi;
						_compiler.Emit(InstructionId.Mov, mem, imm.TruncateTo32Bits());
						mem.Adjust(Cpu.Info.RegisterSize);
						imm.UInt32 = hi0;
						_compiler.Emit(InstructionId.Mov, mem, imm);
					}
					break;
				case VariableType.Fp32:
					imm.TruncateTo32Bits();
					_compiler.Emit(InstructionId.Mov, mem, imm);
					break;
				case VariableType.Fp64:
				case VariableType.Mm:
					if (Constants.X64)
					{
						_compiler.Emit(InstructionId.Mov, mem, imm);
					}
					else
					{
						var hi1 = imm.UInt32Hi;
						_compiler.Emit(InstructionId.Mov, mem, imm.TruncateTo32Bits());
						mem.Adjust(Cpu.Info.RegisterSize);
						imm.UInt32 = hi1;
						_compiler.Emit(InstructionId.Mov, mem, imm);
					}
					break;
				case VariableType.Xmm:
				case VariableType.XmmSs:
				case VariableType.XmmPs:
				case VariableType.XmmSd:
				case VariableType.XmmPd:
					if (Constants.X64)
					{
						var hi = imm.UInt32Hi;

						// Lo part.
						_compiler.Emit(InstructionId.Mov, mem, imm.TruncateTo32Bits());
						mem.Adjust(Cpu.Info.RegisterSize);

						// Hi part.
						imm.UInt32 = hi;
						_compiler.Emit(InstructionId.Mov, mem, imm);
						mem.Adjust(Cpu.Info.RegisterSize);

						// Zero part.
						imm.UInt32 = 0;
						_compiler.Emit(InstructionId.Mov, mem, imm);
						mem.Adjust(Cpu.Info.RegisterSize);

						_compiler.Emit(InstructionId.Mov, mem, imm);
					}
					else
					{
						_compiler.Emit(InstructionId.Mov, mem, imm);
						mem.Adjust(Cpu.Info.RegisterSize);
						imm.Int32 = 0;
						_compiler.Emit(InstructionId.Mov, mem, imm);
					}
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		internal void EmitMoveImmToReg(VariableType dstType, int dstIndex, Immediate src)
		{
			if (dstIndex == RegisterIndex.Invalid)
			{
				
			}
			Register r0;
			var imm = new Immediate(src);

			switch (dstType)
			{
				case VariableType.Invalid:
					break;
				case VariableType.Int8:
				case VariableType.UInt8:
					imm.TruncateTo8Bits();
					r0 = Compiler.Gpd(dstIndex);
					_compiler.Emit(InstructionId.Mov, r0, imm);
					break;
				case VariableType.Int16:
				case VariableType.UInt16:
					imm.TruncateTo16Bits();
					r0 = Compiler.Gpd(dstIndex);
					_compiler.Emit(InstructionId.Mov, r0, imm);
					break;
				case VariableType.Int32:
				case VariableType.UInt32:
					imm.TruncateTo32Bits();
					r0 = Compiler.Gpd(dstIndex);
					_compiler.Emit(InstructionId.Mov, r0, imm);
					break;
				case VariableType.Int64:
				case VariableType.UInt64:
					// Move to Gpd register will also clear high DWORD of Gpq register in
					// 64-bit mode.
					if (imm.IsUInt32())
					{
						imm.TruncateTo32Bits();
						r0 = Compiler.Gpd(dstIndex);
						_compiler.Emit(InstructionId.Mov, r0, imm);
					}
					else
					{
						r0 = Compiler.Gpq(dstIndex);
						_compiler.Emit(InstructionId.Mov, r0, imm);
					}
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		internal void EmitConvertVarToVar(VariableType dstType, int dstIndex, VariableType srcType, int srcIndex)
		{
			var type = dstType;
			while (true)
			{
				switch (type)
				{
					case VariableType.Invalid:
					case VariableType.Int8:
					case VariableType.UInt8:
					case VariableType.Int16:
					case VariableType.UInt16:
					case VariableType.Int32:
					case VariableType.UInt32:
					case VariableType.Int64:
					case VariableType.UInt64:
						break;
					case VariableType.XmmSs:
						if (srcType == VariableType.XmmSd || srcType == VariableType.XmmPd || srcType == VariableType.YmmPd)
						{
							_compiler.Emit(InstructionId.Cvtsd2ss, Compiler.Xmm(dstIndex), Compiler.Xmm(srcIndex));
							return;
						}
						if (srcType >= VariableType.Int8 && srcType <= VariableType.UInt64)
						{
							// TODO: [COMPILER] Variable conversion not supported.
							throw new NotSupportedException();
						}
						return;
					case VariableType.XmmPs:
						if (srcType == VariableType.XmmPd || srcType == VariableType.YmmPd)
						{
							_compiler.Emit(InstructionId.Cvtpd2ps, Compiler.Xmm(dstIndex), Compiler.Xmm(srcIndex));
							return;
						}
						type = VariableType.XmmPd;
						continue;
					case VariableType.XmmSd:
						if (srcType == VariableType.XmmSs || srcType == VariableType.XmmPs || srcType == VariableType.YmmPs)
						{
							_compiler.Emit(InstructionId.Cvtss2sd, Compiler.Xmm(dstIndex), Compiler.Xmm(srcIndex));
							return;
						}
						if (srcType >= VariableType.Int8 && srcType <= VariableType.UInt64)
						{
							// TODO: [COMPILER] Variable conversion not supported.
							throw new NotSupportedException();
						}
						return;
					case VariableType.XmmPd:
						if (srcType == VariableType.XmmPs || srcType == VariableType.YmmPs)
						{
							_compiler.Emit(InstructionId.Cvtps2pd, Compiler.Xmm(dstIndex), Compiler.Xmm(srcIndex));
							return;
						}
						type = VariableType.XmmSd;
						continue;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}

		internal void EmitMoveVarOnStack(VariableType dstType, Memory dst, VariableType srcType, int srcIndex)
		{
			var movGpD = new Action(() =>
			{
				var m0 = new Memory(dst, 4);
				var r0 = Compiler.Gpd(srcIndex);
				_compiler.Emit(InstructionId.Mov, m0, r0);
			});
			var movGpQ = new Action(() =>
			{
				var m0 = new Memory(dst, 8);
				var r0 = Compiler.Gpq(srcIndex);
				_compiler.Emit(InstructionId.Mov, m0, r0);
			});
			var movMmD = new Action(() =>
			{
				var m0 = new Memory(dst, 4);
				var r0 = Compiler.Mm(srcIndex);
				_compiler.Emit(InstructionId.Movd, m0, r0);
			});
			var movMmQ = new Action(() =>
			{
				var m0 = new Memory(dst, 8);
				var r0 = Compiler.Mm(srcIndex);
				_compiler.Emit(InstructionId.Movd, m0, r0);
			});
			var movXmmD = new Action(() =>
			{
				var m0 = new Memory(dst, 4);
				var r0 = Compiler.Xmm(srcIndex);
				_compiler.Emit(InstructionId.Movss, m0, r0);
			});
			var movXmmQ = new Action(() =>
			{
				var m0 = new Memory(dst, 8);
				var r0 = Compiler.Xmm(srcIndex);
				_compiler.Emit(InstructionId.Movlps, m0, r0);
			});
			var extendMovGpD = new Action<Register, InstructionId>((r1, instId) =>
			{
				var m0 = new Memory(dst, 4);
				var r0 = Compiler.Gpd(srcIndex);
				_compiler.Emit(instId, r0, r1);
				_compiler.Emit(InstructionId.Mov, m0, r0);
			});
			var extendMovGpDq = new Action<Memory, Register>((m0, r0) =>
			{
				_compiler.Emit(InstructionId.Mov, m0, r0);
				m0.Adjust(4);
				_compiler.Emit(InstructionId.And, m0, 0);
			});
			var extendMovGpXq = new Action<Register, InstructionId>((r1, instId) =>
			{
				if (Constants.X64)
				{
					var m0 = new Memory(dst, 8);
					var r0 = Compiler.Gpq(srcIndex);
					_compiler.Emit(instId, r0, r1);
					_compiler.Emit(InstructionId.Mov, m0, r0);
				}
				else
				{
					var m0 = new Memory(dst, 4);
					var r0 = Compiler.Gpd(srcIndex);
					_compiler.Emit(instId, r0, r1);
					extendMovGpDq(m0, r0);
				}
			});
			switch (dstType)
			{
				case VariableType.Invalid:
					break;
				case VariableType.Int8:
				case VariableType.UInt8:
					if (srcType >= VariableType.Int8 && srcType <= VariableType.UInt64)
					{
						movGpD();
						return;
					}
					if (srcType == VariableType.Mm)
					{
						movMmD();
						return;
					}
					if (srcType >= VariableType.Xmm && srcType <= VariableType.XmmPd)
					{
						movXmmD();
					}
					break;
				case VariableType.Int16:
				case VariableType.UInt16:
					if (srcType >= VariableType.Int8 && srcType <= VariableType.UInt8)
					{
						extendMovGpD(Compiler.GpbLo(srcIndex), dstType == VariableType.Int16 && srcType == VariableType.Int8 ? InstructionId.Movsx : InstructionId.Movzx);
						return;
					}
					if (srcType >= VariableType.Int16 && srcType <= VariableType.UInt64)
					{
						movGpD();
						return;
					}
					if (srcType == VariableType.Mm)
					{
						movMmD();
						return;
					}
					if (srcType >= VariableType.Xmm && srcType <= VariableType.XmmPd)
					{
						movXmmD();
					}
					break;
				case VariableType.Int32:
				case VariableType.UInt32:
					if (srcType >= VariableType.Int8 && srcType <= VariableType.UInt8)
					{
						extendMovGpD(Compiler.GpbLo(srcIndex), dstType == VariableType.Int32 && srcType == VariableType.Int8 ? InstructionId.Movsx : InstructionId.Movzx);
						return;
					}
					if (srcType >= VariableType.Int16 && srcType <= VariableType.UInt16)
					{
						extendMovGpD(Compiler.Gpw(srcIndex), dstType == VariableType.Int32 && srcType == VariableType.Int16 ? InstructionId.Movsx : InstructionId.Movzx);
						return;
					}
					if (srcType >= VariableType.Int32 && srcType <= VariableType.UInt64)
					{
						movGpD();
						return;
					}
					if (srcType == VariableType.Mm)
					{
						movMmD();
						return;
					}
					if (srcType >= VariableType.Xmm && srcType <= VariableType.XmmPd)
					{
						movXmmD();
					}
					break;
				case VariableType.Int64:
				case VariableType.UInt64:
					if (srcType >= VariableType.Int8 && srcType <= VariableType.UInt8)
					{
						extendMovGpXq(Compiler.GpbLo(srcIndex), dstType == VariableType.Int64 && srcType == VariableType.Int8 ? InstructionId.Movsx : InstructionId.Movzx);
						return;
					}
					if (srcType >= VariableType.Int16 && srcType <= VariableType.UInt16)
					{
						extendMovGpXq(Compiler.Gpw(srcIndex), dstType == VariableType.Int32 && srcType == VariableType.Int16 ? InstructionId.Movsx : InstructionId.Movzx);
						return;
					}
					if (srcType >= VariableType.Int32 && srcType <= VariableType.UInt32)
					{
						if (dstType == VariableType.Int64 && srcType == VariableType.Int32)
						{
							extendMovGpXq(Compiler.Gpd(srcIndex), InstructionId.Movsxd);
						}
						else
						{
							extendMovGpDq(new Memory(dst, 4), Compiler.Gpd(srcIndex));
						}
						return;
					}
					if (srcType >= VariableType.Int64 && srcType <= VariableType.UInt64)
					{
						movGpQ();
						return;
					}
					if (srcType == VariableType.Mm)
					{
						movMmQ();
						return;
					}
					if (srcType >= VariableType.Xmm && srcType <= VariableType.XmmPd)
					{
						movXmmQ();
					}
					break;
				case VariableType.Mm:
					if (srcType >= VariableType.Int8 && srcType <= VariableType.UInt8)
					{
						extendMovGpXq(Compiler.GpbLo(srcIndex), InstructionId.Movzx);
						return;
					}
					if (srcType >= VariableType.Int16 && srcType <= VariableType.UInt16)
					{
						extendMovGpXq(Compiler.Gpw(srcIndex), InstructionId.Movzx);
						return;
					}
					if (srcType >= VariableType.Int32 && srcType <= VariableType.UInt32)
					{
						extendMovGpDq(new Memory(dst), Compiler.Gpd(srcIndex));
						return;
					}
					if (srcType >= VariableType.Int64 && srcType <= VariableType.UInt64)
					{
						movGpQ();
						return;
					}
					if (srcType == VariableType.Mm)
					{
						movMmQ();
						return;
					}
					if (srcType >= VariableType.Xmm && srcType <= VariableType.XmmPd)
					{
						movXmmQ();
					}
					break;
				case VariableType.Fp32:
				case VariableType.XmmSs:
					if (srcType == VariableType.XmmSs || srcType == VariableType.XmmPs || srcType == VariableType.Xmm)
					{
						movXmmQ();
					}
					break;
				case VariableType.Fp64:
				case VariableType.XmmSd:
					if (srcType == VariableType.XmmSd || srcType == VariableType.XmmPd || srcType == VariableType.Xmm)
					{
						movXmmQ();
					}
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		private void EmitPushSequence(int regs)
		{
			var i = 0;

			while (regs != 0)
			{
				if (i >= Cpu.Info.RegisterCount.Get(RegisterClass.Gp))
				{
					throw new ArgumentException();
				}
				if (regs.IsSet(0x1))
				{
					var gpReg = new GpRegister((GpRegisterType) _assembler.Zsp.RegisterType, i);
					_compiler.Emit(InstructionId.Push, gpReg);
				}
				i++;
				regs >>= 1;
			}
		}

		private void EmitPopSequence(int regs)
		{
			if (regs == 0) return;

			var i = Cpu.Info.RegisterCount.Get(RegisterClass.Gp);
			var mask = 0x1 << (i - 1);

			while (i != 0)
			{
				i--;
				if (regs.IsSet(mask))
				{
					var gpReg = new GpRegister((GpRegisterType) _assembler.Zsp.RegisterType, i);
					_compiler.Emit(InstructionId.Pop, gpReg);
				}
				mask >>= 1;
			}
		}

		internal void TranslateOperands(Operand[] opList)
		{
			// Translate variables into registers.
			for (var i = 0; i < opList.Length; i++)
			{
				var op = opList[i];

				if (op.IsVariable())
				{
					var vd = _compiler.GetVariableData(op.Id);
					if (vd == null || vd.RegisterIndex == RegisterIndex.Invalid)
					{
						throw new ArgumentException();
					}

					opList[i] = Register.FromVariable(op.As<Variable>(), vd.RegisterIndex);
				}
				else if (op.IsMemory())
				{
					var m = op.As<Memory>();

					if (m.MemoryType <= MemoryType.StackIndex && m.Base.IsVariableId())
					{
						var vd = _compiler.GetVariableData(m.Base);

						if (m.MemoryType == MemoryType.BaseIndex)
						{
							if (vd.RegisterIndex == RegisterIndex.Invalid)
							{
								throw new ArgumentException();
							}
							m.Base = vd.RegisterIndex;
						}
						else
						{
							if (!vd.IsMemoryArgument)
							{
								GetVarCell(vd);
							}

							// Offset will be patched later by X86Context_patchFuncMem().
							m.SetGpdBase((Cpu.Info.RegisterSize == 4).AsInt());
							m.Adjust(vd.IsMemoryArgument ? ArgActualDisp : VarActualDisp);
						}
					}

					if (!m.Index.IsVariableId()) continue;
					{
						var vd = _compiler.GetVariableData(m.Index);
						if (vd.RegisterIndex == RegisterIndex.Invalid || vd.RegisterIndex == RegisterIndex.R12)
						{
							throw new ArgumentException();
						}
						m.Index = vd.RegisterIndex;
					}
				}
			}
		}

		private void TranslateRet(ReturnNode rNode, LabelNode exitTarget)
		{
			var node = rNode.Next;
			var map = rNode.VariableMap;

			if (map != null)
			{
				var vaList = map.Attributes;
				var vaCount = map.AttributesCount;

				for (var i = 0; i < vaCount; i++)
				{
					var va = vaList[i];
					if (va.Flags.IsSet(VariableFlags.X86Fld4 | VariableFlags.X86Fld8))
					{
						var vd = va.VariableData;

						var flags = vd.Type.GetVariableInfo().ValueFlags;
						var ms = flags.IsSet(VariableValueFlags.Sp) ? 4 : flags.IsSet(VariableValueFlags.Dp) ? 8 : va.Flags.IsSet(VariableFlags.X86Fld4) ? 4 : 8;
						_codeContext.Fld(new Memory(GetVarMem(vd), ms));
					}
				}
			}

			while (node != null)
			{
				switch (node.Type)
				{
					case CodeNodeType.None:
						break;
					case CodeNodeType.Call:
					case CodeNodeType.Instruction:
					case CodeNodeType.Data:
					case CodeNodeType.Return:
						_compiler.SetCurrentNode(rNode);
						_codeContext.Jmp(new Label(exitTarget.LabelId));
						return;
					case CodeNodeType.Label:
						if (node.As<LabelNode>() == exitTarget) return;
						_compiler.SetCurrentNode(rNode);
						_codeContext.Jmp(new Label(exitTarget.LabelId));
						return;
					case CodeNodeType.Comment:
					case CodeNodeType.Alignment:
					case CodeNodeType.Hint:
						break;
					case CodeNodeType.Sentinel:
						return;
					case CodeNodeType.Function:
						throw new ArgumentException();
					case CodeNodeType.CallArgument:
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
				node = node.Next;
			}
			_compiler.SetCurrentNode(rNode);
			_codeContext.Jmp(new Label(exitTarget.LabelId));
		}

		private static int GetDefaultAlignment(int size)
		{
			if (size > 32)
				return 64;
			if (size > 16)
				return 32;
			if (size > 8)
				return 16;
			if (size > 4)
				return 8;
			if (size > 2)
				return 4;
			return size > 1 ? 2 : 1;
		}

		private void CreateVarCell(VariableData vd)
		{
			var size = vd.Info.Size;
			VariableCell cell;
			if (vd.IsStack)
			{
				cell = CreateStackCell(size, vd.Alignment);
			}
			else
			{
				cell = new VariableCell
				{
					Next = _memVarCells,
					Offset = 0,
					Size = size,
					Alignment = size
				};
				_memVarCells = cell;
				_memMaxAlign = Math.Max(_memMaxAlign, size);
//				_memVarTotal += size;

				switch (size)
				{
					case 1:
						_mem1ByteVarsUsed++;
						break;
					case 2:
						_mem2ByteVarsUsed++;
						break;
					case 4:
						_mem4ByteVarsUsed++;
						break;
					case 8:
						_mem8ByteVarsUsed++;
						break;
					case 16:
						_mem16ByteVarsUsed++;
						break;
					case 32:
						_mem32ByteVarsUsed++;
						break;
					case 64:
						_mem64ByteVarsUsed++;
						break;
				}
			}

			vd.MemoryCell = cell;
		}

		private VariableCell CreateStackCell(int size, int alignment)
		{
			var cell = new VariableCell();
			if (alignment == 0)
			{
				alignment = GetDefaultAlignment(size);
			}

			if (alignment > 64)
			{
				alignment = 64;
			}

			if (!alignment.IsPowerOf2())
			{
				throw new ArgumentException("Invalid alignment");
			}
			size = size.AlignTo(alignment);

			// Insert it sorted according to the alignment and size.
			{
				var pPrev = _memStackCells;
				var cur = pPrev;


				var mi = 0;
				VariableCell tmp0 = null;
				while (true)
				{
					if (cur == null) break;
					if ((cur.Alignment > alignment) || (cur.Alignment == alignment && cur.Size > size))
					{
						if (mi++ == 0)
						{
							_memStackCells = cur.Next;
							continue;
						}
						tmp0 = cur;
						var tmp1 = cur.Next;
						cur.Next = cur;
						cur = tmp1;
						continue;
					}
					break;
				}

				cell.Next = cur;
				cell.Offset = 0;
				cell.Size = size;
				cell.Alignment = alignment;

				if (tmp0 != null)
				{
					tmp0.Next = cell;
				}
				else
				{
					_memStackCells = cell;
				}
//				_memStackCellsUsed++;

				_memMaxAlign = Math.Max(_memMaxAlign, alignment);
//				_memStackTotal += size;
			}

			return cell;
		}

		private void GetVarCell(VariableData vd)
		{
			if (vd.MemoryCell == null)
			{
				CreateVarCell(vd);
			}
		}

		internal Memory GetVarMem(VariableData vd)
		{
			GetVarCell(vd);
			return new Memory(_memSlot) { Base = vd.Id };
		}
//
//		private Result NextGroup(Result result)
//		{
//			while (result == Result.NextGroup || _node.IsTranslated())
//			{
//				if (result != Result.NextGroup)
//				{
//					// Switch state if we went to the already translated node.
//					if (_node.Type == CodeNodeType.Label)
//					{
//						var node = _node.As<LabelNode>();
//						_compiler.SetCurrentNode(node.Previous);
//						SwitchState(node.VariableState);
//					}
//				}
//
//				if (_jLinkIndex >= _variableContext.JccList.Count)
//				{
//					return Result.Done;
//				}
//				_node = _variableContext.JccList[_jLinkIndex++];
//
//				var jFlow = GetOppositeJccFlow(_node.As<JumpNode>());
//				LoadState(_node.VariableState);
//
//				if (jFlow.VariableState != null)
//				{
//					TranslateJump(_node.As<JumpNode>(), jFlow.As<LabelNode>());
//
//					_node = jFlow;
//					if (_node.IsTranslated())
//					{
//						return NextGroup(Result.NextGroup);
//					}
//				}
//				else
//				{
//					_node = jFlow;
//				}
//				break;
//			}
//			return Result.Break;
//		}
		
		private static CodeNode GetJccFlow(JumpNode jump)
		{
			return jump.Flags.IsSet(CodeNodeFlags.Taken) ? jump.Target : jump.Next;
		}

		private static CodeNode GetOppositeJccFlow(JumpNode jump)
		{
			return jump.Flags.IsSet(CodeNodeFlags.Taken) ? jump.Next : jump.Target;
		}
	}
}