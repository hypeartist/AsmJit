using System;
using AsmJit.AssemblerContext;
using AsmJit.Common.Operands;

namespace AsmJitTest.TestCases
{
	public sealed class RawAssembler : AssemblerTestCase<Func<int, int, int>>
	{
		protected override void Compile(CodeContext c)
		{
			c.Push(c.Ebp);
			c.Mov(c.Ebp, c.Esp);
			c.Sub(c.Esp, 192);
			c.Push(c.Ebx);
			c.Push(c.Esi);
			c.Push(c.Edi);
			c.Lea(c.Edi, Memory.DWord(c.Ebp, -192));
			c.Mov(c.Ecx, 48);
			c.Mov(c.Eax, -858993460);
			c.RepStosd();
			c.Mov(c.Eax, Memory.DWord(c.Ebp, 8));
			c.Add(c.Eax, Memory.DWord(c.Ebp, 12));
			c.Pop(c.Edi);
			c.Pop(c.Esi);
			c.Pop(c.Ebx);
			c.Mov(c.Esp, c.Ebp);
			c.Pop(c.Ebp);
			c.Ret(8);
		}

		protected override void Execute(Func<int, int, int> fn, out string result, out string expected)
		{
			result = fn(12, 24).ToString();
			expected = (12 + 24).ToString();
		}
	}
}
