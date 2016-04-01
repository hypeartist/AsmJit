namespace AsmJit.Common.Operands
{
	public sealed class RipRegister : Register
	{
		internal RipRegister()
		{
			RegisterType = RegisterType.Rip;
			Index = 0;
			Size = 0;
		}
	}
}