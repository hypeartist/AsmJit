using System.Linq;
using AsmJit.AssemblerContext;
using AsmJit.Common;
using AsmJit.Common.Operands;

namespace AsmJit.CompilerContext.CodeTree
{
	internal class InstructionNode : CodeNode
	{

		public InstructionNode(InstructionId instructionId, InstructionOptions instructionOptions, Operand[] operands)
			: base(CodeNodeType.Instruction)
		{
			InstructionId = instructionId;
			InstructionOptions = instructionOptions;
			Operands = operands;
			MemoryOperandIndex = Constants.InvalidValue;
			for (var i = 0; i < operands.Length; i++)
			{
				if (!operands[i].IsMemory()) continue;
				MemoryOperandIndex = i;
				break;
			}
			Flags |= CodeNodeFlags.Removable;
		}

		public InstructionId InstructionId { get; private set; }

		public InstructionOptions InstructionOptions { get; private set; }

		public Operand[] Operands { get; private set; }

		public int MemoryOperandIndex { get; set; }

		public override string ToString()
		{
			return string.Format("[{0}] {1}: {2}, Ops={3}", FlowId == 0 ? "#" : FlowId.ToString(), Type, InstructionId, string.Join(", ", Operands.ToList().Select(o => o.ToString())));
		}
	}
}