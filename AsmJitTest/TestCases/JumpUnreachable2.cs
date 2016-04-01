using System;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class JumpUnreachable2 : CompilerTestCase<Action>
	{
		protected override void Compile(CodeContext c)
		{
			var l1 = c.Label();
			var l2 = c.Label();

			var v0 = c.UInt32("v0");
			var v1 = c.UInt32("v1");

			c.Jmp(l1);
			c.Bind(l2);
			c.Mov(v0, 1);
			c.Mov(v1, 2);
			c.Cmp(v0, v1);
			c.Jz(l2);
			c.Jmp(l1);

			c.Bind(l1);
			c.Ret();
		}

		protected override void Execute(Action fn, out string result, out string expected)
		{
			result = string.Empty;
			expected = string.Empty;
			fn();
		}
	}
}