using System.ComponentModel;
using AsmJit.Common;

namespace AsmJit.CompilerContext
{
	internal class RegisterMask
	{
		private int _gp;
		private int _mm;
		private int _k;
		private int _xyz;

		public void Reset()
		{
			_gp = 0;
			_mm = 0;
			_k = 0;
			_xyz = 0;
		}

		public bool IsEmpty
		{
			get { return _gp == 0 && _mm == 0 && _k == 0 && _xyz == 0; }
		}

		public void CopyFrom(RegisterMask m)
		{
			_gp = m._gp;
			_mm = m._mm;
			_k = m._k;
			_xyz = m._xyz;
		}

		public void Zero(RegisterClass rc)
		{
			switch (rc)
			{
				case RegisterClass.Gp:
					_gp = 0;
					break;
				case RegisterClass.Mm:
					_mm = 0;
					break;
				case RegisterClass.K:
					_k = 0;
					break;
				case RegisterClass.Xyz:
					_xyz = 0;
					break;
				default:
					throw new InvalidEnumArgumentException();
			}
		}

		public int Get(RegisterClass rc)
		{
			switch (rc)
			{
				case RegisterClass.Gp:
					return _gp;
				case RegisterClass.Mm:
					return _mm;
				case RegisterClass.K:
					return _k;
				case RegisterClass.Xyz:
					return _xyz;
				default:
					throw new InvalidEnumArgumentException();
			}
		}

		public void Set(RegisterClass rc, int mask)
		{
			switch (rc)
			{
				case RegisterClass.Gp:
					_gp = mask;
					break;
				case RegisterClass.Mm:
					_mm = mask;
					break;
				case RegisterClass.K:
					_k = mask;
					break;
				case RegisterClass.Xyz:
					_xyz = mask;
					break;
				default:
					throw new InvalidEnumArgumentException();
			}
		}

		public void And(RegisterClass rc, int mask)
		{
			switch (rc)
			{
				case RegisterClass.Gp:
					_gp &= mask;
					break;
				case RegisterClass.Mm:
					_mm &= mask;
					break;
				case RegisterClass.K:
					_k &= mask;
					break;
				case RegisterClass.Xyz:
					_xyz &= mask;
					break;
				default:
					throw new InvalidEnumArgumentException();
			}
		}

		public void AndNot(RegisterClass rc, int mask)
		{
			switch (rc)
			{
				case RegisterClass.Gp:
					_gp &= ~(ushort)mask;
					break;
				case RegisterClass.Mm:
					_mm &= ~(byte)mask;
					break;
				case RegisterClass.K:
					_k &= ~(byte)mask;
					break;
				case RegisterClass.Xyz:
					_xyz &= (int)~(uint)mask;
					break;
				default:
					throw new InvalidEnumArgumentException();
			}
		}

		public void Or(RegisterClass rc, int mask)
		{
			switch (rc)
			{
				case RegisterClass.Gp:
					_gp |= mask;
					break;
				case RegisterClass.Mm:
					_mm |= mask;
					break;
				case RegisterClass.K:
					_k |= mask;
					break;
				case RegisterClass.Xyz:
					_xyz |= mask;
					break;
				default:
					throw new InvalidEnumArgumentException();
			}
		}

		public void Or(RegisterMask other)
		{
			_gp |= other._gp;
			_mm |= other._mm;
			_k |= other._k;
			_xyz |= other._xyz;
		}

		public void Xor(RegisterClass rc, int mask)
		{
			switch (rc)
			{
				case RegisterClass.Gp:
					_gp ^= mask;
					break;
				case RegisterClass.Mm:
					_mm ^= mask;
					break;
				case RegisterClass.K:
					_k ^= mask;
					break;
				case RegisterClass.Xyz:
					_xyz ^= mask;
					break;
				default:
					throw new InvalidEnumArgumentException();
			}
		}

		public bool Has(RegisterClass rc, int mask)
		{
			switch (rc)
			{
				case RegisterClass.Gp:
					return _gp.IsSet(mask);
				case RegisterClass.Mm:
					return _mm.IsSet(mask);
				case RegisterClass.K:
					return _k.IsSet(mask);
				case RegisterClass.Xyz:
					return _xyz.IsSet(mask);
				default:
					throw new InvalidEnumArgumentException();
			}
		}

		public override string ToString()
		{
			return string.Format("Gp={0}, Mm={1}, K={2}, Xyz={3}", _gp, _mm, _k, _xyz);
		}
	}
}
