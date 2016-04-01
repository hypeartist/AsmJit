using System;
using System.Runtime.InteropServices;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class CallMisc4 : CompilerTestCase<Func<int, int, int>>
	{
		[DllImport("kernel32.dll", EntryPoint = "LoadLibraryA")]
		public static extern unsafe IntPtr LoadLibrary([In][MarshalAs(UnmanagedType.LPStr)] string lpLibFileName);
		[DllImport("kernel32.dll", EntryPoint = "GetProcAddress")]
		public static extern unsafe IntPtr GetProcAddress([In] IntPtr hModule, [In][MarshalAs(UnmanagedType.LPStr)] string lpProcName);

		protected override void Compile(CodeContext c)
		{
			var h = LoadLibrary(IntPtr.Size > 4 ? "c:\\SampleDLL64.dll" : "c:\\SampleDLL.dll");
			var fnPtr = GetProcAddress(h, "addNumbers");

			var v0 = c.Int32("v0");
			var v1 = c.Int32("v1");
			var v2 = c.Int32("v2");

			c.SetArgument(0, v0);
			c.SetArgument(1, v1);

			var call = c.Call(Memory.Fn<Func<int, int, int>>(fnPtr));
			call.SetArgument(0, v0);
			call.SetArgument(1, v1);
			call.SetReturn(0, v2);

			c.Ret(v2);
		}

		protected override void Execute(Func<int, int, int> fn, out string result, out string expected)
		{
			result = fn(4, 5).ToString();
			expected = 9.ToString();
		}
	}
}