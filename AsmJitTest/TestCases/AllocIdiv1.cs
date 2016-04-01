using System;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocIdiv1 : CompilerTestCase<Func<IntPtr, IntPtr, int>>
	{
		protected override void Compile(CodeContext c)
		{
			var a = c.IntPtr("a");
			var b = c.IntPtr("b");

			c.SetArgument(0, a);
			c.SetArgument(1, b);

			var dummy = c.Int32("dummy");

			c.Xor(dummy, dummy);
			c.Idiv(dummy, a, b);
			c.Ret(a);
		}

		protected override void Execute(Func<IntPtr, IntPtr, int> fn, out string result, out string expected)
		{
			var v0 = 2999;
			var v1 = 245;
			result = fn((IntPtr)v0, (IntPtr)v1).ToString();
			expected = (2999/245).ToString();
		}
	}
}