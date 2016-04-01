namespace AsmJit.Common.Operands
{
	internal static class VariableExtensions
	{
		internal static bool IsGp(this Variable op)
		{
			return op.RegisterType <= RegisterType.Gpq;
		}

		internal static bool IsGpb(this Variable op)
		{
			return op.RegisterType <= RegisterType.GpbHi;
		}

		internal static bool IsGpbLo(this Variable op)
		{
			return op.RegisterType == RegisterType.GpbLo;
		}

		internal static bool IsGpbHi(this Variable op)
		{
			return op.RegisterType == RegisterType.GpbHi;
		}

		internal static bool IsGpw(this Variable op)
		{
			return op.RegisterType == RegisterType.Gpw;
		}

		internal static bool IsGpd(this Variable op)
		{
			return op.RegisterType == RegisterType.Gpd;
		}

		internal static bool IsGpq(this Variable op)
		{
			return op.RegisterType == RegisterType.Gpq;
		}

		internal static bool IsMm(this Variable op)
		{
			return op.RegisterType == RegisterType.Mm;
		}

		internal static bool IsK(this Variable op)
		{
			return op.RegisterType == RegisterType.K;
		}

		internal static bool IsXmm(this Variable op)
		{
			return op.RegisterType == RegisterType.Xmm;
		}

		internal static bool IsYmm(this Variable op)
		{
			return op.RegisterType == RegisterType.Ymm;
		}

		internal static bool IsZmm(this Variable op)
		{
			return op.RegisterType == RegisterType.Zmm;
		}
	}
}
