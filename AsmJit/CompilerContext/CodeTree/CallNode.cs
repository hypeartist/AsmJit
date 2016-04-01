using System;
using AsmJit.Common;
using AsmJit.Common.Operands;

namespace AsmJit.CompilerContext.CodeTree
{
	public class CallNode : CodeNode
	{
		private RegisterMask _usedArgs;

		internal CallNode(Operand target, FunctionDeclaration decl)
			: base(CodeNodeType.Call)
		{
			Target = target;
			FunctionDeclaration = decl;
			Arguments = new Operand[decl.ArgumentCount];
			Return = new Operand[2].InitializeWith(() => Operand.Invalid);
		}

		//TODO 

		public void SetArgument(int i, Operand a)
		{
			if (!(i >= 0 && i < Arguments.Length)) { throw new ArgumentException(); }
			Arguments[i] = a;
		}

		public void SetArgument(int i, long a)
		{
			if (!(i >= 0 && i < Arguments.Length)) { throw new ArgumentException(); }
			Arguments[i] = new Immediate(a);
		}

		public void SetArgument(int i, ulong a)
		{
			if (!(i >= 0 && i < Arguments.Length)) { throw new ArgumentException(); }
			Arguments[i] = new Immediate(a);
		}

		public void SetReturn(int i, Operand r)
		{
			if (!(i >= 0 && i < Return.Length)) { throw new ArgumentException(); }
			Return[i] = r;
		}

		internal Operand Target { get; set; }

		internal RegisterMask UsedArgs
		{
			get
			{
				if (_usedArgs != null)
				{
					return _usedArgs;
				}
				var regs = new RegisterMask();
				var argCount = FunctionDeclaration.ArgumentCount;

				for (var i = 0; i < argCount; i++)
				{
					var arg = FunctionDeclaration.GetArgument(i);
					if (arg.RegisterIndex == RegisterIndex.Invalid) continue;
					regs.Or(arg.VariableType.GetRegisterClass(), Utils.Mask(arg.RegisterIndex));
				}

				return _usedArgs = regs;
			}
		}

		internal Operand[] Return { get; private set; }

		internal Operand[] Arguments { get; private set; }

		internal FunctionDeclaration FunctionDeclaration { get; private set; }

	}
}