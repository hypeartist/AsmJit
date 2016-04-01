using AsmJit.AssemblerContext;
using AsmJit.Common;
using AsmJit.Common.Operands;

namespace AsmJit.CompilerContext.CodeTree
{
	internal sealed class JumpNode : InstructionNode
	{
		public JumpNode(InstructionId instructionId, InstructionOptions instructionOptions, Operand[] operands)
			: base(instructionId, instructionOptions, operands)
		{
		}

		public LabelNode Target { get; set; }

		public JumpNode NextJump { get; set; }
	}
}