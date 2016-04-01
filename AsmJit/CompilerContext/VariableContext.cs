using System.Collections.Generic;
using AsmJit.AssemblerContext;
using AsmJit.Common;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext.CodeTree;

namespace AsmJit.CompilerContext
{
	internal class VariableContext
	{
		private VariableAttributes[] _tmpList = new VariableAttributes[80].InitializeWith(() => new VariableAttributes());
		
		public VariableContext()
		{
			JccList = new List<CodeNode>();
			ReturningList = new List<CodeNode>();
			ContextVd = new List<VariableData>();
			ClobberedRegs = new RegisterMask();
			GaRegs = new Dictionary<RegisterClass, int>();
			GaRegs[RegisterClass.Gp] = (int)(Utils.Bits(Cpu.Info.RegisterCount.Gp) & ~Utils.Mask(RegisterIndex.Sp));
			GaRegs[RegisterClass.Mm] = (int)Utils.Bits(Cpu.Info.RegisterCount.Mm);
			GaRegs[RegisterClass.K] = (int)Utils.Bits(Cpu.Info.RegisterCount.K);
			GaRegs[RegisterClass.Xyz] = (int)Utils.Bits(Cpu.Info.RegisterCount.Xyz);
			State = new VariableState(0);
		}

		public VariableState State { get; private set; }

		public Dictionary<RegisterClass, int> GaRegs { get; private set; }

		public List<VariableData> ContextVd { get; private set; }

		public List<CodeNode> ReturningList { get; private set; }

		public int VariableCount { get; set; }

		public RegisterCount RegCount { get; private set; }

		public RegisterMask InRegs { get; private set; }

		public RegisterMask OutRegs { get; private set; }

		public RegisterMask ClobberedRegs { get; private set; }

		public List<CodeNode> JccList { get; private set; }

		public VariableAttributes this[int i]
		{
			get { return _tmpList[i]; }
		}

		public void Begin()
		{
			RegCount = new RegisterCount();
			InRegs = new RegisterMask();
			OutRegs = new RegisterMask();
			ClobberedRegs = new RegisterMask();
		}

		public VariableAttributes Add(VariableData vd, VariableFlags flags, int newAllocable)
		{
			var va = _tmpList[VariableCount++];
			va.Setup(vd, flags, 0, newAllocable);
			va.UsageCount += 1;
			vd.Attributes = va;

			RegisterContextVariable(vd);
			RegCount.Add(vd.Info.RegisterClass);
			return va;
		}

		public VariableAttributes Merge(VariableData vd, VariableFlags flags, int newAllocable)
		{
			var va = vd.Attributes;
			if (va == null)
			{
				va = _tmpList[VariableCount++];
				va.Setup(vd, flags, 0, newAllocable);
				vd.Attributes = va;

				RegisterContextVariable(vd);
				RegCount.Add(vd.Info.RegisterClass);
			}
			va.Flags |= flags;
			va.UsageCount++;
			return va;
		}

		public void End(CodeNode node)
		{
			if (VariableCount == 0 && ClobberedRegs.IsEmpty) return;

			var vaIndex = new RegisterCount();
			vaIndex.IndexFrom(RegCount);

			var vaMap = new VariableMap(VariableCount);

			vaMap.Count.CopyFrom(RegCount);
			vaMap.Start.CopyFrom(vaIndex);
			vaMap.InRegs.CopyFrom(InRegs);
			vaMap.OutRegs.CopyFrom(OutRegs);
			vaMap.ClobberedRegs.CopyFrom(ClobberedRegs);

			var vi = 0;
			while (VariableCount != 0)
			{
				var va = _tmpList[vi];
				var vd = va.VariableData;

				var @class = vd.Info.RegisterClass;
				var dstIndex = vaIndex.Get(@class);

				vaIndex.Add(@class);

				if (va.InRegs != 0)
				{
					va.AllocableRegs = va.InRegs;
				}
				else if (va.OutRegIndex != RegisterIndex.Invalid)
				{
					va.AllocableRegs = Utils.Mask(va.OutRegIndex);
				}
				else
				{
					va.AllocableRegs &= ~InRegs.Get(@class);
				}

				vd.Attributes = null;
				vaMap.Attributes[dstIndex].CopyFrom(va);
				vi++;
				VariableCount--;
			}
			node.VariableMap = vaMap;
			return;
		}

		public void RegisterContextVariable(VariableData vd)
		{
			if (vd.LocalId != Constants.InvalidId)
			{
				return;
			}

			vd.LocalId = ContextVd.Count;
			ContextVd.Add(vd);
		}
	}
}