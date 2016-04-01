namespace AsmJit.Common
{
	public enum CallingConvention
	{
		Default,
		X86CDecl = 1,
		X86StdCall = 2,
		X86MsThisCall = 3,
		X86MsFastCall = 4,
		X86BorlandFastCall = 5,
		X86GccFastCall = 6,
		X86GccRegParm1 = 7,
		X86GccRegParm2 = 8,
		X86GccRegParm3 = 9,
		X64Win = 10,
		X64Unix = 11
	}
}