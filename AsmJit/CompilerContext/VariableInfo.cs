using AsmJit.Common;
using AsmJit.Common.Operands;

namespace AsmJit.CompilerContext
{
	internal class VariableInfo
	{
		public VariableInfo(RegisterType registerType, int size, RegisterClass registerClass, VariableValueFlags valueFlags, string name)
		{
			RegisterType = registerType;
			Size = size;
			RegisterClass = registerClass;
			ValueFlags = valueFlags;
			Name = name;
		}

		public RegisterType RegisterType { get; private set; }

		public int Size { get; private set; }

		public RegisterClass RegisterClass { get; private set; }

		public VariableValueFlags ValueFlags { get; private set; }

		public string Name { get; private set; }
	}
}