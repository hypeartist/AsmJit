using System;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class CallBase : CompilerTestCase<Func<int, int, int, int>>
	{
		protected override void Compile(CodeContext c)
		{
			var v0 = c.Int32("v0");
			var v1 = c.Int32("v1");
			var v2 = c.Int32("v2");

			c.SetArgument(0, v0);
			c.SetArgument(1, v1);
			c.SetArgument(2, v2);

			var fp = Memory.Fn(new Func<int, int, int, int>(CalledFunction));

			// Just do something.
			c.Shl(v0, 1);
			c.Shl(v1, 1);
			c.Shl(v2, 1);

			var fn = c.IntPtr("fn");
			c.Mov(fn, fp);

			var call = c.Call(fn, fp);
			call.SetArgument(0, v2);
			call.SetArgument(1, v1);
			call.SetArgument(2, v0);
			call.SetReturn(0, v0);

			c.Ret(v0);
		}

		protected override void Execute(Func<int, int, int, int> fn, out string result, out string expected)
		{
			result = fn(3, 2, 1).ToString();
			expected = 36.ToString();
		}

		private static int CalledFunction(int a, int b, int c)
		{
			return (a + b) * c;
		}
	}
}