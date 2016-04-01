using System;

namespace AsmJit.CompilerContext.CodeTree
{
	[Flags]
	internal enum FuncionNodeHints
	{
		Naked = 0,
		Compact = 1,
		X86Emms = 17,
		X86SFence = 18,
		X86LFence = 19
	}
}