namespace AsmJit.Common.Operands
{
	public sealed class MmRegister : Register
	{
		internal MmRegister(int index)
		{
			RegisterType = RegisterType.Mm;
			Index = index;
			Size = 8;
		}

		internal MmRegister(MmRegister other) 
			: base(other)
		{
		}
	}
}