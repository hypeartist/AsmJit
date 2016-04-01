using AsmJit.Common.Operands;

namespace AsmJit.AssemblerContext
{
	public partial class CodeContext
	{
		public static RipRegister Rip
		{
			get { return Cpu.Registers.Rip; }
		}

		public SegRegister Es
		{
			get { return Cpu.Registers.Es; }
		}

		public SegRegister Cs
		{
			get { return Cpu.Registers.Cs; }
		}

		public SegRegister Ss
		{
			get { return Cpu.Registers.Ss; }
		}

		public SegRegister Ds
		{
			get { return Cpu.Registers.Ds; }
		}

		public SegRegister Fs
		{
			get { return Cpu.Registers.Fs; }
		}

		public SegRegister Gs
		{
			get { return Cpu.Registers.Gs; }
		}

		public GpRegister Al
		{
			get { return Cpu.Registers.Al; }
		}

		public GpRegister Cl
		{
			get { return Cpu.Registers.Cl; }
		}

		public GpRegister Dl
		{
			get { return Cpu.Registers.Dl; }
		}

		public GpRegister Bl
		{
			get { return Cpu.Registers.Bl; }
		}

		public GpRegister Spl
		{
			get { return Cpu.Registers.Spl; }
		}

		public GpRegister Bpl
		{
			get { return Cpu.Registers.Bpl; }
		}

		public GpRegister Sil
		{
			get { return Cpu.Registers.Sil; }
		}

		public GpRegister Dil
		{
			get { return Cpu.Registers.Dil; }
		}

		public GpRegister R8B
		{
			get { return Cpu.Registers.R8B; }
		}

		public GpRegister R9B
		{
			get { return Cpu.Registers.R9B; }
		}

		public GpRegister R10B
		{
			get { return Cpu.Registers.R10B; }
		}

		public GpRegister R11B
		{
			get { return Cpu.Registers.R11B; }
		}

		public GpRegister R12B
		{
			get { return Cpu.Registers.R12B; }
		}

		public GpRegister R13B
		{
			get { return Cpu.Registers.R13B; }
		}

		public GpRegister R14B
		{
			get { return Cpu.Registers.R14B; }
		}

		public GpRegister R15B
		{
			get { return Cpu.Registers.R15B; }
		}

		public GpRegister Ah
		{
			get { return Cpu.Registers.Ah; }
		}

		public GpRegister Ch
		{
			get { return Cpu.Registers.Ch; }
		}

		public GpRegister Dh
		{
			get { return Cpu.Registers.Dh; }
		}

		public GpRegister Bh
		{
			get { return Cpu.Registers.Bh; }
		}

		public GpRegister Ax
		{
			get { return Cpu.Registers.Ax; }
		}

		public GpRegister Cx
		{
			get { return Cpu.Registers.Cx; }
		}

		public GpRegister Dx
		{
			get { return Cpu.Registers.Dx; }
		}

		public GpRegister Bx
		{
			get { return Cpu.Registers.Bx; }
		}

		public GpRegister Sp
		{
			get { return Cpu.Registers.Sp; }
		}

		public GpRegister Bp
		{
			get { return Cpu.Registers.Bp; }
		}

		public GpRegister Si
		{
			get { return Cpu.Registers.Si; }
		}

		public GpRegister Di
		{
			get { return Cpu.Registers.Di; }
		}

		public GpRegister R8W
		{
			get { return Cpu.Registers.R8W; }
		}

		public GpRegister R9W
		{
			get { return Cpu.Registers.R9W; }
		}

		public GpRegister R10W
		{
			get { return Cpu.Registers.R10W; }
		}

		public GpRegister R11W
		{
			get { return Cpu.Registers.R11W; }
		}

		public GpRegister R12W
		{
			get { return Cpu.Registers.R12W; }
		}

		public GpRegister R13W
		{
			get { return Cpu.Registers.R13W; }
		}

		public GpRegister R14W
		{
			get { return Cpu.Registers.R14W; }
		}

		public GpRegister R15W
		{
			get { return Cpu.Registers.R15W; }
		}

		public GpRegister Eax
		{
			get { return Cpu.Registers.Eax; }
		}

		public GpRegister Ecx
		{
			get { return Cpu.Registers.Ecx; }
		}

		public GpRegister Edx
		{
			get { return Cpu.Registers.Edx; }
		}

		public GpRegister Ebx
		{
			get { return Cpu.Registers.Ebx; }
		}

		public GpRegister Esp
		{
			get { return Cpu.Registers.Esp; }
		}

		public GpRegister Ebp
		{
			get { return Cpu.Registers.Ebp; }
		}

		public GpRegister Esi
		{
			get { return Cpu.Registers.Esi; }
		}

		public GpRegister Edi
		{
			get { return Cpu.Registers.Edi; }
		}

		public GpRegister R8D
		{
			get { return Cpu.Registers.R8D; }
		}

		public GpRegister R9D
		{
			get { return Cpu.Registers.R9D; }
		}

		public GpRegister R10D
		{
			get { return Cpu.Registers.R10D; }
		}

		public GpRegister R11D
		{
			get { return Cpu.Registers.R11D; }
		}

		public GpRegister R12D
		{
			get { return Cpu.Registers.R12D; }
		}

		public GpRegister R13D
		{
			get { return Cpu.Registers.R13D; }
		}

		public GpRegister R14D
		{
			get { return Cpu.Registers.R14D; }
		}

		public GpRegister R15D
		{
			get { return Cpu.Registers.R15D; }
		}

		public GpRegister Rax
		{
			get { return Cpu.Registers.Rax; }
		}

		public GpRegister Rcx
		{
			get { return Cpu.Registers.Rcx; }
		}

		public GpRegister Rdx
		{
			get { return Cpu.Registers.Rdx; }
		}

		public GpRegister Rbx
		{
			get { return Cpu.Registers.Rbx; }
		}

		public GpRegister Rsp
		{
			get { return Cpu.Registers.Rsp; }
		}

		public GpRegister Rbp
		{
			get { return Cpu.Registers.Rbp; }
		}

		public GpRegister Rsi
		{
			get { return Cpu.Registers.Rsi; }
		}

		public GpRegister Rdi
		{
			get { return Cpu.Registers.Rdi; }
		}

		public GpRegister R8
		{
			get { return Cpu.Registers.R8; }
		}

		public GpRegister R9
		{
			get { return Cpu.Registers.R9; }
		}

		public GpRegister R10
		{
			get { return Cpu.Registers.R10; }
		}

		public GpRegister R11
		{
			get { return Cpu.Registers.R11; }
		}

		public GpRegister R12
		{
			get { return Cpu.Registers.R12; }
		}

		public GpRegister R13
		{
			get { return Cpu.Registers.R13; }
		}

		public GpRegister R14
		{
			get { return Cpu.Registers.R14; }
		}

		public GpRegister R15
		{
			get { return Cpu.Registers.R15; }
		}

		public FpRegister Fp0
		{
			get { return Cpu.Registers.Fp0; }
		}

		public FpRegister Fp1
		{
			get { return Cpu.Registers.Fp1; }
		}

		public FpRegister Fp2
		{
			get { return Cpu.Registers.Fp2; }
		}

		public FpRegister Fp3
		{
			get { return Cpu.Registers.Fp3; }
		}

		public FpRegister Fp4
		{
			get { return Cpu.Registers.Fp4; }
		}

		public FpRegister Fp5
		{
			get { return Cpu.Registers.Fp5; }
		}

		public FpRegister Fp6
		{
			get { return Cpu.Registers.Fp6; }
		}

		public FpRegister Fp7
		{
			get { return Cpu.Registers.Fp7; }
		}

		public MmRegister Mm0
		{
			get { return Cpu.Registers.Mm0; }
		}

		public MmRegister Mm1
		{
			get { return Cpu.Registers.Mm1; }
		}

		public MmRegister Mm2
		{
			get { return Cpu.Registers.Mm2; }
		}

		public MmRegister Mm3
		{
			get { return Cpu.Registers.Mm3; }
		}

		public MmRegister Mm4
		{
			get { return Cpu.Registers.Mm4; }
		}

		public MmRegister Mm5
		{
			get { return Cpu.Registers.Mm5; }
		}

		public MmRegister Mm6
		{
			get { return Cpu.Registers.Mm6; }
		}

		public MmRegister Mm7
		{
			get { return Cpu.Registers.Mm7; }
		}

		public KRegister K0
		{
			get { return Cpu.Registers.K0; }
		}

		public KRegister K1
		{
			get { return Cpu.Registers.K1; }
		}

		public KRegister K2
		{
			get { return Cpu.Registers.K2; }
		}

		public KRegister K3
		{
			get { return Cpu.Registers.K3; }
		}

		public KRegister K4
		{
			get { return Cpu.Registers.K4; }
		}

		public KRegister K5
		{
			get { return Cpu.Registers.K5; }
		}

		public KRegister K6
		{
			get { return Cpu.Registers.K6; }
		}

		public KRegister K7
		{
			get { return Cpu.Registers.K7; }
		}

		public XmmRegister Xmm0
		{
			get { return Cpu.Registers.Xmm0; }
		}

		public XmmRegister Xmm1
		{
			get { return Cpu.Registers.Xmm1; }
		}

		public XmmRegister Xmm2
		{
			get { return Cpu.Registers.Xmm2; }
		}

		public XmmRegister Xmm3
		{
			get { return Cpu.Registers.Xmm3; }
		}

		public XmmRegister Xmm4
		{
			get { return Cpu.Registers.Xmm4; }
		}

		public XmmRegister Xmm5
		{
			get { return Cpu.Registers.Xmm5; }
		}

		public XmmRegister Xmm6
		{
			get { return Cpu.Registers.Xmm6; }
		}

		public XmmRegister Xmm7
		{
			get { return Cpu.Registers.Xmm7; }
		}

		public XmmRegister Xmm8
		{
			get { return Cpu.Registers.Xmm8; }
		}

		public XmmRegister Xmm9
		{
			get { return Cpu.Registers.Xmm9; }
		}

		public XmmRegister Xmm10
		{
			get { return Cpu.Registers.Xmm10; }
		}

		public XmmRegister Xmm11
		{
			get { return Cpu.Registers.Xmm11; }
		}

		public XmmRegister Xmm12
		{
			get { return Cpu.Registers.Xmm12; }
		}

		public XmmRegister Xmm13
		{
			get { return Cpu.Registers.Xmm13; }
		}

		public XmmRegister Xmm14
		{
			get { return Cpu.Registers.Xmm14; }
		}

		public XmmRegister Xmm15
		{
			get { return Cpu.Registers.Xmm15; }
		}

		public XmmRegister Xmm16
		{
			get { return Cpu.Registers.Xmm16; }
		}

		public XmmRegister Xmm17
		{
			get { return Cpu.Registers.Xmm17; }
		}

		public XmmRegister Xmm18
		{
			get { return Cpu.Registers.Xmm18; }
		}

		public XmmRegister Xmm19
		{
			get { return Cpu.Registers.Xmm19; }
		}

		public XmmRegister Xmm20
		{
			get { return Cpu.Registers.Xmm20; }
		}

		public XmmRegister Xmm21
		{
			get { return Cpu.Registers.Xmm21; }
		}

		public XmmRegister Xmm22
		{
			get { return Cpu.Registers.Xmm22; }
		}

		public XmmRegister Xmm23
		{
			get { return Cpu.Registers.Xmm23; }
		}

		public XmmRegister Xmm24
		{
			get { return Cpu.Registers.Xmm24; }
		}

		public XmmRegister Xmm25
		{
			get { return Cpu.Registers.Xmm25; }
		}

		public XmmRegister Xmm26
		{
			get { return Cpu.Registers.Xmm26; }
		}

		public XmmRegister Xmm27
		{
			get { return Cpu.Registers.Xmm27; }
		}

		public XmmRegister Xmm28
		{
			get { return Cpu.Registers.Xmm28; }
		}

		public XmmRegister Xmm29
		{
			get { return Cpu.Registers.Xmm29; }
		}

		public XmmRegister Xmm30
		{
			get { return Cpu.Registers.Xmm30; }
		}

		public XmmRegister Xmm31
		{
			get { return Cpu.Registers.Xmm31; }
		}

		public YmmRegister Ymm0
		{
			get { return Cpu.Registers.Ymm0; }
		}

		public YmmRegister Ymm1
		{
			get { return Cpu.Registers.Ymm1; }
		}

		public YmmRegister Ymm2
		{
			get { return Cpu.Registers.Ymm2; }
		}

		public YmmRegister Ymm3
		{
			get { return Cpu.Registers.Ymm3; }
		}

		public YmmRegister Ymm4
		{
			get { return Cpu.Registers.Ymm4; }
		}

		public YmmRegister Ymm5
		{
			get { return Cpu.Registers.Ymm5; }
		}

		public YmmRegister Ymm6
		{
			get { return Cpu.Registers.Ymm6; }
		}

		public YmmRegister Ymm7
		{
			get { return Cpu.Registers.Ymm7; }
		}

		public YmmRegister Ymm8
		{
			get { return Cpu.Registers.Ymm8; }
		}

		public YmmRegister Ymm9
		{
			get { return Cpu.Registers.Ymm9; }
		}

		public YmmRegister Ymm10
		{
			get { return Cpu.Registers.Ymm10; }
		}

		public YmmRegister Ymm11
		{
			get { return Cpu.Registers.Ymm11; }
		}

		public YmmRegister Ymm12
		{
			get { return Cpu.Registers.Ymm12; }
		}

		public YmmRegister Ymm13
		{
			get { return Cpu.Registers.Ymm13; }
		}

		public YmmRegister Ymm14
		{
			get { return Cpu.Registers.Ymm14; }
		}

		public YmmRegister Ymm15
		{
			get { return Cpu.Registers.Ymm15; }
		}

		public YmmRegister Ymm16
		{
			get { return Cpu.Registers.Ymm16; }
		}

		public YmmRegister Ymm17
		{
			get { return Cpu.Registers.Ymm17; }
		}

		public YmmRegister Ymm18
		{
			get { return Cpu.Registers.Ymm18; }
		}

		public YmmRegister Ymm19
		{
			get { return Cpu.Registers.Ymm19; }
		}

		public YmmRegister Ymm20
		{
			get { return Cpu.Registers.Ymm20; }
		}

		public YmmRegister Ymm21
		{
			get { return Cpu.Registers.Ymm21; }
		}

		public YmmRegister Ymm22
		{
			get { return Cpu.Registers.Ymm22; }
		}

		public YmmRegister Ymm23
		{
			get { return Cpu.Registers.Ymm23; }
		}

		public YmmRegister Ymm24
		{
			get { return Cpu.Registers.Ymm24; }
		}

		public YmmRegister Ymm25
		{
			get { return Cpu.Registers.Ymm25; }
		}

		public YmmRegister Ymm26
		{
			get { return Cpu.Registers.Ymm26; }
		}

		public YmmRegister Ymm27
		{
			get { return Cpu.Registers.Ymm27; }
		}

		public YmmRegister Ymm28
		{
			get { return Cpu.Registers.Ymm28; }
		}

		public YmmRegister Ymm29
		{
			get { return Cpu.Registers.Ymm29; }
		}

		public YmmRegister Ymm30
		{
			get { return Cpu.Registers.Ymm30; }
		}

		public YmmRegister Ymm31
		{
			get { return Cpu.Registers.Ymm31; }
		}

		public ZmmRegister Zmm0
		{
			get { return Cpu.Registers.Zmm0; }
		}

		public ZmmRegister Zmm1
		{
			get { return Cpu.Registers.Zmm1; }
		}

		public ZmmRegister Zmm2
		{
			get { return Cpu.Registers.Zmm2; }
		}

		public ZmmRegister Zmm3
		{
			get { return Cpu.Registers.Zmm3; }
		}

		public ZmmRegister Zmm4
		{
			get { return Cpu.Registers.Zmm4; }
		}

		public ZmmRegister Zmm5
		{
			get { return Cpu.Registers.Zmm5; }
		}

		public ZmmRegister Zmm6
		{
			get { return Cpu.Registers.Zmm6; }
		}

		public ZmmRegister Zmm7
		{
			get { return Cpu.Registers.Zmm7; }
		}

		public ZmmRegister Zmm8
		{
			get { return Cpu.Registers.Zmm8; }
		}

		public ZmmRegister Zmm9
		{
			get { return Cpu.Registers.Zmm9; }
		}

		public ZmmRegister Zmm10
		{
			get { return Cpu.Registers.Zmm10; }
		}

		public ZmmRegister Zmm11
		{
			get { return Cpu.Registers.Zmm11; }
		}

		public ZmmRegister Zmm12
		{
			get { return Cpu.Registers.Zmm12; }
		}

		public ZmmRegister Zmm13
		{
			get { return Cpu.Registers.Zmm13; }
		}

		public ZmmRegister Zmm14
		{
			get { return Cpu.Registers.Zmm14; }
		}

		public ZmmRegister Zmm15
		{
			get { return Cpu.Registers.Zmm15; }
		}

		public ZmmRegister Zmm16
		{
			get { return Cpu.Registers.Zmm16; }
		}

		public ZmmRegister Zmm17
		{
			get { return Cpu.Registers.Zmm17; }
		}

		public ZmmRegister Zmm18
		{
			get { return Cpu.Registers.Zmm18; }
		}

		public ZmmRegister Zmm19
		{
			get { return Cpu.Registers.Zmm19; }
		}

		public ZmmRegister Zmm20
		{
			get { return Cpu.Registers.Zmm20; }
		}

		public ZmmRegister Zmm21
		{
			get { return Cpu.Registers.Zmm21; }
		}

		public ZmmRegister Zmm22
		{
			get { return Cpu.Registers.Zmm22; }
		}

		public ZmmRegister Zmm23
		{
			get { return Cpu.Registers.Zmm23; }
		}

		public ZmmRegister Zmm24
		{
			get { return Cpu.Registers.Zmm24; }
		}

		public ZmmRegister Zmm25
		{
			get { return Cpu.Registers.Zmm25; }
		}

		public ZmmRegister Zmm26
		{
			get { return Cpu.Registers.Zmm26; }
		}

		public ZmmRegister Zmm27
		{
			get { return Cpu.Registers.Zmm27; }
		}

		public ZmmRegister Zmm28
		{
			get { return Cpu.Registers.Zmm28; }
		}

		public ZmmRegister Zmm29
		{
			get { return Cpu.Registers.Zmm29; }
		}

		public ZmmRegister Zmm30
		{
			get { return Cpu.Registers.Zmm30; }
		}

		public ZmmRegister Zmm31
		{
			get { return Cpu.Registers.Zmm31; }
		}
	}
}
