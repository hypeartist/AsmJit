using System;
using System.Globalization;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocRetDouble : CompilerTestCase<Func<double, double, double>>
	{
		protected override void Compile(CodeContext c)
		{
			var a = c.XmmSd("a");
			var b = c.XmmSd("b");

			c.SetArgument(0, a);
			c.SetArgument(1, b);

			c.Addsd(a, b);
			c.Ret(a);
		}

		protected override void Execute(Func<double, double, double> fn, out string result, out string expected)
		{
			result = fn(1.0, 2.0).ToString(CultureInfo.InvariantCulture);
			expected = (1.0 + 2.0).ToString(CultureInfo.InvariantCulture);
		}
	}
}