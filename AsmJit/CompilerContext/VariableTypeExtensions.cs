using System;
using System.Collections.Generic;
using AsmJit.Common;
using AsmJit.Common.Operands;

namespace AsmJit.CompilerContext
{
	internal static class VariableTypeExtensions
	{
		public static VariableInfo GetVariableInfo(this VariableType type)
		{
			return _variableInfos[type];
		}

		public static RegisterClass GetRegisterClass(this VariableType type)
		{
			return _variableInfos[type].RegisterClass;
		}

		public static VariableType GetMappedType(this VariableType type)
		{
			return Constants.X64 ? _variableTypeMappingX64[type] : _variableTypeMappingX86[type];
		}

		public static bool IsInvalid(this VariableType type)
		{
			return type == VariableType.Invalid;
		}

		public static bool IsInt(this VariableType type)
		{
			return type >= VariableType.Int8 && type <= VariableType.UIntPtr;
		}

		public static bool IsFp(this VariableType type)
		{
			return type >= VariableType.Fp32 && type <= VariableType.Fp64;
		}

		public static bool IsMm(this VariableType type)
		{
			return type == VariableType.Mm;
		}

		public static bool IsXmm(this VariableType type)
		{
			return type >= VariableType.Xmm && type <= VariableType.XmmPd;
		}

		public static bool IsYmm(this VariableType type)
		{
			return type >= VariableType.Ymm && type <= VariableType.YmmPd;
		}

		public static bool IsZmm(this VariableType type)
		{
			return type >= VariableType.Zmm && type <= VariableType.ZmmPd;
		}

		public static bool AssertValidity(this VariableType type)
		{
			return type >= VariableType.Invalid && type <= VariableType.ZmmPd;
		}

		public static VariableType ToXmm(this VariableType type)
		{
			return type == VariableType.Fp32 ? VariableType.XmmSs : (type == VariableType.Fp64 ? VariableType.XmmSd : type);
		}

		public static VariableType GetVariableType(this Type type)
		{
			var code = Type.GetTypeCode(type);
			switch (code)
			{
				case TypeCode.Empty:
				case TypeCode.Object:
				case TypeCode.DBNull:
				case TypeCode.DateTime:
				case TypeCode.String:
					return type == typeof(Pointer) || type == typeof(IntPtr) ? VariableType.IntPtr : type == typeof(UIntPtr) ? VariableType.UIntPtr : VariableType.Invalid;
				case TypeCode.Boolean:
					return VariableType.Int32;
				case TypeCode.Char:
					return VariableType.UInt16;
				case TypeCode.SByte:
					return VariableType.Int8;
				case TypeCode.Byte:
					return VariableType.UInt8;
				case TypeCode.Int16:
					return VariableType.Int16;
				case TypeCode.UInt16:
					return VariableType.UInt16;
				case TypeCode.Int32:
					return VariableType.Int32;
				case TypeCode.UInt32:
					return VariableType.UInt32;
				case TypeCode.Int64:
					return VariableType.Int64;
				case TypeCode.UInt64:
					return VariableType.UInt64;
				case TypeCode.Single:
					return VariableType.Fp32;
				case TypeCode.Double:
				case TypeCode.Decimal:
					return VariableType.Fp64;
				default:
					return VariableType.Invalid;
			}
		}

		private static Dictionary<VariableType, VariableInfo> _variableInfos = new Dictionary<VariableType, VariableInfo>
		{
			{VariableType.Int8, new VariableInfo(RegisterType.GpbLo, 1, RegisterClass.Gp, 0, "gpb")},
			{VariableType.UInt8, new VariableInfo(RegisterType.GpbLo, 1, RegisterClass.Gp, 0, "gpb")},
			{VariableType.Int16, new VariableInfo(RegisterType.Gpw, 2, RegisterClass.Gp, 0, "gpw")},
			{VariableType.UInt16, new VariableInfo(RegisterType.Gpw, 2, RegisterClass.Gp, 0, "gpw")},
			{VariableType.Int32, new VariableInfo(RegisterType.Gpd, 4, RegisterClass.Gp, 0, "gpd")},
			{VariableType.UInt32, new VariableInfo(RegisterType.Gpd, 4, RegisterClass.Gp, 0, "gpd")},
			{VariableType.Int64, new VariableInfo(RegisterType.Gpq, 8, RegisterClass.Gp, 0, "gpq")},
			{VariableType.UInt64, new VariableInfo(RegisterType.Gpq, 8, RegisterClass.Gp, 0, "gpq")},
			{VariableType.IntPtr, new VariableInfo(0, 0, RegisterClass.Gp, 0, "")},
			{VariableType.UIntPtr, new VariableInfo(0, 0, RegisterClass.Gp, 0, "")},
			{VariableType.Fp32, new VariableInfo(RegisterType.Fp, 4, RegisterClass.Fp, VariableValueFlags.Sp, "fp")},
			{VariableType.Fp64, new VariableInfo(RegisterType.Fp, 8, RegisterClass.Fp, VariableValueFlags.Dp, "fp")},
			{VariableType.Mm, new VariableInfo(RegisterType.Mm, 8, RegisterClass.Mm, 0, "mm")},
			{VariableType.K, new VariableInfo(RegisterType.K, 8, RegisterClass.K, 0, "k")},
			{VariableType.Xmm, new VariableInfo(RegisterType.Xmm, 16, RegisterClass.Xyz, 0, "xmm")},
			{VariableType.XmmSs, new VariableInfo(RegisterType.Xmm, 4, RegisterClass.Xyz, VariableValueFlags.Sp, "xmm")},
			{VariableType.XmmPs, new VariableInfo(RegisterType.Xmm, 16, RegisterClass.Xyz, VariableValueFlags.Sp | VariableValueFlags.Packed, "xmm")},
			{VariableType.XmmSd, new VariableInfo(RegisterType.Xmm, 8, RegisterClass.Xyz, VariableValueFlags.Dp, "xmm")},
			{VariableType.XmmPd, new VariableInfo(RegisterType.Xmm, 16, RegisterClass.Xyz, VariableValueFlags.Dp | VariableValueFlags.Packed, "xmm")},
			{VariableType.Ymm, new VariableInfo(RegisterType.Ymm, 32, RegisterClass.Xyz, 0, "ymm")},
			{VariableType.YmmPs, new VariableInfo(RegisterType.Ymm, 32, RegisterClass.Xyz, VariableValueFlags.Sp | VariableValueFlags.Packed, "ymm")},
			{VariableType.YmmPd, new VariableInfo(RegisterType.Ymm, 32, RegisterClass.Xyz, VariableValueFlags.Dp | VariableValueFlags.Packed, "ymm")},
			{VariableType.Zmm, new VariableInfo(RegisterType.Zmm, 64, RegisterClass.Xyz, 0, "zmm")},
			{VariableType.ZmmPs, new VariableInfo(RegisterType.Zmm, 64, RegisterClass.Xyz, VariableValueFlags.Sp | VariableValueFlags.Packed, "zmm")},
			{VariableType.ZmmPd, new VariableInfo(RegisterType.Zmm, 64, RegisterClass.Xyz, VariableValueFlags.Dp | VariableValueFlags.Packed, "zmm")}
		};

		private static Dictionary<VariableType, VariableType> _variableTypeMappingX86 = new Dictionary<VariableType, VariableType>
		{
			{VariableType.Int8, VariableType.Int8},
			{VariableType.UInt8, VariableType.UInt8},
			{VariableType.Int16, VariableType.Int16},
			{VariableType.UInt16, VariableType.UInt16},
			{VariableType.Int32, VariableType.Int32},
			{VariableType.UInt32, VariableType.UInt32},
			{VariableType.Int64, VariableType.Invalid}, // Invalid in 32-bit mode.
			{VariableType.UInt64, VariableType.Invalid}, // Invalid in 32-bit mode.
			{VariableType.IntPtr, VariableType.Int32}, // Remapped to Int32.
			{VariableType.UIntPtr, VariableType.UInt32}, // Remapped to long32.
			{VariableType.Fp32, VariableType.Fp32},
			{VariableType.Fp64, VariableType.Fp64},
			{VariableType.Mm, VariableType.Mm},
			{VariableType.K, VariableType.K},
			{VariableType.Xmm, VariableType.Xmm},
			{VariableType.XmmSs, VariableType.XmmSs},
			{VariableType.XmmPs, VariableType.XmmPs},
			{VariableType.XmmSd, VariableType.XmmSd},
			{VariableType.XmmPd, VariableType.XmmPd},
			{VariableType.Ymm, VariableType.Ymm},
			{VariableType.YmmPs, VariableType.YmmPs},
			{VariableType.YmmPd, VariableType.YmmPd},
			{VariableType.Zmm, VariableType.Zmm},
			{VariableType.ZmmPs, VariableType.ZmmPs},
			{VariableType.ZmmPd, VariableType.ZmmPd}
		};

		private static Dictionary<VariableType, VariableType> _variableTypeMappingX64 = new Dictionary<VariableType, VariableType>
		{
			{VariableType.Int8, VariableType.Int8},
			{VariableType.UInt8, VariableType.UInt8},
			{VariableType.Int16, VariableType.Int16},
			{VariableType.UInt16, VariableType.UInt16},
			{VariableType.Int32, VariableType.Int32},
			{VariableType.UInt32, VariableType.UInt32},
			{VariableType.Int64, VariableType.Int64},
			{VariableType.UInt64, VariableType.UInt64},
			{VariableType.IntPtr, VariableType.Int64}, // Remapped to Int64.
			{VariableType.UIntPtr, VariableType.UInt64}, // Remapped to long64.
			{VariableType.Fp32, VariableType.Fp32},
			{VariableType.Fp64, VariableType.Fp64},
			{VariableType.Mm, VariableType.Mm},
			{VariableType.K, VariableType.K},
			{VariableType.Xmm, VariableType.Xmm},
			{VariableType.XmmSs, VariableType.XmmSs},
			{VariableType.XmmPs, VariableType.XmmPs},
			{VariableType.XmmSd, VariableType.XmmSd},
			{VariableType.XmmPd, VariableType.XmmPd},
			{VariableType.Ymm, VariableType.Ymm},
			{VariableType.YmmPs, VariableType.YmmPs},
			{VariableType.YmmPd, VariableType.YmmPd},
			{VariableType.Zmm, VariableType.Zmm},
			{VariableType.ZmmPs, VariableType.ZmmPs},
			{VariableType.ZmmPd, VariableType.ZmmPd}
		};
	}
}
