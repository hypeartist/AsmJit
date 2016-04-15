using System;

namespace AsmJit.CompilerContext.CodeTree
{
	[Flags]
	internal enum CodeNodeFlags
	{
		Translated = 0x0001,
		Removable = 0x0002,
		Scheduled = 0x0004,
		Informative = 0x0008,
		Jmp = 0x0010,
		Jcc = 0x0020,
		Taken = 0x0040,
		Ret = 0x0080,
		Special = 0x0100,
		Fp = 0x0200
	}
}