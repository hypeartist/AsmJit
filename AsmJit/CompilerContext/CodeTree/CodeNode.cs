using System.Collections.Generic;

namespace AsmJit.CompilerContext.CodeTree
{
	public abstract class CodeNode
	{
		internal CodeNode(CodeNodeType type)
		{
			Flags |= CodeNodeFlags.Removable;
			Type = type;
		}

		public CodeNode Previous { get; set; }

		public CodeNode Next { get; set; }

		internal CodeNodeType Type { get; private set; }

		internal CodeNodeFlags Flags { get; set; }

		public int FlowId { get; set; }

		internal VariableMap VariableMap { get; set; }

		internal VariableState VariableState { get; set; }

		internal BitArray Liveness { get; set; }

		public T As<T>() where T : CodeNode
		{
			return this as T;
		}
	}
}
