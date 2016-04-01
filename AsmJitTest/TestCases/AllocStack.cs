using System;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocStack : CompilerTestCase<Func<int>>
	{
		protected override void Compile(CodeContext c)
		{
			var stack = c.Stack(256, 1).SetSize(1);
			var i = c.IntPtr("i");
			var a = c.Int32("a");
			var b = c.Int32("b");

			var l1 = c.Label();
			var l2 = c.Label();

			// Fill stack by sequence [0, 1, 2, 3 ... 255].
			c.Xor(i, i);

			c.Bind(l1);
			c.Mov(stack.Clone().SetIndex(i), i.As8());
			c.Inc(i);
			c.Cmp(i, 255);
			c.Jle(l1);

			// Sum sequence in stack.
			c.Xor(i, i);
			c.Xor(a, a);

			c.Bind(l2);
			c.Movzx(b, stack.Clone().SetIndex(i));
			c.Add(a, b);
			c.Inc(i);
			c.Cmp(i, 255);
			c.Jle(l2);

			c.Ret(a);
		}

		protected override void Execute(Func<int> fn, out string result, out string expected)
		{
			result = fn().ToString();
			expected = 32640.ToString();
		}
	}
}