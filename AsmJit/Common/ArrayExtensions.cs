using System;

namespace AsmJit.Common
{
	public static class ArrayExtensions
	{
		public static T[] InitializeWith<T>(this T[] a, Func<T> fn)
		{
			for (var i = 0; i < a.Length; i++)
			{
				a[i] = fn();
			}
			return a;
		}

		public static T[] InitializeWith<T>(this T[] a, Func<int, T> fn)
		{
			for (var i = 0; i < a.Length; i++)
			{
				a[i] = fn(i);
			}
			return a;
		}
	}
}
