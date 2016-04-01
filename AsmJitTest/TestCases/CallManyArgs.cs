using System;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class CallManyArgs : CompilerTestCase<Func<int>>
	{
		protected override void Compile(CodeContext c)
		{
			var fn = c.IntPtr("fn");
			var va = c.Int32("va");
			var vb = c.Int32("vb");
			var vc = c.Int32("vc");
			var vd = c.Int32("vd");
			var ve = c.Int32("ve");
			var vf = c.Int32("vf");
			var vg = c.Int32("vg");
			var vh = c.Int32("vh");
			var vi = c.Int32("vi");
			var vj = c.Int32("vj");

			var fp = Memory.Fn(new Func<int, int, int, int, int, int, int, int, int, int, int>(CalledFunction));

			c.Mov(fn, fp);
			c.Mov(va, 0x03);
			c.Mov(vb, 0x12);
			c.Mov(vc, 0xA0);
			c.Mov(vd, 0x0B);
			c.Mov(ve, 0x2F);
			c.Mov(vf, 0x02);
			c.Mov(vg, 0x0C);
			c.Mov(vh, 0x12);
			c.Mov(vi, 0x18);
			c.Mov(vj, 0x1E);

			var call = c.Call(fn, fp);
			call.SetArgument(0, va);
			call.SetArgument(1, vb);
			call.SetArgument(2, vc);
			call.SetArgument(3, vd);
			call.SetArgument(4, ve);
			call.SetArgument(5, vf);
			call.SetArgument(6, vg);
			call.SetArgument(7, vh);
			call.SetArgument(8, vi);
			call.SetArgument(9, vj);
			call.SetReturn(0, va);

			c.Ret(va);
		}

		protected override void Execute(Func<int> fn, out string result, out string expected)
		{
			result = fn().ToString();
			expected = CalledFunction(0x03, 0x12, 0xA0, 0x0B, 0x2F, 0x02, 0x0C, 0x12, 0x18, 0x1E).ToString();
		}

		private static int CalledFunction(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
		{
			return (a * b * c * d * e) + (f * g * h * i * j);
		}
	}
}