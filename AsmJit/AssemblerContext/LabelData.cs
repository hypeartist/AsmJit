using AsmJit.Common;
using AsmJit.CompilerContext.CodeTree;

namespace AsmJit.AssemblerContext
{
	internal class LabelData
	{
		public LabelData(int contextId)
		{
			ContextId = contextId;
			Offset = Constants.InvalidValue;
		}

		public int Offset { get; set; }

		public LabelLink Links { get; set; }

		public int ContextId { get; private set; }

		public LabelNode ContextData { get; set; }
	}
}
