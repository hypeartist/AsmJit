using System;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class MiscConstPool : CompilerTestCase<Func<int>>
	{
		protected override void Compile(CodeContext c)
		{
			var v0 = c.Int32("v0");
			var v1 = c.Int32("v1");

			var c0 = c.Int32Const(ConstantScope.Local, 200);
			var c1 = c.Int32Const(ConstantScope.Local, 33);

			c.Mov(v0, c0);
			c.Mov(v1, c1);
			c.Add(v0, v1);

			c.Ret(v0);
		}

		protected override void Execute(Func<int> fn, out string result, out string expected)
		{
			result = fn().ToString();
			expected = 233.ToString();
		}
	}
}