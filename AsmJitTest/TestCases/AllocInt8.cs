using System;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocInt8 : CompilerTestCase<Func<sbyte, int>>
	{
		protected override void Compile(CodeContext c)
		{
			var x = c.Int8("x");
			var y = c.Int8("y");

			c.SetArgument(0, x);

			c.Movsx(y, x);

			c.Ret(y);
		}

		protected override void Execute(Func<sbyte, int> fn, out string result, out string expected)
		{
			result = fn(-13).ToString();
			expected = (-13).ToString();
		}
	}
}