using System;

namespace AsmJit.CompilerContext
{
	[Flags]
	public enum VariableValueFlags
	{
		Sp = 0x10,
		Dp = 0x20,
		Packed = 0x40
	}
}