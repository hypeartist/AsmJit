using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsmJit.Common;

namespace AsmJit.CompilerContext.CodeTree
{
	internal static class InstructionNodeExtensions
	{
		internal static bool IsJmp(this InstructionNode node)
		{
			return node.Flags.IsSet(CodeNodeFlags.Jmp);
		}

		internal static bool IsJcc(this InstructionNode node)
		{
			return node.Flags.IsSet(CodeNodeFlags.Jcc);
		}

		internal static bool IsJmpOrJcc(this InstructionNode node)
		{
			return node.IsJmp() || node.IsJcc();
		}

		internal static bool IsRet(this InstructionNode node)
		{
			return node.Flags.IsSet(CodeNodeFlags.Ret);
		}

		internal static bool IsSpecial(this InstructionNode node)
		{
			return node.Flags.IsSet(CodeNodeFlags.Special);
		}

		internal static bool IsFp(this InstructionNode node)
		{
			return node.Flags.IsSet(CodeNodeFlags.Fp);
		}
	}
}
