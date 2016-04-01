namespace AsmJit.AssemblerContext
{
	internal class InstructionInfo
	{
		public InstructionInfo(InstructionNameIndex nameIndex, InstructionExtendedIndex extendedIndex, long primaryOpCode)
		{
			NameIndex = nameIndex;
			ExtendedIndex = extendedIndex;
			PrimaryOpCode = primaryOpCode;
		}

		public InstructionNameIndex NameIndex { get; private set; }

		public long PrimaryOpCode { get; private set; }

		public InstructionExtendedIndex ExtendedIndex { get; private set; }
	}
}