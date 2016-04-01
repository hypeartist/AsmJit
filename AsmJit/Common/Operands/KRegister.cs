namespace AsmJit.Common.Operands
{
	public sealed class KRegister : Register
	{
		internal KRegister(int index)
		{
			RegisterType = RegisterType.K;
			Index = index;
			Size = 8;
		}

		internal KRegister(KRegister other) 
			: base(other)
		{
		}
	}
}