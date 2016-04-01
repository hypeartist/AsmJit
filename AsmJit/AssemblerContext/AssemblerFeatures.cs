using System;

namespace AsmJit.AssemblerContext
{
	[Flags]
	public enum AssemblerFeatures
	{
		OptimizedAlign = 0,
		PredictedJumps = 1
	}
}