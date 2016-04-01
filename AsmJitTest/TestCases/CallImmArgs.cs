using System;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class CallImmArgs : CompilerTestCase<Func<int>>
	{
		protected override void Compile(CodeContext c)
		{
			var fn = c.IntPtr("fn");
			var rv = c.Int32("rv");

			var fp = Memory.Fn(new Func<int, int, int, int, int, int, int, int, int, int, int>(CalledFunction));
			c.Mov(fn, fp);

			var call = c.Call(fn, fp);
			call.SetArgument(0, 0x03);
			call.SetArgument(1, 0x12);
			call.SetArgument(2, 0xA0);
			call.SetArgument(3, 0x0B);
			call.SetArgument(4, 0x2F);
			call.SetArgument(5, 0x02);
			call.SetArgument(6, 0x0C);
			call.SetArgument(7, 0x12);
			call.SetArgument(8, 0x18);
			call.SetArgument(9, 0x1E);
			call.SetReturn(0, rv);

			c.Ret(rv);
		}

		protected override void Execute(Func<int> fn, out string result, out string expected)
		{
			result = fn().ToString();
			expected = CalledFunction(0x03, 0x12, 0xA0, 0x0B, 0x2F, 0x02, 0x0C, 0x12, 0x18, 0x1E).ToString();
		}

		private static int CalledFunction(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
		{
			return (a * b * c * d * e) + (f * g * h * i * j);
		}
	}
}