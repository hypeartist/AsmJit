namespace AsmJit.CompilerContext
{
	internal class VariableCell
	{
		public VariableCell Next { get; set; }

		public int Offset { get; set; }

		public int Size { get; set; }

		public int Alignment { get; set; }
	}
}