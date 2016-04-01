using System;
using AsmJit.AssemblerContext;
using AsmJit.Common;
using AsmJit.Common.Operands;

namespace AsmJit.CompilerContext.CodeTree
{
	internal sealed class FunctionNode : CodeNode
	{
		private VariableData[] _arguments;
		private int _hints;

		public FunctionNode(LabelNode entry, LabelNode exit, VariableType[] arguments, VariableType @return, CallingConvention callingConvention)
			: base(CodeNodeType.Function)
		{
			Entry = entry;
			Exit = exit;
			End = new SentinelNode();
			FunctionDeclaration = new FunctionDeclaration(callingConvention, arguments, @return);
			_arguments = new VariableData[arguments.Length];
			StackFrameCopyGpIndex = new int[6].InitializeWith(() => RegisterIndex.Invalid);
			SaveRestoreRegs = new RegisterMask();
			StackFrameRegIndex = RegisterIndex.Invalid;
			_hints = Utils.Mask((int)FuncionNodeHints.Naked);
		}
		// TODO
		public VariableData GetArgument(int index)
		{
			if (!(index >= 0 && index < _arguments.Length)) { throw new ArgumentException(); }
			return _arguments[index];
		}

		public void SetArgument(int index, VariableData value)
		{
			if (!(index >= 0 && index < _arguments.Length)) { throw new ArgumentException(); }
			_arguments[index] = value;
		}

		public void UpdateRequiredStackAlignment()
		{
			if (RequiredStackAlignment <= Cpu.Info.StackAlignment)
			{
				RequiredStackAlignment = Cpu.Info.StackAlignment;
				FunctionFlags &= ~FunctionNodeFlags.IsStackMisaligned;
			}
			else
			{
				FunctionFlags |= FunctionNodeFlags.IsStackMisaligned;
			}
		}

		public void MergeCallStackSize(int s)
		{
			if (CallStackSize < s)
			{
				CallStackSize = s;
			}
		}

		public FunctionNodeFlags FunctionFlags { get; set; }

		public bool HasHint(FuncionNodeHints hint)
		{
			return ((_hints >> (int)hint) & 0x1) != 0;
		}

		public void SetHint(FuncionNodeHints hint, int value)
		{
			_hints &= ~(1 << (int)hint);
			_hints |= value << (int)hint;
		}
		//		public FuncionNodeHints Hints { get; set; }

		public LabelNode Entry { get; private set; }

		public LabelNode Exit { get; private set; }

		public SentinelNode End { get; private set; }

		public FunctionDeclaration FunctionDeclaration { get; private set; }

		public RegisterMask SaveRestoreRegs { get; private set; }

		public int AlignStackSize { get; set; }

		public int AlignedMemStackSize { get; set; }

		public int PushPopStackSize { get; set; }

		public int MoveStackSize { get; set; }

		public int ExtraStackSize { get; set; }

		public int StackFrameRegIndex { get; set; }

		public bool IsStackFrameRegPreserved { get; set; }

		public int[] StackFrameCopyGpIndex { get; private set; }

		public int RequiredStackAlignment { get; set; }

		public int CallStackSize { get; set; }

		public int MemStackSize { get; set; }
	}
}