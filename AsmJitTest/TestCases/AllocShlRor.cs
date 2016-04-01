using System;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocShlRor : CompilerTestCase<Action<IntPtr, int, int, int>>
	{
		protected override void Compile(CodeContext c)
		{
			var dst = c.IntPtr("dst");
			var var = c.Int32("var");
			var vShlParam = c.Int32("vShlParam");
			var vRorParam = c.Int32("vRorParam");

			c.SetArgument(0, dst);
			c.SetArgument(1, var);
			c.SetArgument(2, vShlParam);
			c.SetArgument(3, vRorParam);

			c.Shl(var, vShlParam);
			c.Ror(var, vRorParam);

			c.Mov(Memory.DWord(dst), var);
		}

		protected override void Execute(Action<IntPtr, int, int, int> fn, out string result, out string expected)
		{
			var v0 = 0x000000FF;
			int resultRet;
			unsafe
			{				
				fn((IntPtr)(&resultRet), v0, 16, 8);
			}
			result = resultRet.ToString();
			expected = 0x0000FF00.ToString();
		}
	}
}