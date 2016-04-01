namespace AsmJit.Common.Operands
{
	public sealed class SegRegister : Register
	{
		internal SegRegister(int index)
		{
			RegisterType = RegisterType.Seg;
			Index = index;
			Size = 2;
		}

		internal SegRegister(SegRegister other)
			: base(other)
		{
		}
	}
}