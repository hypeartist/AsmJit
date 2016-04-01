using System;
using AsmJit.Common;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocMany2 : CompilerTestCase<Action<IntPtr>>
	{
		protected override void Compile(CodeContext c)
		{
			var var = new GpVariable[32];

			var a = c.IntPtr("a");

			c.SetArgument(0, a);

			int i;
			for (i = 0; i < var.Length; i++)
			{
				var[i] = c.Int32("var" + i);
			}

			for (i = 0; i < var.Length; i++)
			{
				c.Xor(var[i], var[i]);
			}

			var v0 = c.Int32("v0");
			var l = c.Label();

			c.Mov(v0, 32);
			c.Bind(l);

			for (i = 0; i < var.Length; i++)
			{
				c.Add(var[i], i);
			}

			c.Dec(v0);
			c.Jnz(l);

			for (i = 0; i < var.Length; i++)
			{
				c.Mov(Memory.DWord(a, i * 4), var[i]);
			}
		}

		protected override void Execute(Action<IntPtr> fn, out string result, out string expected)
		{
			var x = new int[32];
			unsafe
			{

				fixed (int* px = x)
				{
					fn((IntPtr) px);
				}
			}
			result = string.Join(",", x);
			expected = string.Join(",", new int[32].InitializeWith(i => i * 32));
		}
	}
}