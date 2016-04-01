using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmJit.Common
{
	public enum Condition
	{
		A = 0x07,
		AE = 0x03,
		B = 0x02,
		BE = 0x06,
		C = 0x02,
		E = 0x04,
		G = 0x0F,
		GE = 0x0D,
		L = 0x0C,
		LE = 0x0E,
		NA = 0x06,
		NAE = 0x02,
		NB = 0x03,
		NBE = 0x07,
		NC = 0x03,
		NE = 0x05,
		NG = 0x0E,
		NGE = 0x0C,
		NL = 0x0D,
		NLE = 0x0F,
		NO = 0x01,
		NP = 0x0B,
		NS = 0x09,
		NZ = 0x05,
		O = 0x00,
		P = 0x0A,
		PE = 0x0A,
		PO = 0x0B,
		S = 0x08,
		Z = 0x04,
		Sign = S,
		NotSign = NS,
		Overflow = O,
		NotOverflow = NO,
		Less = L,
		LessEqual = LE,
		Greater = G,
		GreaterEqual = GE,
		Below = B,
		BelowEqual = BE,
		Above = A,
		AboveEqual = AE,
		Equal = E,
		NotEqual = NE,
		ParityEven = P,
		ParityOdd = PO,
		Zero = Z,
		NotZero = NZ,
		Negative = S,
		Positive = NS,
		FpuUnordered = 0x10,
		FpuNotUnordered = 0x11,
		None = 0x12
	}
}
