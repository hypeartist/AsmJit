using AsmJit.CompilerContext;

namespace AsmJit.Common.Operands
{
	public class XmmVariable : Variable
	{
		internal XmmVariable(XmmVariableType type)
			: base((VariableType) type)
		{
		}

		internal XmmVariable(XmmVariableType type, int id)
			: base((VariableType) type)
		{
			Id = id;
			var varInfo = ((VariableType) type).GetVariableInfo();
			RegisterType = varInfo.RegisterType;
			Size = varInfo.Size;
		}

		internal XmmVariable(XmmVariable other)
			: base(other)
		{
		}
	}
}