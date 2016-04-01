using System;

namespace AsmJit.CompilerContext
{
	[Flags]
	internal enum VariableFlags : long
	{
		RReg = 0x00000001,
		WReg = 0x00000002,
		XReg = 0x00000003,
		RMem = 0x00000004,
		WMem = 0x00000008,
		XMem = 0x0000000C,
		RDecide = 0x00000010,
		WDecide = 0x00000020,
		XDecide = 0x00000030,
		RConv = 0x00000040,
		WConv = 0x00000080,
		XConv = 0x000000C0,
		RCall = 0x00000100,
		RFunc = 0x00000200,
		WFunc = 0x00000400,
		Spill = 0x00000800,
		Unuse = 0x00001000,
		RAll = RReg | RMem | RDecide | RCall | RFunc,
		WAll = WReg | WMem | WDecide | WFunc,
		AllocRDone = 0x00400000,
		AllocWDone = 0x00800000,
		X86GpbLo = 0x10000000,
		X86GpbHi = 0x20000000,
		X86Fld4 = 0x40000000,
		X86Fld8 = 0x80000000
	}
}
