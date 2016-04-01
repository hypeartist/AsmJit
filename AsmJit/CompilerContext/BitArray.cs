using System;

namespace AsmJit.CompilerContext
{
	internal class BitArray
	{
		public static readonly int EntitySize = IntPtr.Size;
		public static readonly int EntityBits = EntitySize * 8;

		private ulong[] _data;

		public BitArray(int length)
		{
			_data = new ulong[length];
		}

		public int GetBit(int index)
		{
			return (int)((_data[index / EntityBits] >> (index % EntityBits)) & 1);
		}

		public void SetBit(int index)
		{
			_data[index / EntityBits] |= (1UL << (index % EntityBits));
		}

		public void DelBit(int index)
		{
			_data[index / EntityBits] &= ~(1UL << (index % EntityBits));
		}

		public bool CopyBits(BitArray s0, int len)
		{
			var r = 0UL;
			for (var i = 0; i < len; i++)
			{
				var t = s0._data[i];
				_data[i] = t;
				r |= t;
			}
			return r != 0;
		}

		public bool AddBits(BitArray s0, int len)
		{
			return AddBits(this, s0, len);
		}

		public bool AddBits(BitArray s0, BitArray s1, int len)
		{
			var r = 0UL;
			for (var i = 0; i < len; i++)
			{
				var t = s0._data[i] | s1._data[i];
				_data[i] = t;
				r |= t;
			}
			return r != 0;
		}

		public bool AndBits(BitArray s0, int len)
		{
			return AndBits(this, s0, len);
		}

		public bool AndBits(BitArray s0, BitArray s1, int len)
		{
			var r = 0UL;
			for (var i = 0; i < len; i++)
			{
				var t = s0._data[i] & s1._data[i];
				_data[i] = t;
				r |= t;
			}
			return r != 0;
		}

		public bool DelBits(BitArray s0, int len)
		{
			return DelBits(this, s0, len);
		}

		public bool DelBits(BitArray s0, BitArray s1, int len)
		{
			var r = 0UL;
			for (var i = 0; i < len; i++)
			{
				var t = s0._data[i] & ~s1._data[i];
				_data[i] = t;
				r |= t;
			}
			return r != 0;
		}

		public bool AddBitsDelSource(BitArray s0, int len)
		{
			return AddBitsDelSource(this, s0, len);
		}

		public bool AddBitsDelSource(BitArray s0, BitArray s1, int len)
		{
			var r = 0UL;
			for (var i = 0; i < len; i++)
			{
				var a = s0._data[i];
				var b = s1._data[i];

				_data[i] = a | b;
				b &= ~a;

				s1._data[i] = b;
				r |= b;
			}
			return r != 0;
		}

		public override string ToString()
		{
			return string.Join(",", _data);
		}
	}
}