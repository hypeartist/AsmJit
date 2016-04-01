using System;
using System.Globalization;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class CallDoubleAsXmmRet : CompilerTestCase<Func<double, double, double>>
	{
		protected override void Compile(CodeContext c)
		{
			var fn = c.IntPtr("fn");
			var a = c.XmmSd("a");
			var b = c.XmmSd("b");
			var ret = c.XmmSd("ret");

			c.SetArgument(0, a);
			c.SetArgument(1, b);

			var fp = Memory.Fn(new Func<double, double, double>(CalledFunction));
			c.Mov(fn, fp);

			var call = c.Call(fn, fp);
			call.SetArgument(0, a);
			call.SetArgument(1, b);
			call.SetReturn(0, ret);

			c.Ret(ret);
		}

		protected override void Execute(Func<double, double, double> fn, out string result, out string expected)
		{
			result = fn(15.5, 2.0).ToString(CultureInfo.InvariantCulture);
			expected = CalledFunction(15.5, 2.0).ToString(CultureInfo.InvariantCulture);
		}

		private static double CalledFunction(double a, double b)
		{
			return a * b;
		}
	}
}