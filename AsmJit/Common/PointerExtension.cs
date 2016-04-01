using System;
using System.Runtime.InteropServices;

namespace AsmJit.Common
{
	internal static class PointerExtension
	{
		internal static T ToCallable<T>(this Pointer p, Type delegateType)
		{
			var fn = Marshal.GetDelegateForFunctionPointer(p, delegateType);
			var fd = DelegateCreator.CreateCompatibleDelegate<T>(fn, fn.Method);
			return fd;
		}
	}
}
