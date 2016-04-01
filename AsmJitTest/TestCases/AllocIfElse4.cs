using System;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocIfElse4 : CompilerTestCase<Func<int, int, int>>
	{
		protected override void Compile(CodeContext c)
		{
			var v1 = c.Int32("v1");
			var v2 = c.Int32("v2");

			c.SetArgument(0, v1);
			c.SetArgument(1, v2);

			var counter = c.Int32("counter");

			var l1 = c.Label();
			var loop1 = c.Label();
			var loop2 = c.Label();
			var exit = c.Label();

			c.Mov(counter, 0);

			c.Cmp(v1, v2);
			c.Jg(l1);

			c.Bind(loop1);
			c.Mov(v1, counter);

			c.Inc(counter);
			c.Cmp(counter, 1);
			c.Jle(loop1);
			c.Jmp(exit);

			c.Bind(l1);
			c.Bind(loop2);
			c.Mov(v1, counter);
			c.Inc(counter);
			c.Cmp(counter, 2);
			c.Jle(loop2);

			c.Bind(exit);
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