using System;
using AsmJit.AssemblerContext;
using AsmJit.Common;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext.CodeTree;

namespace AsmJit.CompilerContext
{
	internal sealed class VariableAllocator : Allocator
	{
		private RegisterMask _willAlloc = new RegisterMask();
		private RegisterMask _willSpill = new RegisterMask();

		public VariableAllocator(Assembler assembler, Compiler compiler, CodeContext codeContext, Translator translator, VariableContext ctx)
			: base(assembler, compiler, codeContext, translator, ctx)
		{
		}

		private void InitImpl(CodeNode node, VariableMap map)
		{
			Init(node, map);

			// These will block planner from assigning them during planning. Planner will
			// add more registers when assigning registers to variables that don't need
			// any specific register.
			_willAlloc.CopyFrom(map.InRegs);
			_willAlloc.Or(map.OutRegs);
			_willSpill.Reset();
		}

		public void Run(CodeNode node)
		{
			var map = node.VariableMap;
			if (map == null) return;

			InitImpl(node, map);

			UnuseBefore(RegisterClass.Gp);
			UnuseBefore(RegisterClass.Mm);
			UnuseBefore(RegisterClass.Xyz);

			Plan(RegisterClass.Gp);
			Plan(RegisterClass.Mm);
			Plan(RegisterClass.Xyz);

			Spill(RegisterClass.Gp);
			Spill(RegisterClass.Mm);
			Spill(RegisterClass.Xyz);

			Alloc(RegisterClass.Gp);
			Alloc(RegisterClass.Mm);
			Alloc(RegisterClass.Xyz);

			// Translate node operands.
			if (node.Type == CodeNodeType.Instruction)
			{
				var inst = node.As<InstructionNode>();
				Translator.TranslateOperands(inst.Operands);
			}
			else if (node.Type == CodeNodeType.CallArgument)
			{
				var carg = node.As<CallArgumentNode>();

				var call = carg.Call;
				var decl = call.FunctionDeclaration;

				var argIndex = 0;
				var argMask = carg.AffectedArguments;

				var sVd = carg.Source;
				var cVd = carg.Conv;

				// Convert first.
				if (!(sVd.RegisterIndex != RegisterIndex.Invalid)) { throw new ArgumentException(); }

				if (cVd != null)
				{
					if (!(cVd.RegisterIndex != RegisterIndex.Invalid)) { throw new ArgumentException(); }
					Translator.EmitConvertVarToVar(cVd.Type, cVd.RegisterIndex, sVd.Type, sVd.RegisterIndex);
					sVd = cVd;
				}

				while (argMask != 0)
				{
					if (argMask.IsSet(0x1))
					{
						var arg = decl.GetArgument(argIndex);
						if (!(arg.StackOffset != Constants.InvalidValue)) { throw new ArgumentException(); }

						var dst = Memory.Ptr(Assembler.Zsp, -Cpu.Info.RegisterSize + arg.StackOffset);
						Translator.EmitMoveVarOnStack(arg.VariableType, dst, sVd.Type, sVd.RegisterIndex);
					}

					argIndex++;
					argMask >>= 1;
				}
			}

			// Mark variables as modified.
			Modified(RegisterClass.Gp);
			Modified(RegisterClass.Mm);
			Modified(RegisterClass.Xyz);

			// Cleanup; disconnect Vd->Va.
			Cleanup();

			// Update clobbered mask.
			VariableContext.ClobberedRegs.Or(_willAlloc);
			VariableContext.ClobberedRegs.Or(map.ClobberedRegs);

			// Unuse.
			UnuseAfter(RegisterClass.Gp);
			UnuseAfter(RegisterClass.Mm);
			UnuseAfter(RegisterClass.Xyz);
		}

		private void UnuseBefore(RegisterClass @class)
		{
			var list = VaList[(int)@class];
			var count = Count.Get(@class);

			const VariableFlags checkFlags = VariableFlags.XReg | VariableFlags.RMem | VariableFlags.RFunc | VariableFlags.RCall | VariableFlags.RConv;

			for (var i = 0; i < count; i++)
			{
				var va = list[i];

				if ((va.Flags & checkFlags) == VariableFlags.WReg)
				{
					Translator.Unuse(va.VariableData, @class);
				}
			}
		}

		private void UnuseAfter(RegisterClass @class)
		{
			var list = VaList[(int)@class];
			var count = Count.Get(@class);

			for (var i = 0; i < count; i++)
			{
				var va = list[i];

				if (va.Flags.IsSet(VariableFlags.Unuse))
				{
					Translator.Unuse(va.VariableData, @class);
				}
			}
		}

		private void Plan(RegisterClass @class)
		{
			if (Done.Get(@class) == Count.Get(@class)) return;

			int i;
			int willAlloc = _willAlloc.Get(@class);
			int willFree = 0;

			var list = VaList[(int)@class];
			var count = Count.Get(@class);

			var state = VariableContext.State;

			// Calculate 'willAlloc' and 'willFree' masks based on mandatory masks.
			for (i = 0; i < count; i++)
			{
				var va = list[i];
				var vd = va.VariableData;

				var vaFlags = va.Flags;
				var regIndex = vd.RegisterIndex;
				var regMask = (regIndex != RegisterIndex.Invalid) ? Utils.Mask(regIndex) : 0;

				if ((vaFlags & VariableFlags.XReg) != 0)
				{
					// Planning register allocation. First check whether the variable is
					// already allocated in register and if it can stay allocated there.
					//
					// The following conditions may happen:
					//
					// a) Allocated register is one of the mandatoryRegs.
					// b) Allocated register is one of the allocableRegs.
					var mandatoryRegs = va.InRegs;
					var allocableRegs = va.AllocableRegs;

					if (regMask != 0)
					{
						// Special path for planning output-only registers.
						if ((vaFlags & VariableFlags.XReg) == VariableFlags.WReg)
						{
							var outRegIndex = va.OutRegIndex;
							mandatoryRegs = (outRegIndex != RegisterIndex.Invalid) ? Utils.Mask(outRegIndex) : 0;

							if ((mandatoryRegs | allocableRegs).IsSet(regMask))
							{
								va.OutRegIndex = regIndex;
								va.Flags |= VariableFlags.AllocWDone;

								if (mandatoryRegs.IsSet(regMask))
								{
									// Case 'a' - 'willAlloc' contains initially all inRegs from all VarAttr's.
									if (!((willAlloc & regMask) != 0)) { throw new ArgumentException(); }
								}
								else
								{
									// Case 'b'.
									va.OutRegIndex = regIndex;
									willAlloc |= regMask;
								}

								Done.Add(@class);
								continue;
							}
						}
						else
						{
							if ((mandatoryRegs | allocableRegs).IsSet(regMask))
							{
								va.InRegIndex = regIndex;
								va.Flags |= VariableFlags.AllocRDone;

								if (mandatoryRegs.IsSet(regMask))
								{
									// Case 'a' - 'willAlloc' contains initially all inRegs from all VarAttr's.
									if (!((willAlloc & regMask) != 0)) { throw new ArgumentException(); }
								}
								else
								{
									// Case 'b'.
									va.InRegs |= regMask;
									willAlloc |= regMask;
								}

								Done.Add(@class);
								continue;
							}
						}
					}

					// Variable is not allocated or allocated in register that doesn't
					// match inRegs or allocableRegs. The next step is to pick the best
					// register for this variable. If `inRegs` contains any register the
					// decision is simple - we have to follow, in other case will use
					// the advantage of `guessAlloc()` to find a register (or registers)
					// by looking ahead. But the best way to find a good register is not
					// here since now we have no information about the registers that
					// will be freed. So instead of finding register here, we just mark
					// the current register (if variable is allocated) as `willFree` so
					// the planner can use this information in the second step to plan the
					// allocation as a whole.
					willFree |= regMask;
				}
				else
				{
					// Memory access - if variable is allocated it has to be freed.
					if (regMask != 0)
					{
						willFree |= regMask;
					}
					else
					{
						va.Flags |= VariableFlags.AllocRDone;
						Done.Add(@class);
					}
				}
			}

			// Occupied registers without 'willFree' registers; contains basically
			// all the registers we can use to allocate variables without inRegs
			// speficied.
			var occupied = state.Occupied.Get(@class) & ~willFree;
			var willSpill = 0;

			// Find the best registers for variables that are not allocated yet.
			for (i = 0; i < count; i++)
			{
				var va = list[i];
				var vd = va.VariableData;

				var vaFlags = va.Flags;

				if ((vaFlags & VariableFlags.XReg) != 0)
				{
					if ((vaFlags & VariableFlags.XReg) == VariableFlags.WReg)
					{
						if (vaFlags.IsSet(VariableFlags.AllocWDone)) continue;

						// Skip all registers that have assigned outRegIndex. Spill if occupied.
						if (va.OutRegIndex != RegisterIndex.Invalid)
						{
							var outRegs = Utils.Mask(va.OutRegIndex);
							willSpill |= occupied & outRegs;
							continue;
						}
					}
					else
					{
						if (vaFlags.IsSet(VariableFlags.AllocRDone)) continue;

						// We skip all registers that have assigned inRegIndex, indicates that
						// the register to allocate in is known.
						if (va.InRegIndex != RegisterIndex.Invalid)
						{
							var inRegs = va.InRegs;
							willSpill |= occupied & inRegs;
							continue;
						}
					}

					var m = va.InRegs;
					if (va.OutRegIndex != RegisterIndex.Invalid)
					{
						m |= Utils.Mask(va.OutRegIndex);
					}

					m = va.AllocableRegs & ~(willAlloc ^ m);
					m = GuessAlloc(vd, m, @class);
					if (!(m != 0)) { throw new ArgumentException(); }

					var candidateRegs = m & ~occupied;
					var homeMask = vd.HomeMask;

					if (candidateRegs == 0)
					{
						candidateRegs = m & occupied & ~state.Modified.Get(@class);
						if (candidateRegs == 0)
						{
							candidateRegs = m;
						}
					}

					// printf("CANDIDATE: %s %08X\n", vd->getName(), homeMask);
					if (candidateRegs.IsSet(homeMask))
					{
						candidateRegs &= homeMask;
					}

					var regIndex = candidateRegs.FindFirstBit();
					var regMask = Utils.Mask(regIndex);

					if ((vaFlags & VariableFlags.XReg) == VariableFlags.WReg)
					{
						va.OutRegIndex = regIndex;
					}
					else
					{
						va.InRegIndex = regIndex;
						va.InRegs = regMask;
					}

					willAlloc |= regMask;
					willSpill |= regMask & occupied;
					willFree &= ~regMask;
					occupied |= regMask;
				}
				else if ((vaFlags & VariableFlags.XMem) != 0)
				{
					var regIndex = vd.RegisterIndex;
					if (regIndex != RegisterIndex.Invalid && (vaFlags & VariableFlags.XMem) != VariableFlags.WMem)
					{
						willSpill |= Utils.Mask(regIndex);
					}
				}
			}

			_willSpill.Set(@class, willSpill);
			_willAlloc.Set(@class, willAlloc);
		}

		private void Spill(RegisterClass @class)
		{
			var m = _willSpill.Get(@class);
			var i = -1;

			if (m == 0) return;

			var state = VariableContext.State;
			var sVars = state.GetListByClass(@class);

			var availableRegs = VariableContext.GaRegs[@class] & ~(state.Occupied.Get(@class) | m | _willAlloc.Get(@class));
			do
			{
				var bitIndex = m.FindFirstBit() + 1;

				i += bitIndex;
				m >>= bitIndex;

				var vd = sVars[i];
				var va = vd.Attributes;

				if (!(va == null || !va.Flags.IsSet(VariableFlags.XReg))) { throw new ArgumentException(); }

				if (vd.IsModified && availableRegs != 0)
				{
					if (va == null || !va.Flags.IsSet(VariableFlags.Spill))
					{
						var altRegs = GuessSpill(vd, availableRegs, @class);

						if (altRegs != 0)
						{
							var regIndex = altRegs.FindFirstBit();
							var regMask = Utils.Mask(regIndex);

							Translator.Move(vd, @class, regIndex);
							availableRegs ^= regMask;
						}
					}
				}
				Translator.Spill(vd, @class);
			} while (m != 0);
		}

		private void Alloc(RegisterClass @class)
		{
			if (Done.Get(@class) == Count.Get(@class)) return;
			var list = VaList[(int)@class];
			var count = Count.Get(@class);

			var state = VariableContext.State;
			bool didWork;
			do
			{
				didWork = false;
				for (var i = 0; i < count; i++)
				{
					var aVa = list[i];
					var aVd = aVa.VariableData;

					if ((aVa.Flags & (VariableFlags.RReg | VariableFlags.AllocRDone)) != VariableFlags.RReg) continue;

					var aIndex = aVd.RegisterIndex;
					var bIndex = aVa.InRegIndex;

					// Shouldn't be the same.
					if (!(aIndex != bIndex)) { throw new ArgumentException(); }

					var bVd = state.GetListByClass(@class)[bIndex];
					if (bVd != null)
					{
						// Gp registers only - Swap two registers if we can solve two
						// allocation tasks by a single 'xchg' instruction, swapping
						// two registers required by the instruction/node or one register
						// required with another non-required.
						if (@class != RegisterClass.Gp || aIndex == RegisterIndex.Invalid) continue;
						var bVa = bVd.Attributes;
						Translator.SwapGp(aVd, bVd);

						aVa.Flags |= VariableFlags.AllocRDone;
						Done.Add(@class);

						// Doublehit, two registers allocated by a single swap.
						if (bVa != null && bVa.InRegIndex == aIndex)
						{
							bVa.Flags |= VariableFlags.AllocRDone;
							Done.Add(@class);
						}

						didWork = true;
					}
					else if (aIndex != RegisterIndex.Invalid)
					{
						Translator.Move(aVd, @class, bIndex);

						aVa.Flags |= VariableFlags.AllocRDone;
						Done.Add(@class);

						didWork = true;
					}
					else
					{
						Translator.Alloc(aVd, @class, bIndex);

						aVa.Flags |= VariableFlags.AllocRDone;
						Done.Add(@class);

						didWork = true;
					}
				}
			} while (didWork);

			// Alloc 'out' regs.
			for (var i = 0; i < count; i++)
			{
				var va = list[i];
				var vd = va.VariableData;

				if ((va.Flags & (VariableFlags.XReg | VariableFlags.AllocWDone)) != VariableFlags.WReg) continue;

				var regIndex = va.OutRegIndex;
				if (!(regIndex != RegisterIndex.Invalid)) { throw new ArgumentException(); }

				if (vd.RegisterIndex != regIndex)
				{
					if (!(state.GetListByClass(@class)[regIndex] == null)) { throw new ArgumentException(); }
					Translator.Attach(vd, @class, regIndex, false);
				}

				va.Flags |= VariableFlags.AllocWDone;
				Done.Add(@class);
			}
		}

		private void Modified(RegisterClass @class)
		{
			var list = VaList[(int)@class];
			var count = Count.Get(@class);

			for (var i = 0; i < count; i++)
			{
				var va = list[i];

				if (!va.Flags.IsSet(VariableFlags.WReg)) continue;
				var vd = va.VariableData;

				var regIndex = vd.RegisterIndex;
				var regMask = Utils.Mask(regIndex);

				vd.IsModified = true;
				VariableContext.State.Modified.Or(@class, regMask);
			}
		}

		private int GuessAlloc(VariableData vd, int allocableRegs, RegisterClass @class)
		{
			if (!(allocableRegs != 0)) { throw new ArgumentException(); }

			if (allocableRegs.IsPowerOf2()) return allocableRegs;

			var safeRegs = allocableRegs;
			var localId = vd.LocalId;
			var node = Node;

			for (var i = 0; i < Assembler.MaxLookAhead; i++)
			{
				var liveness = node.Liveness;

				// If the variable becomes dead it doesn't make sense to continue.
				if (liveness != null && liveness.GetBit(localId) == 0) break;

				// Stop on `HLSentinel` and `HLRet`.
				if (node.Flags.IsSet(CodeNodeFlags.Ret)) break;

				// Stop on conditional jump, we don't follow them.
				if (node.Flags.IsSet(CodeNodeFlags.Jcc)) break;

				// Advance on non-conditional jump.
				if (node.Flags.IsSet(CodeNodeFlags.Jmp))
				{
					node = node.As<JumpNode>().Target;
					// Stop on jump that is not followed.
					if (node == null) break;
				}

				node = node.Next;
				if (node == null) { throw new ArgumentException(); }

				var map = node.VariableMap;
				if (map == null) continue;
				var va = map.FindAttributesByClass(@class, vd);

				if (va != null)
				{
					// If the variable is overwritten it doesn't mase sense to continue.
					if ((va.Flags & VariableFlags.RAll) == 0) break;

					var mask = va.AllocableRegs;
					if (mask != 0)
					{
						allocableRegs &= mask;
						if (allocableRegs == 0) break;
						safeRegs = allocableRegs;
					}

					mask = va.InRegs;
					if (mask != 0)
					{
						allocableRegs &= mask;
						if (allocableRegs == 0) break;
						safeRegs = allocableRegs;
						break;
					}

					allocableRegs &= ~(map.OutRegs.Get(@class) | map.ClobberedRegs.Get(@class));
					if (allocableRegs == 0) break;
				}
				else
				{
					allocableRegs &= ~(map.InRegs.Get(@class) | map.OutRegs.Get(@class) | map.ClobberedRegs.Get(@class));
					if (allocableRegs == 0) break;
				}

				safeRegs = allocableRegs;
			}
			return safeRegs;
		}

		private int GuessSpill(VariableData vd, int allocableRegs, RegisterClass @class)
		{
			if (allocableRegs == 0) { throw new ArgumentException(); }
			return 0;
		}
	}
}
