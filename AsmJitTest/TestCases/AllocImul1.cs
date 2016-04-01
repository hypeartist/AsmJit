using System;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocImul1 : CompilerTestCase<Action<IntPtr, IntPtr, int, int>>
	{
		protected override void Compile(CodeContext c)
		{
			var dstHi = c.IntPtr("dstHi");
			var dstLo = c.IntPtr("dstLo");
			var vLo = c.Int32("vLo");
			var src = c.Int32("src");

			c.SetArgument(0, dstHi);
			c.SetArgument(1, dstLo);
			c.SetArgument(2, vLo);
			c.SetArgument(3, src);

			var vHi = c.Int32("vHi");

			c.Imul(vHi, vLo, src);

			c.Mov(Memory.DWord(dstHi), vHi);
			c.Mov(Memory.DWord(dstLo), vLo);
		}

		protected override void Execute(Action<IntPtr, IntPtr, int, int> fn, out string result, out string expected)
		{
			var v0 = 4;
			var v1 = 4;
			int resultHi;
			int resultLo;
			unsafe
			{
				fn((IntPtr)(&resultHi), (IntPtr)(&resultLo), v0, v1);
			}
			result = resultHi + " " + resultLo;
			expected = "0" + " " + v0*v1;
		}
	}
}