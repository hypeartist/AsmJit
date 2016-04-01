namespace AsmJit.Common.Operands
{
	public abstract class Variable : Operand
	{
		protected Variable(VariableType type)
			:base(OperandType.Variable)
		{
			VariableType = type;
		}

		protected Variable(Variable other)
			: base(other)
		{
		}

		internal VariableType VariableType
		{
			get { return (VariableType)Reserved2; }
			private set { Reserved2 = (int)value; }
		}

		internal int RegisterIndex
		{
			get { return Reserved0; }
			set { Reserved0 = value; }
		}

		internal RegisterType RegisterType
		{
			get { return (RegisterType)Reserved1; }
			set { Reserved1 = (int)value; }
		}

		internal override T As<T>()
		{
			if (typeof(T) == typeof(Register))
			{
				return Register.FromVariable(this, RegisterIndex) as T;
			}
			return base.As<T>();
		}
	}
}