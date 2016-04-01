using System;
using AsmJit.Common;

namespace AsmJit.CompilerContext
{
	internal class VariableState
	{
		private const int GpIndex = 0;
		private const int GpCount = 16;
		private const int MmIndex = GpIndex + GpCount;
		private const int MmCount = 8;
		private const int XmmIndex = MmIndex + MmCount;
		private const int XmmCount = 16;
		private const int AllCount = XmmIndex + XmmCount;

		private VariableData[] _listGp = new VariableData[GpCount];
		private VariableData[] _listMm = new VariableData[MmCount];
		private VariableData[] _listXmm = new VariableData[XmmCount];

		internal VariableState(int vdCount)
		{
			Occupied = new RegisterMask();
			Modified = new RegisterMask();

			Cells = new ValueSet<VariableUsage, bool>[vdCount];
		}

		internal VariableState(int vdCount, VariableState src)
			: this(vdCount)
		{
			Array.Copy(src._listGp, 0, _listGp, 0, src._listGp.Length);
			Array.Copy(src._listMm, 0, _listMm, 0, src._listMm.Length);
			Array.Copy(src._listXmm, 0, _listXmm, 0, src._listXmm.Length);
		}

		internal VariableData[] GetListByClass(RegisterClass @class)
		{
			switch (@class)
			{
				case RegisterClass.Gp:
					return _listGp;
				case RegisterClass.Mm:
					return _listMm;
				case RegisterClass.Xyz:
					return _listXmm;
				default:
					return null;
			}
		}

		public ValueSet<VariableUsage, bool>[] Cells { get; private set; }

		public RegisterMask Occupied { get; private set; }

		public RegisterMask Modified { get; private set; }
	}
}