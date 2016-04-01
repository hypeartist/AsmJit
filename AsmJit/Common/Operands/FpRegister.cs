namespace AsmJit.Common.Operands
{
	public sealed class FpRegister : Register
	{
		internal FpRegister(int index)
		{
			RegisterType = RegisterType.Fp;
			Index = index;
			Size = 10;
		}

		internal FpRegister(FpRegister other) 
			: base(other)
		{
		}
	}
}