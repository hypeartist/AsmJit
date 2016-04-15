using System;
using System.Runtime.InteropServices;
using System.Security;
using AsmJit.Common;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;
using AsmJitTest.TestCases;

namespace AsmJitTest
{
	class Program
	{
		private static bool _generateAsmListing = false;

		private static Action<IntPtr, IntPtr, UIntPtr> Make()
		{
			var c = Compiler.CreateContext<Action<IntPtr, IntPtr, UIntPtr>>();

			var dst = c.IntPtr("dst");
			var src = c.IntPtr("src");

			var i = c.IntPtr("i");
			var j = c.IntPtr("j");
			var t = c.IntPtr("t");

			var cZero = c.Xmm("cZero");
			var cMul255A = c.Xmm("cMul255A");
			var cMul255M = c.Xmm("cMul255M");

			var x0 = c.Xmm("x0");
			var x1 = c.Xmm("x1");
			var y0 = c.Xmm("y0");
			var a0 = c.Xmm("a0");
			var a1 = c.Xmm("a1");

			var smallLoop = c.Label();
			var smallEnd = c.Label();

			var largeLoop = c.Label();
			var largeEnd = c.Label();

			var data = c.Label();

			c.SetArgument(0, dst);
			c.SetArgument(1, src);
			c.SetArgument(2, i);

			c.Allocate(dst);
			c.Allocate(src);
			c.Allocate(i);

			// How many pixels have to be processed to make the loop aligned.
			c.Lea(t, Memory.Ptr(data));
			c.Xor(j, j);
			c.Xorps(cZero, cZero);

			c.Sub(j, dst);
			c.Movaps(cMul255A, Memory.Ptr(t, 0));

			c.And(j, 15);
			c.Movaps(cMul255M, Memory.Ptr(t, 16));

			c.Shr(j, 2);
			c.Jz(smallEnd);

			// j = min(i, j).
			c.Cmp(j, i);
			c.Cmovg(j, i);

			// i -= j.
			c.Sub(i, j);

			// Small loop.
			c.Bind(smallLoop);

			c.Pcmpeqb(a0, a0);
			c.Movd(y0, Memory.Ptr(src));

			c.Pxor(a0, y0);
			c.Movd(x0, Memory.Ptr(dst));

			c.Psrlw(a0, 8);
			c.Punpcklbw(x0, cZero);

			c.Pshuflw(a0, a0, AsmJit.Common.Utils.Shuffle(1, 1, 1, 1));
			c.Punpcklbw(y0, cZero);

			c.Pmullw(x0, a0);
			c.Paddsw(x0, cMul255A);
			c.Pmulhuw(x0, cMul255M);

			c.Paddw(x0, y0);
			c.Packuswb(x0, x0);

			c.Movd(Memory.Ptr(dst), x0);

			c.Add(dst, 4);
			c.Add(src, 4);

			c.Dec(j);
			c.Jnz(smallLoop);

			// Second section, prepare for an aligned loop.
			c.Bind(smallEnd);

			c.Test(i, i);
			c.Mov(j, i);
			c.Jz(c.Exit);

			c.And(j, 3);
			c.Shr(i, 2);
			c.Jz(largeEnd);

			// Aligned loop.
			c.Bind(largeLoop);

			c.Movups(y0, Memory.Ptr(src));
			c.Pcmpeqb(a0, a0);
			c.Movaps(x0, Memory.Ptr(dst));

			c.Xorps(a0, y0);
			c.Movaps(x1, x0);

			c.Psrlw(a0, 8);
			c.Punpcklbw(x0, cZero);

			c.Movaps(a1, a0);
			c.Punpcklwd(a0, a0);

			c.Punpckhbw(x1, cZero);
			c.Punpckhwd(a1, a1);

			c.Pshufd(a0, a0, AsmJit.Common.Utils.Shuffle(3, 3, 1, 1));
			c.Pshufd(a1, a1, AsmJit.Common.Utils.Shuffle(3, 3, 1, 1));

			c.Pmullw(x0, a0);
			c.Pmullw(x1, a1);

			c.Paddsw(x0, cMul255A);
			c.Paddsw(x1, cMul255A);

			c.Pmulhuw(x0, cMul255M);
			c.Pmulhuw(x1, cMul255M);

			c.Add(src, 16);
			c.Packuswb(x0, x1);

			c.Paddw(x0, y0);
			c.Movaps(Memory.Ptr(dst), x0);

			c.Add(dst, 16);

			c.Dec(i);
			c.Jnz(largeLoop);

			c.Bind(largeEnd);
			c.Test(j, j);
			c.Jnz(smallLoop);

			// Data
			c.Data(data, 16,
				Data.Of(0x0080008000800080, 0x0080008000800080),
				Data.Of(0x0101010101010101, 0x0080008000800080));

			return c.Compile();
		}

		private static uint BlendSrcOver(uint d, uint s)
		{
			var saInv = ~s >> 24;

			var d20 = (d) & 0x00FF00FF;
			var d31 = (d >> 8) & 0x00FF00FF;

			d20 *= saInv;
			d31 *= saInv;

			d20 = ((d20 + ((d20 >> 8) & 0x00FF00FFU) + 0x00800080U) & 0xFF00FF00U) >> 8;
			d31 = ((d31 + ((d31 >> 8) & 0x00FF00FFU) + 0x00800080U) & 0xFF00FF00U);

			return d20 + d31 + s;
		}


		private static void RunTest()
		{
			const int cnt = 17;

			var d = new uint[] { 0x00000000, 0x10101010, 0x20100804, 0x30200003, 0x40204040, 0x5000004D, 0x60302E2C, 0x706F6E6D, 0x807F4F2F, 0x90349001, 0xA0010203, 0xB03204AB, 0xC023AFBD, 0xD0D0D0C0, 0xE0AABBCC, 0xFFFFFFFF, 0xF8F4F2F1 };
			var s = new uint[] { 0xE0E0E0E0, 0xA0008080, 0x341F1E1A, 0xFEFEFEFE, 0x80302010, 0x49490A0B, 0x998F7798, 0x00000000, 0x01010101, 0xA0264733, 0xBAB0B1B9, 0xFF000000, 0xDAB0A0C1, 0xE0BACFDA, 0x99887766, 0xFFFFFF80, 0xEE0A5FEC };

			var rawptr = Marshal.AllocHGlobal((cnt + 3) * sizeof(uint) + 8);
			var pdst = new IntPtr(16 * (((long)rawptr + 15) / 16));

			rawptr = Marshal.AllocHGlobal((cnt + 3) * sizeof(uint) + 8);
			var psrc = new IntPtr(16 * (((long)rawptr + 15) / 16));

			UnsafeMemory.Copy(pdst, Marshal.UnsafeAddrOfPinnedArrayElement(d, 0), cnt * sizeof(uint));
			UnsafeMemory.Copy(psrc, Marshal.UnsafeAddrOfPinnedArrayElement(s, 0), cnt * sizeof(uint));

			var t1 = new ExecutionTimer();
			var t2 = new ExecutionTimer();

			t1.Start();
			for (int i = 0; i < 1000000; i++)
			{
				var e = new uint[cnt];
				for (var z = 0; z < cnt; z++)
				{
					e[z] = BlendSrcOver(d[z], s[z]);
				}	
			}
			t1.Stop();
			var tt1 = t1.Milliseconds;

			var fn = Make();

			t2.Start();
			for (int i = 0; i < 1000000; i++)
			{
				fn(pdst, psrc, (UIntPtr)cnt);
			}
			t2.Stop();
			var tt2 = t2.Milliseconds;

			Console.WriteLine("NET: " + tt1);
			Console.WriteLine("Asm: " + tt2);
			Console.ReadKey();

			UnsafeMemory.Copy(Marshal.UnsafeAddrOfPinnedArrayElement(d, 0), pdst, cnt * sizeof(uint));
		}

		static void Main(string[] arguments)
		{
////			var cpuid = Cpuid.Get();
////
////			Console.WriteLine("CPU:\t" + cpuid.Cpu);
////			Console.WriteLine();
////			Console.WriteLine("\tCache size:\t\t" + cpuid.CacheSize);
////			Console.WriteLine("\tCache line size:\t" + cpuid.CacheLineSize);
////			Console.WriteLine();
////			Console.WriteLine("Extensions: ");
////			Console.WriteLine("\tSSE:\t" + (cpuid.Sse ? "Yes" : "No"));
////			Console.WriteLine("\tSSE2:\t" + (cpuid.Sse2 ? "Yes" : "No"));
////			Console.WriteLine("\tSSE3:\t" + (cpuid.Sse3 ? "Yes" : "No"));
////			Console.WriteLine("\tSSE4.1:\t" + (cpuid.Sse41 ? "Yes" : "No"));
////			Console.WriteLine("\tSSE4.2:\t" + (cpuid.Sse42 ? "Yes" : "No"));
////			Console.WriteLine("\tAVX:\t" + (cpuid.Avx ? "Yes" : "No"));
////			Console.WriteLine("\tAVX2:\t" + (cpuid.Avx2 ? "Yes" : "No"));
////			Console.WriteLine();
//
//			var tr = new TestCaseRunner(_generateAsmListing);
//
////			tr.Add(new JumpCross());
////			tr.Add(new JumpUnreachable1());
////			tr.Add(new JumpUnreachable2());
////			tr.Add(new AllocBase());
////			tr.Add(new AllocManual());
////			tr.Add(new AllocUseMem());
////			tr.Add(new AllocMany1());
////			tr.Add(new AllocMany2());
////			tr.Add(new AllocImul1());
////			tr.Add(new AllocImul2());
////			tr.Add(new AllocIdiv1());
////			tr.Add(new AllocSetz());
////			tr.Add(new AllocShlRor());
////			tr.Add(new AllocGpLo());
////			tr.Add(new AllocRepMovsb());
////			tr.Add(new AllocIfElse1());
////			tr.Add(new AllocIfElse2());
////			tr.Add(new AllocIfElse3());
////			tr.Add(new AllocIfElse4());
////			tr.Add(new AllocInt8());
////			tr.Add(new AllocArgsIntPtr());
////			tr.Add(new AllocArgsFloat());
////			tr.Add(new AllocArgsDouble());
////			tr.Add(new AllocRetFloat());
////			tr.Add(new AllocRetDouble());
////			tr.Add(new AllocStack());
////			tr.Add(new AllocMemcpy());
////			tr.Add(new AllocBlend());
////			tr.Add(new CallBase());
////			tr.Add(new CallFast());
////			tr.Add(new CallManyArgs());
////			tr.Add(new CallDuplicateArgs());
////			tr.Add(new CallImmArgs());
////			tr.Add(new CallPtrArgs());
////			tr.Add(new CallFloatAsXmmRet());
////			tr.Add(new CallDoubleAsXmmRet());
//			tr.Add(new CallConditional());
////			tr.Add(new CallMultiple());
////			tr.Add(new CallRecursive());
////			tr.Add(new CallMisc1());
////			tr.Add(new CallMisc2());
////			tr.Add(new CallMisc3());
////			tr.Add(new CallMisc4());
////			tr.Add(new MiscConstPool());
////			tr.Add(new MiscMultiRet());
////
////			tr.Add(new RawAssembler());
//
//			var resTrue = 0;
//			var resFalse = 0;
//
//			foreach (var data in tr.Run())
//			{
//				var result = data.Item1;
//				Console.WriteLine(result);
//				if (result)
//				{
//					resTrue++;
//				}
//				else
//				{
//					resFalse++;
//				}
//				if (_generateAsmListing)
//				{
//					var asm = data.Item2;
//					Console.Write(asm);
//				}
//			}
//			Console.WriteLine();
//			Console.WriteLine("Passed:\t" + resTrue);
//			Console.WriteLine("Failed:\t" + resFalse);
//			Console.ReadKey();
			RunTest();
		}
	}

	public class ExecutionTimer
	{

		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32", EntryPoint = "QueryPerformanceCounter")]
		public static extern uint QueryPerformanceCounter(ref long t);

		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32", EntryPoint = "QueryPerformanceFrequency")]
		public static extern uint QueryPerformanceFrequency(ref long t);

		private long _startTime;
		private long _stopTime;
		private long _freq;

		public ExecutionTimer()
		{
			_startTime = 0;
			_stopTime = 0;
		}

		public void Start()
		{
			QueryPerformanceFrequency(ref _freq);
			QueryPerformanceCounter(ref _startTime);
		}

		public void Stop()
		{
			QueryPerformanceCounter(ref _stopTime);
		}

		public double Milliseconds
		{
			get
			{
				return ((_stopTime - _startTime) * 1000.0) / _freq;
			}
		}
	}
}
