using System;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class CallConditional : CompilerTestCase<Func<int, int, int, int>>
	{
//		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
//		delegate int CalledFunctionDel(int x, int y);

		protected override void Compile(CodeContext c)
		{
			var x = c.Int32("x");
			var y = c.Int32("y");
			var op = c.Int32("op");

			c.SetArgument(0, x);
			c.SetArgument(1, y);
			c.SetArgument(2, op);

			var opAdd = c.Label();
			var opMul = c.Label();

			c.Cmp(op, 0);
			c.Jz(opAdd);
			c.Cmp(op, 1);
			c.Jz(opMul);

			var result = c.Int32("result_0");
			c.Mov(result, 0);
			c.Ret(result);

			c.Bind(opAdd);
			result = c.Int32("result_1");

//			CalledFunctionDel f = CalledFunctionAdd;
//			var call = c.Call(Memory.Fn(f));
			var call = c.Call(Memory.Fn(new Func<int, int, int>(CalledFunctionAdd)));
			call.SetArgument(0, x);
			call.SetArgument(1, y);
			call.SetReturn(0, result);
			c.Ret(result);

			c.Bind(opMul);
			result = c.Int32("result_2");

//			f = CalledFunctionMul;
//			call = c.Call(Memory.Fn(f));
			call = c.Call(Memory.Fn(new Func<int, int, int>(CalledFunctionMul)));
			call.SetArgument(0, x);
			call.SetArgument(1, y);
			call.SetReturn(0, result);

			c.Ret(result);
		}

		protected override void Execute(Func<int, int, int, int> fn, out string result, out string expected)
		{
			var add = fn(4, 8, 0);
			var mul = fn(4, 8, 1);
			result = add + " " + mul;
			expected = CalledFunctionAdd(4, 8) + " " + CalledFunctionMul(4, 8);
		}

		private static int CalledFunctionAdd(int x, int y)
		{
			return x + y;
		}

		private static int CalledFunctionMul(int x, int y)
		{
			return x * y;
		}
	}
}