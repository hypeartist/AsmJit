using System;
using System.Diagnostics;
using System.Globalization;

namespace AsmJit.Common
{
	[DebuggerDisplay("{_ptr}")]
	public struct Pointer
	{
		private unsafe byte* _ptr;

		internal static Pointer Invalid = new Pointer();

		internal unsafe Pointer(void* ptr, int dataSize = 0, PointerFlags flags = PointerFlags.None)
			: this()
		{
			DataSize = dataSize;
			_ptr = (byte*)ptr;
			Flags = flags;
		}

		internal unsafe Pointer(byte* ptr, int dataSize = 0, PointerFlags flags = PointerFlags.None)
			: this()
		{
			DataSize = dataSize;
			_ptr = ptr;
			Flags = flags;
		}

		internal unsafe Pointer(IntPtr ptr, int dataSize = 0, PointerFlags flags = PointerFlags.None)
			: this()
		{
			DataSize = dataSize;
			_ptr = (byte*)ptr;
			Flags = flags;
		}

		internal int DataSize { get; private set; }

		internal PointerFlags Flags { get; private set; }

		public static Pointer operator +(Pointer p1, int offset)
		{
			unsafe
			{
				return new Pointer { _ptr = p1._ptr + offset, DataSize = offset == 0 ? p1.DataSize : 0 };
			}
		}

		public static Pointer operator +(Pointer p1, Pointer p2)
		{
			unsafe
			{
				return new Pointer { _ptr = p1._ptr + (uint)p2._ptr, DataSize = 0 };
			}
		}

		public static Pointer operator -(Pointer p1, Pointer p2)
		{
			unsafe
			{
				return new Pointer { _ptr = (byte*)Math.Max(0, p1._ptr - p2._ptr), DataSize = 0 };
			}
		}

		public static Pointer operator -(Pointer p1, int offset)
		{
			unsafe
			{
				return new Pointer { _ptr = p1._ptr - offset, DataSize = offset == 0 ? p1.DataSize : 0 };
			}
		}		

		public static bool operator >(Pointer p1, Pointer p2)
		{
			unsafe
			{
				return p1._ptr > p2._ptr;
			}
		}

		public static bool operator <(Pointer p1, Pointer p2)
		{
			return !(p1 > p2);
		}

		public static bool operator <=(Pointer p1, Pointer p2)
		{
			return (p1 < p2) || (p1 == p2);
		}

		public static bool operator >=(Pointer p1, Pointer p2)
		{
			return (p1 > p2) || (p1 == p2);
		}

		public static bool operator ==(Pointer p1, Pointer p2)
		{
			unsafe
			{
				return p1._ptr == p2._ptr && p1.DataSize == p2.DataSize;
			}
		}

		public static bool operator !=(Pointer p1, Pointer p2)
		{
			return !(p1 == p2);
		}

		public static implicit operator IntPtr(Pointer p)
		{
			unsafe
			{
				return (IntPtr)p._ptr;
			}
		}

		public static explicit operator long(Pointer p)
		{
			unsafe
			{
				return (long)(ulong)p._ptr;
			}
		}

		public static implicit operator Pointer(IntPtr p)
		{
			return new Pointer(p);
		}


		public static unsafe implicit operator Pointer(void* p)
		{
			return new Pointer(p);
		}

		internal bool Equals(Pointer other)
		{
			unsafe
			{
				return new IntPtr(_ptr).Equals(new IntPtr(other._ptr));
			}
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			return obj is Pointer && Equals((Pointer)obj);
		}

		public override int GetHashCode()
		{
			unsafe
			{
				return new IntPtr(_ptr).GetHashCode();
			}
		}

		internal void SetUI8(byte value, int index = 0)
		{
			unsafe
			{
				*(_ptr + index) = value;
			}
		}

		internal void SetI8(sbyte value, int index = 0)
		{
			unsafe
			{
				*((sbyte*)_ptr + index) = value;
			}
		}

		internal void SetI16(short value, int index = 0)
		{
			unsafe
			{
				*((short*)_ptr + index) = value;
			}
		}

		internal void SetUI16(ushort value, int index = 0)
		{
			unsafe
			{
				*((ushort*)_ptr + index) = value;
			}
		}

		internal void SetI32(int value, int index = 0)
		{
			unsafe
			{
				*((int*)_ptr + index) = value;
			}
		}

		internal void SetUI32(uint value, int index = 0)
		{
			unsafe
			{
				*((uint*)_ptr + index) = value;
			}
		}

		internal void SetI64(long value, int index = 0)
		{
			unsafe
			{
				*((long*)_ptr + index) = value;
			}
		}

		internal void SetUI64(ulong value, int index = 0)
		{
			unsafe
			{
				*((ulong*)_ptr + index) = value;
			}
		}

		internal void SetF32(float value, int index = 0)
		{
			unsafe
			{
				*((float*)_ptr + index) = value;
			}
		}

		internal void SetF64(double value, int index = 0)
		{
			unsafe
			{
				*((double*)_ptr + index) = value;
			}
		}

		internal byte GetUI8(int index = 0)
		{
			unsafe
			{
				return *(_ptr + index);
			}
		}

		internal sbyte GetI8(int index = 0)
		{
			unsafe
			{
				return *((sbyte*)_ptr + index);
			}
		}


		internal short GetI16(int index = 0)
		{
			unsafe
			{
				return *((short*)_ptr + index);
			}
		}

		internal ushort GetUI16(int index = 0)
		{
			unsafe
			{
				return *((ushort*)_ptr + index);
			}
		}

		internal int GetI32(int index = 0)
		{
			unsafe
			{
				return *((int*)_ptr + index);
			}
		}

		internal uint GetUI32(int index = 0)
		{
			unsafe
			{
				return *((uint*)_ptr + index);
			}
		}

		public override string ToString()
		{
			unsafe
			{
				return "0x" + ((long) _ptr).ToString("X").Trim('{', '}');
			}
		}
	}
}
