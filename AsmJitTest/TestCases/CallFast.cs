using System;
using AsmJit.Common;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class CallFast : CompilerTestCase<Func<int, int>>
	{
		protected override void Compile(CodeContext c)
		{
			var var = c.Int32("var");
			var fn = c.IntPtr("fn");

			c.SetArgument(0, var);

			var fp = Memory.Fn(new Func<int, int>(CalledFunction)/*, CallingConvention.HostDefaultFast*/);
			c.Mov(fn, fp);

			var call = c.Call(fn, fp);
			call.SetArgument(0, var);
			call.SetReturn(0, var);

			call = c.Call(fn, fp);
			call.SetArgument(0, var);
			call.SetReturn(0, var);

			c.Ret(var);
		}

		protected override void Execute(Func<int, int> fn, out string result, out string expected)
		{
			result = fn(9).ToString();
			expected = ((9*9)*(9*9)).ToString();
		}

		private static int CalledFunction(int a)
		{
			return a * a;
		}
	}
}