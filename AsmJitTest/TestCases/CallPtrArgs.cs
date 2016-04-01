using System;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class CallPtrArgs : CompilerTestCase<Func<int>>
	{
		protected override void Compile(CodeContext c)
		{
			var fn = c.IntPtr("fn");
			var rv = c.Int32("rv");

			var fp = Memory.Fn(new Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>(CalledFunction));
			c.Mov(fn, fp);

			var call = c.Call(fn, fp);
			call.SetArgument(0, 1);
			call.SetArgument(1, 2);
			call.SetArgument(2, 3);
			call.SetArgument(3, 4);
			call.SetArgument(4, 5);
			call.SetArgument(5, 6);
			call.SetArgument(6, 7);
			call.SetArgument(7, 8);
			call.SetArgument(8, 9);
			call.SetArgument(9, 10);
			call.SetReturn(0, rv);

			c.Ret(rv);
		}

		protected override void Execute(Func<int> fn, out string result, out string expected)
		{
			result = fn().ToString();
			expected = 55.ToString();
		}

		private static int CalledFunction(IntPtr a, IntPtr b, IntPtr c, IntPtr d, IntPtr e, IntPtr f, IntPtr g, IntPtr h, IntPtr i, IntPtr j)
		{
			return (a.ToInt32() + b.ToInt32() + c.ToInt32() + d.ToInt32() + e.ToInt32()) + (f.ToInt32() + g.ToInt32() + h.ToInt32() + i.ToInt32() + j.ToInt32());
		}
	}
}