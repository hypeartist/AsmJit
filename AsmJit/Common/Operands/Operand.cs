namespace AsmJit.Common.Operands
{
	public abstract class Operand
    {
		protected Operand(OperandType type)
		{
			Id = Constants.InvalidId;
			OperandType = type;
		}

		protected Operand(OperandType type, int size)
		{
			Id = Constants.InvalidId;
			OperandType = type;
			Size = size;
		}

		protected Operand(Operand other)
		{
			OperandType = other.OperandType;
			Id = other.Id;
			Reserved0 = other.Reserved0;
			Reserved1 = other.Reserved1;
			Size = other.Size;
			Reserved2 = other.Reserved2;
			Reserved3 = other.Reserved3;
		}

		protected internal OperandType OperandType { get; protected set; }

		protected internal int Size { get; protected set; }

		protected internal int Reserved0 { get; protected set; }

		protected internal int Reserved1 { get; protected set; }

		protected internal int Id { get; protected set; }

		protected internal int Reserved2 { get; protected set; }

		protected internal int Reserved3 { get; protected set; }

		public static Invalid Invalid
		{
			get { return new Invalid(); }
		}

		internal virtual T As<T>() where T : Operand
		{
			return this as T;
		}

		public override string ToString()
		{
			return string.Format("[{0}: Id={1}, Size={2}]", OperandType, Id == Constants.InvalidId ? "#" : Id.ToString(), Size);
		}
    }
}
