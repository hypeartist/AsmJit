namespace AsmJit.Common.Operands
{
	public sealed class Invalid : Operand
	{
		internal Invalid()
			:base(OperandType.Invalid)
		{ }
	}
}