using System;

namespace AsmJit.Common
{
	internal static class Constants
	{
		public static readonly bool X64 = IntPtr.Size > 4;
		public static readonly CallingConvention DefaultCallingConvention = X64 ? CallingConvention.X64Win : CallingConvention.X86CDecl;

		public const int InvalidValue = -1;
		public const int InvalidId = InvalidValue;

		public static class X86
		{
			/// <summary>
			/// X86/X64 index register legacy and AVX2 (VSIB) support.
			/// </summary>
			public const int MemVSibGpz = 0;
			public const int MemVSibXmm = 1;
			public const int MemVSibYmm = 2;
			public const int MemVSibZmm = 3;

			/// <summary>
			/// X86/X64 specific memory flags.
			/// </summary>
			public const int MemSegBits = 0x7;
			public const int MemSegIndex = 0;
			public const int MemSegMask = MemSegBits << MemSegIndex;
			public const int MemGpdBits = 0x1;
			public const int MemGpdIndex = 3;
			public const int MemGpdMask = MemGpdBits << MemGpdIndex;
			public const int MemVSibBits = 0x3;
			public const int MemVSibIndex = 4;
			public const int MemVSibMask = MemVSibBits << MemVSibIndex;
			public const int MemShiftBits = 0x3;
			public const int MemShiftIndex = 6;
			public const int MemShiftMask = MemShiftBits << MemShiftIndex;

			/// <summary>
			/// X86InstOpCodeFlags
			/// </summary>
			public const long InstOpCode_MM_Shift = 16;
			public const long InstOpCode_MM_Mask = 0x0FU << (int)InstOpCode_MM_Shift;
			public const long InstOpCode_MM_00 = 0x00U << (int)InstOpCode_MM_Shift;
			public const long InstOpCode_MM_0F = 0x01U << (int)InstOpCode_MM_Shift;
			public const long InstOpCode_MM_0F38 = 0x02U << (int)InstOpCode_MM_Shift;
			public const long InstOpCode_MM_0F3A = 0x03U << (int)InstOpCode_MM_Shift;
			public const long InstOpCode_MM_00011 = 0x03U << (int)InstOpCode_MM_Shift;
			public const long InstOpCode_MM_01000 = 0x08U << (int)InstOpCode_MM_Shift;
			public const long InstOpCode_MM_01001 = 0x09U << (int)InstOpCode_MM_Shift;
			public const long InstOpCode_MM_0F01 = 0x0FU << (int)InstOpCode_MM_Shift;
			public const long InstOpCode_PP_Shift = 20;
			public const long InstOpCode_PP_Mask = 0x07U << (int)InstOpCode_PP_Shift;
			public const long InstOpCode_PP_00 = 0x00U << (int)InstOpCode_PP_Shift;
			public const long InstOpCode_PP_66 = 0x01U << (int)InstOpCode_PP_Shift;
			public const long InstOpCode_PP_F3 = 0x02U << (int)InstOpCode_PP_Shift;
			public const long InstOpCode_PP_F2 = 0x03U << (int)InstOpCode_PP_Shift;
			public const long InstOpCode_PP_9B = 0x07U << (int)InstOpCode_PP_Shift;
			public const long InstOpCode_L_Shift = 23;
			public const long InstOpCode_L_Mask = 0x03U << (int)InstOpCode_L_Shift;
			public const long InstOpCode_L_128 = 0x00U << (int)InstOpCode_L_Shift;
			public const long InstOpCode_L_256 = 0x01U << (int)InstOpCode_L_Shift;
			public const long InstOpCode_L_512 = 0x02U << (int)InstOpCode_L_Shift;
			public const long InstOpCode_O_Shift = 25;
			public const long InstOpCode_O_Mask = 0x07U << (int)InstOpCode_O_Shift;
			public const long InstOpCode_EW_Shift = 30;
			public const long InstOpCode_EW_Mask = 0x01U << (int)InstOpCode_EW_Shift;
			public const long InstOpCode_EW = 0x01U << (int)InstOpCode_EW_Shift;
			public const long InstOpCode_W_Shift = 31;
			public const long InstOpCode_W_Mask = 0x01U << (int)InstOpCode_W_Shift;
			public const long InstOpCode_W = 0x01U << (int)InstOpCode_W_Shift;

			/// <summary>
			/// X86InstTable
			/// </summary>
			public const long InstTable_L__ = (0L) << (int)InstOpCode_L_Shift;
			public const long InstTable_L_I = (0L) << (int)InstOpCode_L_Shift;
			public const long InstTable_L_0 = (0L) << (int)InstOpCode_L_Shift;
			public const long InstTable_L_L = (1L) << (int)InstOpCode_L_Shift;
			public const long InstTable_W__ = (0L) << (int)InstOpCode_W_Shift;
			public const long InstTable_W_I = (0L) << (int)InstOpCode_W_Shift;
			public const long InstTable_W_0 = (0L) << (int)InstOpCode_W_Shift;
			public const long InstTable_W_W = (1L) << (int)InstOpCode_W_Shift;
			public const long InstTable_E__ = (0L) << (int)InstOpCode_EW_Shift;
			public const long InstTable_E_I = (0L) << (int)InstOpCode_EW_Shift;
			public const long InstTable_E_0 = (0L) << (int)InstOpCode_EW_Shift;
			public const long InstTable_E_1 = (1L) << (int)InstOpCode_EW_Shift;

			/// <summary>
			/// X86InstOp
			/// </summary>
			public const long InstOpGb = 0x0001;
			public const long InstOpGw = 0x0002;
			public const long InstOpGd = 0x0004;
			public const long InstOpGq = 0x0008;
			public const long InstOpFp = 0x0010;
			public const long InstOpMm = 0x0020;
			public const long InstOpK = 0x0040;
			public const long InstOpXmm = 0x0100;
			public const long InstOpYmm = 0x0200;
			public const long InstOpZmm = 0x0400;
			public const long InstOpMem = 0x1000;
			public const long InstOpImm = 0x2000;
			public const long InstOpLabel = 0x4000;
			public const long InstOpNone = 0x8000;

			/// <summary>
			/// X86InstOpInternal
			/// </summary>
			public const long InstOpI = InstOpImm;
			public const long InstOpL = InstOpLabel;
			public const long InstOpLImm = InstOpLabel | InstOpImm;
			public const long InstOpGwb = InstOpGw | InstOpGb;
			public const long InstOpGqd = InstOpGq | InstOpGd;
			public const long InstOpGqdw = InstOpGq | InstOpGd | InstOpGw;
			public const long InstOpGqdwb = InstOpGq | InstOpGd | InstOpGw | InstOpGb;
			public const long InstOpGbMem = InstOpGb | InstOpMem;
			public const long InstOpGwMem = InstOpGw | InstOpMem;
			public const long InstOpGdMem = InstOpGd | InstOpMem;
			public const long InstOpGqMem = InstOpGq | InstOpMem;
			public const long InstOpGwbMem = InstOpGwb | InstOpMem;
			public const long InstOpGqdMem = InstOpGqd | InstOpMem;
			public const long InstOpGqdwMem = InstOpGqdw | InstOpMem;
			public const long InstOpGqdwbMem = InstOpGqdwb | InstOpMem;
			public const long InstOpFpMem = InstOpFp | InstOpMem;
			public const long InstOpMmMem = InstOpMm | InstOpMem;
			public const long InstOpKMem = InstOpK | InstOpMem;
			public const long InstOpXmmMem = InstOpXmm | InstOpMem;
			public const long InstOpYmmMem = InstOpYmm | InstOpMem;
			public const long InstOpZmmMem = InstOpZmm | InstOpMem;
			public const long InstOpMmXmm = InstOpMm | InstOpXmm;
			public const long InstOpMmXmmMem = InstOpMmXmm | InstOpMem;
			public const long InstOpXy = InstOpXmm | InstOpYmm;
			public const long InstOpXyMem = InstOpXy | InstOpMem;
			public const long InstOpXyz = InstOpXy | InstOpZmm;
			public const long InstOpXyzMem = InstOpXyz | InstOpMem;

			/// <summary>
			/// X86InstFlags
			/// </summary>
			public const long InstFlagNone = 0x00000000;
			public const long InstFlagFlow = 0x00000001;
			public const long InstFlagTest = 0x00000002;
			public const long InstFlagMove = 0x00000004;
			public const long InstFlagXchg = 0x00000008;
			public const long InstFlagFp = 0x00000010;
			public const long InstFlagLock = 0x00000020;
			public const long InstFlagSpecial = 0x00000040;
			public const long InstFlagSpecialMem = 0x00000080;
			public const long InstFlagMem2 = 0x00000100;
			public const long InstFlagMem4 = 0x00000200;
			public const long InstFlagMem8 = 0x00000400;
			public const long InstFlagMem10 = 0x00000800;
			public const long InstFlagZ = 0x00001000;
			public const long InstFlagAvx = 0x00010000;
			public const long InstFlagXop = 0x00020000;
			public const long InstFlagAvx512F = 0x00100000;
			public const long InstFlagAvx512CD = 0x00200000;
			public const long InstFlagAvx512PF = 0x00400000;
			public const long InstFlagAvx512ER = 0x00800000;
			public const long InstFlagAvx512DQ = 0x01000000;
			public const long InstFlagAvx512BW = 0x02000000;
			public const long InstFlagAvx512VL = 0x04000000;
			public const long InstFlagAvx512KMask = 0x08000000;
			public const long InstFlagAvx512KZero = 0x10000000;
			public const long InstFlagAvx512BCast = 0x20000000;
			public const long InstFlagAvx512Sae = 0x40000000;
			public const long InstFlagAvx512Rnd = 0x80000000;

			/// <summary>
			/// X86InstFlagsInternal
			/// </summary>
			public const long InstFlagMem2_4 = InstFlagMem2 | InstFlagMem4;
			public const long InstFlagMem2_4_8 = InstFlagMem2_4 | InstFlagMem8;
			public const long InstFlagMem4_8 = InstFlagMem4 | InstFlagMem8;
			public const long InstFlagMem4_8_10 = InstFlagMem4_8 | InstFlagMem10;

			/// <summary>
			/// X86Cond
			/// </summary>
			public const long CondA = 0x07;
			public const long CondAE = 0x03;
			public const long CondB = 0x02;
			public const long CondBE = 0x06;
			public const long CondC = 0x02;
			public const long CondE = 0x04;
			public const long CondG = 0x0F;
			public const long CondGE = 0x0D;
			public const long CondL = 0x0C;
			public const long CondLE = 0x0E;
			public const long CondNA = 0x06;
			public const long CondNAE = 0x02;
			public const long CondNB = 0x03;
			public const long CondNBE = 0x07;
			public const long CondNC = 0x03;
			public const long CondNE = 0x05;
			public const long CondNG = 0x0E;
			public const long CondNGE = 0x0C;
			public const long CondNL = 0x0D;
			public const long CondNLE = 0x0F;
			public const long CondNO = 0x01;
			public const long CondNP = 0x0B;
			public const long CondNS = 0x09;
			public const long CondNZ = 0x05;
			public const long CondO = 0x00;
			public const long CondP = 0x0A;
			public const long CondPE = 0x0A;
			public const long CondPO = 0x0B;
			public const long CondS = 0x08;
			public const long CondZ = 0x04;
			public const long CondSign = CondS;
			public const long CondNotSign = CondNS;
			public const long CondOverflow = CondO;
			public const long CondNotOverflow = CondNO;
			public const long CondLess = CondL;
			public const long CondLessEqual = CondLE;
			public const long CondGreater = CondG;
			public const long CondGreaterEqual = CondGE;
			public const long CondBelow = CondB;
			public const long CondBelowEqual = CondBE;
			public const long CondAbove = CondA;
			public const long CondAboveEqual = CondAE;
			public const long CondEqual = CondE;
			public const long CondNotEqual = CondNE;
			public const long CondParityEven = CondP;
			public const long CondParityOdd = CondPO;
			public const long CondZero = CondZ;
			public const long CondNotZero = CondNZ;
			public const long CondNegative = CondS;
			public const long CondPositive = CondNS;
			public const long CondFpuUnordered = 0x10;
			public const long CondFpuNotUnordered = 0x11;
			public const long CondNone = 0x12;

			/// <summary>
			/// X86/X64 bytes used to encode important prefixes.
			/// </summary>
			public const byte ByteRex = 0x40;
			public const byte ByteRexW = 0x08;
			public const byte ByteVex2 = 0xC5;
			public const byte ByteVex3 = 0xC4;
			public const byte ByteXop3 = 0x8F;
			public const byte ByteEvex4 = 0x62;

			/// <summary>
			/// AsmJit specific (used to encode VVVV field in XOP/VEX).
			/// </summary>
			public const long VexVVVVShift = 12;
			public const long VexVVVVMask = 0xF << (int)VexVVVVShift;

			/// <summary>
			/// X86InstOptions
			/// </summary>
			public const long InstOptionRex = 0x00000040;
			public const long _InstOptionNoRex = 0x00000080;
			public const long InstOptionLock = 0x00000100;
			public const long InstOptionVex3 = 0x00000200;
			public const long InstOptionEvex = 0x00010000;
			public const long InstOptionEvexZero = 0x00020000;
			public const long InstOptionEvexOneN = 0x00040000;
			public const long InstOptionEvexSae = 0x00080000;
			public const long InstOptionEvexRnSae = 0x00100000;
			public const long InstOptionEvexRdSae = 0x00200000;
			public const long InstOptionEvexRuSae = 0x00400000;
			public const long InstOptionEvexRzSae = 0x00800000;
			public const long RexNoRexMask = InstOptionRex | _InstOptionNoRex;

			/// <summary>
			/// X86/X64 segment codes.
			/// </summary>
			public const long SegDefault = 0;
			public const long SegEs = 1;
			public const long SegCs = 2;
			public const long SegSs = 3;
			public const long SegDs = 4;
			public const long SegFs = 5;
			public const long SegGs = 6;
			public const long SegCount = 7;
		}
	}
}