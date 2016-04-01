using System.Runtime.InteropServices;

namespace AsmJit.Common.Operands
{
	public class Immediate : Operand
	{
		[StructLayout(LayoutKind.Explicit)]
		private unsafe struct Data
		{
			[FieldOffset(0)]
			public fixed sbyte I8[8];
			[FieldOffset(0)]
			public fixed byte U8[8];
			[FieldOffset(0)]
			public fixed short I16[4];
			[FieldOffset(0)]
			public fixed ushort U16[4];
			[FieldOffset(0)]
			public fixed int I32[2];
			[FieldOffset(0)]
			public fixed uint U32[2];
			[FieldOffset(0)]
			public fixed long I64[1];
			[FieldOffset(0)]
			public fixed ulong U64[1];
			[FieldOffset(0)]
			public fixed float F32[2];
			[FieldOffset(0)]
			public fixed double D64[1];
		}

		private Data _data;

		internal Immediate()
			:base(OperandType.Immediate)
		{
		}

		internal Immediate(Immediate other)
			: base(other)
		{
			_data = other._data;
		}

		private Immediate(int value)
			: base(OperandType.Immediate, value.GetSize())
		{
			Int32 = value;
		}

		private Immediate(uint value)
			: base(OperandType.Immediate, value.GetSize())
		{
			UInt32 = value;
		}

		private Immediate(long value)
			: base(OperandType.Immediate, value.GetSize())
		{
			Int64 = value;
		}

		private Immediate(ulong value)
			: base(OperandType.Immediate, value.GetSize())
		{
			UInt64 = value;
		}

		public static implicit operator Immediate(int value)
		{
			return new Immediate(value);
		}

		public static implicit operator Immediate(uint value)
		{
			return new Immediate(value);
		}

		public static implicit operator Immediate(long value)
		{
			return new Immediate(value);
		}

		public static implicit operator Immediate(ulong value)
		{
			return new Immediate(value);
		}

		public sbyte Int8
		{
			get
			{
				unsafe
				{
					fixed (sbyte* p = _data.I8) return p[Utils.ArchIndex(8, 0)];
				}
			}
			set
			{
				unsafe
				{
					if (Constants.X64)
					{
						fixed (long* p = _data.I64) p[0] = value;
					}
					else
					{
						fixed (int* p = _data.I32)
						{
							var val32 = (int)value;
							p[Utils.ArchIndex(2, 0)] = val32;
							p[Utils.ArchIndex(2, 1)] = val32 >> 31;
						}
					}
				}
			}
		}

		public byte UInt8
		{
			get
			{
				unsafe
				{
					fixed (byte* p = _data.U8) return p[Utils.ArchIndex(8, 0)];
				}
			}
			set
			{
				unsafe
				{
					if (Constants.X64)
					{
						fixed (ulong* p = _data.U64) p[0] = value;
					}
					else
					{
						fixed (uint* p = _data.U32)
						{
							p[Utils.ArchIndex(2, 0)] = value;
							p[Utils.ArchIndex(2, 1)] = 0;
						}
					}
				}
			}
		}

		public short Int16
		{
			get
			{
				unsafe
				{
					fixed (short* p = _data.I16) return p[Utils.ArchIndex(4, 0)];
				}
			}
			set
			{
				unsafe
				{
					if (Constants.X64)
					{
						fixed (long* p = _data.I64) p[0] = value;
					}
					else
					{
						fixed (int* p = _data.I32)
						{
							var val32 = (int)value;
							p[Utils.ArchIndex(2, 0)] = val32;
							p[Utils.ArchIndex(2, 1)] = val32 >> 31;
						}
					}
				}
			}
		}

		public ushort UInt16
		{
			get
			{
				unsafe
				{
					fixed (ushort* p = _data.U16) return p[Utils.ArchIndex(4, 0)];
				}
			}
			set
			{
				unsafe
				{
					if (Constants.X64)
					{
						fixed (ulong* p = _data.U64) p[0] = value;
					}
					else
					{
						fixed (uint* p = _data.U32)
						{
							p[Utils.ArchIndex(2, 0)] = value;
							p[Utils.ArchIndex(2, 1)] = 0;
						}
					}
				}
			}
		}

		public int Int32
		{
			get
			{
				unsafe
				{
					fixed (int* p = _data.I32) return p[Utils.ArchIndex(2, 0)];
				}
			}
			set
			{
				unsafe
				{
					if (Constants.X64)
					{
						fixed (long* p = _data.I64) p[0] = value;
					}
					else
					{
						fixed (int* p = _data.I32)
						{
							p[Utils.ArchIndex(2, 0)] = value;
							p[Utils.ArchIndex(2, 1)] = value >> 31;
						}
					}
				}
			}
		}

		public int Int32Lo
		{
			get
			{
				unsafe
				{
					fixed (int* p = _data.I32) return p[Utils.ArchIndex(2, 0)];
				}
			}
		}

		public int Int32Hi
		{
			get
			{
				unsafe
				{
					fixed (int* p = _data.I32) return p[Utils.ArchIndex(2, 1)];
				}
			}
		}

		public uint UInt32
		{
			get
			{
				unsafe
				{
					fixed (uint* p = _data.U32) return p[Utils.ArchIndex(2, 0)];
				}
			}
			set
			{
				unsafe
				{
					if (Constants.X64)
					{
						fixed (ulong* p = _data.U64) p[0] = value;
					}
					else
					{
						fixed (uint* p = _data.U32)
						{
							p[Utils.ArchIndex(2, 0)] = value;
							p[Utils.ArchIndex(2, 1)] = 0;
						}
					}
				}
			}
		}

		public uint UInt32Lo
		{
			get
			{
				unsafe
				{
					fixed (uint* p = _data.U32) return p[Utils.ArchIndex(2, 0)];
				}
			}
		}

		public uint UInt32Hi
		{
			get
			{
				unsafe
				{
					fixed (uint* p = _data.U32) return p[Utils.ArchIndex(2, 1)];
				}
			}
		}

		public long Int64
		{
			get
			{
				unsafe
				{
					fixed (long* p = _data.I64) return p[0];
				}
			}
			set
			{
				unsafe
				{
					fixed (long* p = _data.I64) p[0] = value;
				}
			}
		}

		public ulong UInt64
		{
			get
			{
				unsafe
				{
					fixed (ulong* p = _data.U64) return p[0];
				}
			}
			set
			{
				unsafe
				{
					fixed (ulong* p = _data.U64) p[0] = value;
				}
			}
		}

		public float Float
		{
			get
			{
				unsafe
				{
					fixed (float* p = _data.F32) return p[0];
				}
			}
			set
			{
				unsafe
				{
					fixed (float* p = _data.F32)
					{
						p[Utils.ArchIndex(2, 0)] = value;
					}
					fixed (uint* p = _data.U32)
					{
						p[Utils.ArchIndex(2, 1)] = 0;
					}
				}
			}
		}

		public double Double
		{
			get
			{
				unsafe
				{
					fixed (double* p = _data.D64) return p[0];
				}
			}
			set
			{
				unsafe
				{
					fixed (double* p = _data.D64) p[0] = value;
				}
			}
		}

		internal Immediate TruncateTo8Bits()
		{
			if (Constants.X64)
			{
				unsafe
				{
					fixed (ulong* p = _data.U64) p[0] &= 0x000000FFU;
				}
			}
			else
			{
				unsafe
				{
					fixed (uint* p = _data.U32)
					{
						p[Utils.ArchIndex(2, 0)] &= 0x000000FFU;
						p[Utils.ArchIndex(2, 1)] = 0;
					}
				}
			}
			return this;
		}

		internal Immediate TruncateTo16Bits()
		{
			if (Constants.X64)
			{
				unsafe
				{
					fixed (ulong* p = _data.U64) p[0] &= 0x0000FFFFU;
				}
			}
			else
			{
				unsafe
				{
					fixed (uint* p = _data.U32)
					{
						p[Utils.ArchIndex(2, 0)] &= 0x0000FFFFU;
						p[Utils.ArchIndex(2, 1)] = 0;
					}
				}
			}
			return this;
		}

		internal Immediate TruncateTo32Bits()
		{
			unsafe
			{
				fixed (uint* p = _data.U32)
				{
					p[Utils.ArchIndex(2, 1)] = 0;
				}
			}
			return this;
		}
	}
}