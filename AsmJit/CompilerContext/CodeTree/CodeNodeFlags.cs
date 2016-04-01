using System;

namespace AsmJit.CompilerContext.CodeTree
{
	[Flags]
	internal enum CodeNodeFlags
	{
		Translated = 0x0001,
		Scheduled = 0x0002,
		Informative = 0x0004,
		Jmp = 0x0008,
		Jcc = 0x0010,
		Taken = 0x0020,
		Ret = 0x0040,
		Special = 0x0080,
		Fp = 0x0100
	}
}