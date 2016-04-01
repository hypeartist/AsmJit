using System;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocUseMem : CompilerTestCase<Func<int, int, int>>
	{
		protected override void Compile(CodeContext c)
		{
			var l1 = c.Label();

			var iIdx = c.Int32("iIdx");
			var iEnd = c.Int32("iEnd");

			var aIdx = c.Int32("aIdx");
			var aEnd = c.Int32("aEnd");

			c.SetArgument(0, aIdx);
			c.SetArgument(1, aEnd);

			c.Mov(iIdx, aIdx);
			c.Mov(iEnd, aEnd);
			c.Spill(iEnd);

			c.Bind(l1);
			c.Inc(iIdx);
			c.Cmp(iIdx, iEnd.ToMemory());
			c.Jne(l1);

			c.Ret(iIdx);
		}

		protected override void Execute(Func<int, int, int> fn, out string result, out string expected)
		{
			result = fn(10, 20).ToString();
			expected = 20.ToString();
		}
	}
}