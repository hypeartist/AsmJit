//using AsmJit.Common;
//using AsmJit.Common.Operands;
//
//namespace AsmJit.CompilerContext
//{
//	public sealed class DataContext
//	{
//		private Compiler _compiler;
//
//		internal DataContext(Compiler compiler)
//		{
//			_compiler = compiler;
//		}
//
//		public void Data(Vec128 v)
//		{
//			unsafe
//			{
//				_compiler.Embed(&v, sizeof(Vec128));
//			}
//		}
//
//		public void Align(AligningMode mode, int size)
//		{
//			_compiler.Align(mode, size);
//		}
//
//		public void Bind(Label label)
//		{
//			_compiler.Bind(label);
//		}
//	}
//}