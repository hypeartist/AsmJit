namespace AsmJit.Common.Operands
{
	public class YmmVariable : Variable
	{
		internal YmmVariable(YmmVariableType type)
			: base((VariableType) type)
		{
		}

		internal YmmVariable(XmmVariable other)
			: base(other)
		{
		}
	}
}