using System;
using AsmJit.AssemblerContext;
using AsmJit.Common;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext.CodeTree;

namespace AsmJit.CompilerContext
{
	internal sealed class CodeProcessor
	{
		private Assembler _assembler;
		private Compiler _compiler;
		private CodeContext _codeContext;

		internal CodeProcessor(Assembler assembler, Compiler compiler, CodeContext codeContext)
		{
			_assembler = assembler;
			_compiler = compiler;
			_codeContext = codeContext;
		}

		internal void FetchAndTranslate(FunctionNode func)
		{
			var fetcher = new Fetcher(_compiler, func);
			var vc = fetcher.Run();
			var analyzer = new LivenessAnalyzer(func, vc);
			analyzer.Run();
			var translator = new Translator(_assembler, _compiler, _codeContext, func, vc);
			translator.Run();
		}

		internal void Serialize(CodeNode start, CodeNode stop)
		{
			var current = start;
			do
			{
				switch (current.Type)
				{
					case CodeNodeType.None:
						break;
					case CodeNodeType.Instruction:
						var node = current.As<InstructionNode>();
						var instId = node.InstructionId;
						var opList = node.Operands;
						var opCount = node.Operands.Length;
						Operand o0 = null;
						Operand o1 = null;
						Operand o2 = null;
						Operand o3 = null;
						if (node.IsSpecial())
						{
							switch (instId)
							{
								case InstructionId.Cpuid:
									break;

								case InstructionId.Cbw:
								case InstructionId.Cdq:
								case InstructionId.Cdqe:
								case InstructionId.Cwd:
								case InstructionId.Cwde:
								case InstructionId.Cqo:
									break;

								case InstructionId.Cmpxchg:
									o0 = opList[1];
									o1 = opList[2];
									break;

								case InstructionId.Cmpxchg8b:
								case InstructionId.Cmpxchg16b:
									o0 = opList[4];
									break;

								case InstructionId.Daa:
								case InstructionId.Das:
									break;

								case InstructionId.Imul:
								case InstructionId.Mul:
								case InstructionId.Idiv:
								case InstructionId.Div:
									// Assume "Mul/Div dst_hi (implicit), dst_lo (implicit), src (explicit)".
									if (!(opCount == 3)) { throw new ArgumentException(); }
									o0 = opList[2];
									break;

								case InstructionId.MovPtr:
									break;

								case InstructionId.Lahf:
								case InstructionId.Sahf:
									break;

								case InstructionId.Maskmovq:
								case InstructionId.Maskmovdqu:
									o0 = opList[1];
									o1 = opList[2];
									break;

								case InstructionId.Enter:
									o0 = opList[0];
									o1 = opList[1];
									break;

								case InstructionId.Leave:
									break;

								case InstructionId.Ret:
									if (opCount > 0)
										o0 = opList[0];
									break;

								case InstructionId.Monitor:
								case InstructionId.Mwait:
									break;

								case InstructionId.Pop:
									o0 = opList[0];
									break;

								case InstructionId.Popa:
								case InstructionId.Popf:
									break;

								case InstructionId.Push:
									o0 = opList[0];
									break;

								case InstructionId.Pusha:
								case InstructionId.Pushf:
									break;

								case InstructionId.Rcl:
								case InstructionId.Rcr:
								case InstructionId.Rol:
								case InstructionId.Ror:
								case InstructionId.Sal:
								case InstructionId.Sar:
								case InstructionId.Shl:
								case InstructionId.Shr:
									o0 = opList[0];
									o1 = Cpu.Registers.Cl;
									break;

								case InstructionId.Shld:
								case InstructionId.Shrd:
									o0 = opList[0];
									o1 = opList[1];
									o2 = Cpu.Registers.Cl;
									break;

								case InstructionId.Rdtsc:
								case InstructionId.Rdtscp:
									break;

								case InstructionId.RepLodsB:
								case InstructionId.RepLodsD:
								case InstructionId.RepLodsQ:
								case InstructionId.RepLodsW:
								case InstructionId.RepMovsB:
								case InstructionId.RepMovsD:
								case InstructionId.RepMovsQ:
								case InstructionId.RepMovsW:
								case InstructionId.RepStosB:
								case InstructionId.RepStosD:
								case InstructionId.RepStosQ:
								case InstructionId.RepStosW:
								case InstructionId.RepeCmpsB:
								case InstructionId.RepeCmpsD:
								case InstructionId.RepeCmpsQ:
								case InstructionId.RepeCmpsW:
								case InstructionId.RepeScasB:
								case InstructionId.RepeScasD:
								case InstructionId.RepeScasQ:
								case InstructionId.RepeScasW:
								case InstructionId.RepneCmpsB:
								case InstructionId.RepneCmpsD:
								case InstructionId.RepneCmpsQ:
								case InstructionId.RepneCmpsW:
								case InstructionId.RepneScasB:
								case InstructionId.RepneScasD:
								case InstructionId.RepneScasQ:
								case InstructionId.RepneScasW:
									break;

								case InstructionId.Xrstor:
								case InstructionId.Xrstor64:
								case InstructionId.Xsave:
								case InstructionId.Xsave64:
								case InstructionId.Xsaveopt:
								case InstructionId.Xsaveopt64:
									o0 = opList[0];
									break;

								case InstructionId.Xgetbv:
								case InstructionId.Xsetbv:
									break;

								default:
									throw new ArgumentException();
							}
						}
						else
						{
							if (opCount > 0)
							{
								o0 = opList[0];
							}
							if (opCount > 1)
							{
								o1 = opList[1];
							}
							if (opCount > 2)
							{
								o2 = opList[2];
							}
							if (opCount > 3)
							{
								o3 = opList[3];
							}
						}
						_assembler.Emit(instId, o0, o1, o2, o3, node.InstructionOptions);
						break;
					case CodeNodeType.Data:
						var dnode = current.As<DataNode>();
						_assembler.Embed(dnode.Data, dnode.Size);
						break;
					case CodeNodeType.Alignment:
						var anode = current.As<AlignNode>();
						_assembler.Align(anode.AlignMode, anode.Offset);
						break;
					case CodeNodeType.Label:
						var lnode = current.As<LabelNode>();
						_assembler.Bind(lnode.LabelId);
						break;
					case CodeNodeType.Comment:
					case CodeNodeType.Hint:
					case CodeNodeType.Sentinel:
					case CodeNodeType.Function:
					case CodeNodeType.Return:
						break;
					case CodeNodeType.Call:
						var clnode = current.As<CallNode>();
						_assembler.Emit(InstructionId.Call, clnode.Target, Operand.Invalid, Operand.Invalid, Operand.Invalid, InstructionOptions.None);
						break;
					case CodeNodeType.CallArgument:
						break;
					default:
						throw new ArgumentOutOfRangeException("", "Not must be reached");
				}
				current = current.Next;
			} while (current != stop);
		}
	}
}
