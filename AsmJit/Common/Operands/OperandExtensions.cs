namespace AsmJit.Common.Operands
{
	internal static class OperandExtensions
	{
		internal static bool IsInvalid(this Operand op)
		{
			return op.OperandType == OperandType.Invalid;
		}

		internal static bool IsRegister(this Operand op)
		{
			return op.OperandType == OperandType.Register;
		}

		internal static bool IsVariable(this Operand op)
		{
			return op.OperandType == OperandType.Variable;
		}

		internal static bool IsMemory(this Operand op)
		{
			return op.OperandType == OperandType.Memory;
		}

		internal static bool IsVariableOrMemory(this Operand op)
		{
			return op.IsVariable() || op.IsMemory();
		}

		internal static bool IsImmedate(this Operand op)
		{
			return op.OperandType == OperandType.Immediate;
		}
		internal static bool IsLabel(this Operand op)
		{
			return op.OperandType == OperandType.Label;
		}

		internal static bool IsRegisterType(this Operand op, RegisterType type)
		{
			return op.IsRegister() && op.Reserved1 == (int)type;
		}
	}
}
