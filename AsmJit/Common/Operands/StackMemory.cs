namespace AsmJit.Common.Operands
{
	public sealed class StackMemory : Memory
	{
		internal StackMemory(StackMemory other)
			:base(other)
		{
		}

		internal StackMemory(MemoryType memType, int id)
		{
			Id = id;
			MemoryType = memType;
			Displacement = 0;
			Index = RegisterIndex.Invalid;
		}

		public StackMemory Clone()
		{
			return new StackMemory(this);
		}

		public StackMemory SetIndex(GpVariable index, int shift = 0)
		{
			Index = index.Id;
			VSib = Constants.X86.MemVSibGpz;
			Shift = shift;
			return this;
		}

		public StackMemory SetSize(int size)
		{
			Size = size;
			return this;
		}
	}
}