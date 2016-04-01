using System;
using AsmJit.Common;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocMemcpy : CompilerTestCase<Action<IntPtr, IntPtr, UIntPtr>>
	{
		protected override void Compile(CodeContext c)
		{
			var dst = c.IntPtr("dst");
			var src = c.IntPtr("src");
			var cnt = c.UIntPtr("cnt");

			var loop = c.Label(); // Create base labels we use
			var exit = c.Label(); // in our function.

			c.SetArgument(0, dst);
			c.SetArgument(1, src);
			c.SetArgument(2, cnt);

			c.Allocate(dst); // Allocate all registers now,
			c.Allocate(src); // because we want to keep them
			c.Allocate(cnt); // in physical registers only.

			c.Test(cnt, cnt); // Exit if length is zero.
			c.Jz(exit);

			c.Bind(loop); // Bind the loop label here.

			var tmp = c.Int32("tmp"); // Copy a single dword (4 bytes).
			c.Mov(tmp, Memory.DWord(src));
			c.Mov(Memory.DWord(dst), tmp);

			c.Add(src, 4); // Increment dst/src pointers.
			c.Add(dst, 4);

			c.Dec(cnt); // Loop until cnt isn't zero.
			c.Jnz(loop);

			c.Bind(exit); // Bind the exit label here.
		}

		protected override void Execute(Action<IntPtr, IntPtr, UIntPtr> fn, out string result, out string expected)
		{
			unsafe
			{
				const int cnt = 32;
				var a = new int[cnt].InitializeWith(i => i);
				var b = new int[cnt];

				fixed (int* src = a)
				{
					fixed (int* dst = b)
					{
						fn((IntPtr)dst, (IntPtr)src, (UIntPtr)cnt);
					}
				}
				result = string.Join(",", a);
				expected = string.Join(",", b);
			}
		}
	}
}