using System;
using AsmJitTest.TestCases;

namespace AsmJitTest
{
	class Program
	{
		private static bool _generateAsmListing = false;

		static void Main(string[] arguments)
		{
//			var cpuid = Cpuid.Get();
//
//			Console.WriteLine("CPU:\t" + cpuid.Cpu);
//			Console.WriteLine();
//			Console.WriteLine("\tCache size:\t\t" + cpuid.CacheSize);
//			Console.WriteLine("\tCache line size:\t" + cpuid.CacheLineSize);
//			Console.WriteLine();
//			Console.WriteLine("Extensions: ");
//			Console.WriteLine("\tSSE:\t" + (cpuid.Sse ? "Yes" : "No"));
//			Console.WriteLine("\tSSE2:\t" + (cpuid.Sse2 ? "Yes" : "No"));
//			Console.WriteLine("\tSSE3:\t" + (cpuid.Sse3 ? "Yes" : "No"));
//			Console.WriteLine("\tSSE4.1:\t" + (cpuid.Sse41 ? "Yes" : "No"));
//			Console.WriteLine("\tSSE4.2:\t" + (cpuid.Sse42 ? "Yes" : "No"));
//			Console.WriteLine("\tAVX:\t" + (cpuid.Avx ? "Yes" : "No"));
//			Console.WriteLine("\tAVX2:\t" + (cpuid.Avx2 ? "Yes" : "No"));
//			Console.WriteLine();

			var tr = new TestCaseRunner(_generateAsmListing);

//			tr.Add(new JumpCross());
//			tr.Add(new JumpUnreachable1());
//			tr.Add(new JumpUnreachable2());
//			tr.Add(new AllocBase());
//			tr.Add(new AllocManual());
//			tr.Add(new AllocUseMem());
//			tr.Add(new AllocMany1());
//			tr.Add(new AllocMany2());
//			tr.Add(new AllocImul1());
//			tr.Add(new AllocImul2());
//			tr.Add(new AllocIdiv1());
//			tr.Add(new AllocSetz());
//			tr.Add(new AllocShlRor());
//			tr.Add(new AllocGpLo());
//			tr.Add(new AllocRepMovsb());
//			tr.Add(new AllocIfElse1());
//			tr.Add(new AllocIfElse2());
//			tr.Add(new AllocIfElse3());
//			tr.Add(new AllocIfElse4());
//			tr.Add(new AllocInt8());
//			tr.Add(new AllocArgsIntPtr());
//			tr.Add(new AllocArgsFloat());
//			tr.Add(new AllocArgsDouble());
//			tr.Add(new AllocRetFloat());
//			tr.Add(new AllocRetDouble());
//			tr.Add(new AllocStack());
//			tr.Add(new AllocMemcpy());
//			tr.Add(new AllocBlend());
//			tr.Add(new CallBase());
//			tr.Add(new CallFast());
//			tr.Add(new CallManyArgs());
//			tr.Add(new CallDuplicateArgs());
//			tr.Add(new CallImmArgs());
//			tr.Add(new CallPtrArgs());
//			tr.Add(new CallFloatAsXmmRet());
//			tr.Add(new CallDoubleAsXmmRet());
			tr.Add(new CallConditional());
//			tr.Add(new CallMultiple());
//			tr.Add(new CallRecursive());
//			tr.Add(new CallMisc1());
//			tr.Add(new CallMisc2());
//			tr.Add(new CallMisc3());
//			tr.Add(new CallMisc4());
//			tr.Add(new MiscConstPool());
//			tr.Add(new MiscMultiRet());
//
//			tr.Add(new RawAssembler());

			var resTrue = 0;
			var resFalse = 0;

			foreach (var data in tr.Run())
			{
				var result = data.Item1;
				Console.WriteLine(result);
				if (result)
				{
					resTrue++;
				}
				else
				{
					resFalse++;
				}
				if (_generateAsmListing)
				{
					var asm = data.Item2;
					Console.Write(asm);
				}
			}
			Console.WriteLine();
			Console.WriteLine("Passed:\t" + resTrue);
			Console.WriteLine("Failed:\t" + resFalse);
			Console.ReadKey();
		}
	}
}
