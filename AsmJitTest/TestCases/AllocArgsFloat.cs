using System;
using System.Globalization;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocArgsFloat : CompilerTestCase<Action<float, float, float, float, float, float, float, IntPtr>>
	{
		protected override void Compile(CodeContext c)
		{
			const int cnt = 7;

			var p = c.IntPtr("p");
			var xv = new XmmVariable[cnt];

			int i;
			for (i = 0; i < cnt; i++)
			{
				xv[i] = c.XmmSs("xv" + i);
				c.SetArgument(i, xv[i]);
			}
			c.SetArgument(7, p);

			c.Addss(xv[0], xv[1]);
			c.Addss(xv[0], xv[2]);
			c.Addss(xv[0], xv[3]);
			c.Addss(xv[0], xv[4]);
			c.Addss(xv[0], xv[5]);
			c.Addss(xv[0], xv[6]);

			c.Movss(Memory.Ptr(p), xv[0]);
		}

		protected override void Execute(Action<float, float, float, float, float, float, float, IntPtr> fn, out string result, out string expected)
		{
			unsafe
			{
				float resultRet;
				fn(1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 7.0f, (IntPtr)(&resultRet));

				result = resultRet.ToString(CultureInfo.InvariantCulture);
				expected = (1.0f + 2.0f + 3.0f + 4.0f + 5.0f + 6.0f + 7.0f).ToString(CultureInfo.InvariantCulture);
			}
		}
	}
}