namespace AsmJit.Common
{
	public static class NumericExtensions
	{
		private const int VariableOperandId = 1 << 31;
		private const int VariableOperandMask = ~VariableOperandId;

		public static bool Between(this int v, int a, int b)
		{
			return v >= a && v < b;
		}

		public static int FindFirstBit(this int mask)
		{
			var i = 1;

			while (mask != 0)
			{
				var two = mask & 0x3;
				if (two != 0x0)
				{
					return i - (two & 0x1);
				}

				i += 2;
				mask >>= 2;
			}

			return -1;
		}

		public static int KeepNOnesFromRight(this int mask, int nBits)
		{
			var m = 0x1;

			do
			{
				nBits -= ((mask & m) != 0).AsInt();
				m <<= 1;
				if (nBits != 0) continue;
				m -= 1;
				mask &= m;
				break;
			} while (m != 0);

			return mask;
		}

		public static int IndexNOnesFromRight(this int[] dst, int mask, int nBits)
		{
			var totalBits = nBits;
			var i = 0;
			var m = 0x1;
			var j = 0;
			do
			{
				if ((mask & m) != 0)
				{
					dst[j++] = i;
					if (--nBits == 0) break;
				}

				m <<= 1;
				i++;
			} while (m != 0);

			return totalBits - nBits;
		}

		internal static int BitCount(this long x)
		{
			x = x - ((x >> 1) & 0x55555555U);
			x = (x & 0x33333333U) + ((x >> 2) & 0x33333333U);
			return (int)((((x + (x >> 4)) & 0x0F0F0F0FU) * 0x01010101U) >> 24);
		}

		internal static bool IsInt8(this byte v)
		{
			return true;
		}

		internal static bool IsInt8(this sbyte v)
		{
			return true;
		}

		internal static bool IsInt8(this short v)
		{
			return v >= sbyte.MinValue && v <= sbyte.MaxValue;
		}

		internal static bool IsInt8(this ushort v)
		{
			return v <= byte.MaxValue;
		}

		internal static bool IsInt8(this int v)
		{
			return v >= sbyte.MinValue && v <= sbyte.MaxValue;
		}

		internal static bool IsInt8(this uint v)
		{
			return v <= byte.MaxValue;
		}

		internal static bool IsInt8(this long v)
		{
			return v >= sbyte.MinValue && v <= sbyte.MaxValue;
		}

		internal static bool IsUInt8(this long v)
		{
			return v >= byte.MinValue && v <= byte.MaxValue;
		}

		internal static bool IsUInt8(this ulong v)
		{
			return v <= byte.MaxValue;
		}

		internal static bool IsInt8(this ulong v)
		{
			return v <= byte.MaxValue;
		}

		internal static bool IsInt16(this byte v)
		{
			return true;
		}

		internal static bool IsInt16(this sbyte v)
		{
			return true;
		}

		internal static bool IsInt16(this short v)
		{
			return true;
		}

		internal static bool IsInt16(this ushort v)
		{
			return true;
		}

		internal static bool IsInt16(this int v)
		{
			return v >= short.MinValue && v <= short.MaxValue;
		}

		internal static bool IsInt16(this uint v)
		{
			return v <= ushort.MaxValue;
		}

		internal static bool IsInt16(this long v)
		{
			return v >= short.MinValue && v <= short.MaxValue;
		}

		internal static bool IsUInt16(this long v)
		{
			return v >= ushort.MinValue && v <= ushort.MaxValue;
		}

		internal static bool IsUInt16(this ulong v)
		{
			return v <= ushort.MaxValue;
		}

		internal static bool IsInt16(this ulong v)
		{
			return v <= ushort.MaxValue;
		}

		internal static bool IsInt32(this byte v)
		{
			return true;
		}

		internal static bool IsInt32(this sbyte v)
		{
			return true;
		}

		internal static bool IsInt32(this short v)
		{
			return true;
		}

		internal static bool IsInt32(this ushort v)
		{
			return true;
		}

		internal static bool IsInt32(this int v)
		{
			return true;
		}

		internal static bool IsInt32(this uint v)
		{
			return true;
		}

		internal static bool IsInt32(this long v)
		{
			return v >= int.MinValue && v <= int.MaxValue;
		}

		internal static bool IsUInt32(this long v)
		{
			return v >= uint.MinValue && v <= uint.MaxValue;
		}

		internal static bool IsUInt32(this ulong v)
		{
			return v <= uint.MaxValue;
		}

		internal static bool IsInt32(this ulong v)
		{
			return v <= uint.MaxValue;
		}

		internal static int GetSize(this long value)
		{
			if (value.IsInt8())
			{
				return 1;
			}
			if (value.IsInt16())
			{
				return 2;
			}
			return value.IsInt32() ? 4 : 8;
		}

		internal static int GetSize(this ulong value)
		{
			if (value.IsUInt8())
			{
				return 1;
			}
			if (value.IsUInt16())
			{
				return 2;
			}
			return value.IsUInt32() ? 4 : 8;
		}

		internal static int GetSize(this int value)
		{
			if (value.IsInt8())
			{
				return 1;
			}
			if (value.IsInt16())
			{
				return 2;
			}
			return 4;
		}

		internal static int GetSize(this uint value)
		{
			var val = (ulong)value;
			if (val.IsUInt8())
			{
				return 1;
			}
			if (val.IsUInt16())
			{
				return 2;
			}
			return 4;
		}

		internal static bool IsAligned(this int b, int alignment)
		{
			return b % alignment == 0;
		}

		internal static int AlignDiff(this int b, int alignment)
		{
			return AlignTo(b, alignment) - b;
		}

		internal static int AlignTo(this int b, int alignment)
		{
			return (b + (alignment - 1)) & ~(alignment - 1);
		}

		internal static int AlignToPowerOf2(this int b)
		{
			b -= 1;

			b = b | (b >> 1);
			b = b | (b >> 2);
			b = b | (b >> 4);

			b = b | (b >> (16 * 1)); // Base >> 16.

			return b + 1;
		}

		internal static bool IsPowerOf2(this int n)
		{
			return n != 0 && (n & (n - 1)) == 0;
		}

		public static int Inverse(this int v)
		{
			return v == 0 ? 1 : 0;
		}

		public static bool IsSet(this int value, int flag)
		{
			return (value & flag) != 0;
		}

		public static bool IsSet(this long value, long flag)
		{
			return (value & flag) != 0;
		}

		public static bool IsVariableId(this int v)
		{
			return (v & VariableOperandId) != 0 && (v & VariableOperandMask) < int.MaxValue;
		}

		public static int AsVariableId(this int v)
		{
			return !v.IsVariableId() ? v | VariableOperandId : v;
		}

		public static int GetActualVariableId(this int v)
		{
			return v.IsVariableId() ? v & VariableOperandMask : Constants.InvalidId;
		}
	}
}