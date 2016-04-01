using System;
using System.Runtime.InteropServices;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocRepMovsb : CompilerTestCase<Action<IntPtr, IntPtr, int>>
	{
		protected override void Compile(CodeContext c)
		{
			var dst = c.IntPtr("dst");
			var src = c.IntPtr("src");
			var cnt = c.IntPtr("cnt");

			c.SetArgument(0, dst);
			c.SetArgument(1, src);
			c.SetArgument(2, cnt);

			c.RepMovsb(dst, src, cnt);
		}

		protected override void Execute(Action<IntPtr, IntPtr, int> fn, out string result, out string expected)
		{
			const string str = "Hello AsmJit!";
			string sdst;
			unsafe
			{				
				var dst = stackalloc byte[str.ToCharArray().Length];
				var src = Marshal.StringToHGlobalAnsi(str);
				fn((IntPtr)dst, src, str.ToCharArray().Length);
				sdst = Marshal.PtrToStringAnsi((IntPtr)dst);
			}
			result = sdst;
			expected = str;
		}
	}
}