namespace AsmJit.Common.Operands
{
	public sealed class XmmRegister : Register
	{
		internal XmmRegister(int index)
		{
			RegisterType = RegisterType.Xmm;
			Index = index;
			Size = 16;
		}

		internal XmmRegister(XmmRegister other) 
			: base(other)
		{
		}
	}
}