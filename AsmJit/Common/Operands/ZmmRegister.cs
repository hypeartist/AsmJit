namespace AsmJit.Common.Operands
{
	public sealed class ZmmRegister : Register
	{
		internal ZmmRegister(int index)
		{
			RegisterType = RegisterType.Zmm;
			Index = index;
			Size = 64;
		}

		internal ZmmRegister(ZmmRegister other) 
			: base(other)
		{
		}
	}
}