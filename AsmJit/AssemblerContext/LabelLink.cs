using AsmJit.Common;

namespace AsmJit.AssemblerContext
{
	internal class LabelLink
	{
		internal LabelLink()
		{
			Offset = Constants.InvalidValue;
			RelocationId = Constants.InvalidId;
		}

		internal LabelLink Previous { get; set; }

		internal int Offset { get; set; }

		internal int Displacement { get; set; }

		internal int RelocationId { get; set; }
	}
}