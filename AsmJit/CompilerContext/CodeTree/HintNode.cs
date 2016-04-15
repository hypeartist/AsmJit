namespace AsmJit.CompilerContext.CodeTree
{
	internal sealed class HintNode : CodeNode
	{
		public HintNode(VariableData data, VariableHint hint, int value)
			: base(CodeNodeType.Hint)
		{
			Data = data;
			Hint = hint;
			Value = value;
			Flags |= (CodeNodeFlags.Removable | CodeNodeFlags.Informative);
		}

		public VariableData Data { get; private set; }

		public VariableHint Hint { get; private set; }

		public int Value { get; private set; }

		public override string ToString()
		{
			return string.Format("[{0}] {1}: Hint={2}, Value={3}", FlowId == 0 ? "#" : FlowId.ToString(), Type, Hint, Value);
		}
	}
}