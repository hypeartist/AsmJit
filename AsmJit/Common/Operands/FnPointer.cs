using System;
using System.Linq;
using System.Runtime.InteropServices;
using AsmJit.CompilerContext;

namespace AsmJit.Common.Operands
{
	public class FnPointer : Immediate
	{
		protected FnPointer() { }

		internal FnPointer(Delegate d, CallingConvention convention)
		{
			var def = d.Method.GetBaseDefinition();
			var pars = def.GetParameters();
			if (Constants.X64)
			{
				var dt = DelegateCreator.NewDelegateType(def.ReturnType, pars.Select(p => p.ParameterType).ToArray());
				var fd = Delegate.CreateDelegate(dt, d.Target, d.Method);
				var ptr = Marshal.GetFunctionPointerForDelegate(fd);
				Int64 = ptr.ToInt64();
			}
			else
			{
//				var ptr = Marshal.GetFunctionPointerForDelegate(d);
//				convention = CallingConvention.X86CDecl;
//				Int64 = ptr.ToInt64();

				// TODO: Need fixing!!!
				throw new NotImplementedException("Managed method cannot be called from machine code in X86 mode by now.");
			}

			var args = pars.Select(p => p.ParameterType.GetVariableType()).ToArray();
			var ret = def.ReturnType.GetVariableType();
			FunctionDeclaration = new FunctionDeclaration(convention, args, ret);
		}

		internal FunctionDeclaration FunctionDeclaration { get; set; }
	}

	public class FnPointer<T> : FnPointer
	{
		internal FnPointer(Pointer fnPtr, CallingConvention convention)
		{
			var t = typeof(T);

			var args = new Type[0];
			Type ret = null;
			if (t == typeof(Action))
			{
			}
			else if (Utils.Actions.Contains(t.GetGenericTypeDefinition()))
			{
				var gargs = t.GetGenericArguments();
				args = new Type[gargs.Length].InitializeWith(i => gargs[i]);
			}
			else if (Utils.Funcs.Contains(t.GetGenericTypeDefinition()))
			{
				var gargs = t.GetGenericArguments();
				args = new Type[gargs.Length - 1].InitializeWith(i => gargs[i]);
				ret = gargs.Last();
			}
			else
			{
				throw new ArgumentException();
			}
			Int64 = (long) fnPtr;
			FunctionDeclaration = new FunctionDeclaration(convention, args.Select(a=>a.GetVariableType()).ToArray(), ret.GetVariableType());
		}
	}
}