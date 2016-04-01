using System;
using AsmJit.Common;
using AsmJit.Common.Operands;

namespace AsmJit.AssemblerContext
{
	public sealed class CodeContext<T> : CodeContext
	{
		private Type _delegateType;

		internal CodeContext(Assembler assembler, Type delegateType)
			: base(assembler)
		{
			_delegateType = delegateType;
		}

		public T Compile()
		{
			var fp = Assembler.Make();
			return fp.ToCallable<T>(_delegateType);
		}

		public T Compile(out IntPtr raw, out int codeSize)
		{
			var fp = Assembler.Make(out codeSize);
			raw = fp;
			return fp.ToCallable<T>(_delegateType);
		}
	}

	public partial class CodeContext
	{
		protected Assembler Assembler;

		internal CodeContext(Assembler assembler)
		{
			Assembler = assembler;
		}

		public Label Label()
		{
			return Assembler.CreateLabel();
		}

		public void Bind(Label label)
		{
			Assembler.Bind(label.Id);
		}

		public void Align(AligningMode mode, int size)
		{
			Assembler.Align(mode, size);
		}

		public void Data(Label label, params Data[] data)
		{
			Data(label, 16, data);
		}

		public void Data(Label label, int alignment, params Data[] data)
		{
//			Assembler.
		}
	}
}