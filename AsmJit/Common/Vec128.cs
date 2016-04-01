using System.Runtime.InteropServices;

namespace AsmJit.Common
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Vec128
	{
		[FieldOffset(0)]
		private unsafe fixed sbyte sb[16];
		[FieldOffset(0)]
		private unsafe fixed byte ub[16];
		[FieldOffset(0)]
		private unsafe fixed short sw[8];
		[FieldOffset(0)]
		private unsafe fixed ushort uw[8];
		[FieldOffset(0)]
		private unsafe fixed int sd[4];
		[FieldOffset(0)]
		private unsafe fixed uint ud[4];
		[FieldOffset(0)]
		private unsafe fixed long sq[2];
		[FieldOffset(0)]
		private unsafe fixed ulong uq[2];
		[FieldOffset(0)]
		private unsafe fixed float sf[4];
		[FieldOffset(0)]
		private unsafe fixed double df[2];

		public static Vec128 FromSb(sbyte x0, sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7, sbyte x8, sbyte x9, sbyte x10, sbyte x11, sbyte x12, sbyte x13, sbyte x14, sbyte x15)
		{
			Vec128 self;
			self.SetSb(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15);
			return self;
		}

		//! Set all sixteen 8-bit signed integers.
		public static Vec128 FromSb(sbyte x0)
		{
			Vec128 self;
			self.SetSb(x0);
			return self;
		}

		//! Set all sixteen 8-bit unsigned integers.
		public static Vec128 FromUb(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte x8, byte x9, byte x10, byte x11, byte x12, byte x13, byte x14, byte x15)
		{
			Vec128 self;
			self.SetUb(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15);
			return self;
		}

		//! Set all sixteen 8-bit unsigned integers.
		public static Vec128 FromUb(byte x0)
		{
			Vec128 self;
			self.SetUb(x0);
			return self;
		}

		//! Set all eight 16-bit signed integers.
		public static Vec128 FromSw(short x0, short x1, short x2, short x3, short x4, short x5, short x6, short x7)
		{
			Vec128 self;
			self.SetSw(x0, x1, x2, x3, x4, x5, x6, x7);
			return self;
		}

		//! Set all eight 16-bit signed integers.
		public static Vec128 FromSw(short x0)
		{
			Vec128 self;
			self.SetSw(x0);
			return self;
		}

		//! Set all eight 16-bit unsigned integers.
		public static Vec128 fromUw(ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7)
		{
			Vec128 self;
			self.SetUw(x0, x1, x2, x3, x4, x5, x6, x7);
			return self;
		}

		//! Set all eight 16-bit unsigned integers.
		public static Vec128 FromUw(ushort x0)
		{
			Vec128 self;
			self.SetUw(x0);
			return self;
		}

		//! Set all four 32-bit signed integers.
		public static Vec128 fromSd(int x0, int x1, int x2, int x3)
		{
			Vec128 self;
			self.SetSd(x0, x1, x2, x3);
			return self;
		}

		//! Set all four 32-bit signed integers.
		public static Vec128 FromSd(int x0)
		{
			Vec128 self;
			self.SetSd(x0);
			return self;
		}

		//! Set all four 32-bit unsigned integers.
		public static Vec128 FromUd(uint x0, uint x1, uint x2, uint x3)
		{
			Vec128 self;
			self.SetUd(x0, x1, x2, x3);
			return self;
		}

		//! Set all four 32-bit unsigned integers.
		public static Vec128 FromUd(uint x0)
		{
			Vec128 self;
			self.SetUd(x0);
			return self;
		}

		//! Set all two 64-bit signed integers.
		public static Vec128 FromSq(long x0, long x1)
		{
			Vec128 self;
			self.SetSq(x0, x1);
			return self;
		}

		//! Set all two 64-bit signed integers.
		public static Vec128 FromSq(long x0)
		{
			Vec128 self;
			self.SetSq(x0);
			return self;
		}

		//! Set all two 64-bit unsigned integers.
		public static Vec128 FromUq(ulong x0, ulong x1)
		{
			Vec128 self;
			self.SetUq(x0, x1);
			return self;
		}

		//! Set all two 64-bit unsigned integers.
		public static Vec128 FromUq(ulong x0)
		{
			Vec128 self;
			self.SetUq(x0);
			return self;
		}

		//! Set all four SP-FP floats.
		public static Vec128 FromSf(float x0, float x1, float x2, float x3)
		{
			Vec128 self;
			self.SetSf(x0, x1, x2, x3);
			return self;
		}

		//! Set all four SP-FP floats.
		public static Vec128 FromSf(float x0)
		{
			Vec128 self;
			self.SetSf(x0);
			return self;
		}

		//! Set all two DP-FP floats.
		public static Vec128 FromDf(double x0, double x1)
		{
			Vec128 self;
			self.SetDf(x0, x1);
			return self;
		}

		//! Set all two DP-FP floats.
		public static Vec128 FromDf(double x0)
		{
			Vec128 self;
			self.SetDf(x0);
			return self;
		}

		//! Set all sixteen 8-bit signed integers.
		public void SetSb(sbyte x0, sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7, sbyte x8, sbyte x9, sbyte x10, sbyte x11, sbyte x12, sbyte x13, sbyte x14, sbyte x15)
		{
			unsafe
			{
				fixed (sbyte* p = sb)
				{
					p[0] = x0;
					p[1] = x1;
					p[2] = x2;
					p[3] = x3;
					p[4] = x4;
					p[5] = x5;
					p[6] = x6;
					p[7] = x7;
					p[8] = x8;
					p[9] = x9;
					p[10] = x10;
					p[11] = x11;
					p[12] = x12;
					p[13] = x13;
					p[14] = x14;
					p[15] = x15;
				}
			}
		}

		//! Set all sixteen 8-bit signed integers.
		public void SetSb(sbyte x0)
		{
			SetUb((byte)(x0));
		}

		//! Set all sixteen 8-bit unsigned integers.
		public void SetUb(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte x8, byte x9, byte x10, byte x11, byte x12, byte x13, byte x14, byte x15)
		{
			unsafe
			{
				fixed (byte* p = ub)
				{
					p[0] = x0;
					p[1] = x1;
					p[2] = x2;
					p[3] = x3;
					p[4] = x4;
					p[5] = x5;
					p[6] = x6;
					p[7] = x7;
					p[8] = x8;
					p[9] = x9;
					p[10] = x10;
					p[11] = x11;
					p[12] = x12;
					p[13] = x13;
					p[14] = x14;
					p[15] = x15;
				}
			}
		}

		//! Set all sixteen 8-bit unsigned integers.
		public void SetUb(byte x0)
		{
			unsafe
			{
				if (Constants.X64)
				{
					var t = x0 * 0x0101010101010101UL;
					fixed (ulong* p = uq)
					{
						p[0] = t;
						p[1] = t;
					}
				}
				else
				{
					var t = x0 * 0x01010101U;
					fixed (uint* p = ud)
					{
						p[0] = t;
						p[1] = t;
						p[2] = t;
						p[3] = t;
					}
				}
			}
		}

		//! Set all eight 16-bit signed integers.
		public void SetSw(short x0, short x1, short x2, short x3, short x4, short x5, short x6, short x7)
		{
			unsafe
			{
				fixed (short* p = sw)
				{
					p[0] = x0;
					p[1] = x1;
					p[2] = x2;
					p[3] = x3;
					p[4] = x4;
					p[5] = x5;
					p[6] = x6;
					p[7] = x7;
				}
			}
		}

		//! Set all eight 16-bit signed integers.
		public void SetSw(short x0)
		{
			SetUw((ushort)(x0));
		}

		//! Set all eight 16-bit unsigned integers.
		public void SetUw(ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7)
		{
			unsafe
			{
				fixed (ushort* p = uw)
				{
					p[0] = x0;
					p[1] = x1;
					p[2] = x2;
					p[3] = x3;
					p[4] = x4;
					p[5] = x5;
					p[6] = x6;
					p[7] = x7;
				}
			}
		}

		//! Set all eight 16-bit unsigned integers.
		public void SetUw(ushort x0)
		{
			unsafe
			{
				if (Constants.X64)
				{
					var t = x0 * (0x0001000100010001UL);
					fixed (ulong* p = uq)
					{
						p[0] = t;
						p[1] = t;
					}
				}
				else
				{
					var t = x0 * 0x00010001U;
					fixed (uint* p = ud)
					{
						p[0] = t;
						p[1] = t;
						p[2] = t;
						p[3] = t;
					}
				}
			}
		}

		//! Set all four 32-bit signed integers.
		public void SetSd(int x0, int x1, int x2, int x3)
		{
			unsafe
			{
				fixed (int* p = sd)
				{
					p[0] = x0;
					p[1] = x1;
					p[2] = x2;
					p[3] = x3;
				}
			}
		}

		//! Set all four 32-bit signed integers.
		public void SetSd(int x0)
		{
			SetUd((uint)(x0));
		}

		//! Set all four 32-bit unsigned integers.
		public void SetUd(uint x0, uint x1, uint x2, uint x3)
		{
			unsafe
			{
				fixed (uint* p = ud)
				{
					p[0] = x0;
					p[1] = x1;
					p[2] = x2;
					p[3] = x3;
				}
			}
		}

		//! Set all four 32-bit unsigned integers.
		public void SetUd(uint x0)
		{
			unsafe
			{
				if (Constants.X64)
				{
					var t = ((ulong)(x0) << 32) + x0;
					fixed (ulong* p = uq)
					{
						p[0] = t;
						p[1] = t;
					}
				}
				else
				{
					fixed (uint* p = ud)
					{
						p[0] = x0;
						p[1] = x0;
						p[2] = x0;
						p[3] = x0;
					}
				}
			}
		}

		//! Set all two 64-bit signed integers.
		public void SetSq(long x0, long x1)
		{
			unsafe
			{
				fixed (long* p = sq)
				{
					p[0] = x0;
					p[1] = x1;
				}
			}
		}

		//! Set all two 64-bit signed integers.
		public void SetSq(long x0)
		{
			unsafe
			{
				fixed (long* p = sq)
				{
					p[0] = x0;
					p[1] = x0;
				}
			}
		}

		//! Set all two 64-bit unsigned integers.
		public void SetUq(ulong x0, ulong x1)
		{
			unsafe
			{
				fixed (ulong* p = uq)
				{
					p[0] = x0;
					p[1] = x1;
				}
			}
		}

		//! Set all two 64-bit unsigned integers.
		public void SetUq(ulong x0)
		{
			unsafe
			{
				fixed (ulong* p = uq)
				{
					p[0] = x0;
					p[1] = x0;
				}
			}
		}

		//! Set all four SP-FP floats.
		public void SetSf(float x0, float x1, float x2, float x3)
		{
			unsafe
			{
				fixed (float* p = sf)
				{
					p[0] = x0;
					p[1] = x1;
					p[2] = x2;
					p[3] = x3;
				}
			}
		}

		//! Set all four SP-FP floats.
		public void SetSf(float x0)
		{
			unsafe
			{
				fixed (float* p = sf)
				{
					p[0] = x0;
					p[1] = x0;
					p[2] = x0;
					p[3] = x0;
				}
			}
		}

		//! Set all two DP-FP floats.
		public void SetDf(double x0, double x1)
		{
			unsafe
			{
				fixed (double* p = df)
				{
					p[0] = x0;
					p[1] = x1;
				}
			}
		}

		//! Set all two DP-FP floats.
		public void SetDf(double x0)
		{
			unsafe
			{
				fixed (double* p = df)
				{
					p[0] = x0;
					p[1] = x0;
				}
			}
		}
	}
}
