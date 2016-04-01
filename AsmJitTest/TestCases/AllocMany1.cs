using System;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocMany1 : CompilerTestCase<Action<IntPtr, IntPtr>>
	{
		protected override void Compile(CodeContext c)
		{
			const int count = 8;

			var a0 = c.IntPtr("a0");
			var a1 = c.IntPtr("a1");

			c.SetArgument(0, a0);
			c.SetArgument(1, a1);

			// Create some variables.
			var t = c.Int32("t");
			var x = new GpVariable[count];

			int i;
			for (i = 0; i < count; i++)
			{
				x[i] = c.Int32("x" + i);
			}

			// Setup variables (use mov with reg/imm to se if register allocator works).
			for (i = 0; i < count; i++)
			{
				c.Mov(x[i], i + 1);
			}

			// Make sum (addition).
			c.Xor(t, t);
			for (i = 0; i < count; i++)
			{
				c.Add(t, x[i]);
			}

			// Store result to a given pointer in first argument.
			c.Mov(Memory.DWord(a0), t);

			// Clear t.
			c.Xor(t, t);

			// Make sum (subtraction).
			for (i = 0; i < count; i++)
			{
				c.Sub(t, x[i]);
			}

			// Store result to a given pointer in second argument.
			c.Mov(Memory.DWord(a1), t);
		}

		protected override void Execute(Action<IntPtr, IntPtr> fn, out string result, out string expected)
		{
			int x;
			int y;
			unsafe
			{
				fn((IntPtr) (&x), (IntPtr) (&y));
			}
			result = x + " " + y;
			expected = 36 + " " + -36;
		}
	}
}