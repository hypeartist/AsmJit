using AsmJit.Common.Operands;

namespace AsmJit.Common
{
	public class DataBlock
	{
		public DataBlock(Label label, int alignment, params Data[] data)
		{
			Label = label;
			Data = data;
			Alignment = alignment;
		}

		public Data[] Data { get; private set; }

		public int Alignment { get; private set; }
		
		public Label Label { get; private set; }
	}
}