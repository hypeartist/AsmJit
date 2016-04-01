namespace AsmJit.AssemblerContext
{
	internal class ExtendedInstructionInfo
	{
		public ExtendedInstructionInfo(InstructionEncoding encoding, long writeIndex, long writeSize, long eflagsIn, long eflagsOut, long dummy, long[] operandFlags, long instructionFlags, long secop)
		{
			Encoding = encoding;
			WriteIndex = writeIndex;
			WriteSize = writeSize;
			EflagsIn = eflagsIn;
			EflagsOut = eflagsOut;
			Reserved = dummy;
			OperandFlags = operandFlags;
			InstructionFlags = instructionFlags;
			SecondaryOpCode = secop;
		}

		public InstructionEncoding Encoding { get; private set; }

		public long WriteIndex { get; private set; }

		public long WriteSize { get; private set; }

		public long EflagsIn { get; private set; }

		public long EflagsOut { get; private set; }

		public long Reserved { get; private set; }

		public long[] OperandFlags { get; private set; }

		public long InstructionFlags { get; private set; }

		public long SecondaryOpCode { get; private set; }
	}
}