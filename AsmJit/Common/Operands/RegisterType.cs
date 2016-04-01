namespace AsmJit.Common.Operands
{
	internal enum RegisterType
	{
		Invalid = 0,
		GpbLo = GpRegisterType.GpbLo,
		GpbHi = GpRegisterType.GpbHi,
		PatchedGpbHi = GpbLo | GpbHi,
		Gpw = GpRegisterType.Gpw,
		Gpd = GpRegisterType.Gpd,
		Gpq = GpRegisterType.Gpq,
		Fp = 0x40,
		Mm = 0x50,
		K = 0x60,
		Xmm = 0x70,
		Ymm = 0x80,
		Zmm = 0x90,
		Rip = 0xE0,
		Seg = 0xF0
	}
}