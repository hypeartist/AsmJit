using System;
using AsmJit.Common;

namespace AsmJit.CompilerContext
{
	internal sealed class VariableMap
	{
		public VariableMap(int attrCount)
		{
			InRegs = new RegisterMask();
			OutRegs = new RegisterMask();
			ClobberedRegs = new RegisterMask();
			Start = new RegisterCount();
			Count = new RegisterCount();
			AttributesCount = attrCount;
			Attributes = new VariableAttributes[attrCount].InitializeWith(() => new VariableAttributes());
		}

		public VariableAttributes FindAttributes(VariableData vd)
		{
			var list = Attributes;
			var count = AttributesCount;
			for (var i = 0; i < count; i++)
			{
				if (list[i].VariableData == vd)
				{
					return list[i];
				}
			}
			return null;
		}

		public VariableAttributes FindAttributesByClass(RegisterClass @class, VariableData vd)
		{
			var list = GetListByClass(@class);
			var count = Count.Get(@class);
			for (var i = 0; i < count; i++)
			{
				if (list[i].VariableData == vd)
				{
					return list[i];
				}
			}
			return null;
		}

		public VariableAttributes[] GetListByClass(RegisterClass @class)
		{
			var tmp = new VariableAttributes[AttributesCount - Start.Get(@class)];
			Array.Copy(Attributes, Start.Get(@class), tmp, 0, AttributesCount - Start.Get(@class));
			return tmp;
		}

		public RegisterCount Count { get; private set; }

		public RegisterMask InRegs { get; private set; }

		public RegisterMask OutRegs { get; private set; }

		public RegisterMask ClobberedRegs { get; private set; }

		public RegisterCount Start { get; private set; }

		public int AttributesCount { get; private set; }

		public VariableAttributes[] Attributes { get; private set; }
	}
}