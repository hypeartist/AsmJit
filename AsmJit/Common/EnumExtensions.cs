using System;

namespace AsmJit.Common
{
	public static class EnumExtensions
	{
		public static bool IsSet(this Enum value, Enum flag)
		{
			return (Convert.ToInt64(value) & Convert.ToInt64(flag)) != 0;
		}
	}
}