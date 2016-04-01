using AsmJit.CompilerContext;

namespace AsmJit.Common.Operands
{
	public class FpVariable : Variable
	{
		internal FpVariable(FpVariableType type)
			: base((VariableType) type)
		{
		}

		internal FpVariable(FpVariableType type, int id)
			: base((VariableType) type)
		{
			Id = id;
			var varInfo = ((VariableType) type).GetVariableInfo();
			RegisterType = varInfo.RegisterType;
			Size = varInfo.Size;
		}
		
		internal FpVariable(FpVariable other)
			: base(other)
		{
		}
	}
}