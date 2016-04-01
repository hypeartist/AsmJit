using System;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class CallDuplicateArgs : CompilerTestCase<Func<int>>
	{
		protected override void Compile(CodeContext c)
		{
			var fn = c.IntPtr("fn");
			var a = c.Int32("a");

			var fp = Memory.Fn(new Func<int, int, int, int, int, int, int, int, int, int, int>(CalledFunction));
			c.Mov(fn, fp);
			c.Mov(a, 3);

			var call = c.Call(fn, fp);
			call.SetArgument(0, a);
			call.SetArgument(1, a);
			call.SetArgument(2, a);
			call.SetArgument(3, a);
			call.SetArgument(4, a);
			call.SetArgument(5, a);
			call.SetArgument(6, a);
			call.SetArgument(7, a);
			call.SetArgument(8, a);
			call.SetArgument(9, a);
			call.SetReturn(0, a);

			c.Ret(a);
		}

		protected override void Execute(Func<int> fn, out string result, out string expected)
		{
			result = fn().ToString();
			expected = CalledFunction(3, 3, 3, 3, 3, 3, 3, 3, 3, 3).ToString();
		}

		private static int CalledFunction(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
		{
			return (a * b * c * d * e) + (f * g * h * i * j);
		}
	}
}