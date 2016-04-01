using AsmJit.AssemblerContext;
using AsmJit.Common;
using AsmJit.CompilerContext.CodeTree;

namespace AsmJit.CompilerContext
{
	internal abstract class Allocator
	{
		protected Assembler Assembler;
		protected Compiler Compiler;
		protected CodeContext CodeContext;
		protected Translator Translator;
		protected VariableContext VariableContext;
		protected CodeNode Node;
		protected VariableMap Map;
		protected VariableAttributes[][] VaList;//[_kX86RegClassManagedCount];
		private int _vaCount;
		protected RegisterCount Count = new RegisterCount();
		protected RegisterCount Done = new RegisterCount();

		protected Allocator(Assembler assembler, Compiler compiler, CodeContext codeContext, Translator translator, VariableContext variableContext)
		{
			Assembler = assembler;
			Compiler = compiler;
			CodeContext = codeContext;
			Translator = translator;
			VariableContext = variableContext;
			VaList = new VariableAttributes[4][];
		}

		protected void Init(CodeNode node, VariableMap map)
		{
			Node = node;
			Map = map;

			// We have to set the correct cursor in case any instruction is emitted
			// during the allocation phase; it has to be emitted before the current
			// instruction.
			Compiler.SetCurrentNode(node.Previous);

			// Setup the lists of variables.
			{
				VaList[(int)RegisterClass.Gp] = map.GetListByClass(RegisterClass.Gp);
				VaList[(int)RegisterClass.Mm] = map.GetListByClass(RegisterClass.Mm);
				VaList[(int)RegisterClass.K] = map.GetListByClass(RegisterClass.K);
				VaList[(int)RegisterClass.Xyz] = map.GetListByClass(RegisterClass.Xyz);
			}

			// Setup counters.
			_vaCount = map.Attributes.Length;

			Count.CopyFrom(map.Count);
			Done.Reset();

			// Connect Vd->Va.
			for (var i = 0; i < _vaCount; i++)
			{
				var va = VaList[0][i];
				var vd = va.VariableData;

				vd.Attributes = va;
			}
		}

		protected void Cleanup()
		{
			// Disconnect Vd->Va.
			for (var i = 0; i < _vaCount; i++)
			{
				var va = VaList[0][i];
				var vd = va.VariableData;

				vd.Attributes = null;
			}
		}
	}
}
