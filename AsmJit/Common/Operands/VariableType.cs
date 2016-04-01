namespace AsmJit.Common.Operands
{
	public enum VariableType
	{
		Invalid = -1,
		Int8 = GpVariableType.Int8,
		UInt8 = GpVariableType.UInt8,
		Int16 = GpVariableType.Int16,
		UInt16 = GpVariableType.UInt16,
		Int32 = GpVariableType.Int32,
		UInt32 = GpVariableType.UInt32,
		Int64 = GpVariableType.Int64,
		UInt64 = GpVariableType.UInt64,
		IntPtr = GpVariableType.IntPtr,
		UIntPtr = GpVariableType.UIntPtr,
		Fp32 = FpVariableType.Fp32,
		Fp64 = FpVariableType.Fp64,
		Mm = 12,
		K = 13,
		Xmm = XmmVariableType.Xmm,
		XmmSs = XmmVariableType.XmmSs,
		XmmPs = XmmVariableType.XmmPs,
		XmmSd = XmmVariableType.XmmSd,
		XmmPd = XmmVariableType.XmmPd,
		Ymm = YmmVariableType.Ymm,
		YmmPs = YmmVariableType.YmmPs,
		YmmPd = YmmVariableType.YmmPd,
		Zmm = ZmmVariableType.Zmm,
		ZmmPs = ZmmVariableType.ZmmPs,
		ZmmPd = ZmmVariableType.ZmmPd,
		Stack
	}
}