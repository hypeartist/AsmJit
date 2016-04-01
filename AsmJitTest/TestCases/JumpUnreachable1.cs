using System;
using AsmJit.Common;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class JumpUnreachable1 : CompilerTestCase<Action>
	{
		protected override void Compile(CodeContext c)
		{
			var l1 = c.Label();
			var l2 = c.Label();
			var l3 = c.Label();
			var l4 = c.Label();
			var l5 = c.Label();
			var l6 = c.Label();
			var l7 = c.Label();

			var v0 = c.UInt32("v0");
			var v1 = c.UInt32("v1");

			c.Bind(l2);
			c.Bind(l3);

			c.Jmp(l1);

			c.Bind(l5);
			c.Mov(v0, 0);

			c.Bind(l6);
			c.Jmp(l3);
			c.Mov(v1, 1);
			c.Jmp(l1);

			c.Bind(l4);
			c.Jmp(l2);
			c.Bind(l7);
			c.Add(v0, v1);

			c.Align(AligningMode.Code, 16);
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