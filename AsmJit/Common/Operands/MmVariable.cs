namespace AsmJit.Common.Operands
{
	public class MmVariable : Variable
	{
		internal MmVariable()
			: base(VariableType.Mm)
		{
		}

		internal MmVariable(MmVariable other)
			: base(other)
		{
		}
	}
}