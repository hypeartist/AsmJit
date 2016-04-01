using AsmJit.Common;

namespace AsmJit.AssemblerContext
{
	internal static class ExtendedInstructionInfoExtensions
	{
		public static bool IsFlow(this ExtendedInstructionInfo info)
		{
			return info.InstructionFlags.IsSet(Constants.X86.InstFlagFlow);
		}

		public static bool IsTest(this ExtendedInstructionInfo info)
		{
			return info.InstructionFlags.IsSet(Constants.X86.InstFlagTest);
		}

		public static bool IsMove(this ExtendedInstructionInfo info)
		{
			return info.InstructionFlags.IsSet(Constants.X86.InstFlagMove);
		}

		public static bool IsXchg(this ExtendedInstructionInfo info)
		{
			return info.InstructionFlags.IsSet(Constants.X86.InstFlagXchg);
		}

		public static bool IsFp(this ExtendedInstructionInfo info)
		{
			return info.InstructionFlags.IsSet(Constants.X86.InstFlagFp);
		}

		public static bool IsLockable(this ExtendedInstructionInfo info)
		{
			return info.InstructionFlags.IsSet(Constants.X86.InstFlagLock);
		}

		public static bool IsSpecial(this ExtendedInstructionInfo info)
		{
			return info.InstructionFlags.IsSet(Constants.X86.InstFlagSpecial);
		}

		public static bool IsSpecialMem(this ExtendedInstructionInfo info)
		{
			return info.InstructionFlags.IsSet(Constants.X86.InstFlagSpecialMem);
		}

		public static bool IsZeroIfMem(this ExtendedInstructionInfo info)
		{
			return info.InstructionFlags.IsSet(Constants.X86.InstFlagZ);
		}
	}
}
