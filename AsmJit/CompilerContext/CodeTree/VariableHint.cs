namespace AsmJit.CompilerContext.CodeTree
{
	internal enum VariableHint
	{
		Alloc = 0,
		Spill = 1,
		Save = 2,
		SaveAndUnuse = 3,
		Unuse = 4
	}
}