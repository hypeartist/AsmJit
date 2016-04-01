using System;
using System.Globalization;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocArgsDouble : CompilerTestCase<Action<double, double, double, double, double, double, double, IntPtr>>
	{
		protected override void Compile(CodeContext c)
		{
			const int cnt = 7;

			var p = c.IntPtr("p");
			var xv = new XmmVariable[cnt];

			int i;
			for (i = 0; i < cnt; i++)
			{
				xv[i] = c.XmmSd("xv" + i);
				c.SetArgument(i, xv[i]);
			}
			c.SetArgument(7, p);

			c.Addsd(xv[0], xv[1]);
			c.Addsd(xv[0], xv[2]);
			c.Addsd(xv[0], xv[3]);
			c.Addsd(xv[0], xv[4]);
			c.Addsd(xv[0], xv[5]);
			c.Addsd(xv[0], xv[6]);

			c.Movsd(Memory.Ptr(p), xv[0]);
		}

		protected override void Execute(Action<double, double, double, double, double, double, double, IntPtr> fn, out string result, out string expected)
		{
			unsafe
			{
				double resultRet;
				fn(1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, (IntPtr)(&resultRet));

				result = resultRet.ToString(CultureInfo.InvariantCulture);
				expected = (1.0 + 2.0 + 3.0 + 4.0 + 5.0 + 6.0 + 7.0).ToString(CultureInfo.InvariantCulture);
			}
		}
	}
}