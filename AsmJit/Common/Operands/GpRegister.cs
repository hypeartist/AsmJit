using System.Collections.Generic;

namespace AsmJit.Common.Operands
{
	public sealed class GpRegister : Register
	{
		private static Dictionary<GpRegisterType, int> _sizeMap = new Dictionary<GpRegisterType, int>
		{
			{GpRegisterType.GpbLo, 1},
			{GpRegisterType.GpbHi, 1},
			{GpRegisterType.Gpw, 2},
			{GpRegisterType.Gpd, 4},
			{GpRegisterType.Gpq, 8}
		};  

		internal GpRegister(GpRegister other)
			: base(other)
		{
		}

		internal GpRegister(GpRegisterType type, int index)
		{
			RegisterType = (RegisterType) type;
			Index = index;
			Size = _sizeMap[type];
		}
	}
}