using System;
using AsmJit.Common;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class CallMultiple : CompilerTestCase<Func<IntPtr, int>>
	{
		protected override void Compile(CodeContext c)
		{
			int i;

			var buf = c.IntPtr("buf");
			var acc0 = c.Int32("acc0");
			var acc1 = c.Int32("acc1");

			c.SetArgument(0, buf);

			c.Mov(acc0, 0);
			c.Mov(acc1, 0);

			for (i = 0; i < 4; i++)
			{
				var ret = c.Int32("ret");
				var ptr = c.IntPtr("ptr");
				var idx = c.Int32("idx");

				c.Mov(ptr, buf);
				c.Mov(idx, i);

				var call = c.Call(Memory.Fn(new Func<IntPtr, int, int>(CalledFunction)/*, CallingConvention.HostDefaultFast*/));
				call.SetArgument(0, ptr);
				call.SetArgument(1, idx);
				call.SetReturn(0, ret);

				c.Add(acc0, ret);

				c.Mov(ptr, buf);
				c.Mov(idx, i);

				call = c.Call(Memory.Fn(new Func<IntPtr, int, int>(CalledFunction)/*, CallingConvention.HostDefaultFast*/));
				call.SetArgument(0, ptr);
				call.SetArgument(1, idx);
				call.SetReturn(0, ret);

				c.Sub(acc1, ret);
			}

			c.Add(acc0, acc1);
			c.Ret(acc0);
		}

		protected override void Execute(Func<IntPtr, int> fn, out string result, out string expected)
		{
			var ar = new[] { 127, 87, 23, 17 };
			unsafe
			{
				fixed (int* buffer = ar)
				{
					result = fn((IntPtr)buffer).ToString();
				}
			}
			expected = 0.ToString();
		}

		private static unsafe int CalledFunction(IntPtr pInt, int index)
		{
			return ((int*)pInt)[index];
		}
	}
}