using System;
using System.Globalization;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class CallMisc2 : CompilerTestCase<Func<IntPtr, double>>
	{
		protected override void Compile(CodeContext c)
		{
			var p = c.IntPtr("p");
			var fn = c.IntPtr("fn");

			var arg = c.XmmSd("arg");
			var ret = c.XmmSd("ret");

			var fp = Memory.Fn(new Func<double, double>(CalledFunction));

			c.SetArgument(0, p);
			c.Movsd(arg, Memory.Ptr(p));
			c.Mov(fn, fp);

			var call = c.Call(fn, fp);
			call.SetArgument(0, arg);
			call.SetReturn(0, ret);

			c.Ret(ret);
		}

		protected override void Execute(Func<IntPtr, double> fn, out string result, out string expected)
		{
			var a = 2.0;
			unsafe
			{
				result = fn((IntPtr)(&a)).ToString(CultureInfo.InvariantCulture);
			}
			expected = CalledFunction(a).ToString(CultureInfo.InvariantCulture);
		}

		private static double CalledFunction(double a)
		{
			return a*a;
		}
	}
}