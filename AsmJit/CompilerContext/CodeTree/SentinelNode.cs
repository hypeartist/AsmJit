namespace AsmJit.CompilerContext.CodeTree
{
	internal sealed class SentinelNode : CodeNode
	{
		public SentinelNode()
			: base(CodeNodeType.Sentinel)
		{
		}
	}
}