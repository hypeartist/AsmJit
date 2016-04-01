namespace AsmJit.CompilerContext.CodeTree
{
	internal sealed class CallArgumentNode : CodeNode
	{
		public CallArgumentNode(CallNode call, VariableData src, VariableData conv)
			: base(CodeNodeType.CallArgument)
		{
			Call = call;
			Source = src;
			Conv = conv;
		}

		public CallNode Call { get; private set; }

		public VariableData Source { get; private set; }

		public VariableData Conv { get; private set; }

		public int AffectedArguments { get; set; }
	}
}