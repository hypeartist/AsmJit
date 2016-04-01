using System;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocArgsIntPtr : CompilerTestCase<Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>>
	{
		protected override void Compile(CodeContext c)
		{
			const int cnt = 8;
			var var = new GpVariable[cnt];

			int i;
			for (i = 0; i < cnt; i++)
			{
				var[i] = c.IntPtr("var" + i);
				c.SetArgument(i, var[i]);
			}

			for (i = 0; i < cnt; i++)
			{
				c.Add(var[i], i + 1);
			}

			for (i = 0; i < cnt; i++)
			{
				c.Add(Memory.Byte(var[i]), i + 1);
			}
		}

		protected override void Execute(Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr> fn, out string result, out string expected)
		{
			unsafe
			{
				var a = new byte[9];
				var b = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
				fixed (byte* resultBuf = a)
				{
					fn((IntPtr)resultBuf, (IntPtr)resultBuf, (IntPtr)resultBuf, (IntPtr)resultBuf, (IntPtr)resultBuf, (IntPtr)resultBuf, (IntPtr)resultBuf, (IntPtr)resultBuf);
				}

				result = string.Join(",", a);
				expected = string.Join(",", b);
			}
		}
	}
}