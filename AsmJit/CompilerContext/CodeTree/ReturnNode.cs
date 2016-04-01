using AsmJit.Common.Operands;

namespace AsmJit.CompilerContext.CodeTree
{
	internal sealed class ReturnNode : CodeNode
	{
		public ReturnNode(Operand o0, Operand o1)
			: base(CodeNodeType.Return)
		{
			Operands = new Operand[2];
			Operands[0] = o0;
			Operands[1] = o1;
			Flags |= CodeNodeFlags.Ret;
		}

		public Operand[] Operands { get; private set; }
	}
}