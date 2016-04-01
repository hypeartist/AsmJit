using AsmJit.Common;
using AsmJit.Common.Operands;

namespace AsmJit.CompilerContext
{
	public partial class CodeContext
	{
		private static InstructionId[] _condToCmovcc = { InstructionId.Cmovo, InstructionId.Cmovno, InstructionId.Cmovb, InstructionId.Cmovae, InstructionId.Cmove, InstructionId.Cmovne, InstructionId.Cmovbe, InstructionId.Cmova, InstructionId.Cmovs, InstructionId.Cmovns, InstructionId.Cmovpe, InstructionId.Cmovpo, InstructionId.Cmovl, InstructionId.Cmovge, InstructionId.Cmovle, InstructionId.Cmovg, InstructionId.None, InstructionId.None, InstructionId.None, InstructionId.None };
		private static InstructionId[] _condToJcc = { InstructionId.Jo, InstructionId.Jno, InstructionId.Jb, InstructionId.Jae, InstructionId.Je, InstructionId.Jne, InstructionId.Jbe, InstructionId.Ja, InstructionId.Js, InstructionId.Jns, InstructionId.Jpe, InstructionId.Jpo, InstructionId.Jl, InstructionId.Jge, InstructionId.Jle, InstructionId.Jg, InstructionId.None, InstructionId.None, InstructionId.None, InstructionId.None };
		private static InstructionId[] _condToSetcc = { InstructionId.Seto, InstructionId.Setno, InstructionId.Setb, InstructionId.Setae, InstructionId.Sete, InstructionId.Setne, InstructionId.Setbe, InstructionId.Seta, InstructionId.Sets, InstructionId.Setns, InstructionId.Setpe, InstructionId.Setpo, InstructionId.Setl, InstructionId.Setge, InstructionId.Setle, InstructionId.Setg, InstructionId.None, InstructionId.None, InstructionId.None, InstructionId.None };

		private static InstructionId CondToCmovcc(Condition cond)
		{
			return _condToCmovcc[(int)cond];
		}

		private static InstructionId CondToJcc(Condition cond)
		{
			return _condToJcc[(int)cond];
		}

		private static InstructionId CondToSetcc(Condition cond)
		{
			return _condToSetcc[(int)cond];
		}

		public void Adc(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Add(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Add, o0, o1);
		}

		public void And(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.And, o0, o1);
		}

		public void And(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.And, o0, o1);
		}

		public void And(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.And, o0, o1);
		}

		public void And(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.And, o0, o1);
		}

		public void And(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.And, o0, o1);
		}

		public void And(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.And, o0, o1);
		}

		public void And(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.And, o0, o1);
		}

		public void And(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.And, o0, o1);
		}

		public void And(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.And, o0, o1);
		}

		public void And(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.And, o0, o1);
		}

		public void And(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.And, o0, o1);
		}

		public void And(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.And, o0, o1);
		}

		public void And(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.And, o0, o1);
		}

		public void Bsf(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Bsf, o0, o1);
		}

		public void Bsf(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Bsf, o0, o1);
		}

		public void Bsr(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Bsr, o0, o1);
		}

		public void Bsr(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Bsr, o0, o1);
		}

		public void Bswap(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Bswap, o0);
		}

		public void Bt(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Btc(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btr(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Bts(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Bts, o0, o1);
		}
		//
		//		public CallNode Call(GpVariable dst, FuncPrototype p)
		//		{
		//			return _assembler.AddCall(dst, p);
		//		}
		//
		//		public CallNode Call(Memory dst, FuncPrototype p)
		//		{
		//			return _assembler.AddCall(dst, p);
		//		}
		//
		//		public CallNode Call(Label label, FuncPrototype p)
		//		{
		//			return _assembler.AddCall(label, p);
		//		}
		//
		//		public CallNode Call(Immediate dst, FuncPrototype p)
		//		{
		//			return _assembler.AddCall(dst, p);
		//		}
		//
		//		public CallNode Call(Pointer dst, FuncPrototype p)
		//		{
		//			return _assembler.AddCall(new Immediate(dst), p);
		//		}

		public void Clc()
		{
			Compiler.Emit(InstructionId.Clc);
		}

		public void Cld()
		{
			Compiler.Emit(InstructionId.Cld);
		}

		public void Cmc()
		{
			Compiler.Emit(InstructionId.Cmc);
		}

		public void Cbw(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Cbw, o0);
		}

		public void Cdq(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cdq, o0, o1);
		}

		public void Cdqe(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Cdqe, o0);
		}

		public void Cqo(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cdq, o0, o1);
		}

		public void Cwd(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cwd, o0, o1);
		}

		public void Cwde(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Cwde, o0);
		}

		public void Cmov(Condition cc, GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(CondToCmovcc(cc), o0, o1);
		}

		public void Cmova(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmova, o0, o1);
		}

		public void Cmovae(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovae, o0, o1);
		}

		public void Cmovb(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovb, o0, o1);
		}

		public void Cmovbe(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovbe, o0, o1);
		}

		public void Cmovc(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovc, o0, o1);
		}

		public void Cmove(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmove, o0, o1);
		}

		public void Cmovg(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovg, o0, o1);
		}

		public void Cmovge(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovge, o0, o1);
		}

		public void Cmovl(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovl, o0, o1);
		}

		public void Cmovle(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovle, o0, o1);
		}

		public void Cmovna(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovna, o0, o1);
		}

		public void Cmovnae(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovnae, o0, o1);
		}

		public void Cmovnb(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovnb, o0, o1);
		}

		public void Cmovnbe(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovnbe, o0, o1);
		}

		public void Cmovnc(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovnc, o0, o1);
		}

		public void Cmovne(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovne, o0, o1);
		}

		public void Cmovng(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovng, o0, o1);
		}

		public void Cmovnge(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovnge, o0, o1);
		}

		public void Cmovnl(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovnl, o0, o1);
		}

		public void Cmovnle(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovnle, o0, o1);
		}

		public void Cmovno(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovno, o0, o1);
		}

		public void Cmovnp(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovnp, o0, o1);
		}

		public void Cmovns(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovns, o0, o1);
		}

		public void Cmovnz(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovnz, o0, o1);
		}

		public void Cmovo(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovo, o0, o1);
		}

		public void Cmovp(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovp, o0, o1);
		}

		public void Cmovpe(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovpe, o0, o1);
		}

		public void Cmovpo(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovpo, o0, o1);
		}

		public void Cmovs(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovs, o0, o1);
		}

		public void Cmovz(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmovz, o0, o1);
		}

		public void Cmov(Condition cc, GpVariable o0, Memory o1)
		{
			Compiler.Emit(CondToCmovcc(cc), o0, o1);
		}

		public void Cmova(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmova, o0, o1);
		}

		public void Cmovae(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovae, o0, o1);
		}

		public void Cmovb(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovb, o0, o1);
		}

		public void Cmovbe(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovbe, o0, o1);
		}

		public void Cmovc(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovc, o0, o1);
		}

		public void Cmove(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmove, o0, o1);
		}

		public void Cmovg(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovg, o0, o1);
		}

		public void Cmovge(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovge, o0, o1);
		}

		public void Cmovl(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovl, o0, o1);
		}

		public void Cmovle(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovle, o0, o1);
		}

		public void Cmovna(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovna, o0, o1);
		}

		public void Cmovnae(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovnae, o0, o1);
		}

		public void Cmovnb(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovnb, o0, o1);
		}

		public void Cmovnbe(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovnbe, o0, o1);
		}

		public void Cmovnc(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovnc, o0, o1);
		}

		public void Cmovne(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovne, o0, o1);
		}

		public void Cmovng(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovng, o0, o1);
		}

		public void Cmovnge(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovnge, o0, o1);
		}

		public void Cmovnl(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovnl, o0, o1);
		}

		public void Cmovnle(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovnle, o0, o1);
		}

		public void Cmovno(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovno, o0, o1);
		}

		public void Cmovnp(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovnp, o0, o1);
		}

		public void Cmovns(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovns, o0, o1);
		}

		public void Cmovnz(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovnz, o0, o1);
		}

		public void Cmovo(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovo, o0, o1);
		}

		public void Cmovp(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovp, o0, o1);
		}

		public void Cmovpe(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovpe, o0, o1);
		}

		public void Cmovpo(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovpo, o0, o1);
		}

		public void Cmovs(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovs, o0, o1);
		}

		public void Cmovz(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmovz, o0, o1);
		}

		public void Cmp(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmpsb(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.CmpsB, o0, o1);
		}

		public void Cmpsd(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.CmpsD, o0, o1);
		}

		public void Cmpsq(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.CmpsQ, o0, o1);
		}

		public void Cmpsw(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.CmpsW, o0, o1);
		}

		public void Cmpxchg(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Cmpxchg, o0, o1, o2);
		}

		public void Cmpxchg(GpVariable o0, Memory o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Cmpxchg, o0, o1, o2);
		}

		public void Cmpxchg16b(GpVariable r_edx, GpVariable r_eax, GpVariable r_ecx, GpVariable r_ebx, Memory x_mem)
		{
			Compiler.Emit(InstructionId.Cmpxchg16b, r_edx, r_eax, r_ecx, r_ebx, x_mem);
		}

		public void Cmpxchg8b(GpVariable r_edx, GpVariable r_eax, GpVariable r_ecx, GpVariable r_ebx, Memory x_mem)
		{
			Compiler.Emit(InstructionId.Cmpxchg8b, r_edx, r_eax, r_ecx, r_ebx, x_mem);
		}

		public void Cpuid(GpVariable x_eax, GpVariable w_ebx, GpVariable x_ecx, GpVariable w_edx)
		{
			Compiler.Emit(InstructionId.Cpuid, x_eax, w_ebx, x_ecx, w_edx);
		}

		public void Daa(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Daa, o0);
		}

		public void Das(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Das, o0);
		}

		public void Dec(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Dec, o0);
		}

		public void Dec(Memory o0)
		{
			Compiler.Emit(InstructionId.Dec, o0);
		}

		public void Div(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Div, o0, o1, o2);
		}

		public void Div(GpVariable o0, GpVariable o1, Memory o2)
		{
			Compiler.Emit(InstructionId.Div, o0, o1, o2);
		}

		public void Idiv(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Idiv, o0, o1, o2);
		}

		public void Idiv(GpVariable o0, GpVariable o1, Memory o2)
		{
			Compiler.Emit(InstructionId.Idiv, o0, o1, o2);
		}

		public void Imul(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1, o2);
		}

		public void Imul(GpVariable o0, GpVariable o1, Memory o2)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1, o2);
		}

		public void Imul(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1);
		}

		public void Imul(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1);
		}

		public void Imul(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1);
		}

		public void Imul(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1);
		}

		public void Imul(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1);
		}

		public void Imul(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1);
		}

		public void Imul(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1);
		}

		public void Imul(GpVariable o0, GpVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1, o2);
		}

		public void Imul(GpVariable o0, GpVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1, o2);
		}

		public void Imul(GpVariable o0, GpVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1, o2);
		}

		public void Imul(GpVariable o0, GpVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1, o2);
		}

		public void Imul(GpVariable o0, GpVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1, o2);
		}

		public void Imul(GpVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1, o2);
		}

		public void Imul(GpVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1, o2);
		}

		public void Imul(GpVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1, o2);
		}

		public void Imul(GpVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1, o2);
		}

		public void Imul(GpVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Imul, o0, o1, o2);
		}

		public void Inc(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Inc, o0);
		}

		public void Inc(Memory o0)
		{
			Compiler.Emit(InstructionId.Inc, o0);
		}

		public void Int(Immediate o0)
		{
			Compiler.Emit(InstructionId.Int, o0);
		}

		public void Int(int o0)
		{
			Compiler.Emit(InstructionId.Int, o0);
		}

		public void Int(uint o0)
		{
			Compiler.Emit(InstructionId.Int, o0);
		}

		public void Int(long o0)
		{
			Compiler.Emit(InstructionId.Int, o0);
		}

		public void Int(ulong o0)
		{
			Compiler.Emit(InstructionId.Int, o0);
		}

		public void Int3()
		{
			Int(3);
		}

		public void J(Condition cc, Label o0)
		{
			Compiler.Emit(CondToJcc(cc), o0);
		}

		public void Ja(Label o0)
		{
			Compiler.Emit(InstructionId.Ja, o0);
		}

		public void Jae(Label o0)
		{
			Compiler.Emit(InstructionId.Jae, o0);
		}

		public void Jb(Label o0)
		{
			Compiler.Emit(InstructionId.Jb, o0);
		}

		public void Jbe(Label o0)
		{
			Compiler.Emit(InstructionId.Jbe, o0);
		}

		public void Jc(Label o0)
		{
			Compiler.Emit(InstructionId.Jc, o0);
		}

		public void Je(Label o0)
		{
			Compiler.Emit(InstructionId.Je, o0);
		}

		public void Jg(Label o0)
		{
			Compiler.Emit(InstructionId.Jg, o0);
		}

		public void Jge(Label o0)
		{
			Compiler.Emit(InstructionId.Jge, o0);
		}

		public void Jl(Label o0)
		{
			Compiler.Emit(InstructionId.Jl, o0);
		}

		public void Jle(Label o0)
		{
			Compiler.Emit(InstructionId.Jle, o0);
		}

		public void Jna(Label o0)
		{
			Compiler.Emit(InstructionId.Jna, o0);
		}

		public void Jnae(Label o0)
		{
			Compiler.Emit(InstructionId.Jnae, o0);
		}

		public void Jnb(Label o0)
		{
			Compiler.Emit(InstructionId.Jnb, o0);
		}

		public void Jnbe(Label o0)
		{
			Compiler.Emit(InstructionId.Jnbe, o0);
		}

		public void Jnc(Label o0)
		{
			Compiler.Emit(InstructionId.Jnc, o0);
		}

		public void Jne(Label o0)
		{
			Compiler.Emit(InstructionId.Jne, o0);
		}

		public void Jng(Label o0)
		{
			Compiler.Emit(InstructionId.Jng, o0);
		}

		public void Jnge(Label o0)
		{
			Compiler.Emit(InstructionId.Jnge, o0);
		}

		public void Jnl(Label o0)
		{
			Compiler.Emit(InstructionId.Jnl, o0);
		}

		public void Jnle(Label o0)
		{
			Compiler.Emit(InstructionId.Jnle, o0);
		}

		public void Jno(Label o0)
		{
			Compiler.Emit(InstructionId.Jno, o0);
		}

		public void Jnp(Label o0)
		{
			Compiler.Emit(InstructionId.Jnp, o0);
		}

		public void Jns(Label o0)
		{
			Compiler.Emit(InstructionId.Jns, o0);
		}

		public void Jnz(Label o0)
		{
			Compiler.Emit(InstructionId.Jnz, o0);
		}

		public void Jo(Label o0)
		{
			Compiler.Emit(InstructionId.Jo, o0);
		}

		public void Jp(Label o0)
		{
			Compiler.Emit(InstructionId.Jp, o0);
		}

		public void Jpe(Label o0)
		{
			Compiler.Emit(InstructionId.Jpe, o0);
		}

		public void Jpo(Label o0)
		{
			Compiler.Emit(InstructionId.Jpo, o0);
		}

		public void Js(Label o0)
		{
			Compiler.Emit(InstructionId.Js, o0);
		}

		public void Jz(Label o0)
		{
			Compiler.Emit(InstructionId.Jz, o0);
		}

		public void Jecxz(GpVariable o0, Label o1)
		{
			Compiler.Emit(InstructionId.Jecxz, o0, o1);
		}

		public void Jmp(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Jmp, o0);
		}

		public void Jmp(Memory o0)
		{
			Compiler.Emit(InstructionId.Jmp, o0);
		}

		public void Jmp(Label o0)
		{
			Compiler.Emit(InstructionId.Jmp, o0);
		}

		public void Jmp(Immediate o0)
		{
			Compiler.Emit(InstructionId.Jmp, o0);
		}

		public void Jmp(Pointer dst)
		{
			Jmp(new Immediate((long)dst));
		}

		public void Lahf(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Lahf, o0);
		}

		public void Lea(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Lea, o0, o1);
		}

		public void Lodsb(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.LodsB, o0, o1);
		}

		public void Lodsd(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.LodsD, o0, o1);
		}

		public void Lodsq(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.LodsQ, o0, o1);
		}

		public void Lodsw(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.LodsW, o0, o1);
		}

		public void Mov(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(GpVariable o0, SegRegister o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(Memory o0, SegRegister o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(SegRegister o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(SegRegister o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Mov, o0, o1);
		}

		public void MovPtr(GpRegister o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.MovPtr, o0, o1);
		}

		public void MovPtr(GpRegister o0, Pointer o1)
		{
			Compiler.Emit(InstructionId.MovPtr, o0, new Immediate((long)o1));
		}

		public void MovPtr(Immediate o0, GpRegister o1)
		{
			Compiler.Emit(InstructionId.MovPtr, o0, o1);
		}

		public void MovPtr(Pointer o0, GpRegister o1)
		{
			Compiler.Emit(InstructionId.MovPtr, new Immediate((long)o0), o1);
		}

		public void Movbe(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movbe, o0, o1);
		}

		public void Movbe(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Movbe, o0, o1);
		}

		public void Movsb(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.MovsB, o0, o1);
		}

		public void Movsd(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.MovsD, o0, o1);
		}

		public void Movsq(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.MovsQ, o0, o1);
		}

		public void Movsw(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.MovsW, o0, o1);
		}

		public void Movsx(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Movsx, o0, o1);
		}

		public void Movsx(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movsx, o0, o1);
		}

		public void Movsxd(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Movsxd, o0, o1);
		}

		public void Movsxd(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movsxd, o0, o1);
		}

		public void Movzx(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Movzx, o0, o1);
		}

		public void Movzx(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movzx, o0, o1);
		}

		public void Mul(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Mul, o0, o1, o2);
		}

		public void Mul(GpVariable o0, GpVariable o1, Memory o2)
		{
			Compiler.Emit(InstructionId.Mul, o0, o1, o2);
		}

		public void Neg(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Neg, o0);
		}

		public void Neg(Memory o0)
		{
			Compiler.Emit(InstructionId.Neg, o0);
		}

		public void Nop()
		{
			Compiler.Emit(InstructionId.Nop);
		}

		public void Not(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Not, o0);
		}

		public void Not(Memory o0)
		{
			Compiler.Emit(InstructionId.Not, o0);
		}

		public void Or(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Or, o0, o1);
		}

		public void Pop(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Pop, o0);
		}

		public void Pop(Memory o0)
		{
			Compiler.Emit(InstructionId.Pop, o0);
		}

		public void Popf()
		{
			Compiler.Emit(InstructionId.Popf);
		}

		public void Push(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Push, o0);
		}

		public void Push(Memory o0)
		{
			Compiler.Emit(InstructionId.Push, o0);
		}

		public void Push(SegRegister o0)
		{
			Compiler.Emit(InstructionId.Push, o0);
		}

		public void Push(Immediate o0)
		{
			Compiler.Emit(InstructionId.Push, o0);
		}

		public void Push(int o0)
		{
			Compiler.Emit(InstructionId.Push, o0);
		}

		public void Push(uint o0)
		{
			Compiler.Emit(InstructionId.Push, o0);
		}

		public void Push(long o0)
		{
			Compiler.Emit(InstructionId.Push, o0);
		}

		public void Push(ulong o0)
		{
			Compiler.Emit(InstructionId.Push, o0);
		}

		public void Pushf()
		{
			Compiler.Emit(InstructionId.Pushf);
		}

		public void Rcl(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcr(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rdtsc(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Rdtsc, o0, o1);
		}

		public void Rdtscp(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Rdtscp, o0, o1, o2);
		}

		public void RepLodsb(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepLodsB, o0, o1, o2);
		}

		public void RepLodsd(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepLodsD, o0, o1, o2);
		}

		public void RepLodsq(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepLodsQ, o0, o1, o2);
		}

		public void RepLodsw(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepLodsW, o0, o1, o2);
		}

		public void RepMovsb(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepMovsB, o0, o1, o2);
		}

		public void RepMovsd(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepMovsD, o0, o1, o2);
		}

		public void RepMovsq(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepMovsQ, o0, o1, o2);
		}

		public void RepMovsw(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepMovsW, o0, o1, o2);
		}

		public void RepStosb(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepStosB, o0, o1, o2);
		}

		public void RepStosd(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepStosD, o0, o1, o2);
		}

		public void RepStosq(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepStosQ, o0, o1, o2);
		}

		public void RepStosw(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepStosW, o0, o1, o2);
		}

		public void RepeCmpsb(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepeCmpsB, o0, o1, o2);
		}

		public void RepeCmpsd(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepeCmpsD, o0, o1, o2);
		}

		public void RepeCmpsq(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepeCmpsQ, o0, o1, o2);
		}

		public void RepeCmpsw(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepeCmpsW, o0, o1, o2);
		}

		public void RepeScasb(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepeScasB, o0, o1, o2);
		}

		public void RepeScasd(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepeScasD, o0, o1, o2);
		}

		public void RepeScasq(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepeScasQ, o0, o1, o2);
		}

		public void RepeScasw(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepeScasW, o0, o1, o2);
		}

		public void RepneCmpsb(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepneCmpsB, o0, o1, o2);
		}

		public void RepneCmpsd(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepneCmpsD, o0, o1, o2);
		}

		public void RepneCmpsq(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepneCmpsQ, o0, o1, o2);
		}

		public void RepneCmpsw(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepneCmpsW, o0, o1, o2);
		}

		public void RepneScasb(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepneScasB, o0, o1, o2);
		}

		public void RepneScasd(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepneScasD, o0, o1, o2);
		}

		public void RepneScasq(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepneScasQ, o0, o1, o2);
		}

		public void RepneScasw(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.RepneScasW, o0, o1, o2);
		}

		public void Ret()
		{
			Compiler.CreateReturn(Operand.Invalid, Operand.Invalid);
		}

		public void Ret(GpVariable o0)
		{
			Compiler.CreateReturn(o0, Operand.Invalid);
		}

		public void Ret(GpVariable o0, GpVariable o1)
		{
			Compiler.CreateReturn(o0, o1);
		}

		public void Ret(XmmVariable o0)
		{
			Compiler.CreateReturn(o0, Operand.Invalid);
		}

		public void Ret(XmmVariable o0, XmmVariable o1)
		{
			Compiler.CreateReturn(o0, o1);
		}

		public void Rol(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Ror(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Sahf(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Sahf, o0);
		}

		public void Sbb(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sal(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sar(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Scasb(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.ScasB, o0, o1);
		}

		public void Scasd(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.ScasD, o0, o1);
		}

		public void Scasq(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.ScasQ, o0, o1);
		}

		public void Scasw(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.ScasW, o0, o1);
		}

		public void Set(Condition cc, GpVariable o0)
		{
			Compiler.Emit(CondToSetcc(cc), o0);
		}

		public void Seta(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Seta, o0);
		}

		public void Setae(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setae, o0);
		}

		public void Setb(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setb, o0);
		}

		public void Setbe(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setbe, o0);
		}

		public void Setc(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setc, o0);
		}

		public void Sete(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Sete, o0);
		}

		public void Setg(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setg, o0);
		}

		public void Setge(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setge, o0);
		}

		public void Setl(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setl, o0);
		}

		public void Setle(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setle, o0);
		}

		public void Setna(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setna, o0);
		}

		public void Setnae(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setnae, o0);
		}

		public void Setnb(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setnb, o0);
		}

		public void Setnbe(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setnbe, o0);
		}

		public void Setnc(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setnc, o0);
		}

		public void Setne(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setne, o0);
		}

		public void Setng(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setng, o0);
		}

		public void Setnge(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setnge, o0);
		}

		public void Setnl(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setnl, o0);
		}

		public void Setnle(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setnle, o0);
		}

		public void Setno(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setno, o0);
		}

		public void Setnp(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setnp, o0);
		}

		public void Setns(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setns, o0);
		}

		public void Setnz(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setnz, o0);
		}

		public void Seto(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Seto, o0);
		}

		public void Setp(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setp, o0);
		}

		public void Setpe(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setpe, o0);
		}

		public void Setpo(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setpo, o0);
		}

		public void Sets(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Sets, o0);
		}

		public void Setz(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Setz, o0);
		}

		public void Set(Condition cc, Memory o0)
		{
			Compiler.Emit(CondToSetcc(cc), o0);
		}

		public void Seta(Memory o0)
		{
			Compiler.Emit(InstructionId.Seta, o0);
		}

		public void Setae(Memory o0)
		{
			Compiler.Emit(InstructionId.Setae, o0);
		}

		public void Setb(Memory o0)
		{
			Compiler.Emit(InstructionId.Setb, o0);
		}

		public void Setbe(Memory o0)
		{
			Compiler.Emit(InstructionId.Setbe, o0);
		}

		public void Setc(Memory o0)
		{
			Compiler.Emit(InstructionId.Setc, o0);
		}

		public void Sete(Memory o0)
		{
			Compiler.Emit(InstructionId.Sete, o0);
		}

		public void Setg(Memory o0)
		{
			Compiler.Emit(InstructionId.Setg, o0);
		}

		public void Setge(Memory o0)
		{
			Compiler.Emit(InstructionId.Setge, o0);
		}

		public void Setl(Memory o0)
		{
			Compiler.Emit(InstructionId.Setl, o0);
		}

		public void Setle(Memory o0)
		{
			Compiler.Emit(InstructionId.Setle, o0);
		}

		public void Setna(Memory o0)
		{
			Compiler.Emit(InstructionId.Setna, o0);
		}

		public void Setnae(Memory o0)
		{
			Compiler.Emit(InstructionId.Setnae, o0);
		}

		public void Setnb(Memory o0)
		{
			Compiler.Emit(InstructionId.Setnb, o0);
		}

		public void Setnbe(Memory o0)
		{
			Compiler.Emit(InstructionId.Setnbe, o0);
		}

		public void Setnc(Memory o0)
		{
			Compiler.Emit(InstructionId.Setnc, o0);
		}

		public void Setne(Memory o0)
		{
			Compiler.Emit(InstructionId.Setne, o0);
		}

		public void Setng(Memory o0)
		{
			Compiler.Emit(InstructionId.Setng, o0);
		}

		public void Setnge(Memory o0)
		{
			Compiler.Emit(InstructionId.Setnge, o0);
		}

		public void Setnl(Memory o0)
		{
			Compiler.Emit(InstructionId.Setnl, o0);
		}

		public void Setnle(Memory o0)
		{
			Compiler.Emit(InstructionId.Setnle, o0);
		}

		public void Setno(Memory o0)
		{
			Compiler.Emit(InstructionId.Setno, o0);
		}

		public void Setnp(Memory o0)
		{
			Compiler.Emit(InstructionId.Setnp, o0);
		}

		public void Setns(Memory o0)
		{
			Compiler.Emit(InstructionId.Setns, o0);
		}

		public void Setnz(Memory o0)
		{
			Compiler.Emit(InstructionId.Setnz, o0);
		}

		public void Seto(Memory o0)
		{
			Compiler.Emit(InstructionId.Seto, o0);
		}

		public void Setp(Memory o0)
		{
			Compiler.Emit(InstructionId.Setp, o0);
		}

		public void Setpe(Memory o0)
		{
			Compiler.Emit(InstructionId.Setpe, o0);
		}

		public void Setpo(Memory o0)
		{
			Compiler.Emit(InstructionId.Setpo, o0);
		}

		public void Sets(Memory o0)
		{
			Compiler.Emit(InstructionId.Sets, o0);
		}

		public void Setz(Memory o0)
		{
			Compiler.Emit(InstructionId.Setz, o0);
		}

		public void Shl(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shr(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shld(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(Memory o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(GpVariable o0, GpVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(GpVariable o0, GpVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(GpVariable o0, GpVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(GpVariable o0, GpVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(GpVariable o0, GpVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(Memory o0, GpVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(Memory o0, GpVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(Memory o0, GpVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(Memory o0, GpVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(Memory o0, GpVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shrd(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(Memory o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(GpVariable o0, GpVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(GpVariable o0, GpVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(GpVariable o0, GpVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(GpVariable o0, GpVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(GpVariable o0, GpVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(Memory o0, GpVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(Memory o0, GpVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(Memory o0, GpVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(Memory o0, GpVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(Memory o0, GpVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Stc()
		{
			Compiler.Emit(InstructionId.Stc);
		}

		public void Std()
		{
			Compiler.Emit(InstructionId.Std);
		}

		public void Stosb(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.StosB, o0, o1);
		}

		public void Stosd(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.StosD, o0, o1);
		}

		public void Stosq(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.StosQ, o0, o1);
		}

		public void Stosw(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.StosW, o0, o1);
		}

		public void Sub(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Test(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Test, o0, o1);
		}

		public void Ud2()
		{
			Compiler.Emit(InstructionId.Ud2);
		}

		public void Xadd(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Xadd, o0, o1);
		}

		public void Xadd(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Xadd, o0, o1);
		}

		public void Xchg(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Xchg, o0, o1);
		}

		public void Xchg(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Xchg, o0, o1);
		}

		public void Xchg(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Xchg, o0, o1);
		}

		public void Xor(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(GpVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(GpVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(GpVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(GpVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(GpVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Xor, o0, o1);
		}

		public void F2xm1()
		{
			Compiler.Emit(InstructionId.F2xm1);
		}

		public void Fabs()
		{
			Compiler.Emit(InstructionId.Fabs);
		}

		public void Fadd(FpRegister o0, FpRegister o1)
		{
			Compiler.Emit(InstructionId.Fadd, o0, o1);
		}

		public void Fadd(Memory o0)
		{
			Compiler.Emit(InstructionId.Fadd, o0);
		}

		public void Faddp(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Faddp, o0);
		}

		public void Faddp()
		{
			Compiler.Emit(InstructionId.Faddp);
		}

		public void Fbld(Memory o0)
		{
			Compiler.Emit(InstructionId.Fbld, o0);
		}

		public void Fbstp(Memory o0)
		{
			Compiler.Emit(InstructionId.Fbstp, o0);
		}

		public void Fchs()
		{
			Compiler.Emit(InstructionId.Fchs);
		}

		public void Fclex()
		{
			Compiler.Emit(InstructionId.Fclex);
		}

		public void Fcmovb(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fcmovb, o0);
		}

		public void Fcmovbe(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fcmovbe, o0);
		}

		public void Fcmove(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fcmove, o0);
		}

		public void Fcmovnb(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fcmovnb, o0);
		}

		public void Fcmovnbe(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fcmovnbe, o0);
		}

		public void Fcmovne(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fcmovne, o0);
		}

		public void Fcmovnu(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fcmovnu, o0);
		}

		public void Fcmovu(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fcmovu, o0);
		}

		public void Fcom(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fcom, o0);
		}

		public void Fcom()
		{
			Compiler.Emit(InstructionId.Fcom);
		}

		public void Fcom(Memory o0)
		{
			Compiler.Emit(InstructionId.Fcom, o0);
		}

		public void Fcomp(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fcomp, o0);
		}

		public void Fcomp()
		{
			Compiler.Emit(InstructionId.Fcomp);
		}

		public void Fcomp(Memory o0)
		{
			Compiler.Emit(InstructionId.Fcomp, o0);
		}

		public void Fcompp()
		{
			Compiler.Emit(InstructionId.Fcompp);
		}

		public void Fcomi(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fcomi, o0);
		}

		public void Fcomip(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fcomip, o0);
		}

		public void Fcos()
		{
			Compiler.Emit(InstructionId.Fcos);
		}

		public void Fdecstp()
		{
			Compiler.Emit(InstructionId.Fdecstp);
		}

		public void Fdiv(FpRegister o0, FpRegister o1)
		{
			Compiler.Emit(InstructionId.Fdiv, o0, o1);
		}

		public void Fdiv(Memory o0)
		{
			Compiler.Emit(InstructionId.Fdiv, o0);
		}

		public void Fdivp(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fdivp, o0);
		}

		public void Fdivp()
		{
			Compiler.Emit(InstructionId.Fdivp);
		}

		public void Fdivr(FpRegister o0, FpRegister o1)
		{
			Compiler.Emit(InstructionId.Fdivr, o0, o1);
		}

		public void Fdivr(Memory o0)
		{
			Compiler.Emit(InstructionId.Fdivr, o0);
		}

		public void Fdivrp(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fdivrp, o0);
		}

		public void Fdivrp()
		{
			Compiler.Emit(InstructionId.Fdivrp);
		}

		public void Ffree(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Ffree, o0);
		}

		public void Fiadd(Memory o0)
		{
			Compiler.Emit(InstructionId.Fiadd, o0);
		}

		public void Ficom(Memory o0)
		{
			Compiler.Emit(InstructionId.Ficom, o0);
		}

		public void Ficomp(Memory o0)
		{
			Compiler.Emit(InstructionId.Ficomp, o0);
		}

		public void Fidiv(Memory o0)
		{
			Compiler.Emit(InstructionId.Fidiv, o0);
		}

		public void Fidivr(Memory o0)
		{
			Compiler.Emit(InstructionId.Fidivr, o0);
		}

		public void Fild(Memory o0)
		{
			Compiler.Emit(InstructionId.Fild, o0);
		}

		public void Fimul(Memory o0)
		{
			Compiler.Emit(InstructionId.Fimul, o0);
		}

		public void Fincstp()
		{
			Compiler.Emit(InstructionId.Fincstp);
		}

		public void Finit()
		{
			Compiler.Emit(InstructionId.Finit);
		}

		public void Fisub(Memory o0)
		{
			Compiler.Emit(InstructionId.Fisub, o0);
		}

		public void Fisubr(Memory o0)
		{
			Compiler.Emit(InstructionId.Fisubr, o0);
		}

		public void Fninit()
		{
			Compiler.Emit(InstructionId.Fninit);
		}

		public void Fist(Memory o0)
		{
			Compiler.Emit(InstructionId.Fist, o0);
		}

		public void Fistp(Memory o0)
		{
			Compiler.Emit(InstructionId.Fistp, o0);
		}

		public void Fld(Memory o0)
		{
			Compiler.Emit(InstructionId.Fld, o0);
		}

		public void Fld(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fld, o0);
		}

		public void Fld1()
		{
			Compiler.Emit(InstructionId.Fld1);
		}

		public void Fldl2t()
		{
			Compiler.Emit(InstructionId.Fldl2t);
		}

		public void Fldl2e()
		{
			Compiler.Emit(InstructionId.Fldl2e);
		}

		public void Fldpi()
		{
			Compiler.Emit(InstructionId.Fldpi);
		}

		public void Fldlg2()
		{
			Compiler.Emit(InstructionId.Fldlg2);
		}

		public void Fldln2()
		{
			Compiler.Emit(InstructionId.Fldln2);
		}

		public void Fldz()
		{
			Compiler.Emit(InstructionId.Fldz);
		}

		public void Fldcw(Memory o0)
		{
			Compiler.Emit(InstructionId.Fldcw, o0);
		}

		public void Fldenv(Memory o0)
		{
			Compiler.Emit(InstructionId.Fldenv, o0);
		}

		public void Fmul(FpRegister o0, FpRegister o1)
		{
			Compiler.Emit(InstructionId.Fmul, o0, o1);
		}

		public void Fmul(Memory o0)
		{
			Compiler.Emit(InstructionId.Fmul, o0);
		}

		public void Fmulp(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fmulp, o0);
		}

		public void Fmulp()
		{
			Compiler.Emit(InstructionId.Fmulp);
		}

		public void Fnclex()
		{
			Compiler.Emit(InstructionId.Fnclex);
		}

		public void Fnop()
		{
			Compiler.Emit(InstructionId.Fnop);
		}

		public void Fnsave(Memory o0)
		{
			Compiler.Emit(InstructionId.Fnsave, o0);
		}

		public void Fnstenv(Memory o0)
		{
			Compiler.Emit(InstructionId.Fnstenv, o0);
		}

		public void Fnstcw(Memory o0)
		{
			Compiler.Emit(InstructionId.Fnstcw, o0);
		}

		public void Fnstsw(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Fnstsw, o0);
		}

		public void Fnstsw(Memory o0)
		{
			Compiler.Emit(InstructionId.Fnstsw, o0);
		}

		public void Fpatan()
		{
			Compiler.Emit(InstructionId.Fpatan);
		}

		public void Fprem()
		{
			Compiler.Emit(InstructionId.Fprem);
		}

		public void Fprem1()
		{
			Compiler.Emit(InstructionId.Fprem1);
		}

		public void Fptan()
		{
			Compiler.Emit(InstructionId.Fptan);
		}

		public void Frndint()
		{
			Compiler.Emit(InstructionId.Frndint);
		}

		public void Frstor(Memory o0)
		{
			Compiler.Emit(InstructionId.Frstor, o0);
		}

		public void Fsave(Memory o0)
		{
			Compiler.Emit(InstructionId.Fsave, o0);
		}

		public void Fscale()
		{
			Compiler.Emit(InstructionId.Fscale);
		}

		public void Fsin()
		{
			Compiler.Emit(InstructionId.Fsin);
		}

		public void Fsincos()
		{
			Compiler.Emit(InstructionId.Fsincos);
		}

		public void Fsqrt()
		{
			Compiler.Emit(InstructionId.Fsqrt);
		}

		public void Fst(Memory o0)
		{
			Compiler.Emit(InstructionId.Fst, o0);
		}

		public void Fst(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fst, o0);
		}

		public void Fstp(Memory o0)
		{
			Compiler.Emit(InstructionId.Fstp, o0);
		}

		public void Fstp(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fstp, o0);
		}

		public void Fstcw(Memory o0)
		{
			Compiler.Emit(InstructionId.Fstcw, o0);
		}

		public void Fstenv(Memory o0)
		{
			Compiler.Emit(InstructionId.Fstenv, o0);
		}

		public void Fstsw(GpVariable o0)
		{
			Compiler.Emit(InstructionId.Fstsw, o0);
		}

		public void Fstsw(Memory o0)
		{
			Compiler.Emit(InstructionId.Fstsw, o0);
		}

		public void Fsub(FpRegister o0, FpRegister o1)
		{
			Compiler.Emit(InstructionId.Fsub, o0, o1);
		}

		public void Fsub(Memory o0)
		{
			Compiler.Emit(InstructionId.Fsub, o0);
		}

		public void Fsubp(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fsubp, o0);
		}

		public void Fsubp()
		{
			Compiler.Emit(InstructionId.Fsubp);
		}

		public void Fsubr(FpRegister o0, FpRegister o1)
		{
			Compiler.Emit(InstructionId.Fsubr, o0, o1);
		}

		public void Fsubr(Memory o0)
		{
			Compiler.Emit(InstructionId.Fsubr, o0);
		}

		public void Fsubrp(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fsubrp, o0);
		}

		public void Fsubrp()
		{
			Compiler.Emit(InstructionId.Fsubrp);
		}

		public void Ftst()
		{
			Compiler.Emit(InstructionId.Ftst);
		}

		public void Fucom(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fucom, o0);
		}

		public void Fucom()
		{
			Compiler.Emit(InstructionId.Fucom);
		}

		public void Fucomi(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fucomi, o0);
		}

		public void Fucomip(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fucomip, o0);
		}

		public void Fucomp(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fucomp, o0);
		}

		public void Fucomp()
		{
			Compiler.Emit(InstructionId.Fucomp);
		}

		public void Fucompp()
		{
			Compiler.Emit(InstructionId.Fucompp);
		}

		public void Fwait()
		{
			Compiler.Emit(InstructionId.Fwait);
		}

		public void Fxam()
		{
			Compiler.Emit(InstructionId.Fxam);
		}

		public void Fxch(FpRegister o0)
		{
			Compiler.Emit(InstructionId.Fxch, o0);
		}

		public void Fxrstor(Memory o0)
		{
			Compiler.Emit(InstructionId.Fxrstor, o0);
		}

		public void Fxsave(Memory o0)
		{
			Compiler.Emit(InstructionId.Fxsave, o0);
		}

		public void Fxtract()
		{
			Compiler.Emit(InstructionId.Fxtract);
		}

		public void Fyl2x()
		{
			Compiler.Emit(InstructionId.Fyl2x);
		}

		public void Fyl2xp1()
		{
			Compiler.Emit(InstructionId.Fyl2xp1);
		}

		public void Movd(Memory o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movd(GpVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movd(MmVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movq(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(Memory o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(GpVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(MmVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Packssdw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Packssdw, o0, o1);
		}

		public void Packssdw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Packssdw, o0, o1);
		}

		public void Packsswb(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Packsswb, o0, o1);
		}

		public void Packsswb(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Packsswb, o0, o1);
		}

		public void Packuswb(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Packuswb, o0, o1);
		}

		public void Packuswb(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Packuswb, o0, o1);
		}

		public void Paddb(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddb, o0, o1);
		}

		public void Paddb(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddb, o0, o1);
		}

		public void Paddd(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddd, o0, o1);
		}

		public void Paddd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddd, o0, o1);
		}

		public void Paddsb(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddsb, o0, o1);
		}

		public void Paddsb(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddsb, o0, o1);
		}

		public void Paddsw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddsw, o0, o1);
		}

		public void Paddsw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddsw, o0, o1);
		}

		public void Paddusb(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddusb, o0, o1);
		}

		public void Paddusb(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddusb, o0, o1);
		}

		public void Paddusw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddusw, o0, o1);
		}

		public void Paddusw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddusw, o0, o1);
		}

		public void Paddw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddw, o0, o1);
		}

		public void Paddw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddw, o0, o1);
		}

		public void Pand(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pand, o0, o1);
		}

		public void Pand(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pand, o0, o1);
		}

		public void Pandn(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pandn, o0, o1);
		}

		public void Pandn(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pandn, o0, o1);
		}

		public void Pcmpeqb(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pcmpeqb, o0, o1);
		}

		public void Pcmpeqb(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pcmpeqb, o0, o1);
		}

		public void Pcmpeqd(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pcmpeqd, o0, o1);
		}

		public void Pcmpeqd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pcmpeqd, o0, o1);
		}

		public void Pcmpeqw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pcmpeqw, o0, o1);
		}

		public void Pcmpeqw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pcmpeqw, o0, o1);
		}

		public void Pcmpgtb(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pcmpgtb, o0, o1);
		}

		public void Pcmpgtb(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pcmpgtb, o0, o1);
		}

		public void Pcmpgtd(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pcmpgtd, o0, o1);
		}

		public void Pcmpgtd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pcmpgtd, o0, o1);
		}

		public void Pcmpgtw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pcmpgtw, o0, o1);
		}

		public void Pcmpgtw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pcmpgtw, o0, o1);
		}

		public void Pmulhw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmulhw, o0, o1);
		}

		public void Pmulhw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmulhw, o0, o1);
		}

		public void Pmullw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmullw, o0, o1);
		}

		public void Pmullw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmullw, o0, o1);
		}

		public void Por(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Por, o0, o1);
		}

		public void Por(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Por, o0, o1);
		}

		public void Pmaddwd(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmaddwd, o0, o1);
		}

		public void Pmaddwd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmaddwd, o0, o1);
		}

		public void Pslld(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(MmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(MmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(MmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(MmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(MmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Psllq(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(MmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(MmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(MmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(MmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(MmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(MmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(MmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(MmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(MmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(MmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psrad(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(MmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(MmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(MmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(MmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(MmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psraw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(MmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(MmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(MmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(MmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(MmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psrld(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(MmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(MmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(MmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(MmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(MmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrlq(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(MmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(MmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(MmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(MmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(MmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(MmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(MmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(MmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(MmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(MmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psubb(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubb, o0, o1);
		}

		public void Psubb(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubb, o0, o1);
		}

		public void Psubd(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubd, o0, o1);
		}

		public void Psubd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubd, o0, o1);
		}

		public void Psubsb(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubsb, o0, o1);
		}

		public void Psubsb(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubsb, o0, o1);
		}

		public void Psubsw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubsw, o0, o1);
		}

		public void Psubsw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubsw, o0, o1);
		}

		public void Psubusb(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubusb, o0, o1);
		}

		public void Psubusb(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubusb, o0, o1);
		}

		public void Psubusw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubusw, o0, o1);
		}

		public void Psubusw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubusw, o0, o1);
		}

		public void Psubw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubw, o0, o1);
		}

		public void Psubw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubw, o0, o1);
		}

		public void Punpckhbw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Punpckhbw, o0, o1);
		}

		public void Punpckhbw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Punpckhbw, o0, o1);
		}

		public void Punpckhdq(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Punpckhdq, o0, o1);
		}

		public void Punpckhdq(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Punpckhdq, o0, o1);
		}

		public void Punpckhwd(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Punpckhwd, o0, o1);
		}

		public void Punpckhwd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Punpckhwd, o0, o1);
		}

		public void Punpcklbw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Punpcklbw, o0, o1);
		}

		public void Punpcklbw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Punpcklbw, o0, o1);
		}

		public void Punpckldq(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Punpckldq, o0, o1);
		}

		public void Punpckldq(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Punpckldq, o0, o1);
		}

		public void Punpcklwd(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Punpcklwd, o0, o1);
		}

		public void Punpcklwd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Punpcklwd, o0, o1);
		}

		public void Pxor(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pxor, o0, o1);
		}

		public void Pxor(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pxor, o0, o1);
		}

		public void Emms()
		{
			Compiler.Emit(InstructionId.Emms);
		}

		public void Pf2id(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pf2id, o0, o1);
		}

		public void Pf2id(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pf2id, o0, o1);
		}

		public void Pf2iw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pf2iw, o0, o1);
		}

		public void Pf2iw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pf2iw, o0, o1);
		}

		public void Pfacc(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfacc, o0, o1);
		}

		public void Pfacc(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfacc, o0, o1);
		}

		public void Pfadd(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfadd, o0, o1);
		}

		public void Pfadd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfadd, o0, o1);
		}

		public void Pfcmpeq(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfcmpeq, o0, o1);
		}

		public void Pfcmpeq(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfcmpeq, o0, o1);
		}

		public void Pfcmpge(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfcmpge, o0, o1);
		}

		public void Pfcmpge(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfcmpge, o0, o1);
		}

		public void Pfcmpgt(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfcmpgt, o0, o1);
		}

		public void Pfcmpgt(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfcmpgt, o0, o1);
		}

		public void Pfmax(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfmax, o0, o1);
		}

		public void Pfmax(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfmax, o0, o1);
		}

		public void Pfmin(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfmin, o0, o1);
		}

		public void Pfmin(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfmin, o0, o1);
		}

		public void Pfmul(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfmul, o0, o1);
		}

		public void Pfmul(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfmul, o0, o1);
		}

		public void Pfnacc(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfnacc, o0, o1);
		}

		public void Pfnacc(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfnacc, o0, o1);
		}

		public void Pfpnacc(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfpnacc, o0, o1);
		}

		public void Pfpnacc(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfpnacc, o0, o1);
		}

		public void Pfrcp(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfrcp, o0, o1);
		}

		public void Pfrcp(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfrcp, o0, o1);
		}

		public void Pfrcpit1(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfrcpit1, o0, o1);
		}

		public void Pfrcpit1(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfrcpit1, o0, o1);
		}

		public void Pfrcpit2(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfrcpit2, o0, o1);
		}

		public void Pfrcpit2(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfrcpit2, o0, o1);
		}

		public void Pfrsqit1(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfrsqit1, o0, o1);
		}

		public void Pfrsqit1(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfrsqit1, o0, o1);
		}

		public void Pfrsqrt(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfrsqrt, o0, o1);
		}

		public void Pfrsqrt(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfrsqrt, o0, o1);
		}

		public void Pfsub(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfsub, o0, o1);
		}

		public void Pfsub(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfsub, o0, o1);
		}

		public void Pfsubr(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pfsubr, o0, o1);
		}

		public void Pfsubr(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pfsubr, o0, o1);
		}

		public void Pi2fd(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pi2fd, o0, o1);
		}

		public void Pi2fd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pi2fd, o0, o1);
		}

		public void Pi2fw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pi2fw, o0, o1);
		}

		public void Pi2fw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pi2fw, o0, o1);
		}

		public void Pswapd(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pswapd, o0, o1);
		}

		public void Pswapd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pswapd, o0, o1);
		}

		public void Prefetch_3dnow(Memory o0)
		{
			Compiler.Emit(InstructionId.Prefetch3dNow, o0);
		}

		public void Prefetchw_3dnow(Memory o0)
		{
			Compiler.Emit(InstructionId.Prefetchw3dNow, o0);
		}

		public void Femms()
		{
			Compiler.Emit(InstructionId.Femms);
		}

		public void Addps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Addps, o0, o1);
		}

		public void Addps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Addps, o0, o1);
		}

		public void Addss(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Addss, o0, o1);
		}

		public void Addss(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Addss, o0, o1);
		}

		public void Andnps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Andnps, o0, o1);
		}

		public void Andnps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Andnps, o0, o1);
		}

		public void Andps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Andps, o0, o1);
		}

		public void Andps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Andps, o0, o1);
		}

		public void Cmpps(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Cmpps, o0, o1, o2);
		}

		public void Cmpps(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Cmpps, o0, o1, o2);
		}

		public void Cmpps(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Cmpps, o0, o1, o2);
		}

		public void Cmpps(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Cmpps, o0, o1, o2);
		}

		public void Cmpps(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Cmpps, o0, o1, o2);
		}

		public void Cmpps(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Cmpps, o0, o1, o2);
		}

		public void Cmpps(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Cmpps, o0, o1, o2);
		}

		public void Cmpps(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Cmpps, o0, o1, o2);
		}

		public void Cmpps(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Cmpps, o0, o1, o2);
		}

		public void Cmpps(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Cmpps, o0, o1, o2);
		}

		public void Cmpss(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Cmpss, o0, o1, o2);
		}

		public void Cmpss(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Cmpss, o0, o1, o2);
		}

		public void Cmpss(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Cmpss, o0, o1, o2);
		}

		public void Cmpss(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Cmpss, o0, o1, o2);
		}

		public void Cmpss(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Cmpss, o0, o1, o2);
		}

		public void Cmpss(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Cmpss, o0, o1, o2);
		}

		public void Cmpss(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Cmpss, o0, o1, o2);
		}

		public void Cmpss(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Cmpss, o0, o1, o2);
		}

		public void Cmpss(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Cmpss, o0, o1, o2);
		}

		public void Cmpss(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Cmpss, o0, o1, o2);
		}

		public void Comiss(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Comiss, o0, o1);
		}

		public void Comiss(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Comiss, o0, o1);
		}

		public void Cvtpi2ps(XmmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtpi2ps, o0, o1);
		}

		public void Cvtpi2ps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtpi2ps, o0, o1);
		}

		public void Cvtps2pi(MmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtps2pi, o0, o1);
		}

		public void Cvtps2pi(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtps2pi, o0, o1);
		}

		public void Cvtsi2ss(XmmVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtsi2ss, o0, o1);
		}

		public void Cvtsi2ss(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtsi2ss, o0, o1);
		}

		public void Cvtss2si(GpVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtss2si, o0, o1);
		}

		public void Cvtss2si(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtss2si, o0, o1);
		}

		public void Cvttps2pi(MmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvttps2pi, o0, o1);
		}

		public void Cvttps2pi(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvttps2pi, o0, o1);
		}

		public void Cvttss2si(GpVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvttss2si, o0, o1);
		}

		public void Cvttss2si(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvttss2si, o0, o1);
		}

		public void Divps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Divps, o0, o1);
		}

		public void Divps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Divps, o0, o1);
		}

		public void Divss(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Divss, o0, o1);
		}

		public void Divss(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Divss, o0, o1);
		}

		public void Ldmxcsr(Memory o0)
		{
			Compiler.Emit(InstructionId.Ldmxcsr, o0);
		}

		public void Maskmovq(GpVariable o0, MmVariable o1, MmVariable o2)
		{
			Compiler.Emit(InstructionId.Maskmovq, o0, o1, o2);
		}

		public void Maxps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Maxps, o0, o1);
		}

		public void Maxps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Maxps, o0, o1);
		}

		public void Maxss(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Maxss, o0, o1);
		}

		public void Maxss(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Maxss, o0, o1);
		}

		public void Minps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Minps, o0, o1);
		}

		public void Minps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Minps, o0, o1);
		}

		public void Minss(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Minss, o0, o1);
		}

		public void Minss(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Minss, o0, o1);
		}

		public void Movaps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movaps, o0, o1);
		}

		public void Movaps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movaps, o0, o1);
		}

		public void Movaps(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movaps, o0, o1);
		}

		public void Movd(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movd(GpVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movd(XmmVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(GpVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(XmmVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movntq(Memory o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Movntq, o0, o1);
		}

		public void Movhlps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movhlps, o0, o1);
		}

		public void Movhps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movhps, o0, o1);
		}

		public void Movhps(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movhps, o0, o1);
		}

		public void Movlhps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movlhps, o0, o1);
		}

		public void Movlps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movlps, o0, o1);
		}

		public void Movlps(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movlps, o0, o1);
		}

		public void Movntps(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movntps, o0, o1);
		}

		public void Movss(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movss, o0, o1);
		}

		public void Movss(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movss, o0, o1);
		}

		public void Movss(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movss, o0, o1);
		}

		public void Movups(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movups, o0, o1);
		}

		public void Movups(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movups, o0, o1);
		}

		public void Movups(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movups, o0, o1);
		}

		public void Mulps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Mulps, o0, o1);
		}

		public void Mulps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Mulps, o0, o1);
		}

		public void Mulss(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Mulss, o0, o1);
		}

		public void Mulss(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Mulss, o0, o1);
		}

		public void Orps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Orps, o0, o1);
		}

		public void Orps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Orps, o0, o1);
		}

		public void Pavgb(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pavgb, o0, o1);
		}

		public void Pavgb(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pavgb, o0, o1);
		}

		public void Pavgw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pavgw, o0, o1);
		}

		public void Pavgw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pavgw, o0, o1);
		}

		public void Pextrw(GpVariable o0, MmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(GpVariable o0, MmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(GpVariable o0, MmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(GpVariable o0, MmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(GpVariable o0, MmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pinsrw(MmVariable o0, GpVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(MmVariable o0, GpVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(MmVariable o0, GpVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(MmVariable o0, GpVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(MmVariable o0, GpVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(MmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(MmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(MmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(MmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(MmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pmaxsw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmaxsw, o0, o1);
		}

		public void Pmaxsw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmaxsw, o0, o1);
		}

		public void Pmaxub(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmaxub, o0, o1);
		}

		public void Pmaxub(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmaxub, o0, o1);
		}

		public void Pminsw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pminsw, o0, o1);
		}

		public void Pminsw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pminsw, o0, o1);
		}

		public void Pminub(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pminub, o0, o1);
		}

		public void Pminub(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pminub, o0, o1);
		}

		public void Pmovmskb(GpVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmovmskb, o0, o1);
		}

		public void Pmulhuw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmulhuw, o0, o1);
		}

		public void Pmulhuw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmulhuw, o0, o1);
		}

		public void Psadbw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psadbw, o0, o1);
		}

		public void Psadbw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psadbw, o0, o1);
		}

		public void Pshufw(MmVariable o0, MmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pshufw, o0, o1, o2);
		}

		public void Pshufw(MmVariable o0, MmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pshufw, o0, o1, o2);
		}

		public void Pshufw(MmVariable o0, MmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pshufw, o0, o1, o2);
		}

		public void Pshufw(MmVariable o0, MmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pshufw, o0, o1, o2);
		}

		public void Pshufw(MmVariable o0, MmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pshufw, o0, o1, o2);
		}

		public void Pshufw(MmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pshufw, o0, o1, o2);
		}

		public void Pshufw(MmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pshufw, o0, o1, o2);
		}

		public void Pshufw(MmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pshufw, o0, o1, o2);
		}

		public void Pshufw(MmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pshufw, o0, o1, o2);
		}

		public void Pshufw(MmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pshufw, o0, o1, o2);
		}

		public void Rcpps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Rcpps, o0, o1);
		}

		public void Rcpps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Rcpps, o0, o1);
		}

		public void Rcpss(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Rcpss, o0, o1);
		}

		public void Rcpss(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Rcpss, o0, o1);
		}

		public void Prefetch(Memory o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Prefetch, o0, o1);
		}

		public void Prefetch(Memory o0, int o1)
		{
			Compiler.Emit(InstructionId.Prefetch, o0, o1);
		}

		public void Prefetch(Memory o0, uint o1)
		{
			Compiler.Emit(InstructionId.Prefetch, o0, o1);
		}

		public void Prefetch(Memory o0, long o1)
		{
			Compiler.Emit(InstructionId.Prefetch, o0, o1);
		}

		public void Prefetch(Memory o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Prefetch, o0, o1);
		}

		public void Psadbw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psadbw, o0, o1);
		}

		public void Psadbw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psadbw, o0, o1);
		}

		public void Rsqrtps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Rsqrtps, o0, o1);
		}

		public void Rsqrtps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Rsqrtps, o0, o1);
		}

		public void Rsqrtss(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Rsqrtss, o0, o1);
		}

		public void Rsqrtss(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Rsqrtss, o0, o1);
		}

		public void Sfence()
		{
			Compiler.Emit(InstructionId.Sfence);
		}

		public void Shufps(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Shufps, o0, o1, o2);
		}

		public void Shufps(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Shufps, o0, o1, o2);
		}

		public void Shufps(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Shufps, o0, o1, o2);
		}

		public void Shufps(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Shufps, o0, o1, o2);
		}

		public void Shufps(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Shufps, o0, o1, o2);
		}

		public void Shufps(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Shufps, o0, o1, o2);
		}

		public void Shufps(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Shufps, o0, o1, o2);
		}

		public void Shufps(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Shufps, o0, o1, o2);
		}

		public void Shufps(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Shufps, o0, o1, o2);
		}

		public void Shufps(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Shufps, o0, o1, o2);
		}

		public void Sqrtps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Sqrtps, o0, o1);
		}

		public void Sqrtps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Sqrtps, o0, o1);
		}

		public void Sqrtss(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Sqrtss, o0, o1);
		}

		public void Sqrtss(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Sqrtss, o0, o1);
		}

		public void Stmxcsr(Memory o0)
		{
			Compiler.Emit(InstructionId.Stmxcsr, o0);
		}

		public void Subps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Subps, o0, o1);
		}

		public void Subps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Subps, o0, o1);
		}

		public void Subss(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Subss, o0, o1);
		}

		public void Subss(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Subss, o0, o1);
		}

		public void Ucomiss(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Ucomiss, o0, o1);
		}

		public void Ucomiss(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Ucomiss, o0, o1);
		}

		public void Unpckhps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Unpckhps, o0, o1);
		}

		public void Unpckhps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Unpckhps, o0, o1);
		}

		public void Unpcklps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Unpcklps, o0, o1);
		}

		public void Unpcklps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Unpcklps, o0, o1);
		}

		public void Xorps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Xorps, o0, o1);
		}

		public void Xorps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Xorps, o0, o1);
		}

		public void Addpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Addpd, o0, o1);
		}

		public void Addpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Addpd, o0, o1);
		}

		public void Addsd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Addsd, o0, o1);
		}

		public void Addsd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Addsd, o0, o1);
		}

		public void Andnpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Andnpd, o0, o1);
		}

		public void Andnpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Andnpd, o0, o1);
		}

		public void Andpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Andpd, o0, o1);
		}

		public void Andpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Andpd, o0, o1);
		}

		public void Clflush(Memory o0)
		{
			Compiler.Emit(InstructionId.Clflush, o0);
		}

		public void Cmppd(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Cmppd, o0, o1, o2);
		}

		public void Cmppd(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Cmppd, o0, o1, o2);
		}

		public void Cmppd(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Cmppd, o0, o1, o2);
		}

		public void Cmppd(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Cmppd, o0, o1, o2);
		}

		public void Cmppd(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Cmppd, o0, o1, o2);
		}

		public void Cmppd(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Cmppd, o0, o1, o2);
		}

		public void Cmppd(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Cmppd, o0, o1, o2);
		}

		public void Cmppd(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Cmppd, o0, o1, o2);
		}

		public void Cmppd(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Cmppd, o0, o1, o2);
		}

		public void Cmppd(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Cmppd, o0, o1, o2);
		}

		public void Cmpsd(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Cmpsd, o0, o1, o2);
		}

		public void Cmpsd(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Cmpsd, o0, o1, o2);
		}

		public void Cmpsd(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Cmpsd, o0, o1, o2);
		}

		public void Cmpsd(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Cmpsd, o0, o1, o2);
		}

		public void Cmpsd(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Cmpsd, o0, o1, o2);
		}

		public void Cmpsd(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Cmpsd, o0, o1, o2);
		}

		public void Cmpsd(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Cmpsd, o0, o1, o2);
		}

		public void Cmpsd(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Cmpsd, o0, o1, o2);
		}

		public void Cmpsd(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Cmpsd, o0, o1, o2);
		}

		public void Cmpsd(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Cmpsd, o0, o1, o2);
		}

		public void Comisd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Comisd, o0, o1);
		}

		public void Comisd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Comisd, o0, o1);
		}

		public void Cvtdq2pd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtdq2pd, o0, o1);
		}

		public void Cvtdq2pd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtdq2pd, o0, o1);
		}

		public void Cvtdq2ps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtdq2ps, o0, o1);
		}

		public void Cvtdq2ps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtdq2ps, o0, o1);
		}

		public void Cvtpd2dq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtpd2dq, o0, o1);
		}

		public void Cvtpd2dq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtpd2dq, o0, o1);
		}

		public void Cvtpd2pi(MmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtpd2pi, o0, o1);
		}

		public void Cvtpd2pi(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtpd2pi, o0, o1);
		}

		public void Cvtpd2ps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtpd2ps, o0, o1);
		}

		public void Cvtpd2ps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtpd2ps, o0, o1);
		}

		public void Cvtpi2pd(XmmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtpi2pd, o0, o1);
		}

		public void Cvtpi2pd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtpi2pd, o0, o1);
		}

		public void Cvtps2dq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtps2dq, o0, o1);
		}

		public void Cvtps2dq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtps2dq, o0, o1);
		}

		public void Cvtps2pd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtps2pd, o0, o1);
		}

		public void Cvtps2pd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtps2pd, o0, o1);
		}

		public void Cvtsd2si(GpVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtsd2si, o0, o1);
		}

		public void Cvtsd2si(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtsd2si, o0, o1);
		}

		public void Cvtsd2ss(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtsd2ss, o0, o1);
		}

		public void Cvtsd2ss(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtsd2ss, o0, o1);
		}

		public void Cvtsi2sd(XmmVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtsi2sd, o0, o1);
		}

		public void Cvtsi2sd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtsi2sd, o0, o1);
		}

		public void Cvtss2sd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvtss2sd, o0, o1);
		}

		public void Cvtss2sd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvtss2sd, o0, o1);
		}

		public void Cvttpd2pi(MmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvttpd2pi, o0, o1);
		}

		public void Cvttpd2pi(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvttpd2pi, o0, o1);
		}

		public void Cvttpd2dq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvttpd2dq, o0, o1);
		}

		public void Cvttpd2dq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvttpd2dq, o0, o1);
		}

		public void Cvttps2dq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvttps2dq, o0, o1);
		}

		public void Cvttps2dq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvttps2dq, o0, o1);
		}

		public void Cvttsd2si(GpVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Cvttsd2si, o0, o1);
		}

		public void Cvttsd2si(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Cvttsd2si, o0, o1);
		}

		public void Divpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Divpd, o0, o1);
		}

		public void Divpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Divpd, o0, o1);
		}

		public void Divsd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Divsd, o0, o1);
		}

		public void Divsd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Divsd, o0, o1);
		}

		public void Lfence()
		{
			Compiler.Emit(InstructionId.Lfence);
		}

		public void Maskmovdqu(GpVariable o0, XmmVariable o1, XmmVariable o2)
		{
			Compiler.Emit(InstructionId.Maskmovdqu, o0, o1, o2);
		}

		public void Maxpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Maxpd, o0, o1);
		}

		public void Maxpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Maxpd, o0, o1);
		}

		public void Maxsd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Maxsd, o0, o1);
		}

		public void Maxsd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Maxsd, o0, o1);
		}

		public void Mfence()
		{
			Compiler.Emit(InstructionId.Mfence);
		}

		public void Minpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Minpd, o0, o1);
		}

		public void Minpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Minpd, o0, o1);
		}

		public void Minsd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Minsd, o0, o1);
		}

		public void Minsd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Minsd, o0, o1);
		}

		public void Movdqa(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movdqa, o0, o1);
		}

		public void Movdqa(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movdqa, o0, o1);
		}

		public void Movdqa(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movdqa, o0, o1);
		}

		public void Movdqu(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movdqu, o0, o1);
		}

		public void Movdqu(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movdqu, o0, o1);
		}

		public void Movdqu(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movdqu, o0, o1);
		}

		public void Movmskps(GpVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movmskps, o0, o1);
		}

		public void Movmskpd(GpVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movmskpd, o0, o1);
		}

		public void Movsd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movsd, o0, o1);
		}

		public void Movsd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movsd, o0, o1);
		}

		public void Movsd(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movsd, o0, o1);
		}

		public void Movapd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movapd, o0, o1);
		}

		public void Movapd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movapd, o0, o1);
		}

		public void Movapd(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movapd, o0, o1);
		}

		public void Movdq2q(MmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movdq2q, o0, o1);
		}

		public void Movq2dq(XmmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Movq2dq, o0, o1);
		}

		public void Movhpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movhpd, o0, o1);
		}

		public void Movhpd(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movhpd, o0, o1);
		}

		public void Movlpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movlpd, o0, o1);
		}

		public void Movlpd(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movlpd, o0, o1);
		}

		public void Movntdq(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movntdq, o0, o1);
		}

		public void Movnti(Memory o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Movnti, o0, o1);
		}

		public void Movntpd(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movntpd, o0, o1);
		}

		public void Movupd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movupd, o0, o1);
		}

		public void Movupd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movupd, o0, o1);
		}

		public void Movupd(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movupd, o0, o1);
		}

		public void Mulpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Mulpd, o0, o1);
		}

		public void Mulpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Mulpd, o0, o1);
		}

		public void Mulsd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Mulsd, o0, o1);
		}

		public void Mulsd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Mulsd, o0, o1);
		}

		public void Orpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Orpd, o0, o1);
		}

		public void Orpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Orpd, o0, o1);
		}

		public void Packsswb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Packsswb, o0, o1);
		}

		public void Packsswb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Packsswb, o0, o1);
		}

		public void Packssdw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Packssdw, o0, o1);
		}

		public void Packssdw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Packssdw, o0, o1);
		}

		public void Packuswb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Packuswb, o0, o1);
		}

		public void Packuswb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Packuswb, o0, o1);
		}

		public void Paddb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddb, o0, o1);
		}

		public void Paddb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddb, o0, o1);
		}

		public void Paddw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddw, o0, o1);
		}

		public void Paddw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddw, o0, o1);
		}

		public void Paddd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddd, o0, o1);
		}

		public void Paddd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddd, o0, o1);
		}

		public void Paddq(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddq, o0, o1);
		}

		public void Paddq(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddq, o0, o1);
		}

		public void Paddq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddq, o0, o1);
		}

		public void Paddq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddq, o0, o1);
		}

		public void Paddsb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddsb, o0, o1);
		}

		public void Paddsb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddsb, o0, o1);
		}

		public void Paddsw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddsw, o0, o1);
		}

		public void Paddsw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddsw, o0, o1);
		}

		public void Paddusb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddusb, o0, o1);
		}

		public void Paddusb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddusb, o0, o1);
		}

		public void Paddusw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Paddusw, o0, o1);
		}

		public void Paddusw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Paddusw, o0, o1);
		}

		public void Pand(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pand, o0, o1);
		}

		public void Pand(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pand, o0, o1);
		}

		public void Pandn(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pandn, o0, o1);
		}

		public void Pandn(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pandn, o0, o1);
		}

		public void Pause()
		{
			Compiler.Emit(InstructionId.Pause);
		}

		public void Pavgb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pavgb, o0, o1);
		}

		public void Pavgb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pavgb, o0, o1);
		}

		public void Pavgw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pavgw, o0, o1);
		}

		public void Pavgw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pavgw, o0, o1);
		}

		public void Pcmpeqb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pcmpeqb, o0, o1);
		}

		public void Pcmpeqb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pcmpeqb, o0, o1);
		}

		public void Pcmpeqw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pcmpeqw, o0, o1);
		}

		public void Pcmpeqw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pcmpeqw, o0, o1);
		}

		public void Pcmpeqd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pcmpeqd, o0, o1);
		}

		public void Pcmpeqd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pcmpeqd, o0, o1);
		}

		public void Pcmpgtb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pcmpgtb, o0, o1);
		}

		public void Pcmpgtb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pcmpgtb, o0, o1);
		}

		public void Pcmpgtw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pcmpgtw, o0, o1);
		}

		public void Pcmpgtw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pcmpgtw, o0, o1);
		}

		public void Pcmpgtd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pcmpgtd, o0, o1);
		}

		public void Pcmpgtd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pcmpgtd, o0, o1);
		}

		public void Pextrw(GpVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(GpVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(GpVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(GpVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(GpVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pinsrw(XmmVariable o0, GpVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(XmmVariable o0, GpVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(XmmVariable o0, GpVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(XmmVariable o0, GpVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(XmmVariable o0, GpVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pmaxsw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmaxsw, o0, o1);
		}

		public void Pmaxsw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmaxsw, o0, o1);
		}

		public void Pmaxub(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmaxub, o0, o1);
		}

		public void Pmaxub(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmaxub, o0, o1);
		}

		public void Pminsw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pminsw, o0, o1);
		}

		public void Pminsw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pminsw, o0, o1);
		}

		public void Pminub(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pminub, o0, o1);
		}

		public void Pminub(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pminub, o0, o1);
		}

		public void Pmovmskb(GpVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmovmskb, o0, o1);
		}

		public void Pmulhw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmulhw, o0, o1);
		}

		public void Pmulhw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmulhw, o0, o1);
		}

		public void Pmulhuw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmulhuw, o0, o1);
		}

		public void Pmulhuw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmulhuw, o0, o1);
		}

		public void Pmullw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmullw, o0, o1);
		}

		public void Pmullw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmullw, o0, o1);
		}

		public void Pmuludq(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmuludq, o0, o1);
		}

		public void Pmuludq(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmuludq, o0, o1);
		}

		public void Pmuludq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmuludq, o0, o1);
		}

		public void Pmuludq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmuludq, o0, o1);
		}

		public void Por(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Por, o0, o1);
		}

		public void Por(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Por, o0, o1);
		}

		public void Pslld(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(XmmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(XmmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(XmmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(XmmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(XmmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Psllq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(XmmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(XmmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(XmmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(XmmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(XmmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(XmmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(XmmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(XmmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(XmmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(XmmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Pslldq(XmmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Pslldq, o0, o1);
		}

		public void Pslldq(XmmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Pslldq, o0, o1);
		}

		public void Pslldq(XmmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Pslldq, o0, o1);
		}

		public void Pslldq(XmmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Pslldq, o0, o1);
		}

		public void Pslldq(XmmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Pslldq, o0, o1);
		}

		public void Psrad(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(XmmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(XmmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(XmmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(XmmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(XmmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psraw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(XmmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(XmmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(XmmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(XmmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(XmmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psubb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubb, o0, o1);
		}

		public void Psubb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubb, o0, o1);
		}

		public void Psubd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubd, o0, o1);
		}

		public void Psubd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubd, o0, o1);
		}

		public void Psubq(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubq, o0, o1);
		}

		public void Psubq(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubq, o0, o1);
		}

		public void Psubq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubq, o0, o1);
		}

		public void Psubq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubq, o0, o1);
		}

		public void Psubw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubw, o0, o1);
		}

		public void Psubw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubw, o0, o1);
		}

		public void Pmaddwd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmaddwd, o0, o1);
		}

		public void Pmaddwd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmaddwd, o0, o1);
		}

		public void Pshufd(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pshufd, o0, o1, o2);
		}

		public void Pshufd(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pshufd, o0, o1, o2);
		}

		public void Pshufd(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pshufd, o0, o1, o2);
		}

		public void Pshufd(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pshufd, o0, o1, o2);
		}

		public void Pshufd(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pshufd, o0, o1, o2);
		}

		public void Pshufd(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pshufd, o0, o1, o2);
		}

		public void Pshufd(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pshufd, o0, o1, o2);
		}

		public void Pshufd(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pshufd, o0, o1, o2);
		}

		public void Pshufd(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pshufd, o0, o1, o2);
		}

		public void Pshufd(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pshufd, o0, o1, o2);
		}

		public void Pshufhw(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pshufhw, o0, o1, o2);
		}

		public void Pshufhw(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pshufhw, o0, o1, o2);
		}

		public void Pshufhw(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pshufhw, o0, o1, o2);
		}

		public void Pshufhw(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pshufhw, o0, o1, o2);
		}

		public void Pshufhw(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pshufhw, o0, o1, o2);
		}

		public void Pshufhw(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pshufhw, o0, o1, o2);
		}

		public void Pshufhw(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pshufhw, o0, o1, o2);
		}

		public void Pshufhw(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pshufhw, o0, o1, o2);
		}

		public void Pshufhw(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pshufhw, o0, o1, o2);
		}

		public void Pshufhw(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pshufhw, o0, o1, o2);
		}

		public void Pshuflw(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pshuflw, o0, o1, o2);
		}

		public void Pshuflw(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pshuflw, o0, o1, o2);
		}

		public void Pshuflw(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pshuflw, o0, o1, o2);
		}

		public void Pshuflw(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pshuflw, o0, o1, o2);
		}

		public void Pshuflw(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pshuflw, o0, o1, o2);
		}

		public void Pshuflw(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pshuflw, o0, o1, o2);
		}

		public void Pshuflw(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pshuflw, o0, o1, o2);
		}

		public void Pshuflw(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pshuflw, o0, o1, o2);
		}

		public void Pshuflw(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pshuflw, o0, o1, o2);
		}

		public void Pshuflw(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pshuflw, o0, o1, o2);
		}

		public void Psrld(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(XmmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(XmmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(XmmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(XmmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(XmmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrlq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(XmmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(XmmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(XmmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(XmmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(XmmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrldq(XmmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psrldq, o0, o1);
		}

		public void Psrldq(XmmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psrldq, o0, o1);
		}

		public void Psrldq(XmmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psrldq, o0, o1);
		}

		public void Psrldq(XmmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psrldq, o0, o1);
		}

		public void Psrldq(XmmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psrldq, o0, o1);
		}

		public void Psrlw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(XmmVariable o0, Immediate o1)
		{
			Compiler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(XmmVariable o0, int o1)
		{
			Compiler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(XmmVariable o0, uint o1)
		{
			Compiler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(XmmVariable o0, long o1)
		{
			Compiler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(XmmVariable o0, ulong o1)
		{
			Compiler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psubsb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubsb, o0, o1);
		}

		public void Psubsb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubsb, o0, o1);
		}

		public void Psubsw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubsw, o0, o1);
		}

		public void Psubsw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubsw, o0, o1);
		}

		public void Psubusb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubusb, o0, o1);
		}

		public void Psubusb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubusb, o0, o1);
		}

		public void Psubusw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psubusw, o0, o1);
		}

		public void Psubusw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psubusw, o0, o1);
		}

		public void Punpckhbw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Punpckhbw, o0, o1);
		}

		public void Punpckhbw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Punpckhbw, o0, o1);
		}

		public void Punpckhdq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Punpckhdq, o0, o1);
		}

		public void Punpckhdq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Punpckhdq, o0, o1);
		}

		public void Punpckhqdq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Punpckhqdq, o0, o1);
		}

		public void Punpckhqdq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Punpckhqdq, o0, o1);
		}

		public void Punpckhwd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Punpckhwd, o0, o1);
		}

		public void Punpckhwd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Punpckhwd, o0, o1);
		}

		public void Punpcklbw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Punpcklbw, o0, o1);
		}

		public void Punpcklbw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Punpcklbw, o0, o1);
		}

		public void Punpckldq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Punpckldq, o0, o1);
		}

		public void Punpckldq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Punpckldq, o0, o1);
		}

		public void Punpcklqdq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Punpcklqdq, o0, o1);
		}

		public void Punpcklqdq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Punpcklqdq, o0, o1);
		}

		public void Punpcklwd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Punpcklwd, o0, o1);
		}

		public void Punpcklwd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Punpcklwd, o0, o1);
		}

		public void Pxor(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pxor, o0, o1);
		}

		public void Pxor(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pxor, o0, o1);
		}

		public void Shufpd(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Shufpd, o0, o1, o2);
		}

		public void Shufpd(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Shufpd, o0, o1, o2);
		}

		public void Shufpd(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Shufpd, o0, o1, o2);
		}

		public void Shufpd(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Shufpd, o0, o1, o2);
		}

		public void Shufpd(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Shufpd, o0, o1, o2);
		}

		public void Shufpd(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Shufpd, o0, o1, o2);
		}

		public void Shufpd(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Shufpd, o0, o1, o2);
		}

		public void Shufpd(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Shufpd, o0, o1, o2);
		}

		public void Shufpd(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Shufpd, o0, o1, o2);
		}

		public void Shufpd(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Shufpd, o0, o1, o2);
		}

		public void Sqrtpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Sqrtpd, o0, o1);
		}

		public void Sqrtpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Sqrtpd, o0, o1);
		}

		public void Sqrtsd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Sqrtsd, o0, o1);
		}

		public void Sqrtsd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Sqrtsd, o0, o1);
		}

		public void Subpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Subpd, o0, o1);
		}

		public void Subpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Subpd, o0, o1);
		}

		public void Subsd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Subsd, o0, o1);
		}

		public void Subsd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Subsd, o0, o1);
		}

		public void Ucomisd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Ucomisd, o0, o1);
		}

		public void Ucomisd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Ucomisd, o0, o1);
		}

		public void Unpckhpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Unpckhpd, o0, o1);
		}

		public void Unpckhpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Unpckhpd, o0, o1);
		}

		public void Unpcklpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Unpcklpd, o0, o1);
		}

		public void Unpcklpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Unpcklpd, o0, o1);
		}

		public void Xorpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Xorpd, o0, o1);
		}

		public void Xorpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Xorpd, o0, o1);
		}

		public void Addsubpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Addsubpd, o0, o1);
		}

		public void Addsubpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Addsubpd, o0, o1);
		}

		public void Addsubps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Addsubps, o0, o1);
		}

		public void Addsubps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Addsubps, o0, o1);
		}

		public void Fisttp(Memory o0)
		{
			Compiler.Emit(InstructionId.Fisttp, o0);
		}

		public void Haddpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Haddpd, o0, o1);
		}

		public void Haddpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Haddpd, o0, o1);
		}

		public void Haddps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Haddps, o0, o1);
		}

		public void Haddps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Haddps, o0, o1);
		}

		public void Hsubpd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Hsubpd, o0, o1);
		}

		public void Hsubpd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Hsubpd, o0, o1);
		}

		public void Hsubps(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Hsubps, o0, o1);
		}

		public void Hsubps(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Hsubps, o0, o1);
		}

		public void Lddqu(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Lddqu, o0, o1);
		}

		public void Movddup(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movddup, o0, o1);
		}

		public void Movddup(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movddup, o0, o1);
		}

		public void Movshdup(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movshdup, o0, o1);
		}

		public void Movshdup(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movshdup, o0, o1);
		}

		public void Movsldup(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movsldup, o0, o1);
		}

		public void Movsldup(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movsldup, o0, o1);
		}

		public void Psignb(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psignb, o0, o1);
		}

		public void Psignb(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psignb, o0, o1);
		}

		public void Psignb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psignb, o0, o1);
		}

		public void Psignb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psignb, o0, o1);
		}

		public void Psignd(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psignd, o0, o1);
		}

		public void Psignd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psignd, o0, o1);
		}

		public void Psignd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psignd, o0, o1);
		}

		public void Psignd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psignd, o0, o1);
		}

		public void Psignw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Psignw, o0, o1);
		}

		public void Psignw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psignw, o0, o1);
		}

		public void Psignw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Psignw, o0, o1);
		}

		public void Psignw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Psignw, o0, o1);
		}

		public void Phaddd(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Phaddd, o0, o1);
		}

		public void Phaddd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Phaddd, o0, o1);
		}

		public void Phaddd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Phaddd, o0, o1);
		}

		public void Phaddd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Phaddd, o0, o1);
		}

		public void Phaddsw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Phaddsw, o0, o1);
		}

		public void Phaddsw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Phaddsw, o0, o1);
		}

		public void Phaddsw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Phaddsw, o0, o1);
		}

		public void Phaddsw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Phaddsw, o0, o1);
		}

		public void Phaddw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Phaddw, o0, o1);
		}

		public void Phaddw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Phaddw, o0, o1);
		}

		public void Phaddw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Phaddw, o0, o1);
		}

		public void Phaddw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Phaddw, o0, o1);
		}

		public void Phsubd(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Phsubd, o0, o1);
		}

		public void Phsubd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Phsubd, o0, o1);
		}

		public void Phsubd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Phsubd, o0, o1);
		}

		public void Phsubd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Phsubd, o0, o1);
		}

		public void Phsubsw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Phsubsw, o0, o1);
		}

		public void Phsubsw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Phsubsw, o0, o1);
		}

		public void Phsubsw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Phsubsw, o0, o1);
		}

		public void Phsubsw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Phsubsw, o0, o1);
		}

		public void Phsubw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Phsubw, o0, o1);
		}

		public void Phsubw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Phsubw, o0, o1);
		}

		public void Phsubw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Phsubw, o0, o1);
		}

		public void Phsubw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Phsubw, o0, o1);
		}

		public void Pmaddubsw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmaddubsw, o0, o1);
		}

		public void Pmaddubsw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmaddubsw, o0, o1);
		}

		public void Pmaddubsw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmaddubsw, o0, o1);
		}

		public void Pmaddubsw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmaddubsw, o0, o1);
		}

		public void Pabsb(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pabsb, o0, o1);
		}

		public void Pabsb(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pabsb, o0, o1);
		}

		public void Pabsb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pabsb, o0, o1);
		}

		public void Pabsb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pabsb, o0, o1);
		}

		public void Pabsd(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pabsd, o0, o1);
		}

		public void Pabsd(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pabsd, o0, o1);
		}

		public void Pabsd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pabsd, o0, o1);
		}

		public void Pabsd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pabsd, o0, o1);
		}

		public void Pabsw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pabsw, o0, o1);
		}

		public void Pabsw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pabsw, o0, o1);
		}

		public void Pabsw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pabsw, o0, o1);
		}

		public void Pabsw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pabsw, o0, o1);
		}

		public void Pmulhrsw(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmulhrsw, o0, o1);
		}

		public void Pmulhrsw(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmulhrsw, o0, o1);
		}

		public void Pmulhrsw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmulhrsw, o0, o1);
		}

		public void Pmulhrsw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmulhrsw, o0, o1);
		}

		public void Pshufb(MmVariable o0, MmVariable o1)
		{
			Compiler.Emit(InstructionId.Pshufb, o0, o1);
		}

		public void Pshufb(MmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pshufb, o0, o1);
		}

		public void Pshufb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pshufb, o0, o1);
		}

		public void Pshufb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pshufb, o0, o1);
		}

		public void Palignr(MmVariable o0, MmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(MmVariable o0, MmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(MmVariable o0, MmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(MmVariable o0, MmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(MmVariable o0, MmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(MmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(MmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(MmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(MmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(MmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Blendpd(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Blendpd, o0, o1, o2);
		}

		public void Blendpd(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Blendpd, o0, o1, o2);
		}

		public void Blendpd(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Blendpd, o0, o1, o2);
		}

		public void Blendpd(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Blendpd, o0, o1, o2);
		}

		public void Blendpd(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Blendpd, o0, o1, o2);
		}

		public void Blendpd(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Blendpd, o0, o1, o2);
		}

		public void Blendpd(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Blendpd, o0, o1, o2);
		}

		public void Blendpd(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Blendpd, o0, o1, o2);
		}

		public void Blendpd(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Blendpd, o0, o1, o2);
		}

		public void Blendpd(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Blendpd, o0, o1, o2);
		}

		public void Blendps(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Blendps, o0, o1, o2);
		}

		public void Blendps(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Blendps, o0, o1, o2);
		}

		public void Blendps(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Blendps, o0, o1, o2);
		}

		public void Blendps(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Blendps, o0, o1, o2);
		}

		public void Blendps(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Blendps, o0, o1, o2);
		}

		public void Blendps(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Blendps, o0, o1, o2);
		}

		public void Blendps(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Blendps, o0, o1, o2);
		}

		public void Blendps(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Blendps, o0, o1, o2);
		}

		public void Blendps(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Blendps, o0, o1, o2);
		}

		public void Blendps(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Blendps, o0, o1, o2);
		}

		public void Blendvpd(XmmVariable o0, XmmVariable o1, XmmVariable o2)
		{
			Compiler.Emit(InstructionId.Blendvpd, o0, o1, o2);
		}

		public void Blendvpd(XmmVariable o0, Memory o1, XmmVariable o2)
		{
			Compiler.Emit(InstructionId.Blendvpd, o0, o1, o2);
		}

		public void Blendvps(XmmVariable o0, XmmVariable o1, XmmVariable o2)
		{
			Compiler.Emit(InstructionId.Blendvps, o0, o1, o2);
		}

		public void Blendvps(XmmVariable o0, Memory o1, XmmVariable o2)
		{
			Compiler.Emit(InstructionId.Blendvps, o0, o1, o2);
		}

		public void Dppd(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Dppd, o0, o1, o2);
		}

		public void Dppd(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Dppd, o0, o1, o2);
		}

		public void Dppd(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Dppd, o0, o1, o2);
		}

		public void Dppd(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Dppd, o0, o1, o2);
		}

		public void Dppd(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Dppd, o0, o1, o2);
		}

		public void Dppd(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Dppd, o0, o1, o2);
		}

		public void Dppd(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Dppd, o0, o1, o2);
		}

		public void Dppd(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Dppd, o0, o1, o2);
		}

		public void Dppd(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Dppd, o0, o1, o2);
		}

		public void Dppd(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Dppd, o0, o1, o2);
		}

		public void Dpps(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Dpps, o0, o1, o2);
		}

		public void Dpps(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Dpps, o0, o1, o2);
		}

		public void Dpps(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Dpps, o0, o1, o2);
		}

		public void Dpps(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Dpps, o0, o1, o2);
		}

		public void Dpps(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Dpps, o0, o1, o2);
		}

		public void Dpps(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Dpps, o0, o1, o2);
		}

		public void Dpps(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Dpps, o0, o1, o2);
		}

		public void Dpps(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Dpps, o0, o1, o2);
		}

		public void Dpps(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Dpps, o0, o1, o2);
		}

		public void Dpps(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Dpps, o0, o1, o2);
		}

		public void Extractps(GpVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Extractps, o0, o1, o2);
		}

		public void Extractps(GpVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Extractps, o0, o1, o2);
		}

		public void Extractps(GpVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Extractps, o0, o1, o2);
		}

		public void Extractps(GpVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Extractps, o0, o1, o2);
		}

		public void Extractps(GpVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Extractps, o0, o1, o2);
		}

		public void Extractps(Memory o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Extractps, o0, o1, o2);
		}

		public void Extractps(Memory o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Extractps, o0, o1, o2);
		}

		public void Extractps(Memory o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Extractps, o0, o1, o2);
		}

		public void Extractps(Memory o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Extractps, o0, o1, o2);
		}

		public void Extractps(Memory o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Extractps, o0, o1, o2);
		}

		public void Insertps(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Insertps, o0, o1, o2);
		}

		public void Insertps(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Insertps, o0, o1, o2);
		}

		public void Insertps(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Insertps, o0, o1, o2);
		}

		public void Insertps(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Insertps, o0, o1, o2);
		}

		public void Insertps(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Insertps, o0, o1, o2);
		}

		public void Insertps(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Insertps, o0, o1, o2);
		}

		public void Insertps(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Insertps, o0, o1, o2);
		}

		public void Insertps(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Insertps, o0, o1, o2);
		}

		public void Insertps(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Insertps, o0, o1, o2);
		}

		public void Insertps(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Insertps, o0, o1, o2);
		}

		public void Movntdqa(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Movntdqa, o0, o1);
		}

		public void Mpsadbw(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Mpsadbw, o0, o1, o2);
		}

		public void Mpsadbw(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Mpsadbw, o0, o1, o2);
		}

		public void Mpsadbw(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Mpsadbw, o0, o1, o2);
		}

		public void Mpsadbw(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Mpsadbw, o0, o1, o2);
		}

		public void Mpsadbw(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Mpsadbw, o0, o1, o2);
		}

		public void Mpsadbw(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Mpsadbw, o0, o1, o2);
		}

		public void Mpsadbw(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Mpsadbw, o0, o1, o2);
		}

		public void Mpsadbw(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Mpsadbw, o0, o1, o2);
		}

		public void Mpsadbw(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Mpsadbw, o0, o1, o2);
		}

		public void Mpsadbw(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Mpsadbw, o0, o1, o2);
		}

		public void Packusdw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Packusdw, o0, o1);
		}

		public void Packusdw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Packusdw, o0, o1);
		}

		public void Pblendvb(XmmVariable o0, XmmVariable o1, XmmVariable o2)
		{
			Compiler.Emit(InstructionId.Pblendvb, o0, o1, o2);
		}

		public void Pblendvb(XmmVariable o0, Memory o1, XmmVariable o2)
		{
			Compiler.Emit(InstructionId.Pblendvb, o0, o1, o2);
		}

		public void Pblendw(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pblendw, o0, o1, o2);
		}

		public void Pblendw(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pblendw, o0, o1, o2);
		}

		public void Pblendw(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pblendw, o0, o1, o2);
		}

		public void Pblendw(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pblendw, o0, o1, o2);
		}

		public void Pblendw(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pblendw, o0, o1, o2);
		}

		public void Pblendw(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pblendw, o0, o1, o2);
		}

		public void Pblendw(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pblendw, o0, o1, o2);
		}

		public void Pblendw(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pblendw, o0, o1, o2);
		}

		public void Pblendw(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pblendw, o0, o1, o2);
		}

		public void Pblendw(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pblendw, o0, o1, o2);
		}

		public void Pcmpeqq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pcmpeqq, o0, o1);
		}

		public void Pcmpeqq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pcmpeqq, o0, o1);
		}

		public void Pextrb(GpVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pextrb, o0, o1, o2);
		}

		public void Pextrb(GpVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pextrb, o0, o1, o2);
		}

		public void Pextrb(GpVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pextrb, o0, o1, o2);
		}

		public void Pextrb(GpVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pextrb, o0, o1, o2);
		}

		public void Pextrb(GpVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pextrb, o0, o1, o2);
		}

		public void Pextrb(Memory o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pextrb, o0, o1, o2);
		}

		public void Pextrb(Memory o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pextrb, o0, o1, o2);
		}

		public void Pextrb(Memory o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pextrb, o0, o1, o2);
		}

		public void Pextrb(Memory o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pextrb, o0, o1, o2);
		}

		public void Pextrb(Memory o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pextrb, o0, o1, o2);
		}

		public void Pextrd(GpVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pextrd, o0, o1, o2);
		}

		public void Pextrd(GpVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pextrd, o0, o1, o2);
		}

		public void Pextrd(GpVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pextrd, o0, o1, o2);
		}

		public void Pextrd(GpVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pextrd, o0, o1, o2);
		}

		public void Pextrd(GpVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pextrd, o0, o1, o2);
		}

		public void Pextrd(Memory o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pextrd, o0, o1, o2);
		}

		public void Pextrd(Memory o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pextrd, o0, o1, o2);
		}

		public void Pextrd(Memory o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pextrd, o0, o1, o2);
		}

		public void Pextrd(Memory o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pextrd, o0, o1, o2);
		}

		public void Pextrd(Memory o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pextrd, o0, o1, o2);
		}

		public void Pextrq(GpVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pextrq, o0, o1, o2);
		}

		public void Pextrq(GpVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pextrq, o0, o1, o2);
		}

		public void Pextrq(GpVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pextrq, o0, o1, o2);
		}

		public void Pextrq(GpVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pextrq, o0, o1, o2);
		}

		public void Pextrq(GpVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pextrq, o0, o1, o2);
		}

		public void Pextrq(Memory o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pextrq, o0, o1, o2);
		}

		public void Pextrq(Memory o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pextrq, o0, o1, o2);
		}

		public void Pextrq(Memory o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pextrq, o0, o1, o2);
		}

		public void Pextrq(Memory o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pextrq, o0, o1, o2);
		}

		public void Pextrq(Memory o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pextrq, o0, o1, o2);
		}

		public void Pextrw(Memory o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(Memory o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(Memory o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(Memory o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(Memory o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Phminposuw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Phminposuw, o0, o1);
		}

		public void Phminposuw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Phminposuw, o0, o1);
		}

		public void Pinsrb(XmmVariable o0, GpVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pinsrb, o0, o1, o2);
		}

		public void Pinsrb(XmmVariable o0, GpVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pinsrb, o0, o1, o2);
		}

		public void Pinsrb(XmmVariable o0, GpVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pinsrb, o0, o1, o2);
		}

		public void Pinsrb(XmmVariable o0, GpVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pinsrb, o0, o1, o2);
		}

		public void Pinsrb(XmmVariable o0, GpVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pinsrb, o0, o1, o2);
		}

		public void Pinsrb(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pinsrb, o0, o1, o2);
		}

		public void Pinsrb(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pinsrb, o0, o1, o2);
		}

		public void Pinsrb(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pinsrb, o0, o1, o2);
		}

		public void Pinsrb(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pinsrb, o0, o1, o2);
		}

		public void Pinsrb(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pinsrb, o0, o1, o2);
		}

		public void Pinsrd(XmmVariable o0, GpVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pinsrd, o0, o1, o2);
		}

		public void Pinsrd(XmmVariable o0, GpVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pinsrd, o0, o1, o2);
		}

		public void Pinsrd(XmmVariable o0, GpVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pinsrd, o0, o1, o2);
		}

		public void Pinsrd(XmmVariable o0, GpVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pinsrd, o0, o1, o2);
		}

		public void Pinsrd(XmmVariable o0, GpVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pinsrd, o0, o1, o2);
		}

		public void Pinsrd(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pinsrd, o0, o1, o2);
		}

		public void Pinsrd(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pinsrd, o0, o1, o2);
		}

		public void Pinsrd(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pinsrd, o0, o1, o2);
		}

		public void Pinsrd(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pinsrd, o0, o1, o2);
		}

		public void Pinsrd(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pinsrd, o0, o1, o2);
		}

		public void Pinsrq(XmmVariable o0, GpVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pinsrq, o0, o1, o2);
		}

		public void Pinsrq(XmmVariable o0, GpVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pinsrq, o0, o1, o2);
		}

		public void Pinsrq(XmmVariable o0, GpVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pinsrq, o0, o1, o2);
		}

		public void Pinsrq(XmmVariable o0, GpVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pinsrq, o0, o1, o2);
		}

		public void Pinsrq(XmmVariable o0, GpVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pinsrq, o0, o1, o2);
		}

		public void Pinsrq(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pinsrq, o0, o1, o2);
		}

		public void Pinsrq(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pinsrq, o0, o1, o2);
		}

		public void Pinsrq(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pinsrq, o0, o1, o2);
		}

		public void Pinsrq(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pinsrq, o0, o1, o2);
		}

		public void Pinsrq(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pinsrq, o0, o1, o2);
		}

		public void Pmaxsb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmaxsb, o0, o1);
		}

		public void Pmaxsb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmaxsb, o0, o1);
		}

		public void Pmaxsd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmaxsd, o0, o1);
		}

		public void Pmaxsd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmaxsd, o0, o1);
		}

		public void Pmaxud(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmaxud, o0, o1);
		}

		public void Pmaxud(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmaxud, o0, o1);
		}

		public void Pmaxuw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmaxuw, o0, o1);
		}

		public void Pmaxuw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmaxuw, o0, o1);
		}

		public void Pminsb(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pminsb, o0, o1);
		}

		public void Pminsb(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pminsb, o0, o1);
		}

		public void Pminsd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pminsd, o0, o1);
		}

		public void Pminsd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pminsd, o0, o1);
		}

		public void Pminuw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pminuw, o0, o1);
		}

		public void Pminuw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pminuw, o0, o1);
		}

		public void Pminud(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pminud, o0, o1);
		}

		public void Pminud(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pminud, o0, o1);
		}

		public void Pmovsxbd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmovsxbd, o0, o1);
		}

		public void Pmovsxbd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmovsxbd, o0, o1);
		}

		public void Pmovsxbq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmovsxbq, o0, o1);
		}

		public void Pmovsxbq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmovsxbq, o0, o1);
		}

		public void Pmovsxbw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmovsxbw, o0, o1);
		}

		public void Pmovsxbw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmovsxbw, o0, o1);
		}

		public void Pmovsxdq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmovsxdq, o0, o1);
		}

		public void Pmovsxdq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmovsxdq, o0, o1);
		}

		public void Pmovsxwd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmovsxwd, o0, o1);
		}

		public void Pmovsxwd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmovsxwd, o0, o1);
		}

		public void Pmovsxwq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmovsxwq, o0, o1);
		}

		public void Pmovsxwq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmovsxwq, o0, o1);
		}

		public void Pmovzxbd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmovzxbd, o0, o1);
		}

		public void Pmovzxbd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmovzxbd, o0, o1);
		}

		public void Pmovzxbq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmovzxbq, o0, o1);
		}

		public void Pmovzxbq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmovzxbq, o0, o1);
		}

		public void Pmovzxbw(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmovzxbw, o0, o1);
		}

		public void Pmovzxbw(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmovzxbw, o0, o1);
		}

		public void Pmovzxdq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmovzxdq, o0, o1);
		}

		public void Pmovzxdq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmovzxdq, o0, o1);
		}

		public void Pmovzxwd(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmovzxwd, o0, o1);
		}

		public void Pmovzxwd(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmovzxwd, o0, o1);
		}

		public void Pmovzxwq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmovzxwq, o0, o1);
		}

		public void Pmovzxwq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmovzxwq, o0, o1);
		}

		public void Pmuldq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmuldq, o0, o1);
		}

		public void Pmuldq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmuldq, o0, o1);
		}

		public void Pmulld(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pmulld, o0, o1);
		}

		public void Pmulld(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pmulld, o0, o1);
		}

		public void Ptest(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Ptest, o0, o1);
		}

		public void Ptest(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Ptest, o0, o1);
		}

		public void Roundpd(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Roundpd, o0, o1, o2);
		}

		public void Roundpd(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Roundpd, o0, o1, o2);
		}

		public void Roundpd(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Roundpd, o0, o1, o2);
		}

		public void Roundpd(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Roundpd, o0, o1, o2);
		}

		public void Roundpd(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Roundpd, o0, o1, o2);
		}

		public void Roundpd(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Roundpd, o0, o1, o2);
		}

		public void Roundpd(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Roundpd, o0, o1, o2);
		}

		public void Roundpd(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Roundpd, o0, o1, o2);
		}

		public void Roundpd(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Roundpd, o0, o1, o2);
		}

		public void Roundpd(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Roundpd, o0, o1, o2);
		}

		public void Roundps(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Roundps, o0, o1, o2);
		}

		public void Roundps(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Roundps, o0, o1, o2);
		}

		public void Roundps(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Roundps, o0, o1, o2);
		}

		public void Roundps(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Roundps, o0, o1, o2);
		}

		public void Roundps(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Roundps, o0, o1, o2);
		}

		public void Roundps(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Roundps, o0, o1, o2);
		}

		public void Roundps(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Roundps, o0, o1, o2);
		}

		public void Roundps(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Roundps, o0, o1, o2);
		}

		public void Roundps(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Roundps, o0, o1, o2);
		}

		public void Roundps(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Roundps, o0, o1, o2);
		}

		public void Roundsd(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Roundsd, o0, o1, o2);
		}

		public void Roundsd(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Roundsd, o0, o1, o2);
		}

		public void Roundsd(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Roundsd, o0, o1, o2);
		}

		public void Roundsd(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Roundsd, o0, o1, o2);
		}

		public void Roundsd(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Roundsd, o0, o1, o2);
		}

		public void Roundsd(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Roundsd, o0, o1, o2);
		}

		public void Roundsd(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Roundsd, o0, o1, o2);
		}

		public void Roundsd(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Roundsd, o0, o1, o2);
		}

		public void Roundsd(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Roundsd, o0, o1, o2);
		}

		public void Roundsd(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Roundsd, o0, o1, o2);
		}

		public void Roundss(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Roundss, o0, o1, o2);
		}

		public void Roundss(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Roundss, o0, o1, o2);
		}

		public void Roundss(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Roundss, o0, o1, o2);
		}

		public void Roundss(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Roundss, o0, o1, o2);
		}

		public void Roundss(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Roundss, o0, o1, o2);
		}

		public void Roundss(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Roundss, o0, o1, o2);
		}

		public void Roundss(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Roundss, o0, o1, o2);
		}

		public void Roundss(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Roundss, o0, o1, o2);
		}

		public void Roundss(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Roundss, o0, o1, o2);
		}

		public void Roundss(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Roundss, o0, o1, o2);
		}

		public void Crc32(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Crc32, o0, o1);
		}

		public void Crc32(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Crc32, o0, o1);
		}

		public void Pcmpestri(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pcmpestri, o0, o1, o2);
		}

		public void Pcmpestri(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pcmpestri, o0, o1, o2);
		}

		public void Pcmpestri(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pcmpestri, o0, o1, o2);
		}

		public void Pcmpestri(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pcmpestri, o0, o1, o2);
		}

		public void Pcmpestri(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pcmpestri, o0, o1, o2);
		}

		public void Pcmpestri(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pcmpestri, o0, o1, o2);
		}

		public void Pcmpestri(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pcmpestri, o0, o1, o2);
		}

		public void Pcmpestri(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pcmpestri, o0, o1, o2);
		}

		public void Pcmpestri(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pcmpestri, o0, o1, o2);
		}

		public void Pcmpestri(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pcmpestri, o0, o1, o2);
		}

		public void Pcmpestrm(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pcmpestrm, o0, o1, o2);
		}

		public void Pcmpestrm(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pcmpestrm, o0, o1, o2);
		}

		public void Pcmpestrm(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pcmpestrm, o0, o1, o2);
		}

		public void Pcmpestrm(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pcmpestrm, o0, o1, o2);
		}

		public void Pcmpestrm(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pcmpestrm, o0, o1, o2);
		}

		public void Pcmpestrm(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pcmpestrm, o0, o1, o2);
		}

		public void Pcmpestrm(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pcmpestrm, o0, o1, o2);
		}

		public void Pcmpestrm(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pcmpestrm, o0, o1, o2);
		}

		public void Pcmpestrm(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pcmpestrm, o0, o1, o2);
		}

		public void Pcmpestrm(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pcmpestrm, o0, o1, o2);
		}

		public void Pcmpistri(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pcmpistri, o0, o1, o2);
		}

		public void Pcmpistri(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pcmpistri, o0, o1, o2);
		}

		public void Pcmpistri(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pcmpistri, o0, o1, o2);
		}

		public void Pcmpistri(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pcmpistri, o0, o1, o2);
		}

		public void Pcmpistri(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pcmpistri, o0, o1, o2);
		}

		public void Pcmpistri(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pcmpistri, o0, o1, o2);
		}

		public void Pcmpistri(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pcmpistri, o0, o1, o2);
		}

		public void Pcmpistri(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pcmpistri, o0, o1, o2);
		}

		public void Pcmpistri(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pcmpistri, o0, o1, o2);
		}

		public void Pcmpistri(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pcmpistri, o0, o1, o2);
		}

		public void Pcmpistrm(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pcmpistrm, o0, o1, o2);
		}

		public void Pcmpistrm(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pcmpistrm, o0, o1, o2);
		}

		public void Pcmpistrm(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pcmpistrm, o0, o1, o2);
		}

		public void Pcmpistrm(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pcmpistrm, o0, o1, o2);
		}

		public void Pcmpistrm(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pcmpistrm, o0, o1, o2);
		}

		public void Pcmpistrm(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pcmpistrm, o0, o1, o2);
		}

		public void Pcmpistrm(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pcmpistrm, o0, o1, o2);
		}

		public void Pcmpistrm(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pcmpistrm, o0, o1, o2);
		}

		public void Pcmpistrm(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pcmpistrm, o0, o1, o2);
		}

		public void Pcmpistrm(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pcmpistrm, o0, o1, o2);
		}

		public void Pcmpgtq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Pcmpgtq, o0, o1);
		}

		public void Pcmpgtq(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Pcmpgtq, o0, o1);
		}

		public void Extrq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Extrq, o0, o1);
		}

		public void Extrq(XmmVariable o0, Immediate o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Extrq, o0, o1, o2);
		}

		public void Extrq(XmmVariable o0, int o1, int o2)
		{
			Compiler.Emit(InstructionId.Extrq, o0, new Immediate(o1), o2);
		}

		public void Extrq(XmmVariable o0, uint o1, uint o2)
		{
			Compiler.Emit(InstructionId.Extrq, o0, new Immediate(o1), o2);
		}

		public void Extrq(XmmVariable o0, long o1, long o2)
		{
			Compiler.Emit(InstructionId.Extrq, o0, new Immediate(o1), o2);
		}

		public void Extrq(XmmVariable o0, ulong o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Extrq, o0, new Immediate(o1), o2);
		}

		public void Insertq(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Insertq, o0, o1);
		}

		public void Insertq(XmmVariable o0, XmmVariable o1, Immediate o2, Immediate o3)
		{
			Compiler.Emit(InstructionId.Insertq, o0, o1, o2, o3);
		}

		public void Insertq(XmmVariable o0, XmmVariable o1, int o2, int o3)
		{
			Compiler.Emit(InstructionId.Insertq, o0, o1, new Immediate(o2), o3);
		}

		public void Insertq(XmmVariable o0, XmmVariable o1, uint o2, uint o3)
		{
			Compiler.Emit(InstructionId.Insertq, o0, o1, new Immediate(o2), o3);
		}

		public void Insertq(XmmVariable o0, XmmVariable o1, long o2, long o3)
		{
			Compiler.Emit(InstructionId.Insertq, o0, o1, new Immediate(o2), o3);
		}

		public void Insertq(XmmVariable o0, XmmVariable o1, ulong o2, ulong o3)
		{
			Compiler.Emit(InstructionId.Insertq, o0, o1, new Immediate(o2), o3);
		}

		public void Movntsd(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movntsd, o0, o1);
		}

		public void Movntss(Memory o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Movntss, o0, o1);
		}

		public void Popcnt(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Popcnt, o0, o1);
		}

		public void Popcnt(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Popcnt, o0, o1);
		}

		public void Lzcnt(GpVariable o0, GpVariable o1)
		{
			Compiler.Emit(InstructionId.Lzcnt, o0, o1);
		}

		public void Lzcnt(GpVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Lzcnt, o0, o1);
		}

		public void Aesdec(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Aesdec, o0, o1);
		}

		public void Aesdec(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Aesdec, o0, o1);
		}

		public void Aesdeclast(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Aesdeclast, o0, o1);
		}

		public void Aesdeclast(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Aesdeclast, o0, o1);
		}

		public void Aesenc(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Aesenc, o0, o1);
		}

		public void Aesenc(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Aesenc, o0, o1);
		}

		public void Aesenclast(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Aesenclast, o0, o1);
		}

		public void Aesenclast(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Aesenclast, o0, o1);
		}

		public void Aesimc(XmmVariable o0, XmmVariable o1)
		{
			Compiler.Emit(InstructionId.Aesimc, o0, o1);
		}

		public void Aesimc(XmmVariable o0, Memory o1)
		{
			Compiler.Emit(InstructionId.Aesimc, o0, o1);
		}

		public void Aeskeygenassist(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Aeskeygenassist, o0, o1, o2);
		}

		public void Aeskeygenassist(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Aeskeygenassist, o0, o1, o2);
		}

		public void Aeskeygenassist(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Aeskeygenassist, o0, o1, o2);
		}

		public void Aeskeygenassist(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Aeskeygenassist, o0, o1, o2);
		}

		public void Aeskeygenassist(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Aeskeygenassist, o0, o1, o2);
		}

		public void Aeskeygenassist(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Aeskeygenassist, o0, o1, o2);
		}

		public void Aeskeygenassist(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Aeskeygenassist, o0, o1, o2);
		}

		public void Aeskeygenassist(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Aeskeygenassist, o0, o1, o2);
		}

		public void Aeskeygenassist(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Aeskeygenassist, o0, o1, o2);
		}

		public void Aeskeygenassist(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Aeskeygenassist, o0, o1, o2);
		}

		public void Pclmulqdq(XmmVariable o0, XmmVariable o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pclmulqdq, o0, o1, o2);
		}

		public void Pclmulqdq(XmmVariable o0, XmmVariable o1, int o2)
		{
			Compiler.Emit(InstructionId.Pclmulqdq, o0, o1, o2);
		}

		public void Pclmulqdq(XmmVariable o0, XmmVariable o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pclmulqdq, o0, o1, o2);
		}

		public void Pclmulqdq(XmmVariable o0, XmmVariable o1, long o2)
		{
			Compiler.Emit(InstructionId.Pclmulqdq, o0, o1, o2);
		}

		public void Pclmulqdq(XmmVariable o0, XmmVariable o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pclmulqdq, o0, o1, o2);
		}

		public void Pclmulqdq(XmmVariable o0, Memory o1, Immediate o2)
		{
			Compiler.Emit(InstructionId.Pclmulqdq, o0, o1, o2);
		}

		public void Pclmulqdq(XmmVariable o0, Memory o1, int o2)
		{
			Compiler.Emit(InstructionId.Pclmulqdq, o0, o1, o2);
		}

		public void Pclmulqdq(XmmVariable o0, Memory o1, uint o2)
		{
			Compiler.Emit(InstructionId.Pclmulqdq, o0, o1, o2);
		}

		public void Pclmulqdq(XmmVariable o0, Memory o1, long o2)
		{
			Compiler.Emit(InstructionId.Pclmulqdq, o0, o1, o2);
		}

		public void Pclmulqdq(XmmVariable o0, Memory o1, ulong o2)
		{
			Compiler.Emit(InstructionId.Pclmulqdq, o0, o1, o2);
		}

		public void Xrstor(Memory o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Xrstor, o0, o1, o2);
		}

		public void Xrstor64(Memory o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Xrstor64, o0, o1, o2);
		}

		public void Xsave(Memory o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Xsave, o0, o1, o2);
		}

		public void Xsave64(Memory o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Xsave64, o0, o1, o2);
		}

		public void Xsaveopt(Memory o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Xsaveopt, o0, o1, o2);
		}

		public void Xsaveopt64(Memory o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Xsaveopt64, o0, o1, o2);
		}

		public void Xgetbv(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Xgetbv, o0, o1, o2);
		}

		public void Xsetbv(GpVariable o0, GpVariable o1, GpVariable o2)
		{
			Compiler.Emit(InstructionId.Xsetbv, o0, o1, o2);
		}
	}
}
