using System;
using AsmJit.Common.Operands;

namespace AsmJit.Common
{
	internal class FunctionInOut
	{
		public FunctionInOut(VariableType variableType, int registerIndex, int stackOffset = Constants.InvalidValue)
		{
			VariableType = variableType;
			RegisterIndex = registerIndex;
			StackOffset = stackOffset;
		}

		public VariableType VariableType { get; private set; }

		public int RegisterIndex { get; private set; }

		public int StackOffset { get; private set; }
	}
}
