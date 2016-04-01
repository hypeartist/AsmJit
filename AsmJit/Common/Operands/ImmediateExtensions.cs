namespace AsmJit.Common.Operands
{
	internal static class ImmediateExtensions
	{
		public static bool IsInt8(this Immediate imm)
		{
			return imm.Int64.IsInt8();
		}

		public static bool IsUInt8(this Immediate imm)
		{
			return imm.Int64.IsInt8();
		}

		public static bool IsInt16(this Immediate imm)
		{
			return imm.Int64.IsInt16();
		}

		public static bool IsUInt16(this Immediate imm)
		{
			return imm.Int64.IsUInt16();
		}

		public static bool IsInt32(this Immediate imm)
		{
			return imm.Int64.IsInt32();
		}

		public static bool IsUInt32(this Immediate imm)
		{
			return imm.Int64.IsUInt32();
		}
	}
}
