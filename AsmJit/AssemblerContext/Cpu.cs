using System;
using AsmJit.Common;
using AsmJit.Common.Operands;

namespace AsmJit.AssemblerContext
{
	public static class Cpu
	{
		private static RipRegister _rip;
		private static SegRegister[] _seg;
		private static GpRegister[] _gpbLo;
		private static GpRegister[] _gpbHi;
		private static GpRegister[] _gpw;
		private static GpRegister[] _gpd;
		private static GpRegister[] _gpq;
		private static FpRegister[] _fp;
		private static MmRegister[] _mm;
		private static KRegister[] _k;
		private static XmmRegister[] _xmm;
		private static YmmRegister[] _ymm;
		private static ZmmRegister[] _zmm;

		static Cpu()
		{
			_rip = new RipRegister();
			_seg = new SegRegister[7].InitializeWith(i => new SegRegister(i));
			_gpbLo = new GpRegister[16].InitializeWith(i => new GpRegister(GpRegisterType.GpbLo, i));
			_gpbHi = new GpRegister[4].InitializeWith(i => new GpRegister(GpRegisterType.GpbHi, i));
			_gpw = new GpRegister[16].InitializeWith(i => new GpRegister(GpRegisterType.Gpw, i));
			_gpd = new GpRegister[16].InitializeWith(i => new GpRegister(GpRegisterType.Gpd, i));
			_gpq = new GpRegister[16].InitializeWith(i => new GpRegister(GpRegisterType.Gpq, i));
			_fp = new FpRegister[8].InitializeWith(i => new FpRegister(i));
			_mm = new MmRegister[8].InitializeWith(i => new MmRegister(i));
			_k = new KRegister[8].InitializeWith(i => new KRegister(i));
			_xmm = new XmmRegister[32].InitializeWith(i => new XmmRegister(i));
			_ymm = new YmmRegister[32].InitializeWith(i => new YmmRegister(i));
			_zmm = new ZmmRegister[32].InitializeWith(i => new ZmmRegister(i));
		}

		internal static class Info
		{
			public static readonly int RegisterSize = Constants.X64 ? 8 : 4;
			public static readonly int StackAlignment = Constants.X64 ? 16 : IntPtr.Size;

			public static RegisterCount RegisterCount
			{
				get
				{
					return RegisterCount.SystemDefault;
				}
			}
		}

		public static class Registers
		{
			public static RipRegister Rip
			{
				get { return _rip; }
			}

			public static SegRegister Es
			{
				get { return _seg[1]; }
			}

			public static SegRegister Cs
			{
				get { return _seg[2]; }
			}

			public static SegRegister Ss
			{
				get { return _seg[3]; }
			}

			public static SegRegister Ds
			{
				get { return _seg[4]; }
			}

			public static SegRegister Fs
			{
				get { return _seg[5]; }
			}

			public static SegRegister Gs
			{
				get { return _seg[6]; }
			}

			public static GpRegister Al
			{
				get { return _gpbLo[0]; }
			}

			public static GpRegister Cl
			{
				get { return _gpbLo[1]; }
			}

			public static GpRegister Dl
			{
				get { return _gpbLo[2]; }
			}

			public static GpRegister Bl
			{
				get { return _gpbLo[3]; }
			}

			public static GpRegister Spl
			{
				get { return _gpbLo[4]; }
			}

			public static GpRegister Bpl
			{
				get { return _gpbLo[5]; }
			}

			public static GpRegister Sil
			{
				get { return _gpbLo[6]; }
			}

			public static GpRegister Dil
			{
				get { return _gpbLo[7]; }
			}

			public static GpRegister R8B
			{
				get { return _gpbLo[8]; }
			}

			public static GpRegister R9B
			{
				get { return _gpbLo[9]; }
			}

			public static GpRegister R10B
			{
				get { return _gpbLo[10]; }
			}

			public static GpRegister R11B
			{
				get { return _gpbLo[11]; }
			}

			public static GpRegister R12B
			{
				get { return _gpbLo[12]; }
			}

			public static GpRegister R13B
			{
				get { return _gpbLo[13]; }
			}

			public static GpRegister R14B
			{
				get { return _gpbLo[14]; }
			}

			public static GpRegister R15B
			{
				get { return _gpbLo[15]; }
			}

			public static GpRegister Ah
			{
				get { return _gpbHi[0]; }
			}

			public static GpRegister Ch
			{
				get { return _gpbHi[1]; }
			}

			public static GpRegister Dh
			{
				get { return _gpbHi[2]; }
			}

			public static GpRegister Bh
			{
				get { return _gpbHi[3]; }
			}

			public static GpRegister Ax
			{
				get { return _gpw[0]; }
			}

			public static GpRegister Cx
			{
				get { return _gpw[1]; }
			}

			public static GpRegister Dx
			{
				get { return _gpw[2]; }
			}

			public static GpRegister Bx
			{
				get { return _gpw[3]; }
			}

			public static GpRegister Sp
			{
				get { return _gpw[4]; }
			}

			public static GpRegister Bp
			{
				get { return _gpw[5]; }
			}

			public static GpRegister Si
			{
				get { return _gpw[6]; }
			}

			public static GpRegister Di
			{
				get { return _gpw[7]; }
			}

			public static GpRegister R8W
			{
				get { return _gpw[8]; }
			}

			public static GpRegister R9W
			{
				get { return _gpw[9]; }
			}

			public static GpRegister R10W
			{
				get { return _gpw[10]; }
			}

			public static GpRegister R11W
			{
				get { return _gpw[11]; }
			}

			public static GpRegister R12W
			{
				get { return _gpw[12]; }
			}

			public static GpRegister R13W
			{
				get { return _gpw[13]; }
			}

			public static GpRegister R14W
			{
				get { return _gpw[14]; }
			}

			public static GpRegister R15W
			{
				get { return _gpw[15]; }
			}

			public static GpRegister Eax
			{
				get { return _gpd[0]; }
			}

			public static GpRegister Ecx
			{
				get { return _gpd[1]; }
			}

			public static GpRegister Edx
			{
				get { return _gpd[2]; }
			}

			public static GpRegister Ebx
			{
				get { return _gpd[3]; }
			}

			public static GpRegister Esp
			{
				get { return _gpd[4]; }
			}

			public static GpRegister Ebp
			{
				get { return _gpd[5]; }
			}

			public static GpRegister Esi
			{
				get { return _gpd[6]; }
			}

			public static GpRegister Edi
			{
				get { return _gpd[7]; }
			}

			public static GpRegister R8D
			{
				get { return _gpd[8]; }
			}

			public static GpRegister R9D
			{
				get { return _gpd[9]; }
			}

			public static GpRegister R10D
			{
				get { return _gpd[10]; }
			}

			public static GpRegister R11D
			{
				get { return _gpd[11]; }
			}

			public static GpRegister R12D
			{
				get { return _gpd[12]; }
			}

			public static GpRegister R13D
			{
				get { return _gpd[13]; }
			}

			public static GpRegister R14D
			{
				get { return _gpd[14]; }
			}

			public static GpRegister R15D
			{
				get { return _gpd[15]; }
			}

			public static GpRegister Rax
			{
				get { return _gpq[0]; }
			}

			public static GpRegister Rcx
			{
				get { return _gpq[1]; }
			}

			public static GpRegister Rdx
			{
				get { return _gpq[2]; }
			}

			public static GpRegister Rbx
			{
				get { return _gpq[3]; }
			}

			public static GpRegister Rsp
			{
				get { return _gpq[4]; }
			}

			public static GpRegister Rbp
			{
				get { return _gpq[5]; }
			}

			public static GpRegister Rsi
			{
				get { return _gpq[6]; }
			}

			public static GpRegister Rdi
			{
				get { return _gpq[7]; }
			}

			public static GpRegister R8
			{
				get { return _gpq[8]; }
			}

			public static GpRegister R9
			{
				get { return _gpq[9]; }
			}

			public static GpRegister R10
			{
				get { return _gpq[10]; }
			}

			public static GpRegister R11
			{
				get { return _gpq[11]; }
			}

			public static GpRegister R12
			{
				get { return _gpq[12]; }
			}

			public static GpRegister R13
			{
				get { return _gpq[13]; }
			}

			public static GpRegister R14
			{
				get { return _gpq[14]; }
			}

			public static GpRegister R15
			{
				get { return _gpq[15]; }
			}

			public static FpRegister Fp0
			{
				get { return _fp[0]; }
			}

			public static FpRegister Fp1
			{
				get { return _fp[1]; }
			}

			public static FpRegister Fp2
			{
				get { return _fp[2]; }
			}

			public static FpRegister Fp3
			{
				get { return _fp[3]; }
			}

			public static FpRegister Fp4
			{
				get { return _fp[4]; }
			}

			public static FpRegister Fp5
			{
				get { return _fp[5]; }
			}

			public static FpRegister Fp6
			{
				get { return _fp[6]; }
			}

			public static FpRegister Fp7
			{
				get { return _fp[7]; }
			}

			public static MmRegister Mm0
			{
				get { return _mm[0]; }
			}

			public static MmRegister Mm1
			{
				get { return _mm[1]; }
			}

			public static MmRegister Mm2
			{
				get { return _mm[2]; }
			}

			public static MmRegister Mm3
			{
				get { return _mm[3]; }
			}

			public static MmRegister Mm4
			{
				get { return _mm[4]; }
			}

			public static MmRegister Mm5
			{
				get { return _mm[5]; }
			}

			public static MmRegister Mm6
			{
				get { return _mm[6]; }
			}

			public static MmRegister Mm7
			{
				get { return _mm[7]; }
			}

			public static KRegister K0
			{
				get { return _k[0]; }
			}

			public static KRegister K1
			{
				get { return _k[1]; }
			}

			public static KRegister K2
			{
				get { return _k[2]; }
			}

			public static KRegister K3
			{
				get { return _k[3]; }
			}

			public static KRegister K4
			{
				get { return _k[4]; }
			}

			public static KRegister K5
			{
				get { return _k[5]; }
			}

			public static KRegister K6
			{
				get { return _k[6]; }
			}

			public static KRegister K7
			{
				get { return _k[7]; }
			}

			public static XmmRegister Xmm0
			{
				get { return _xmm[0]; }
			}

			public static XmmRegister Xmm1
			{
				get { return _xmm[1]; }
			}

			public static XmmRegister Xmm2
			{
				get { return _xmm[2]; }
			}

			public static XmmRegister Xmm3
			{
				get { return _xmm[3]; }
			}

			public static XmmRegister Xmm4
			{
				get { return _xmm[4]; }
			}

			public static XmmRegister Xmm5
			{
				get { return _xmm[5]; }
			}

			public static XmmRegister Xmm6
			{
				get { return _xmm[6]; }
			}

			public static XmmRegister Xmm7
			{
				get { return _xmm[7]; }
			}

			public static XmmRegister Xmm8
			{
				get { return _xmm[8]; }
			}

			public static XmmRegister Xmm9
			{
				get { return _xmm[9]; }
			}

			public static XmmRegister Xmm10
			{
				get { return _xmm[10]; }
			}

			public static XmmRegister Xmm11
			{
				get { return _xmm[11]; }
			}

			public static XmmRegister Xmm12
			{
				get { return _xmm[12]; }
			}

			public static XmmRegister Xmm13
			{
				get { return _xmm[13]; }
			}

			public static XmmRegister Xmm14
			{
				get { return _xmm[14]; }
			}

			public static XmmRegister Xmm15
			{
				get { return _xmm[15]; }
			}

			public static XmmRegister Xmm16
			{
				get { return _xmm[16]; }
			}

			public static XmmRegister Xmm17
			{
				get { return _xmm[17]; }
			}

			public static XmmRegister Xmm18
			{
				get { return _xmm[18]; }
			}

			public static XmmRegister Xmm19
			{
				get { return _xmm[19]; }
			}

			public static XmmRegister Xmm20
			{
				get { return _xmm[20]; }
			}

			public static XmmRegister Xmm21
			{
				get { return _xmm[21]; }
			}

			public static XmmRegister Xmm22
			{
				get { return _xmm[22]; }
			}

			public static XmmRegister Xmm23
			{
				get { return _xmm[23]; }
			}

			public static XmmRegister Xmm24
			{
				get { return _xmm[24]; }
			}

			public static XmmRegister Xmm25
			{
				get { return _xmm[25]; }
			}

			public static XmmRegister Xmm26
			{
				get { return _xmm[26]; }
			}

			public static XmmRegister Xmm27
			{
				get { return _xmm[27]; }
			}

			public static XmmRegister Xmm28
			{
				get { return _xmm[28]; }
			}

			public static XmmRegister Xmm29
			{
				get { return _xmm[29]; }
			}

			public static XmmRegister Xmm30
			{
				get { return _xmm[30]; }
			}

			public static XmmRegister Xmm31
			{
				get { return _xmm[31]; }
			}

			public static YmmRegister Ymm0
			{
				get { return _ymm[0]; }
			}

			public static YmmRegister Ymm1
			{
				get { return _ymm[1]; }
			}

			public static YmmRegister Ymm2
			{
				get { return _ymm[2]; }
			}

			public static YmmRegister Ymm3
			{
				get { return _ymm[3]; }
			}

			public static YmmRegister Ymm4
			{
				get { return _ymm[4]; }
			}

			public static YmmRegister Ymm5
			{
				get { return _ymm[5]; }
			}

			public static YmmRegister Ymm6
			{
				get { return _ymm[6]; }
			}

			public static YmmRegister Ymm7
			{
				get { return _ymm[7]; }
			}

			public static YmmRegister Ymm8
			{
				get { return _ymm[8]; }
			}

			public static YmmRegister Ymm9
			{
				get { return _ymm[9]; }
			}

			public static YmmRegister Ymm10
			{
				get { return _ymm[10]; }
			}

			public static YmmRegister Ymm11
			{
				get { return _ymm[11]; }
			}

			public static YmmRegister Ymm12
			{
				get { return _ymm[12]; }
			}

			public static YmmRegister Ymm13
			{
				get { return _ymm[13]; }
			}

			public static YmmRegister Ymm14
			{
				get { return _ymm[14]; }
			}

			public static YmmRegister Ymm15
			{
				get { return _ymm[15]; }
			}

			public static YmmRegister Ymm16
			{
				get { return _ymm[16]; }
			}

			public static YmmRegister Ymm17
			{
				get { return _ymm[17]; }
			}

			public static YmmRegister Ymm18
			{
				get { return _ymm[18]; }
			}

			public static YmmRegister Ymm19
			{
				get { return _ymm[19]; }
			}

			public static YmmRegister Ymm20
			{
				get { return _ymm[20]; }
			}

			public static YmmRegister Ymm21
			{
				get { return _ymm[21]; }
			}

			public static YmmRegister Ymm22
			{
				get { return _ymm[22]; }
			}

			public static YmmRegister Ymm23
			{
				get { return _ymm[23]; }
			}

			public static YmmRegister Ymm24
			{
				get { return _ymm[24]; }
			}

			public static YmmRegister Ymm25
			{
				get { return _ymm[25]; }
			}

			public static YmmRegister Ymm26
			{
				get { return _ymm[26]; }
			}

			public static YmmRegister Ymm27
			{
				get { return _ymm[27]; }
			}

			public static YmmRegister Ymm28
			{
				get { return _ymm[28]; }
			}

			public static YmmRegister Ymm29
			{
				get { return _ymm[29]; }
			}

			public static YmmRegister Ymm30
			{
				get { return _ymm[30]; }
			}

			public static YmmRegister Ymm31
			{
				get { return _ymm[31]; }
			}

			public static ZmmRegister Zmm0
			{
				get { return _zmm[0]; }
			}

			public static ZmmRegister Zmm1
			{
				get { return _zmm[1]; }
			}

			public static ZmmRegister Zmm2
			{
				get { return _zmm[2]; }
			}

			public static ZmmRegister Zmm3
			{
				get { return _zmm[3]; }
			}

			public static ZmmRegister Zmm4
			{
				get { return _zmm[4]; }
			}

			public static ZmmRegister Zmm5
			{
				get { return _zmm[5]; }
			}

			public static ZmmRegister Zmm6
			{
				get { return _zmm[6]; }
			}

			public static ZmmRegister Zmm7
			{
				get { return _zmm[7]; }
			}

			public static ZmmRegister Zmm8
			{
				get { return _zmm[8]; }
			}

			public static ZmmRegister Zmm9
			{
				get { return _zmm[9]; }
			}

			public static ZmmRegister Zmm10
			{
				get { return _zmm[10]; }
			}

			public static ZmmRegister Zmm11
			{
				get { return _zmm[11]; }
			}

			public static ZmmRegister Zmm12
			{
				get { return _zmm[12]; }
			}

			public static ZmmRegister Zmm13
			{
				get { return _zmm[13]; }
			}

			public static ZmmRegister Zmm14
			{
				get { return _zmm[14]; }
			}

			public static ZmmRegister Zmm15
			{
				get { return _zmm[15]; }
			}

			public static ZmmRegister Zmm16
			{
				get { return _zmm[16]; }
			}

			public static ZmmRegister Zmm17
			{
				get { return _zmm[17]; }
			}

			public static ZmmRegister Zmm18
			{
				get { return _zmm[18]; }
			}

			public static ZmmRegister Zmm19
			{
				get { return _zmm[19]; }
			}

			public static ZmmRegister Zmm20
			{
				get { return _zmm[20]; }
			}

			public static ZmmRegister Zmm21
			{
				get { return _zmm[21]; }
			}

			public static ZmmRegister Zmm22
			{
				get { return _zmm[22]; }
			}

			public static ZmmRegister Zmm23
			{
				get { return _zmm[23]; }
			}

			public static ZmmRegister Zmm24
			{
				get { return _zmm[24]; }
			}

			public static ZmmRegister Zmm25
			{
				get { return _zmm[25]; }
			}

			public static ZmmRegister Zmm26
			{
				get { return _zmm[26]; }
			}

			public static ZmmRegister Zmm27
			{
				get { return _zmm[27]; }
			}

			public static ZmmRegister Zmm28
			{
				get { return _zmm[28]; }
			}

			public static ZmmRegister Zmm29
			{
				get { return _zmm[29]; }
			}

			public static ZmmRegister Zmm30
			{
				get { return _zmm[30]; }
			}

			public static ZmmRegister Zmm31
			{
				get { return _zmm[31]; }
			} 
		}
	}
}
