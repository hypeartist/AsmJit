namespace AsmJit.Common
{
	internal enum InstructionId
	{
		None = 0,
		Adc = 1,         // X86/X64
		Add,             // X86/X64
		Addpd,           // SSE2
		Addps,           // SSE
		Addsd,           // SSE2
		Addss,           // SSE
		Addsubpd,        // SSE3
		Addsubps,        // SSE3
		Aesdec,          // AESNI
		Aesdeclast,      // AESNI
		Aesenc,          // AESNI
		Aesenclast,      // AESNI
		Aesimc,          // AESNI
		Aeskeygenassist, // AESNI
		And,             // X86/X64
		Andn,            // BMI
		Andnpd,          // SSE2
		Andnps,          // SSE
		Andpd,           // SSE2
		Andps,           // SSE
		Bextr,           // BMI
		Blendpd,         // SSE4.1
		Blendps,         // SSE4.1
		Blendvpd,        // SSE4.1
		Blendvps,        // SSE4.1
		Blsi,            // BMI
		Blsmsk,          // BMI
		Blsr,            // BMI
		Bsf,             // X86/X64
		Bsr,             // X86/X64
		Bswap,           // X86/X64 (i486+)
		Bt,              // X86/X64
		Btc,             // X86/X64
		Btr,             // X86/X64
		Bts,             // X86/X64
		Bzhi,            // BMI2
		Call,            // X86/X64
		Cbw,             // X86/X64
		Cdq,             // X86/X64
		Cdqe,            // X64 only
		Clc,             // X86/X64
		Cld,             // X86/X64
		Clflush,         // SSE2
		Cmc,             // X86/X64
		Cmova,           // X86/X64 (cmovcc) (i586+)
		Cmovae,          // X86/X64 (cmovcc) (i586+)
		Cmovb,           // X86/X64 (cmovcc) (i586+)
		Cmovbe,          // X86/X64 (cmovcc) (i586+)
		Cmovc,           // X86/X64 (cmovcc) (i586+)
		Cmove,           // X86/X64 (cmovcc) (i586+)
		Cmovg,           // X86/X64 (cmovcc) (i586+)
		Cmovge,          // X86/X64 (cmovcc) (i586+)
		Cmovl,           // X86/X64 (cmovcc) (i586+)
		Cmovle,          // X86/X64 (cmovcc) (i586+)
		Cmovna,          // X86/X64 (cmovcc) (i586+)
		Cmovnae,         // X86/X64 (cmovcc) (i586+)
		Cmovnb,          // X86/X64 (cmovcc) (i586+)
		Cmovnbe,         // X86/X64 (cmovcc) (i586+)
		Cmovnc,          // X86/X64 (cmovcc) (i586+)
		Cmovne,          // X86/X64 (cmovcc) (i586+)
		Cmovng,          // X86/X64 (cmovcc) (i586+)
		Cmovnge,         // X86/X64 (cmovcc) (i586+)
		Cmovnl,          // X86/X64 (cmovcc) (i586+)
		Cmovnle,         // X86/X64 (cmovcc) (i586+)
		Cmovno,          // X86/X64 (cmovcc) (i586+)
		Cmovnp,          // X86/X64 (cmovcc) (i586+)
		Cmovns,          // X86/X64 (cmovcc) (i586+)
		Cmovnz,          // X86/X64 (cmovcc) (i586+)
		Cmovo,           // X86/X64 (cmovcc) (i586+)
		Cmovp,           // X86/X64 (cmovcc) (i586+)
		Cmovpe,          // X86/X64 (cmovcc) (i586+)
		Cmovpo,          // X86/X64 (cmovcc) (i586+)
		Cmovs,           // X86/X64 (cmovcc) (i586+)
		Cmovz,           // X86/X64 (cmovcc) (i586+)
		Cmp,             // X86/X64
		Cmppd,           // SSE2
		Cmpps,           // SSE
		CmpsB,           // CMPS - X86/X64
		CmpsD,           // CMPS - X86/X64
		CmpsQ,           // CMPS - X64
		CmpsW,           // CMPS - X86/X64
		Cmpsd,           // SSE2
		Cmpss,           // SSE
		Cmpxchg,         // X86/X64 (i486+)
		Cmpxchg16b,      // X64 only
		Cmpxchg8b,       // X86/X64 (i586+)
		Comisd,          // SSE2
		Comiss,          // SSE
		Cpuid,           // X86/X64 (i486/i586+)
		Cqo,             // X64 only
		Crc32,           // SSE4.2
		Cvtdq2pd,        // SSE2
		Cvtdq2ps,        // SSE2
		Cvtpd2dq,        // SSE2
		Cvtpd2pi,        // SSE2
		Cvtpd2ps,        // SSE2
		Cvtpi2pd,        // SSE2
		Cvtpi2ps,        // SSE
		Cvtps2dq,        // SSE2
		Cvtps2pd,        // SSE2
		Cvtps2pi,        // SSE
		Cvtsd2si,        // SSE2
		Cvtsd2ss,        // SSE2
		Cvtsi2sd,        // SSE2
		Cvtsi2ss,        // SSE
		Cvtss2sd,        // SSE2
		Cvtss2si,        // SSE
		Cvttpd2dq,       // SSE2
		Cvttpd2pi,       // SSE2
		Cvttps2dq,       // SSE2
		Cvttps2pi,       // SSE
		Cvttsd2si,       // SSE2
		Cvttss2si,       // SSE
		Cwd,             // X86/X64
		Cwde,            // X86/X64
		Daa,             // X86 only
		Das,             // X86 only
		Dec,             // X86/X64
		Div,             // X86/X64
		Divpd,           // SSE2
		Divps,           // SSE
		Divsd,           // SSE2
		Divss,           // SSE
		Dppd,            // SSE4.1
		Dpps,            // SSE4.1
		Emms,            // MMX
		Enter,           // X86/X64
		Extractps,       // SSE4.1
		Extrq,           // SSE4a
		F2xm1,           // FPU
		Fabs,            // FPU
		Fadd,            // FPU
		Faddp,           // FPU
		Fbld,            // FPU
		Fbstp,           // FPU
		Fchs,            // FPU
		Fclex,           // FPU
		Fcmovb,          // FPU
		Fcmovbe,         // FPU
		Fcmove,          // FPU
		Fcmovnb,         // FPU
		Fcmovnbe,        // FPU
		Fcmovne,         // FPU
		Fcmovnu,         // FPU
		Fcmovu,          // FPU
		Fcom,            // FPU
		Fcomi,           // FPU
		Fcomip,          // FPU
		Fcomp,           // FPU
		Fcompp,          // FPU
		Fcos,            // FPU
		Fdecstp,         // FPU
		Fdiv,            // FPU
		Fdivp,           // FPU
		Fdivr,           // FPU
		Fdivrp,          // FPU
		Femms,           // 3dNow!
		Ffree,           // FPU
		Fiadd,           // FPU
		Ficom,           // FPU
		Ficomp,          // FPU
		Fidiv,           // FPU
		Fidivr,          // FPU
		Fild,            // FPU
		Fimul,           // FPU
		Fincstp,         // FPU
		Finit,           // FPU
		Fist,            // FPU
		Fistp,           // FPU
		Fisttp,          // SSE3
		Fisub,           // FPU
		Fisubr,          // FPU
		Fld,             // FPU
		Fld1,            // FPU
		Fldcw,           // FPU
		Fldenv,          // FPU
		Fldl2e,          // FPU
		Fldl2t,          // FPU
		Fldlg2,          // FPU
		Fldln2,          // FPU
		Fldpi,           // FPU
		Fldz,            // FPU
		Fmul,            // FPU
		Fmulp,           // FPU
		Fnclex,          // FPU
		Fninit,          // FPU
		Fnop,            // FPU
		Fnsave,          // FPU
		Fnstcw,          // FPU
		Fnstenv,         // FPU
		Fnstsw,          // FPU
		Fpatan,          // FPU
		Fprem,           // FPU
		Fprem1,          // FPU
		Fptan,           // FPU
		Frndint,         // FPU
		Frstor,          // FPU
		Fsave,           // FPU
		Fscale,          // FPU
		Fsin,            // FPU
		Fsincos,         // FPU
		Fsqrt,           // FPU
		Fst,             // FPU
		Fstcw,           // FPU
		Fstenv,          // FPU
		Fstp,            // FPU
		Fstsw,           // FPU
		Fsub,            // FPU
		Fsubp,           // FPU
		Fsubr,           // FPU
		Fsubrp,          // FPU
		Ftst,            // FPU
		Fucom,           // FPU
		Fucomi,          // FPU
		Fucomip,         // FPU
		Fucomp,          // FPU
		Fucompp,         // FPU
		Fwait,           // FPU
		Fxam,            // FPU
		Fxch,            // FPU
		Fxrstor,         // FPU
		Fxsave,          // FPU
		Fxtract,         // FPU
		Fyl2x,           // FPU
		Fyl2xp1,         // FPU
		Haddpd,          // SSE3
		Haddps,          // SSE3
		Hsubpd,          // SSE3
		Hsubps,          // SSE3
		Idiv,            // X86/X64
		Imul,            // X86/X64
		Inc,             // X86/X64
		Insertps,        // SSE4.1
		Insertq,         // SSE4a
		Int,             // X86/X64
		Ja,              // X86/X64 (jcc)
		Jae,             // X86/X64 (jcc)
		Jb,              // X86/X64 (jcc)
		Jbe,             // X86/X64 (jcc)
		Jc,              // X86/X64 (jcc)
		Je,              // X86/X64 (jcc)
		Jg,              // X86/X64 (jcc)
		Jge,             // X86/X64 (jcc)
		Jl,              // X86/X64 (jcc)
		Jle,             // X86/X64 (jcc)
		Jna,             // X86/X64 (jcc)
		Jnae,            // X86/X64 (jcc)
		Jnb,             // X86/X64 (jcc)
		Jnbe,            // X86/X64 (jcc)
		Jnc,             // X86/X64 (jcc)
		Jne,             // X86/X64 (jcc)
		Jng,             // X86/X64 (jcc)
		Jnge,            // X86/X64 (jcc)
		Jnl,             // X86/X64 (jcc)
		Jnle,            // X86/X64 (jcc)
		Jno,             // X86/X64 (jcc)
		Jnp,             // X86/X64 (jcc)
		Jns,             // X86/X64 (jcc)
		Jnz,             // X86/X64 (jcc)
		Jo,              // X86/X64 (jcc)
		Jp,              // X86/X64 (jcc)
		Jpe,             // X86/X64 (jcc)
		Jpo,             // X86/X64 (jcc)
		Js,              // X86/X64 (jcc)
		Jz,              // X86/X64 (jcc)
		Jecxz,           // X86/X64 (jcxz/jecxz/jrcxz)
		Jmp,             // X86/X64 (jmp)
		Lahf,            // X86/X64 (CPUID NEEDED)
		Lddqu,           // SSE3
		Ldmxcsr,         // SSE
		Lea,             // X86/X64
		Leave,           // X86/X64
		Lfence,          // SSE2
		LodsB,           // LODS - X86/X64
		LodsD,           // LODS - X86/X64
		LodsQ,           // LODS - X86/X64
		LodsW,           // LODS - X86/X64
		Lzcnt,           // LZCNT
		Maskmovdqu,      // SSE2
		Maskmovq,        // MMX-Ext
		Maxpd,           // SSE2
		Maxps,           // SSE
		Maxsd,           // SSE2
		Maxss,           // SSE
		Mfence,          // SSE2
		Minpd,           // SSE2
		Minps,           // SSE
		Minsd,           // SSE2
		Minss,           // SSE
		Monitor,         // SSE3
		Mov,             // X86/X64
		MovPtr,          // X86/X64
		Movapd,          // SSE2
		Movaps,          // SSE
		Movbe,           // SSE3 - Intel-Atom
		Movd,            // MMX/SSE2
		Movddup,         // SSE3
		Movdq2q,         // SSE2
		Movdqa,          // SSE2
		Movdqu,          // SSE2
		Movhlps,         // SSE
		Movhpd,          // SSE2
		Movhps,          // SSE
		Movlhps,         // SSE
		Movlpd,          // SSE2
		Movlps,          // SSE
		Movmskpd,        // SSE2
		Movmskps,        // SSE2
		Movntdq,         // SSE2
		Movntdqa,        // SSE4.1
		Movnti,          // SSE2
		Movntpd,         // SSE2
		Movntps,         // SSE
		Movntq,          // MMX-Ext
		Movntsd,         // SSE4a
		Movntss,         // SSE4a
		Movq,            // MMX/SSE/SSE2
		Movq2dq,         // SSE2
		MovsB,           // MOVS - X86/X64
		MovsD,           // MOVS - X86/X64
		MovsQ,           // MOVS - X64
		MovsW,           // MOVS - X86/X64
		Movsd,           // SSE2
		Movshdup,        // SSE3
		Movsldup,        // SSE3
		Movss,           // SSE
		Movsx,           // X86/X64
		Movsxd,          // X86/X64
		Movupd,          // SSE2
		Movups,          // SSE
		Movzx,           // X86/X64
		Mpsadbw,         // SSE4.1
		Mul,             // X86/X64
		Mulpd,           // SSE2
		Mulps,           // SSE
		Mulsd,           // SSE2
		Mulss,           // SSE
		Mulx,            // BMI2
		Mwait,           // SSE3
		Neg,             // X86/X64
		Nop,             // X86/X64
		Not,             // X86/X64
		Or,              // X86/X64
		Orpd,            // SSE2
		Orps,            // SSE
		Pabsb,           // SSSE3
		Pabsd,           // SSSE3
		Pabsw,           // SSSE3
		Packssdw,        // MMX/SSE2
		Packsswb,        // MMX/SSE2
		Packusdw,        // SSE4.1
		Packuswb,        // MMX/SSE2
		Paddb,           // MMX/SSE2
		Paddd,           // MMX/SSE2
		Paddq,           // SSE2
		Paddsb,          // MMX/SSE2
		Paddsw,          // MMX/SSE2
		Paddusb,         // MMX/SSE2
		Paddusw,         // MMX/SSE2
		Paddw,           // MMX/SSE2
		Palignr,         // SSSE3
		Pand,            // MMX/SSE2
		Pandn,           // MMX/SSE2
		Pause,           // SSE2.
		Pavgb,           // MMX-Ext
		Pavgw,           // MMX-Ext
		Pblendvb,        // SSE4.1
		Pblendw,         // SSE4.1
		Pclmulqdq,       // PCLMULQDQ
		Pcmpeqb,         // MMX/SSE2
		Pcmpeqd,         // MMX/SSE2
		Pcmpeqq,         // SSE4.1
		Pcmpeqw,         // MMX/SSE2
		Pcmpestri,       // SSE4.2
		Pcmpestrm,       // SSE4.2
		Pcmpgtb,         // MMX/SSE2
		Pcmpgtd,         // MMX/SSE2
		Pcmpgtq,         // SSE4.2
		Pcmpgtw,         // MMX/SSE2
		Pcmpistri,       // SSE4.2
		Pcmpistrm,       // SSE4.2
		Pdep,            // BMI2
		Pext,            // BMI2
		Pextrb,          // SSE4.1
		Pextrd,          // SSE4.1
		Pextrq,          // SSE4.1
		Pextrw,          // MMX-Ext/SSE2
		Pf2id,           // 3dNow!
		Pf2iw,           // Enhanced 3dNow!
		Pfacc,           // 3dNow!
		Pfadd,           // 3dNow!
		Pfcmpeq,         // 3dNow!
		Pfcmpge,         // 3dNow!
		Pfcmpgt,         // 3dNow!
		Pfmax,           // 3dNow!
		Pfmin,           // 3dNow!
		Pfmul,           // 3dNow!
		Pfnacc,          // Enhanced 3dNow!
		Pfpnacc,         // Enhanced 3dNow!
		Pfrcp,           // 3dNow!
		Pfrcpit1,        // 3dNow!
		Pfrcpit2,        // 3dNow!
		Pfrsqit1,        // 3dNow!
		Pfrsqrt,         // 3dNow!
		Pfsub,           // 3dNow!
		Pfsubr,          // 3dNow!
		Phaddd,          // SSSE3
		Phaddsw,         // SSSE3
		Phaddw,          // SSSE3
		Phminposuw,      // SSE4.1
		Phsubd,          // SSSE3
		Phsubsw,         // SSSE3
		Phsubw,          // SSSE3
		Pi2fd,           // 3dNow!
		Pi2fw,           // Enhanced 3dNow!
		Pinsrb,          // SSE4.1
		Pinsrd,          // SSE4.1
		Pinsrq,          // SSE4.1
		Pinsrw,          // MMX-Ext
		Pmaddubsw,       // SSSE3
		Pmaddwd,         // MMX/SSE2
		Pmaxsb,          // SSE4.1
		Pmaxsd,          // SSE4.1
		Pmaxsw,          // MMX-Ext
		Pmaxub,          // MMX-Ext
		Pmaxud,          // SSE4.1
		Pmaxuw,          // SSE4.1
		Pminsb,          // SSE4.1
		Pminsd,          // SSE4.1
		Pminsw,          // MMX-Ext
		Pminub,          // MMX-Ext
		Pminud,          // SSE4.1
		Pminuw,          // SSE4.1
		Pmovmskb,        // MMX-Ext
		Pmovsxbd,        // SSE4.1
		Pmovsxbq,        // SSE4.1
		Pmovsxbw,        // SSE4.1
		Pmovsxdq,        // SSE4.1
		Pmovsxwd,        // SSE4.1
		Pmovsxwq,        // SSE4.1
		Pmovzxbd,        // SSE4.1
		Pmovzxbq,        // SSE4.1
		Pmovzxbw,        // SSE4.1
		Pmovzxdq,        // SSE4.1
		Pmovzxwd,        // SSE4.1
		Pmovzxwq,        // SSE4.1
		Pmuldq,          // SSE4.1
		Pmulhrsw,        // SSSE3
		Pmulhuw,         // MMX-Ext
		Pmulhw,          // MMX/SSE2
		Pmulld,          // SSE4.1
		Pmullw,          // MMX/SSE2
		Pmuludq,         // SSE2
		Pop,             // X86/X64
		Popa,            // X86 only
		Popcnt,          // SSE4.2
		Popf,            // X86/X64
		Por,             // MMX/SSE2
		Prefetch,        // MMX-Ext/SSE
		Prefetch3dNow,   // 3dNow!
		Prefetchw3dNow,  // 3dNow!
		Psadbw,          // MMX-Ext
		Pshufb,          // SSSE3
		Pshufd,          // SSE2
		Pshufhw,         // SSE2
		Pshuflw,         // SSE2
		Pshufw,          // MMX-Ext
		Psignb,          // SSSE3
		Psignd,          // SSSE3
		Psignw,          // SSSE3
		Pslld,           // MMX/SSE2
		Pslldq,          // SSE2
		Psllq,           // MMX/SSE2
		Psllw,           // MMX/SSE2
		Psrad,           // MMX/SSE2
		Psraw,           // MMX/SSE2
		Psrld,           // MMX/SSE2
		Psrldq,          // SSE2
		Psrlq,           // MMX/SSE2
		Psrlw,           // MMX/SSE2
		Psubb,           // MMX/SSE2
		Psubd,           // MMX/SSE2
		Psubq,           // SSE2
		Psubsb,          // MMX/SSE2
		Psubsw,          // MMX/SSE2
		Psubusb,         // MMX/SSE2
		Psubusw,         // MMX/SSE2
		Psubw,           // MMX/SSE2
		Pswapd,          // Enhanced 3dNow!
		Ptest,           // SSE4.1
		Punpckhbw,       // MMX/SSE2
		Punpckhdq,       // MMX/SSE2
		Punpckhqdq,      // SSE2
		Punpckhwd,       // MMX/SSE2
		Punpcklbw,       // MMX/SSE2
		Punpckldq,       // MMX/SSE2
		Punpcklqdq,      // SSE2
		Punpcklwd,       // MMX/SSE2
		Push,            // X86/X64
		Pusha,           // X86 only
		Pushf,           // X86/X64
		Pxor,            // MMX/SSE2
		Rcl,             // X86/X64
		Rcpps,           // SSE
		Rcpss,           // SSE
		Rcr,             // X86/X64
		Rdfsbase,        // FSGSBASE (x64)
		Rdgsbase,        // FSGSBASE (x64)
		Rdrand,          // RDRAND
		Rdtsc,           // X86/X64
		Rdtscp,          // X86/X64
		RepLodsB,        // X86/X64 (REP)
		RepLodsD,        // X86/X64 (REP)
		RepLodsQ,        // X64 only (REP)
		RepLodsW,        // X86/X64 (REP)
		RepMovsB,        // X86/X64 (REP)
		RepMovsD,        // X86/X64 (REP)
		RepMovsQ,        // X64 only (REP)
		RepMovsW,        // X86/X64 (REP)
		RepStosB,        // X86/X64 (REP)
		RepStosD,        // X86/X64 (REP)
		RepStosQ,        // X64 only (REP)
		RepStosW,        // X86/X64 (REP)
		RepeCmpsB,       // X86/X64 (REP)
		RepeCmpsD,       // X86/X64 (REP)
		RepeCmpsQ,       // X64 only (REP)
		RepeCmpsW,       // X86/X64 (REP)
		RepeScasB,       // X86/X64 (REP)
		RepeScasD,       // X86/X64 (REP)
		RepeScasQ,       // X64 only (REP)
		RepeScasW,       // X86/X64 (REP)
		RepneCmpsB,      // X86/X64 (REP)
		RepneCmpsD,      // X86/X64 (REP)
		RepneCmpsQ,      // X64 only (REP)
		RepneCmpsW,      // X86/X64 (REP)
		RepneScasB,      // X86/X64 (REP)
		RepneScasD,      // X86/X64 (REP)
		RepneScasQ,      // X64 only (REP)
		RepneScasW,      // X86/X64 (REP)
		Ret,             // X86/X64
		Rol,             // X86/X64
		Ror,             // X86/X64
		Rorx,            // BMI2
		Roundpd,         // SSE4.1
		Roundps,         // SSE4.1
		Roundsd,         // SSE4.1
		Roundss,         // SSE4.1
		Rsqrtps,         // SSE
		Rsqrtss,         // SSE
		Sahf,            // X86/X64 (CPUID NEEDED)
		Sal,             // X86/X64
		Sar,             // X86/X64
		Sarx,            // BMI2
		Sbb,             // X86/X64
		ScasB,           // SCAS - X86/X64
		ScasD,           // SCAS - X86/X64
		ScasQ,           // SCAS - X64
		ScasW,           // SCAS - X86/X64
		Seta,            // X86/X64 (setcc)
		Setae,           // X86/X64 (setcc)
		Setb,            // X86/X64 (setcc)
		Setbe,           // X86/X64 (setcc)
		Setc,            // X86/X64 (setcc)
		Sete,            // X86/X64 (setcc)
		Setg,            // X86/X64 (setcc)
		Setge,           // X86/X64 (setcc)
		Setl,            // X86/X64 (setcc)
		Setle,           // X86/X64 (setcc)
		Setna,           // X86/X64 (setcc)
		Setnae,          // X86/X64 (setcc)
		Setnb,           // X86/X64 (setcc)
		Setnbe,          // X86/X64 (setcc)
		Setnc,           // X86/X64 (setcc)
		Setne,           // X86/X64 (setcc)
		Setng,           // X86/X64 (setcc)
		Setnge,          // X86/X64 (setcc)
		Setnl,           // X86/X64 (setcc)
		Setnle,          // X86/X64 (setcc)
		Setno,           // X86/X64 (setcc)
		Setnp,           // X86/X64 (setcc)
		Setns,           // X86/X64 (setcc)
		Setnz,           // X86/X64 (setcc)
		Seto,            // X86/X64 (setcc)
		Setp,            // X86/X64 (setcc)
		Setpe,           // X86/X64 (setcc)
		Setpo,           // X86/X64 (setcc)
		Sets,            // X86/X64 (setcc)
		Setz,            // X86/X64 (setcc)
		Sfence,          // MMX-Ext/SSE
		Shl,             // X86/X64
		Shld,            // X86/X64
		Shlx,            // BMI2
		Shr,             // X86/X64
		Shrd,            // X86/X64
		Shrx,            // BMI2
		Shufpd,          // SSE2
		Shufps,          // SSE
		Sqrtpd,          // SSE2
		Sqrtps,          // SSE
		Sqrtsd,          // SSE2
		Sqrtss,          // SSE
		Stc,             // X86/X64
		Std,             // X86/X64
		Stmxcsr,         // SSE
		StosB,           // STOS - X86/X64
		StosD,           // STOS - X86/X64
		StosQ,           // STOS - X64
		StosW,           // STOS - X86/X64
		Sub,             // X86/X64
		Subpd,           // SSE2
		Subps,           // SSE
		Subsd,           // SSE2
		Subss,           // SSE
		Test,            // X86/X64
		Tzcnt,           // TZCNT
		Ucomisd,         // SSE2
		Ucomiss,         // SSE
		Ud2,             // X86/X64
		Unpckhpd,        // SSE2
		Unpckhps,        // SSE
		Unpcklpd,        // SSE2
		Unpcklps,        // SSE
		Vaddpd,          // AVX
		Vaddps,          // AVX
		Vaddsd,          // AVX
		Vaddss,          // AVX
		Vaddsubpd,       // AVX
		Vaddsubps,       // AVX
		Vaesdec,         // AVX+AESNI
		Vaesdeclast,     // AVX+AESNI
		Vaesenc,         // AVX+AESNI
		Vaesenclast,     // AVX+AESNI
		Vaesimc,         // AVX+AESNI
		Vaeskeygenassist,// AVX+AESNI
		Vandnpd,         // AVX
		Vandnps,         // AVX
		Vandpd,          // AVX
		Vandps,          // AVX
		Vblendpd,        // AVX
		Vblendps,        // AVX
		Vblendvpd,       // AVX
		Vblendvps,       // AVX
		Vbroadcastf128,  // AVX
		Vbroadcasti128,  // AVX2
		Vbroadcastsd,    // AVX/AVX2
		Vbroadcastss,    // AVX/AVX2
		Vcmppd,          // AVX
		Vcmpps,          // AVX
		Vcmpsd,          // AVX
		Vcmpss,          // AVX
		Vcomisd,         // AVX
		Vcomiss,         // AVX
		Vcvtdq2pd,       // AVX
		Vcvtdq2ps,       // AVX
		Vcvtpd2dq,       // AVX
		Vcvtpd2ps,       // AVX
		Vcvtph2ps,       // F16C
		Vcvtps2dq,       // AVX
		Vcvtps2pd,       // AVX
		Vcvtps2ph,       // F16C
		Vcvtsd2si,       // AVX
		Vcvtsd2ss,       // AVX
		Vcvtsi2sd,       // AVX
		Vcvtsi2ss,       // AVX
		Vcvtss2sd,       // AVX
		Vcvtss2si,       // AVX
		Vcvttpd2dq,      // AVX
		Vcvttps2dq,      // AVX
		Vcvttsd2si,      // AVX
		Vcvttss2si,      // AVX
		Vdivpd,          // AVX
		Vdivps,          // AVX
		Vdivsd,          // AVX
		Vdivss,          // AVX
		Vdppd,           // AVX
		Vdpps,           // AVX
		Vextractf128,    // AVX
		Vextracti128,    // AVX2
		Vextractps,      // AVX
		Vfmadd132pd,     // FMA3
		Vfmadd132ps,     // FMA3
		Vfmadd132sd,     // FMA3
		Vfmadd132ss,     // FMA3
		Vfmadd213pd,     // FMA3
		Vfmadd213ps,     // FMA3
		Vfmadd213sd,     // FMA3
		Vfmadd213ss,     // FMA3
		Vfmadd231pd,     // FMA3
		Vfmadd231ps,     // FMA3
		Vfmadd231sd,     // FMA3
		Vfmadd231ss,     // FMA3
		Vfmaddpd,        // FMA4
		Vfmaddps,        // FMA4
		Vfmaddsd,        // FMA4
		Vfmaddss,        // FMA4
		Vfmaddsub132pd,  // FMA3
		Vfmaddsub132ps,  // FMA3
		Vfmaddsub213pd,  // FMA3
		Vfmaddsub213ps,  // FMA3
		Vfmaddsub231pd,  // FMA3
		Vfmaddsub231ps,  // FMA3
		Vfmaddsubpd,     // FMA4
		Vfmaddsubps,     // FMA4
		Vfmsub132pd,     // FMA3
		Vfmsub132ps,     // FMA3
		Vfmsub132sd,     // FMA3
		Vfmsub132ss,     // FMA3
		Vfmsub213pd,     // FMA3
		Vfmsub213ps,     // FMA3
		Vfmsub213sd,     // FMA3
		Vfmsub213ss,     // FMA3
		Vfmsub231pd,     // FMA3
		Vfmsub231ps,     // FMA3
		Vfmsub231sd,     // FMA3
		Vfmsub231ss,     // FMA3
		Vfmsubadd132pd,  // FMA3
		Vfmsubadd132ps,  // FMA3
		Vfmsubadd213pd,  // FMA3
		Vfmsubadd213ps,  // FMA3
		Vfmsubadd231pd,  // FMA3
		Vfmsubadd231ps,  // FMA3
		Vfmsubaddpd,     // FMA4
		Vfmsubaddps,     // FMA4
		Vfmsubpd,        // FMA4
		Vfmsubps,        // FMA4
		Vfmsubsd,        // FMA4
		Vfmsubss,        // FMA4
		Vfnmadd132pd,    // FMA3
		Vfnmadd132ps,    // FMA3
		Vfnmadd132sd,    // FMA3
		Vfnmadd132ss,    // FMA3
		Vfnmadd213pd,    // FMA3
		Vfnmadd213ps,    // FMA3
		Vfnmadd213sd,    // FMA3
		Vfnmadd213ss,    // FMA3
		Vfnmadd231pd,    // FMA3
		Vfnmadd231ps,    // FMA3
		Vfnmadd231sd,    // FMA3
		Vfnmadd231ss,    // FMA3
		Vfnmaddpd,       // FMA4
		Vfnmaddps,       // FMA4
		Vfnmaddsd,       // FMA4
		Vfnmaddss,       // FMA4
		Vfnmsub132pd,    // FMA3
		Vfnmsub132ps,    // FMA3
		Vfnmsub132sd,    // FMA3
		Vfnmsub132ss,    // FMA3
		Vfnmsub213pd,    // FMA3
		Vfnmsub213ps,    // FMA3
		Vfnmsub213sd,    // FMA3
		Vfnmsub213ss,    // FMA3
		Vfnmsub231pd,    // FMA3
		Vfnmsub231ps,    // FMA3
		Vfnmsub231sd,    // FMA3
		Vfnmsub231ss,    // FMA3
		Vfnmsubpd,       // FMA4
		Vfnmsubps,       // FMA4
		Vfnmsubsd,       // FMA4
		Vfnmsubss,       // FMA4
		Vfrczpd,         // XOP
		Vfrczps,         // XOP
		Vfrczsd,         // XOP
		Vfrczss,         // XOP
		Vgatherdpd,      // AVX2
		Vgatherdps,      // AVX2
		Vgatherqpd,      // AVX2
		Vgatherqps,      // AVX2
		Vhaddpd,         // AVX
		Vhaddps,         // AVX
		Vhsubpd,         // AVX
		Vhsubps,         // AVX
		Vinsertf128,     // AVX
		Vinserti128,     // AVX2
		Vinsertps,       // AVX
		Vlddqu,          // AVX
		Vldmxcsr,        // AVX
		Vmaskmovdqu,     // AVX
		Vmaskmovpd,      // AVX
		Vmaskmovps,      // AVX
		Vmaxpd,          // AVX
		Vmaxps,          // AVX
		Vmaxsd,          // AVX
		Vmaxss,          // AVX
		Vminpd,          // AVX
		Vminps,          // AVX
		Vminsd,          // AVX
		Vminss,          // AVX
		Vmovapd,         // AVX
		Vmovaps,         // AVX
		Vmovd,           // AVX
		Vmovddup,        // AVX
		Vmovdqa,         // AVX
		Vmovdqu,         // AVX
		Vmovhlps,        // AVX
		Vmovhpd,         // AVX
		Vmovhps,         // AVX
		Vmovlhps,        // AVX
		Vmovlpd,         // AVX
		Vmovlps,         // AVX
		Vmovmskpd,       // AVX
		Vmovmskps,       // AVX
		Vmovntdq,        // AVX
		Vmovntdqa,       // AVX/AVX2
		Vmovntpd,        // AVX
		Vmovntps,        // AVX
		Vmovq,           // AVX
		Vmovsd,          // AVX
		Vmovshdup,       // AVX
		Vmovsldup,       // AVX
		Vmovss,          // AVX
		Vmovupd,         // AVX
		Vmovups,         // AVX
		Vmpsadbw,        // AVX/AVX2
		Vmulpd,          // AVX
		Vmulps,          // AVX
		Vmulsd,          // AVX
		Vmulss,          // AVX
		Vorpd,           // AVX
		Vorps,           // AVX
		Vpabsb,          // AVX2
		Vpabsd,          // AVX2
		Vpabsw,          // AVX2
		Vpackssdw,       // AVX2
		Vpacksswb,       // AVX2
		Vpackusdw,       // AVX2
		Vpackuswb,       // AVX2
		Vpaddb,          // AVX2
		Vpaddd,          // AVX2
		Vpaddq,          // AVX2
		Vpaddsb,         // AVX2
		Vpaddsw,         // AVX2
		Vpaddusb,        // AVX2
		Vpaddusw,        // AVX2
		Vpaddw,          // AVX2
		Vpalignr,        // AVX2
		Vpand,           // AVX2
		Vpandn,          // AVX2
		Vpavgb,          // AVX2
		Vpavgw,          // AVX2
		Vpblendd,        // AVX2
		Vpblendvb,       // AVX2
		Vpblendw,        // AVX2
		Vpbroadcastb,    // AVX2
		Vpbroadcastd,    // AVX2
		Vpbroadcastq,    // AVX2
		Vpbroadcastw,    // AVX2
		Vpclmulqdq,      // AVX+PCLMULQDQ
		Vpcmov,          // XOP
		Vpcmpeqb,        // AVX2
		Vpcmpeqd,        // AVX2
		Vpcmpeqq,        // AVX2
		Vpcmpeqw,        // AVX2
		Vpcmpestri,      // AVX
		Vpcmpestrm,      // AVX
		Vpcmpgtb,        // AVX2
		Vpcmpgtd,        // AVX2
		Vpcmpgtq,        // AVX2
		Vpcmpgtw,        // AVX2
		Vpcmpistri,      // AVX
		Vpcmpistrm,      // AVX
		Vpcomb,          // XOP
		Vpcomd,          // XOP
		Vpcomq,          // XOP
		Vpcomub,         // XOP
		Vpcomud,         // XOP
		Vpcomuq,         // XOP
		Vpcomuw,         // XOP
		Vpcomw,          // XOP
		Vperm2f128,      // AVX
		Vperm2i128,      // AVX2
		Vpermd,          // AVX2
		Vpermil2pd,      // XOP
		Vpermil2ps,      // XOP
		Vpermilpd,       // AVX
		Vpermilps,       // AVX
		Vpermpd,         // AVX2
		Vpermps,         // AVX2
		Vpermq,          // AVX2
		Vpextrb,         // AVX
		Vpextrd,         // AVX
		Vpextrq,         // AVX (x64 only)
		Vpextrw,         // AVX
		Vpgatherdd,      // AVX2
		Vpgatherdq,      // AVX2
		Vpgatherqd,      // AVX2
		Vpgatherqq,      // AVX2
		Vphaddbd,        // XOP
		Vphaddbq,        // XOP
		Vphaddbw,        // XOP
		Vphaddd,         // AVX2
		Vphadddq,        // XOP
		Vphaddsw,        // AVX2
		Vphaddubd,       // XOP
		Vphaddubq,       // XOP
		Vphaddubw,       // XOP
		Vphaddudq,       // XOP
		Vphadduwd,       // XOP
		Vphadduwq,       // XOP
		Vphaddw,         // AVX2
		Vphaddwd,        // XOP
		Vphaddwq,        // XOP
		Vphminposuw,     // AVX
		Vphsubbw,        // XOP
		Vphsubd,         // AVX2
		Vphsubdq,        // XOP
		Vphsubsw,        // AVX2
		Vphsubw,         // AVX2
		Vphsubwd,        // XOP
		Vpinsrb,         // AVX
		Vpinsrd,         // AVX
		Vpinsrq,         // AVX (x64 only)
		Vpinsrw,         // AVX
		Vpmacsdd,        // XOP
		Vpmacsdqh,       // XOP
		Vpmacsdql,       // XOP
		Vpmacssdd,       // XOP
		Vpmacssdqh,      // XOP
		Vpmacssdql,      // XOP
		Vpmacsswd,       // XOP
		Vpmacssww,       // XOP
		Vpmacswd,        // XOP
		Vpmacsww,        // XOP
		Vpmadcsswd,      // XOP
		Vpmadcswd,       // XOP
		Vpmaddubsw,      // AVX/AVX2
		Vpmaddwd,        // AVX/AVX2
		Vpmaskmovd,      // AVX2
		Vpmaskmovq,      // AVX2
		Vpmaxsb,         // AVX/AVX2
		Vpmaxsd,         // AVX/AVX2
		Vpmaxsw,         // AVX/AVX2
		Vpmaxub,         // AVX/AVX2
		Vpmaxud,         // AVX/AVX2
		Vpmaxuw,         // AVX/AVX2
		Vpminsb,         // AVX/AVX2
		Vpminsd,         // AVX/AVX2
		Vpminsw,         // AVX/AVX2
		Vpminub,         // AVX/AVX2
		Vpminud,         // AVX/AVX2
		Vpminuw,         // AVX/AVX2
		Vpmovmskb,       // AVX/AVX2
		Vpmovsxbd,       // AVX/AVX2
		Vpmovsxbq,       // AVX/AVX2
		Vpmovsxbw,       // AVX/AVX2
		Vpmovsxdq,       // AVX/AVX2
		Vpmovsxwd,       // AVX/AVX2
		Vpmovsxwq,       // AVX/AVX2
		Vpmovzxbd,       // AVX/AVX2
		Vpmovzxbq,       // AVX/AVX2
		Vpmovzxbw,       // AVX/AVX2
		Vpmovzxdq,       // AVX/AVX2
		Vpmovzxwd,       // AVX/AVX2
		Vpmovzxwq,       // AVX/AVX2
		Vpmuldq,         // AVX/AVX2
		Vpmulhrsw,       // AVX/AVX2
		Vpmulhuw,        // AVX/AVX2
		Vpmulhw,         // AVX/AVX2
		Vpmulld,         // AVX/AVX2
		Vpmullw,         // AVX/AVX2
		Vpmuludq,        // AVX/AVX2
		Vpor,            // AVX/AVX2
		Vpperm,          // XOP
		Vprotb,          // XOP
		Vprotd,          // XOP
		Vprotq,          // XOP
		Vprotw,          // XOP
		Vpsadbw,         // AVX/AVX2
		Vpshab,          // XOP
		Vpshad,          // XOP
		Vpshaq,          // XOP
		Vpshaw,          // XOP
		Vpshlb,          // XOP
		Vpshld,          // XOP
		Vpshlq,          // XOP
		Vpshlw,          // XOP
		Vpshufb,         // AVX/AVX2
		Vpshufd,         // AVX/AVX2
		Vpshufhw,        // AVX/AVX2
		Vpshuflw,        // AVX/AVX2
		Vpsignb,         // AVX/AVX2
		Vpsignd,         // AVX/AVX2
		Vpsignw,         // AVX/AVX2
		Vpslld,          // AVX/AVX2
		Vpslldq,         // AVX/AVX2
		Vpsllq,          // AVX/AVX2
		Vpsllvd,         // AVX2
		Vpsllvq,         // AVX2
		Vpsllw,          // AVX/AVX2
		Vpsrad,          // AVX/AVX2
		Vpsravd,         // AVX2
		Vpsraw,          // AVX/AVX2
		Vpsrld,          // AVX/AVX2
		Vpsrldq,         // AVX/AVX2
		Vpsrlq,          // AVX/AVX2
		Vpsrlvd,         // AVX2
		Vpsrlvq,         // AVX2
		Vpsrlw,          // AVX/AVX2
		Vpsubb,          // AVX/AVX2
		Vpsubd,          // AVX/AVX2
		Vpsubq,          // AVX/AVX2
		Vpsubsb,         // AVX/AVX2
		Vpsubsw,         // AVX/AVX2
		Vpsubusb,        // AVX/AVX2
		Vpsubusw,        // AVX/AVX2
		Vpsubw,          // AVX/AVX2
		Vptest,          // AVX
		Vpunpckhbw,      // AVX/AVX2
		Vpunpckhdq,      // AVX/AVX2
		Vpunpckhqdq,     // AVX/AVX2
		Vpunpckhwd,      // AVX/AVX2
		Vpunpcklbw,      // AVX/AVX2
		Vpunpckldq,      // AVX/AVX2
		Vpunpcklqdq,     // AVX/AVX2
		Vpunpcklwd,      // AVX/AVX2
		Vpxor,           // AVX/AVX2
		Vrcpps,          // AVX
		Vrcpss,          // AVX
		Vroundpd,        // AVX
		Vroundps,        // AVX
		Vroundsd,        // AVX
		Vroundss,        // AVX
		Vrsqrtps,        // AVX
		Vrsqrtss,        // AVX
		Vshufpd,         // AVX
		Vshufps,         // AVX
		Vsqrtpd,         // AVX
		Vsqrtps,         // AVX
		Vsqrtsd,         // AVX
		Vsqrtss,         // AVX
		Vstmxcsr,        // AVX
		Vsubpd,          // AVX
		Vsubps,          // AVX
		Vsubsd,          // AVX
		Vsubss,          // AVX
		Vtestpd,         // AVX
		Vtestps,         // AVX
		Vucomisd,        // AVX
		Vucomiss,        // AVX
		Vunpckhpd,       // AVX
		Vunpckhps,       // AVX
		Vunpcklpd,       // AVX
		Vunpcklps,       // AVX
		Vxorpd,          // AVX
		Vxorps,          // AVX
		Vzeroall,        // AVX
		Vzeroupper,      // AVX
		Wrfsbase,        // FSGSBASE (x64)
		Wrgsbase,        // FSGSBASE (x64)
		Xadd,            // X86/X64 (i486+)
		Xchg,            // X86/X64
		Xgetbv,          // XSAVE
		Xor,             // X86/X64
		Xorpd,           // SSE2
		Xorps,           // SSE
		Xrstor,          // XSAVE
		Xrstor64,        // XSAVE
		Xsave,           // XSAVE
		Xsave64,         // XSAVE
		Xsaveopt,        // XSAVE
		Xsaveopt64,      // XSAVE
		Xsetbv          // XSAVE
	}
}
