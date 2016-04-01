namespace AsmJit.Common.Operands
{
	public sealed class YmmRegister : Register
	{
		internal YmmRegister(int index)
		{
			RegisterType = RegisterType.Ymm;
			Index = index;
			Size = 32;
		}

		internal YmmRegister(YmmRegister other) 
			: base(other)
		{
		}
	}
}