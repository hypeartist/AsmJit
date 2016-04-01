using System;
using AsmJit.Common;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext.CodeTree;

namespace AsmJit.CompilerContext
{
	public sealed class CodeContext<T> : CodeContext
	{
		private Type _delegateType;

		internal CodeContext(Compiler compiler, Type delegateType)
			: base(compiler)
		{
			_delegateType = delegateType;
		}

		public T Compile()
		{
			var fp = Compiler.EndFunction();
			return fp.ToCallable<T>(_delegateType);
		}

		public T Compile(out IntPtr raw, out int codeSize)
		{
			var fp = Compiler.EndFunction(out codeSize);
			raw = fp;
			return fp.ToCallable<T>(_delegateType);
		}
	}

	public partial class CodeContext
	{
		protected Compiler Compiler;
		
		internal CodeContext(Compiler compiler)
		{
			Compiler = compiler;
		}

		public Label Entry
		{
			get { return Compiler.GetEntryLabel(); }
		}

		public Label Exit
		{
			get { return Compiler.GetExitLabel(); }
		}

		public void SetArgument(int index, Variable v)
		{
			Compiler.SetArgument(index, v);
		}

		public Label Label()
		{
			return Compiler.CreateLabel();
		}

		public CallNode Call(GpVariable target, FnPointer fn)
		{
			return Compiler.CreateCall(target, fn.FunctionDeclaration);
		}

		public CallNode Call(Label target)
		{
			return Compiler.CreateCall(target);
		}

		public CallNode Call(FnPointer fn)
		{
			return Compiler.CreateCall(new Immediate(fn), fn.FunctionDeclaration);
		}

		public CodeContext Unfollow()
		{
			Compiler.Unfollow();
			return this;
		}

		public void Bind(Label label)
		{
			Compiler.Bind(label);
		}

		public void Spill(Variable variable)
		{
			Compiler.Spill(variable);
		}

		public void Unuse(Variable variable)
		{
			Compiler.Unuse(variable);
		}

		public void Allocate(Variable variable)
		{
			Compiler.Allocate(variable);
		}

		public void Allocate(Variable variable, Register r)
		{
			Compiler.Allocate(variable, r);
		}

		public void Align(AligningMode mode, int size)
		{
			Compiler.Align(mode, size);
		}

		public void Data(Label label, int alignment, params Data[] data)
		{
			Compiler.Data(label, alignment, data);
		}

		//		public void Data(params DataBlock[] data)
		//		{
		//			Compiler.Data(data);
		//		}
		//
		//		public void DataBlock(Action<DataContext> dataBlock)
		//		{
		//			Compiler.Data(dataBlock);
		//		}

		public StackMemory Stack(int size, int alignment, string name = null)
		{
			return Compiler.CreateStack(size, alignment, name);
		}

		public GpVariable Int8(string name = null)
		{
			return Compiler.CreateVariable<GpVariable>(VariableType.Int8, name);
		}

		public GpVariable UInt8(string name = null)
		{
			return Compiler.CreateVariable<GpVariable>(VariableType.UInt8, name);
		}

		public GpVariable Int16(string name = null)
		{
			return Compiler.CreateVariable<GpVariable>(VariableType.Int16, name);
		}

		public GpVariable UInt16(string name = null)
		{
			return Compiler.CreateVariable<GpVariable>(VariableType.UInt16, name);
		}

		public GpVariable Int32(string name = null)
		{
			return Compiler.CreateVariable<GpVariable>(VariableType.Int32, name);
		}

		public GpVariable UInt32(string name = null)
		{
			return Compiler.CreateVariable<GpVariable>(VariableType.UInt32, name);
		}

		public GpVariable Int64(string name = null)
		{
			return Compiler.CreateVariable<GpVariable>(VariableType.Int64, name);
		}

		public GpVariable UInt64(string name = null)
		{
			return Compiler.CreateVariable<GpVariable>(VariableType.UInt64, name);
		}

		public GpVariable IntPtr(string name = null)
		{
			return Compiler.CreateVariable<GpVariable>(VariableType.IntPtr, name);
		}

		public GpVariable UIntPtr(string name = null)
		{
			return Compiler.CreateVariable<GpVariable>(VariableType.UIntPtr, name);
		}

		public XmmVariable Xmm(string name = null)
		{
			return Compiler.CreateVariable<XmmVariable>(VariableType.Xmm, name);
		}

		public XmmVariable XmmSs(string name = null)
		{
			return Compiler.CreateVariable<XmmVariable>(VariableType.XmmSs, name);
		}

		public XmmVariable XmmSd(string name = null)
		{
			return Compiler.CreateVariable<XmmVariable>(VariableType.XmmSd, name);
		}

		public Memory Int32Const(ConstantScope scope, int v)
		{
			unsafe
			{
				var p = &v;
				return Compiler.CreateConstant(scope, p, 4);
			}
		}
	}
}
