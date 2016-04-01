namespace AsmJit.Common.Operands
{
	internal static class MemoryExtensions
	{
		internal static bool IsBaseIndexType(this Memory op)
		{
			return op.MemoryType <= MemoryType.StackIndex;
		}

		internal static bool HasBaseOrIndex(this Memory op)
		{
			return op.Base != RegisterIndex.Invalid || op.Index != RegisterIndex.Invalid;
		}
	}
}
