namespace AsmJit.Common.Operands
{
	internal static class RegisterExtensions
	{
		internal static bool IsGp(this Register op)
		{
			return op.RegisterType >= RegisterType.GpbLo && op.RegisterType <= RegisterType.Gpq;
		}

		internal static bool IsGpb(this Register op)
		{
			return op.RegisterType >= RegisterType.GpbLo && op.RegisterType <= RegisterType.GpbHi;
		}

		internal static bool IsGpbLo(this Register op)
		{
			return op.RegisterType == RegisterType.GpbLo;
		}

		internal static bool IsGpbHi(this Register op)
		{
			return op.RegisterType == RegisterType.GpbHi;
		}

		internal static bool IsGpw(this Register op)
		{
			return op.RegisterType == RegisterType.Gpw;
		}

		internal static bool IsGpd(this Register op)
		{
			return op.RegisterType == RegisterType.Gpd;
		}

		internal static bool IsGpq(this Register op)
		{
			return op.RegisterType == RegisterType.Gpq;
		}

		internal static bool IsMm(this Register op)
		{
			return op.RegisterType == RegisterType.Mm;
		}

		internal static bool IsK(this Register op)
		{
			return op.RegisterType == RegisterType.K;
		}

		internal static bool IsXmm(this Register op)
		{
			return op.RegisterType == RegisterType.Xmm;
		}

		internal static bool IsYmm(this Register op)
		{
			return op.RegisterType == RegisterType.Ymm;
		}

		internal static bool IsZmm(this Register op)
		{
			return op.RegisterType == RegisterType.Zmm;
		}
	}
}
