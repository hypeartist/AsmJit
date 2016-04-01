using AsmJit.Common;

namespace AsmJit.CompilerContext.CodeTree
{
	internal sealed class DataNode : CodeNode
	{
		public DataNode(Pointer data, int size)
			: base(CodeNodeType.Data)
		{
			Size = size;
			Data = data;
		}

		public Pointer Data { get; private set; }

		public int Size { get; private set; }
	}
}