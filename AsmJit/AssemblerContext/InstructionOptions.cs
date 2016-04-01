using System;

namespace AsmJit.AssemblerContext
{
	[Flags]
	internal enum InstructionOptions
	{
		None = 0x00000000,
		ShortForm = 0x00000001,
		LongForm = 0x00000002,
		Taken = 0x00000004,
		NotTaken = 0x00000008,
		Unfollow = 0x00000010,
		Overwrite = 0x00000020,
		Rex = 0x00000040,
		NoRex = 0x00000080,
		NoRexMask = Rex | NoRex,
		Lock = 0x00000100,
		Vex3 = 0x00000200,
		Evex = 0x00010000,
		Zero = 0x00020000,
		OneN = 0x00040000,
		Sae = 0x00080000,
		RnSae = 0x00100000,
		RdSae = 0x00200000,
		RuSae = 0x00400000,
		RzSae = 0x00800000
	}
}