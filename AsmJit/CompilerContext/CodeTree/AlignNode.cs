using AsmJit.Common;

namespace AsmJit.CompilerContext.CodeTree
{
	internal sealed class AlignNode : CodeNode
	{
		public AlignNode(AligningMode alignMode, int offset)
			: base(CodeNodeType.Alignment)
		{
			AlignMode = alignMode;
			Offset = offset;
		}

		public AligningMode AlignMode { get; private set; }

		public int Offset { get; private set; }
	}
}