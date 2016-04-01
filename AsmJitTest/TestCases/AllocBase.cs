using System;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocBase : CompilerTestCase<Func<int>>
	{
		protected override void Compile(CodeContext c)
		{
			var v0 = c.Int32("v0");
			var v1 = c.Int32("v1");
			var v2 = c.Int32("v2");
			var v3 = c.Int32("v3");
			var v4 = c.Int32("v4");

			c.Xor(v0, v0);

			c.Mov(v1, 1);
			c.Mov(v2, 2);
			c.Mov(v3, 3);
			c.Mov(v4, 4);

			c.Add(v0, v1);
			c.Add(v0, v2);
			c.Add(v0, v3);
			c.Add(v0, v4);

			c.Ret(v0);
		}

		protected override void Execute(Func<int> fn, out string result, out string expected)
		{
			result = fn().ToString();
			expected = (1 + 2 + 3 + 4).ToString();
		}
	}
}