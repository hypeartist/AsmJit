using System;
using AsmJit.AssemblerContext;
using AsmJit.Common.Operands;
using CodeContext = AsmJit.CompilerContext.CodeContext;

namespace AsmJitTest.TestCases
{
	public sealed class CallMisc1 : CompilerTestCase<Func<int, int, int>>
	{
		protected override void Compile(CodeContext c)
		{
			var a = c.Int32("a");
			var b = c.Int32("b");
			var r = c.Int32("r");

			c.SetArgument(0, a);
			c.SetArgument(1, b);

			c.Allocate(a, Cpu.Registers.Eax);
			c.Allocate(b, Cpu.Registers.Ebx);

			var call = c.Call(Memory.Fn(new Action<int, int>(CalledFunction)));
			call.SetArgument(0, a);
			call.SetArgument(1, b);

			c.Lea(r, Memory.Ptr(a, b));
			c.Ret(r);
		}

		protected override void Execute(Func<int, int, int> fn, out string result, out string expected)
		{
			result = fn(44, 199).ToString();
			expected = 243.ToString();
		}

		private static void CalledFunction(int a, int b)
		{
		}
	}
}