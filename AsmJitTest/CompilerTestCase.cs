using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using AsmJit.AssemblerContext;
using AsmJit.CompilerContext;
using SharpDisasm;
using CodeContext = AsmJit.CompilerContext.CodeContext;

namespace AsmJitTest
{
	public sealed class TestCaseRunner
	{
		private bool _disasm;
		private List<TestCase> _testCases = new List<TestCase>();

		public TestCaseRunner(bool generateAsmListing = false)
		{
			_disasm = generateAsmListing;
		}

		public void Add(TestCase testCase)
		{
			_testCases.Add(testCase);
		}

		public IEnumerable<Tuple<bool, string>> Run()
		{
			if (_disasm)
			{
				foreach (var testCase in _testCases)
				{
					string disasm;
					var res = testCase.Run(out disasm);
					yield return new Tuple<bool, string>(res, disasm);
				}	
			}
			else
			{
				foreach (var testCase in _testCases)
				{
					var res = testCase.Run();
					yield return new Tuple<bool, string>(res, null);
				}	
			}
		}
	}

	public abstract class TestCase
	{
		public abstract bool Run();
		public abstract bool Run(out string disassemly);
	}

	public abstract class CompilerTestCase<T> : TestCase
	{
		private AsmJit.CompilerContext.CodeContext<T> _ctx;

		protected CompilerTestCase()
		{
			_ctx = Compiler.CreateContext<T>();
		}

		public override bool Run()
		{
			Compile(_ctx);
			string result;
			string expected;
			Execute(_ctx.Compile(), out result, out expected);
			return result == expected;
		}

		public override unsafe bool Run(out string disassemly)
		{
			Compile(_ctx);
			string result;
			string expected;
			IntPtr fp;
			int codeSize;
			Execute(_ctx.Compile(out fp, out codeSize), out result, out expected);
			var tmp = Marshal.AllocHGlobal(codeSize);
			Buffer.MemoryCopy((void*) fp, (void*) tmp, codeSize, codeSize);
			const ArchitectureMode mode = ArchitectureMode.x86_64;
			Disassembler.Translator.IncludeAddress = true;
			Disassembler.Translator.IncludeBinary = true;
			var disasm = new Disassembler(tmp, codeSize, mode, (ulong)fp.ToInt64(), true);
			disassemly = disasm.Disassemble().Aggregate("", (current, insn) => current + insn + Environment.NewLine);
			Marshal.FreeHGlobal(tmp);
			return result == expected;
		}

		protected abstract void Compile(CodeContext c);
		protected abstract void Execute(T fn, out string result, out string expected);
	}

	public abstract class AssemblerTestCase<T> : TestCase
	{
		private AsmJit.AssemblerContext.CodeContext<T> _ctx;

		protected AssemblerTestCase()
		{
			_ctx = Assembler.CreateContext<T>();
		}

		public override bool Run()
		{
			Compile(_ctx);
			string result;
			string expected;
			Execute(_ctx.Compile(), out result, out expected);
			return result == expected;
		}

		public override unsafe bool Run(out string disassemly)
		{
			Compile(_ctx);
			string result;
			string expected;
			IntPtr fp;
			int codeSize;
			Execute(_ctx.Compile(out fp, out codeSize), out result, out expected);
			var tmp = Marshal.AllocHGlobal(codeSize);
			Buffer.MemoryCopy((void*)fp, (void*)tmp, codeSize, codeSize);
			const ArchitectureMode mode = ArchitectureMode.x86_64;
			Disassembler.Translator.IncludeAddress = true;
			Disassembler.Translator.IncludeBinary = true;
			var disasm = new Disassembler(tmp, codeSize, mode, (ulong)fp.ToInt64(), true);
			disassemly = disasm.Disassemble().Aggregate("", (current, insn) => current + insn + Environment.NewLine);
			Marshal.FreeHGlobal(tmp);
			return result == expected;
		}

		protected abstract void Compile(AsmJit.AssemblerContext.CodeContext c);
		protected abstract void Execute(T fn, out string result, out string expected);
	}
}