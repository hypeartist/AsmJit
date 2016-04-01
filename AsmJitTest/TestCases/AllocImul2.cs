using System;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocImul2 : CompilerTestCase<Action<IntPtr, IntPtr>>
	{
		protected override void Compile(CodeContext c)
		{
			var dst = c.IntPtr("dst");
			var src = c.IntPtr("src");

			c.SetArgument(0, dst);
			c.SetArgument(1, src);

			for (var i = 0; i < 4; i++)
			{
				var x = c.Int32("x");
				var y = c.Int32("y");
				var hi = c.Int32("hi");

				c.Mov(x, Memory.DWord(src, 0));
				c.Mov(y, Memory.DWord(src, 4));

				c.Imul(hi, x, y);
				c.Add(Memory.DWord(dst, 0), hi);
				c.Add(Memory.DWord(dst, 4), x);
			}
		}

		protected override void Execute(Action<IntPtr, IntPtr> fn, out string result, out string expected)
		{
			var src = new int[2];
			var resultRet = new int[2];
			unsafe
			{			
				src[0] = 4;
				src[1] = 9;
				
				resultRet[0] = 0;
				resultRet[1] = 0;

				fixed (int* psrc = src)
				{
					fixed (int* pres = resultRet)
					{
						fn((IntPtr)pres, (IntPtr)psrc);
					}
				}
			}
			result = resultRet[0] + " " + resultRet[1];
			expected = "0" + " " + 4*9*4;
		}
	}
}