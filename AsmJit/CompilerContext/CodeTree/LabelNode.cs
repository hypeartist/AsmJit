namespace AsmJit.CompilerContext.CodeTree
{
	internal sealed class LabelNode : CodeNode
	{
		public LabelNode(int labelId)
			: base(CodeNodeType.Label)
		{
			LabelId = labelId;
		}

		public int LabelId { get; private set; }

		public int ReferenceCount { get; set; }

		public JumpNode From { get; set; }

		public override string ToString()
		{
			return string.Format("[{0}] {1}: Id={2}, From=({3})", FlowId == 0 ? "#" : FlowId.ToString(), Type, LabelId, From);
		}
	}
}