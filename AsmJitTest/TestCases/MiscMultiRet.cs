using System;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class MiscMultiRet : CompilerTestCase<Func<int, int, int, int>>
	{
		protected override void Compile(CodeContext c)
		{
			var op = c.Int32("op");
			var a = c.Int32("a");
			var b = c.Int32("b");

			var zero = c.Label();
			var add = c.Label();
			var sub = c.Label();
			var mul = c.Label();
			var div = c.Label();

			c.SetArgument(0, op);
			c.SetArgument(1, a);
			c.SetArgument(2, b);

			c.Cmp(op, 0);
			c.Jz(add);

			c.Cmp(op, 1);
			c.Jz(sub);

			c.Cmp(op, 2);
			c.Jz(mul);

			c.Cmp(op, 3);
			c.Jz(div);

			c.Bind(zero);
			c.Xor(a, a);
			c.Ret(a);

			c.Bind(add);
			c.Add(a, b);
			c.Ret(a);

			c.Bind(sub);
			c.Sub(a, b);
			c.Ret(a);

			c.Bind(mul);
			c.Imul(a, b);
			c.Ret(a);

			c.Bind(div);
			c.Cmp(b, 0);
			c.Jz(zero);

			var z = c.Int32("z");
			c.Xor(z, z);
			c.Idiv(z, a, b);
			c.Ret(a);
		}

		protected override void Execute(Func<int, int, int, int> fn, out string result, out string expected)
		{
			var a = 44;
			var b = 3;

			var r0 = fn(0, a, b);
			var r1 = fn(1, a, b);
			var r2 = fn(2, a, b);
			var r3 = fn(3, a, b);

			var e0 = a + b;
			var e1 = a - b;
			var e2 = a * b;
			var e3 = a / b;

			result = string.Format("{0} {1} {2} {3}", r0, r1, r2, r3);
			expected = string.Format("{0} {1} {2} {3}", e0, e1, e2, e3);
		}
	}
}