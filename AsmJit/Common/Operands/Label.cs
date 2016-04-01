namespace AsmJit.Common.Operands
{
	public sealed class Label : Operand
	{
		internal Label(int id)
			: base(OperandType.Label)
		{
			Id = id;
		}

		internal void Reset()
		{
			Id = Constants.InvalidId;
			Size = 0;
		}
	}
}