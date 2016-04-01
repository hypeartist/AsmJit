using System;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocIfElse2 : CompilerTestCase<Func<int, int, int>>
	{
		protected override void Compile(CodeContext c)
		{
			var v1 = c.Int32("v1");
			var v2 = c.Int32("v2");

			c.SetArgument(0, v1);
			c.SetArgument(1, v2);

			var l1 = c.Label();
			var l2 = c.Label();
			var l3 = c.Label();
			var l4 = c.Label();

			c.Jmp(l1);
			c.Bind(l2);
			c.Jmp(l4);
			c.Bind(l1);

			c.Cmp(v1, v2);
			c.Jg(l3);

			c.Mov(v1, 1);
			c.Jmp(l2);

			c.Bind(l3);
			c.Mov(v1, 2);
			c.Jmp(l2);

			c.Bind(l4);

			c.Ret(v1);
		}

		protected override void Execute(Func<int, int, int> fn, out string result, out string expected)
		{
			var r1 = fn(0, 1);
			var r2 = fn(1, 0);

			result = r1 + " " + r2;
			expected = 1 + " " + 2;
		}
	}
}