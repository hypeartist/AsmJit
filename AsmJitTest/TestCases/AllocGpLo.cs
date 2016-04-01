using System;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocGpLo : CompilerTestCase<Func<UIntPtr, uint>>
	{
		private const int Cnt = 32;

		protected override void Compile(CodeContext c)
		{
			var rPtr = c.UIntPtr("rPtr");
			var rSum = c.UInt32("rSum");

			c.SetArgument(0, rPtr);

			var rVar = new GpVariable[Cnt];
			int i;
			for (i = 0; i < Cnt; i++)
			{
				rVar[i] = c.UInt32("x" + i);
			}
			// Init pseudo-regs with values from our array.
			for (i = 0; i < Cnt; i++)
			{
				c.Mov(rVar[i], Memory.DWord(rPtr, i * 4));
			}

			for (i = 2; i < Cnt; i++)
			{
				// Add and truncate to 8 bit; no purpose, just mess with jit.
				c.Add(rVar[i], rVar[i - 1]);
				c.Movzx(rVar[i], rVar[i].As8());
				c.Movzx(rVar[i - 2], rVar[i - 1].As8());
				c.Movzx(rVar[i - 1], rVar[i - 2].As8());
			}

			// Sum up all computed values.
			c.Mov(rSum, 0);
			for (i = 0; i < Cnt; i++)
			{
				c.Add(rSum, rVar[i]);
			}

			// Return the sum.
			c.Ret(rSum);
		}

		protected override void Execute(Func<UIntPtr, uint> fn, out string result, out string expected)
		{
			unsafe
			{
				uint expectRet = 0;
				var buf = stackalloc uint[Cnt];
				int i;
				for (i = 0; i < Cnt; i++)
				{
					buf[i] = 1;
				}

				for (i = 2; i < Cnt; i++)
				{
					buf[i] += buf[i - 1];
					buf[i] = buf[i] & 0xFF;
					buf[i - 2] = buf[i - 1] & 0xFF;
					buf[i - 1] = buf[i - 2] & 0xFF;
				}

				for (i = 0; i < Cnt; i++)
				{
					expectRet += buf[i];
				}

				for (i = 0; i < Cnt; i++)
				{
					buf[i] = 1;
				}

				result = fn((UIntPtr)buf).ToString();
				expected = expectRet.ToString();
			}
		}
	}
}