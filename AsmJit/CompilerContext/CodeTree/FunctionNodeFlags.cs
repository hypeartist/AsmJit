using System;

namespace AsmJit.CompilerContext.CodeTree
{
	[Flags]
	internal enum FunctionNodeFlags : uint
	{
		IsNaked = 0x00000001,
		IsCaller = 0x00000002,
		IsStackMisaligned = 0x00000004,
		IsStackAdjusted = 0x00000008,
		IsFinished = 0x80000000,
		X86Leave = 0x00010000,
		X86MoveArgs = 0x00040000,
		X86Emms = 0x01000000,
		X86SFence = 0x02000000,
		X86LFence = 0x04000000
	}
}