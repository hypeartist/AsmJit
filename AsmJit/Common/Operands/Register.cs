using System;

namespace AsmJit.Common.Operands
{
	public abstract class Register : Operand
	{
		protected Register()
			: base(OperandType.Register)
		{
			Index = RegisterIndex.Invalid;
			RegisterType = RegisterType.Invalid;
		}

		protected Register(Register other)
			: base(other)
		{
		}

		internal int Index
		{
			get { return Reserved0; }
			set { Reserved0 = value; }
		}

		internal RegisterType RegisterType
		{
			get { return (RegisterType)Reserved1; }
			set { Reserved1 = (int)value; }
		}

		internal static Register FromVariable(Variable var, int index)
		{
			switch (var.RegisterType)
			{
				case RegisterType.GpbLo:
					return new GpRegister(GpRegisterType.GpbLo, index) { Id = var.Id, Size = var.Size };
				case RegisterType.GpbHi:
					return new GpRegister(GpRegisterType.GpbHi, index) { Id = var.Id, Size = var.Size };
				case RegisterType.Gpw:
					return new GpRegister(GpRegisterType.Gpw, index) { Id = var.Id, Size = var.Size };
				case RegisterType.Gpd:
					return new GpRegister(GpRegisterType.Gpd, index) { Id = var.Id, Size = var.Size };
				case RegisterType.Gpq:
					return new GpRegister(GpRegisterType.Gpq, index) { Id = var.Id, Size = var.Size };
				case RegisterType.Fp:
					return new FpRegister(index) { Id = var.Id, Size = var.Size };
				case RegisterType.Mm:
					return new MmRegister(index) { Id = var.Id, Size = var.Size };
				case RegisterType.K:
					return new KRegister(index) { Id = var.Id, Size = var.Size };
				case RegisterType.Xmm:
					return new XmmRegister(index) {Id = var.Id, Size = var.Size};
				case RegisterType.Ymm:
					return new YmmRegister(index) { Id = var.Id, Size = var.Size };
				case RegisterType.Zmm:
					return new ZmmRegister(index) { Id = var.Id, Size = var.Size };
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		public override string ToString()
		{
			return string.Format("[{0}: Id={1}, Size={2}, Type={3}, Idx={4}]", OperandType, Id == Constants.InvalidId ? "#" : Id.ToString(), Size, RegisterType, Index == RegisterIndex.Invalid ? "#" : Index.ToString());
		}
	}
}