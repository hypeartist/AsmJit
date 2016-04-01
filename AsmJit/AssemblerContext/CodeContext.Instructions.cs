using System;
using AsmJit.Common;
using AsmJit.Common.Operands;

namespace AsmJit.AssemblerContext
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

		public void Adc(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Adc, o0, (Immediate)o1);
		}

		public void Adc(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Adc, o0, (Immediate)o1);
		}

		public void Adc(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Adc, o0, o1);
		}

		public void Adc(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Adc, o0, (Immediate)o1);
		}

		public void Adc(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Adc, o0, (Immediate)o1);
		}

		public void Add(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Add, o0, (Immediate)o1);
		}

		public void Add(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Add, o0, (Immediate)o1);
		}

		public void Add(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Add, o0, o1);
		}

		public void Add(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Add, o0, (Immediate)o1);
		}

		public void Add(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Add, o0, (Immediate)o1);
		}

		public void And(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.And, o0, o1);
		}

		public void And(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.And, o0, o1);
		}

		public void And(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.And, o0, o1);
		}

		public void And(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.And, o0, (Immediate)o1);
		}

		public void And(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.And, o0, (Immediate)o1);
		}

		public void And(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.And, o0, o1);
		}

		public void And(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.And, o0, o1);
		}

		public void And(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.And, o0, (Immediate)o1);
		}

		public void And(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.And, o0, (Immediate)o1);
		}

		public void Bsf(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Bsf, o0, o1);
		}

		public void Bsf(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Bsf, o0, o1);
		}

		public void Bsr(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Bsr, o0, o1);
		}

		public void Bsr(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Bsr, o0, o1);
		}

		public void Bswap(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Bswap, o0);
		}

		public void Bt(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Bt, o0, (Immediate)o1);
		}

		public void Bt(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Bt, o0, (Immediate)o1);
		}

		public void Bt(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Bt, o0, o1);
		}

		public void Bt(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Bt, o0, (Immediate)o1);
		}

		public void Bt(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Bt, o0, (Immediate)o1);
		}

		public void Btc(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Btc, o0, (Immediate)o1);
		}

		public void Btc(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Btc, o0, (Immediate)o1);
		}

		public void Btc(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Btc, o0, o1);
		}

		public void Btc(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Btc, o0, (Immediate)o1);
		}

		public void Btc(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Btc, o0, (Immediate)o1);
		}

		public void Btr(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Btr, o0, (Immediate)o1);
		}

		public void Btr(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Btr, o0, (Immediate)o1);
		}

		public void Btr(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Btr, o0, o1);
		}

		public void Btr(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Btr, o0, (Immediate)o1);
		}

		public void Btr(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Btr, o0, (Immediate)o1);
		}

		public void Bts(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Bts, o0, (Immediate)o1);
		}

		public void Bts(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Bts, o0, (Immediate)o1);
		}

		public void Bts(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Bts, o0, o1);
		}

		public void Bts(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Bts, o0, (Immediate)o1);
		}

		public void Bts(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Bts, o0, (Immediate)o1);
		}

		public void Call(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Call, o0);
		}

		public void Call(Memory o0)
		{
			Assembler.Emit(InstructionId.Call, o0);
		}

		public void Call(Label o0)
		{
			Assembler.Emit(InstructionId.Call, o0);
		}

		public void Call(Immediate o0)
		{
			Assembler.Emit(InstructionId.Call, o0);
		}

		public void Call(IntPtr o0)
		{
			Call(o0.ToInt64());
		}

		public void Clc()
		{
			Assembler.Emit(InstructionId.Clc);
		}

		public void Cld()
		{
			Assembler.Emit(InstructionId.Cld);
		}

		public void Cmc()
		{
			Assembler.Emit(InstructionId.Cmc);
		}

		public void Cbw()
		{
			Assembler.Emit(InstructionId.Cbw);
		}

		public void Cdq()
		{
			Assembler.Emit(InstructionId.Cdq);
		}

		public void Cdqe()
		{
			Assembler.Emit(InstructionId.Cdqe);
		}

		public void Cqo()
		{
			Assembler.Emit(InstructionId.Cqo);
		}

		public void Cwd()
		{
			Assembler.Emit(InstructionId.Cwd);
		}

		public void Cwde()
		{
			Assembler.Emit(InstructionId.Cwde);
		}

		public void Cmov(Condition cc, GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(CondToCmovcc(cc), o0, o1);
		}

		public void Cmova(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmova, o0, o1);
		}

		public void Cmovae(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovae, o0, o1);
		}

		public void Cmovb(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovb, o0, o1);
		}

		public void Cmovbe(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovbe, o0, o1);
		}

		public void Cmovc(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovc, o0, o1);
		}

		public void Cmove(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmove, o0, o1);
		}

		public void Cmovg(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovg, o0, o1);
		}

		public void Cmovge(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovge, o0, o1);
		}

		public void Cmovl(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovl, o0, o1);
		}

		public void Cmovle(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovle, o0, o1);
		}

		public void Cmovna(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovna, o0, o1);
		}

		public void Cmovnae(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovnae, o0, o1);
		}

		public void Cmovnb(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovnb, o0, o1);
		}

		public void Cmovnbe(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovnbe, o0, o1);
		}

		public void Cmovnc(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovnc, o0, o1);
		}

		public void Cmovne(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovne, o0, o1);
		}

		public void Cmovng(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovng, o0, o1);
		}

		public void Cmovnge(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovnge, o0, o1);
		}

		public void Cmovnl(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovnl, o0, o1);
		}

		public void Cmovnle(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovnle, o0, o1);
		}

		public void Cmovno(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovno, o0, o1);
		}

		public void Cmovnp(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovnp, o0, o1);
		}

		public void Cmovns(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovns, o0, o1);
		}

		public void Cmovnz(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovnz, o0, o1);
		}

		public void Cmovo(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovo, o0, o1);
		}

		public void Cmovp(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovp, o0, o1);
		}

		public void Cmovpe(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovpe, o0, o1);
		}

		public void Cmovpo(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovpo, o0, o1);
		}

		public void Cmovs(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovs, o0, o1);
		}

		public void Cmovz(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmovz, o0, o1);
		}

		public void Cmov(Condition cc, GpRegister o0, Memory o1)
		{
			Assembler.Emit(CondToCmovcc(cc), o0, o1);
		}

		public void Cmova(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmova, o0, o1);
		}

		public void Cmovae(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovae, o0, o1);
		}

		public void Cmovb(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovb, o0, o1);
		}

		public void Cmovbe(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovbe, o0, o1);
		}

		public void Cmovc(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovc, o0, o1);
		}

		public void Cmove(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmove, o0, o1);
		}

		public void Cmovg(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovg, o0, o1);
		}

		public void Cmovge(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovge, o0, o1);
		}

		public void Cmovl(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovl, o0, o1);
		}

		public void Cmovle(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovle, o0, o1);
		}

		public void Cmovna(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovna, o0, o1);
		}

		public void Cmovnae(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovnae, o0, o1);
		}

		public void Cmovnb(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovnb, o0, o1);
		}

		public void Cmovnbe(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovnbe, o0, o1);
		}

		public void Cmovnc(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovnc, o0, o1);
		}

		public void Cmovne(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovne, o0, o1);
		}

		public void Cmovng(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovng, o0, o1);
		}

		public void Cmovnge(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovnge, o0, o1);
		}

		public void Cmovnl(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovnl, o0, o1);
		}

		public void Cmovnle(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovnle, o0, o1);
		}

		public void Cmovno(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovno, o0, o1);
		}

		public void Cmovnp(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovnp, o0, o1);
		}

		public void Cmovns(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovns, o0, o1);
		}

		public void Cmovnz(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovnz, o0, o1);
		}

		public void Cmovo(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovo, o0, o1);
		}

		public void Cmovp(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovp, o0, o1);
		}

		public void Cmovpe(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovpe, o0, o1);
		}

		public void Cmovpo(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovpo, o0, o1);
		}

		public void Cmovs(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovs, o0, o1);
		}

		public void Cmovz(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmovz, o0, o1);
		}

		public void Cmp(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Cmp, o0, (Immediate)o1);
		}

		public void Cmp(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Cmp, o0, (Immediate)o1);
		}

		public void Cmp(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Cmp, o0, o1);
		}

		public void Cmp(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Cmp, o0, (Immediate)o1);
		}

		public void Cmp(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Cmp, o0, (Immediate)o1);
		}

		public void Cmpsb()
		{
			Assembler.Emit(InstructionId.CmpsB);
		}

		public void Cmpsd()
		{
			Assembler.Emit(InstructionId.CmpsD);
		}

		public void Cmpsq()
		{
			Assembler.Emit(InstructionId.CmpsQ);
		}

		public void Cmpsw()
		{
			Assembler.Emit(InstructionId.CmpsW);
		}

		public void Cmpxchg(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmpxchg, o0, o1);
		}

		public void Cmpxchg(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cmpxchg, o0, o1);
		}

		public void Cmpxchg16b(Memory o0)
		{
			Assembler.Emit(InstructionId.Cmpxchg16b, o0);
		}

		public void Cmpxchg8b(Memory o0)
		{
			Assembler.Emit(InstructionId.Cmpxchg8b, o0);
		}

		public void Cpuid()
		{
			Assembler.Emit(InstructionId.Cpuid);
		}

		public void Daa()
		{
			Assembler.Emit(InstructionId.Daa);
		}

		public void Das()
		{
			Assembler.Emit(InstructionId.Das);
		}

		public void Dec(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Dec, o0);
		}

		public void Dec(Memory o0)
		{
			Assembler.Emit(InstructionId.Dec, o0);
		}

		public void Div(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Div, o0);
		}

		public void Div(Memory o0)
		{
			Assembler.Emit(InstructionId.Div, o0);
		}

		public void Enter(Immediate o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Enter, o0, o1);
		}

		public void Idiv(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Idiv, o0);
		}

		public void Idiv(Memory o0)
		{
			Assembler.Emit(InstructionId.Idiv, o0);
		}

		public void Imul(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Imul, o0);
		}

		public void Imul(Memory o0)
		{
			Assembler.Emit(InstructionId.Imul, o0);
		}

		public void Imul(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Imul, o0, o1);
		}

		public void Imul(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Imul, o0, o1);
		}

		public void Imul(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Imul, o0, o1);
		}

		public void Imul(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Imul, o0, (Immediate)o1);
		}

		public void Imul(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Imul, o0, (Immediate)o1);
		}

		public void Imul(GpRegister o0, GpRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Imul, o0, o1, o2);
		}

		public void Imul(GpRegister o0, GpRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Imul, o0, o1, (Immediate)o2);
		}

		public void Imul(GpRegister o0, GpRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Imul, o0, o1, (Immediate)o2);
		}

		public void Imul(GpRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Imul, o0, o1, o2);
		}

		public void Imul(GpRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Imul, o0, o1, (Immediate)o2);
		}

		public void Imul(GpRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Imul, o0, o1, (Immediate)o2);
		}

		public void Inc(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Inc, o0);
		}

		public void Inc(Memory o0)
		{
			Assembler.Emit(InstructionId.Inc, o0);
		}

		public void Int(Immediate o0)
		{
			Assembler.Emit(InstructionId.Int, o0);
		}

		public void Int(long o0)
		{
			Assembler.Emit(InstructionId.Int, (Immediate)o0);
		}

		public void Int(ulong o0)
		{
			Assembler.Emit(InstructionId.Int, (Immediate)o0);
		}

		public void Int3()
		{
			Int(3);
		}

		public void J(Condition cc, Label o0)
		{
			Assembler.Emit(CondToJcc(cc), o0);
		}

		public void Ja(Label o0)
		{
			Assembler.Emit(InstructionId.Ja, o0);
		}

		public void Jae(Label o0)
		{
			Assembler.Emit(InstructionId.Jae, o0);
		}

		public void Jb(Label o0)
		{
			Assembler.Emit(InstructionId.Jb, o0);
		}

		public void Jbe(Label o0)
		{
			Assembler.Emit(InstructionId.Jbe, o0);
		}

		public void Jc(Label o0)
		{
			Assembler.Emit(InstructionId.Jc, o0);
		}

		public void Je(Label o0)
		{
			Assembler.Emit(InstructionId.Je, o0);
		}

		public void Jg(Label o0)
		{
			Assembler.Emit(InstructionId.Jg, o0);
		}

		public void Jge(Label o0)
		{
			Assembler.Emit(InstructionId.Jge, o0);
		}

		public void Jl(Label o0)
		{
			Assembler.Emit(InstructionId.Jl, o0);
		}

		public void Jle(Label o0)
		{
			Assembler.Emit(InstructionId.Jle, o0);
		}

		public void Jna(Label o0)
		{
			Assembler.Emit(InstructionId.Jna, o0);
		}

		public void Jnae(Label o0)
		{
			Assembler.Emit(InstructionId.Jnae, o0);
		}

		public void Jnb(Label o0)
		{
			Assembler.Emit(InstructionId.Jnb, o0);
		}

		public void Jnbe(Label o0)
		{
			Assembler.Emit(InstructionId.Jnbe, o0);
		}

		public void Jnc(Label o0)
		{
			Assembler.Emit(InstructionId.Jnc, o0);
		}

		public void Jne(Label o0)
		{
			Assembler.Emit(InstructionId.Jne, o0);
		}

		public void Jng(Label o0)
		{
			Assembler.Emit(InstructionId.Jng, o0);
		}

		public void Jnge(Label o0)
		{
			Assembler.Emit(InstructionId.Jnge, o0);
		}

		public void Jnl(Label o0)
		{
			Assembler.Emit(InstructionId.Jnl, o0);
		}

		public void Jnle(Label o0)
		{
			Assembler.Emit(InstructionId.Jnle, o0);
		}

		public void Jno(Label o0)
		{
			Assembler.Emit(InstructionId.Jno, o0);
		}

		public void Jnp(Label o0)
		{
			Assembler.Emit(InstructionId.Jnp, o0);
		}

		public void Jns(Label o0)
		{
			Assembler.Emit(InstructionId.Jns, o0);
		}

		public void Jnz(Label o0)
		{
			Assembler.Emit(InstructionId.Jnz, o0);
		}

		public void Jo(Label o0)
		{
			Assembler.Emit(InstructionId.Jo, o0);
		}

		public void Jp(Label o0)
		{
			Assembler.Emit(InstructionId.Jp, o0);
		}

		public void Jpe(Label o0)
		{
			Assembler.Emit(InstructionId.Jpe, o0);
		}

		public void Jpo(Label o0)
		{
			Assembler.Emit(InstructionId.Jpo, o0);
		}

		public void Js(Label o0)
		{
			Assembler.Emit(InstructionId.Js, o0);
		}

		public void Jz(Label o0)
		{
			Assembler.Emit(InstructionId.Jz, o0);
		}

		public void Jecxz(GpRegister o0, Label o1)
		{
			Assembler.Emit(InstructionId.Jecxz, o0, o1);
		}

		public void Jmp(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Jmp, o0);
		}

		public void Jmp(Memory o0)
		{
			Assembler.Emit(InstructionId.Jmp, o0);
		}

		public void Jmp(Label o0)
		{
			Assembler.Emit(InstructionId.Jmp, o0);
		}

		public void Jmp(Immediate o0)
		{
			Assembler.Emit(InstructionId.Jmp, o0);
		}

		public void Jmp(IntPtr dst)
		{
			Jmp((Immediate)dst.ToInt64());
		}

		public void Lahf()
		{
			Assembler.Emit(InstructionId.Lahf);
		}

		public void Lea(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Lea, o0, o1);
		}

		public void Leave()
		{
			Assembler.Emit(InstructionId.Leave);
		}

		public void Lodsb()
		{
			Assembler.Emit(InstructionId.LodsB);
		}

		public void Lodsd()
		{
			Assembler.Emit(InstructionId.LodsD);
		}

		public void Lodsq()
		{
			Assembler.Emit(InstructionId.LodsQ);
		}

		public void Lodsw()
		{
			Assembler.Emit(InstructionId.LodsW);
		}

		public void Mov(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Mov, o0, (Immediate)o1);
		}

		public void Mov(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Mov, o0, (Immediate)o1);
		}

		public void Mov(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Mov, o0, (Immediate)o1);
		}

		public void Mov(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Mov, o0, (Immediate)o1);
		}

		public void Mov(GpRegister o0, SegRegister o1)
		{
			Assembler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(Memory o0, SegRegister o1)
		{
			Assembler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(SegRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Mov, o0, o1);
		}

		public void Mov(SegRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Mov, o0, o1);
		}

		public void MovPtr(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.MovPtr, o0, o1);
		}

		public void MovPtr(GpRegister o0, IntPtr o1)
		{
			Assembler.Emit(InstructionId.MovPtr, o0, (Immediate)o1.ToInt64());
		}

		public void MovPtr(Immediate o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.MovPtr, o0, o1);
		}

		public void MovPtr(IntPtr o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.MovPtr, (Immediate)o0.ToInt64(), o1);
		}

		public void Movbe(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movbe, o0, o1);
		}

		public void Movbe(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Movbe, o0, o1);
		}

		public void Movsb()
		{
			Assembler.Emit(InstructionId.MovsB);
		}

		public void Movsd()
		{
			Assembler.Emit(InstructionId.MovsD);
		}

		public void Movsq()
		{
			Assembler.Emit(InstructionId.MovsQ);
		}

		public void Movsw()
		{
			Assembler.Emit(InstructionId.MovsW);
		}

		public void Movsx(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Movsx, o0, o1);
		}

		public void Movsx(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movsx, o0, o1);
		}

		public void Movsxd(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Movsxd, o0, o1);
		}

		public void Movsxd(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movsxd, o0, o1);
		}

		public void Movzx(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Movzx, o0, o1);
		}

		public void Movzx(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movzx, o0, o1);
		}

		public void Mul(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Mul, o0);
		}

		public void Mul(Memory o0)
		{
			Assembler.Emit(InstructionId.Mul, o0);
		}

		public void Neg(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Neg, o0);
		}

		public void Neg(Memory o0)
		{
			Assembler.Emit(InstructionId.Neg, o0);
		}

		public void Nop()
		{
			Assembler.Emit(InstructionId.Nop);
		}

		public void Not(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Not, o0);
		}

		public void Not(Memory o0)
		{
			Assembler.Emit(InstructionId.Not, o0);
		}

		public void Or(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Or, o0, (Immediate)o1);
		}

		public void Or(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Or, o0, (Immediate)o1);
		}

		public void Or(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Or, o0, o1);
		}

		public void Or(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Or, o0, (Immediate)o1);
		}

		public void Or(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Or, o0, (Immediate)o1);
		}

		public void Pop(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Pop, o0);
		}

		public void Pop(Memory o0)
		{
			Assembler.Emit(InstructionId.Pop, o0);
		}

		public void Pop(SegRegister o0)
		{
			Assembler.Emit(InstructionId.Pop, o0);
		}

		public void Popa()
		{
			Assembler.Emit(InstructionId.Popa);
		}

		public void Popf()
		{
			Assembler.Emit(InstructionId.Popf);
		}

		public void Push(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Push, o0);
		}

		public void Push(Memory o0)
		{
			Assembler.Emit(InstructionId.Push, o0);
		}

		public void Push(SegRegister o0)
		{
			Assembler.Emit(InstructionId.Push, o0);
		}

		public void Push(Immediate o0)
		{
			Assembler.Emit(InstructionId.Push, o0);
		}

		public void Push(long o0)
		{
			Assembler.Emit(InstructionId.Push, (Immediate)o0);
		}

		public void Push(ulong o0)
		{
			Assembler.Emit(InstructionId.Push, (Immediate)o0);
		}

		public void Pusha()
		{
			Assembler.Emit(InstructionId.Pusha);
		}

		public void Pushf()
		{
			Assembler.Emit(InstructionId.Pushf);
		}

		public void Rcl(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Rcl, o0, (Immediate)o1);
		}

		public void Rcl(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Rcl, o0, (Immediate)o1);
		}

		public void Rcl(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Rcl, o0, o1);
		}

		public void Rcl(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Rcl, o0, (Immediate)o1);
		}

		public void Rcl(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Rcl, o0, (Immediate)o1);
		}

		public void Rcr(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Rcr, o0, (Immediate)o1);
		}

		public void Rcr(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Rcr, o0, (Immediate)o1);
		}

		public void Rcr(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Rcr, o0, o1);
		}

		public void Rcr(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Rcr, o0, (Immediate)o1);
		}

		public void Rcr(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Rcr, o0, (Immediate)o1);
		}

		public void Rdtsc()
		{
			Assembler.Emit(InstructionId.Rdtsc);
		}

		public void Rdtscp()
		{
			Assembler.Emit(InstructionId.Rdtscp);
		}

		public void RepLodsb()
		{
			Assembler.Emit(InstructionId.RepLodsB);
		}

		public void RepLodsd()
		{
			Assembler.Emit(InstructionId.RepLodsD);
		}

		public void RepLodsq()
		{
			Assembler.Emit(InstructionId.RepLodsQ);
		}

		public void RepLodsw()
		{
			Assembler.Emit(InstructionId.RepLodsW);
		}

		public void RepMovsb()
		{
			Assembler.Emit(InstructionId.RepMovsB);
		}

		public void RepMovsd()
		{
			Assembler.Emit(InstructionId.RepMovsD);
		}

		public void RepMovsq()
		{
			Assembler.Emit(InstructionId.RepMovsQ);
		}

		public void RepMovsw()
		{
			Assembler.Emit(InstructionId.RepMovsW);
		}

		public void RepStosb()
		{
			Assembler.Emit(InstructionId.RepStosB);
		}

		public void RepStosd()
		{
			Assembler.Emit(InstructionId.RepStosD);
		}

		public void RepStosq()
		{
			Assembler.Emit(InstructionId.RepStosQ);
		}

		public void RepStosw()
		{
			Assembler.Emit(InstructionId.RepStosW);
		}

		public void RepeCmpsb()
		{
			Assembler.Emit(InstructionId.RepeCmpsB);
		}

		public void RepeCmpsd()
		{
			Assembler.Emit(InstructionId.RepeCmpsD);
		}

		public void RepeCmpsq()
		{
			Assembler.Emit(InstructionId.RepeCmpsQ);
		}

		public void RepeCmpsw()
		{
			Assembler.Emit(InstructionId.RepeCmpsW);
		}

		public void RepeScasb()
		{
			Assembler.Emit(InstructionId.RepeScasB);
		}

		public void RepeScasd()
		{
			Assembler.Emit(InstructionId.RepeScasD);
		}

		public void RepeScasq()
		{
			Assembler.Emit(InstructionId.RepeScasQ);
		}

		public void RepeScasw()
		{
			Assembler.Emit(InstructionId.RepeScasW);
		}

		public void RepneCmpsb()
		{
			Assembler.Emit(InstructionId.RepneCmpsB);
		}

		public void RepneCmpsd()
		{
			Assembler.Emit(InstructionId.RepneCmpsD);
		}

		public void RepneCmpsq()
		{
			Assembler.Emit(InstructionId.RepneCmpsQ);
		}

		public void RepneCmpsw()
		{
			Assembler.Emit(InstructionId.RepneCmpsW);
		}

		public void RepneScasb()
		{
			Assembler.Emit(InstructionId.RepneScasB);
		}

		public void RepneScasd()
		{
			Assembler.Emit(InstructionId.RepneScasD);
		}

		public void RepneScasq()
		{
			Assembler.Emit(InstructionId.RepneScasQ);
		}

		public void RepneScasw()
		{
			Assembler.Emit(InstructionId.RepneScasW);
		}

		public void Ret()
		{
			Assembler.Emit(InstructionId.Ret);
		}

		public void Ret(Immediate o0)
		{
			Assembler.Emit(InstructionId.Ret, o0);
		}

		public void Ret(long o0)
		{
			Assembler.Emit(InstructionId.Ret, (Immediate)o0);
		}

		public void Ret(ulong o0)
		{
			Assembler.Emit(InstructionId.Ret, (Immediate)o0);
		}

		public void Rol(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Rol, o0, (Immediate)o1);
		}

		public void Rol(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Rol, o0, (Immediate)o1);
		}

		public void Rol(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Rol, o0, o1);
		}

		public void Rol(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Rol, o0, (Immediate)o1);
		}

		public void Rol(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Rol, o0, (Immediate)o1);
		}

		public void Ror(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Ror, o0, (Immediate)o1);
		}

		public void Ror(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Ror, o0, (Immediate)o1);
		}

		public void Ror(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Ror, o0, o1);
		}

		public void Ror(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Ror, o0, (Immediate)o1);
		}

		public void Ror(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Ror, o0, (Immediate)o1);
		}

		public void Sahf()
		{
			Assembler.Emit(InstructionId.Sahf);
		}

		public void Sbb(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Sbb, o0, (Immediate)o1);
		}

		public void Sbb(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Sbb, o0, (Immediate)o1);
		}

		public void Sbb(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Sbb, o0, o1);
		}

		public void Sbb(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Sbb, o0, (Immediate)o1);
		}

		public void Sbb(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Sbb, o0, (Immediate)o1);
		}

		public void Sal(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Sal, o0, (Immediate)o1);
		}

		public void Sal(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Sal, o0, (Immediate)o1);
		}

		public void Sal(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Sal, o0, o1);
		}

		public void Sal(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Sal, o0, (Immediate)o1);
		}

		public void Sal(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Sal, o0, (Immediate)o1);
		}

		public void Sar(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Sar, o0, (Immediate)o1);
		}

		public void Sar(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Sar, o0, (Immediate)o1);
		}

		public void Sar(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Sar, o0, o1);
		}

		public void Sar(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Sar, o0, (Immediate)o1);
		}

		public void Sar(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Sar, o0, (Immediate)o1);
		}

		public void Scasb()
		{
			Assembler.Emit(InstructionId.ScasB);
		}

		public void Scasd()
		{
			Assembler.Emit(InstructionId.ScasD);
		}

		public void Scasq()
		{
			Assembler.Emit(InstructionId.ScasQ);
		}

		public void Scasw()
		{
			Assembler.Emit(InstructionId.ScasW);
		}

		public void Set(Condition cc, GpRegister o0)
		{
			Assembler.Emit(CondToSetcc(cc), o0);
		}

		public void Seta(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Seta, o0);
		}

		public void Setae(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setae, o0);
		}

		public void Setb(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setb, o0);
		}

		public void Setbe(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setbe, o0);
		}

		public void Setc(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setc, o0);
		}

		public void Sete(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Sete, o0);
		}

		public void Setg(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setg, o0);
		}

		public void Setge(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setge, o0);
		}

		public void Setl(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setl, o0);
		}

		public void Setle(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setle, o0);
		}

		public void Setna(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setna, o0);
		}

		public void Setnae(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setnae, o0);
		}

		public void Setnb(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setnb, o0);
		}

		public void Setnbe(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setnbe, o0);
		}

		public void Setnc(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setnc, o0);
		}

		public void Setne(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setne, o0);
		}

		public void Setng(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setng, o0);
		}

		public void Setnge(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setnge, o0);
		}

		public void Setnl(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setnl, o0);
		}

		public void Setnle(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setnle, o0);
		}

		public void Setno(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setno, o0);
		}

		public void Setnp(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setnp, o0);
		}

		public void Setns(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setns, o0);
		}

		public void Setnz(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setnz, o0);
		}

		public void Seto(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Seto, o0);
		}

		public void Setp(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setp, o0);
		}

		public void Setpe(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setpe, o0);
		}

		public void Setpo(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setpo, o0);
		}

		public void Sets(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Sets, o0);
		}

		public void Setz(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Setz, o0);
		}

		public void Set(Condition cc, Memory o0)
		{
			Assembler.Emit(CondToSetcc(cc), o0);
		}

		public void Seta(Memory o0)
		{
			Assembler.Emit(InstructionId.Seta, o0);
		}

		public void Setae(Memory o0)
		{
			Assembler.Emit(InstructionId.Setae, o0);
		}

		public void Setb(Memory o0)
		{
			Assembler.Emit(InstructionId.Setb, o0);
		}

		public void Setbe(Memory o0)
		{
			Assembler.Emit(InstructionId.Setbe, o0);
		}

		public void Setc(Memory o0)
		{
			Assembler.Emit(InstructionId.Setc, o0);
		}

		public void Sete(Memory o0)
		{
			Assembler.Emit(InstructionId.Sete, o0);
		}

		public void Setg(Memory o0)
		{
			Assembler.Emit(InstructionId.Setg, o0);
		}

		public void Setge(Memory o0)
		{
			Assembler.Emit(InstructionId.Setge, o0);
		}

		public void Setl(Memory o0)
		{
			Assembler.Emit(InstructionId.Setl, o0);
		}

		public void Setle(Memory o0)
		{
			Assembler.Emit(InstructionId.Setle, o0);
		}

		public void Setna(Memory o0)
		{
			Assembler.Emit(InstructionId.Setna, o0);
		}

		public void Setnae(Memory o0)
		{
			Assembler.Emit(InstructionId.Setnae, o0);
		}

		public void Setnb(Memory o0)
		{
			Assembler.Emit(InstructionId.Setnb, o0);
		}

		public void Setnbe(Memory o0)
		{
			Assembler.Emit(InstructionId.Setnbe, o0);
		}

		public void Setnc(Memory o0)
		{
			Assembler.Emit(InstructionId.Setnc, o0);
		}

		public void Setne(Memory o0)
		{
			Assembler.Emit(InstructionId.Setne, o0);
		}

		public void Setng(Memory o0)
		{
			Assembler.Emit(InstructionId.Setng, o0);
		}

		public void Setnge(Memory o0)
		{
			Assembler.Emit(InstructionId.Setnge, o0);
		}

		public void Setnl(Memory o0)
		{
			Assembler.Emit(InstructionId.Setnl, o0);
		}

		public void Setnle(Memory o0)
		{
			Assembler.Emit(InstructionId.Setnle, o0);
		}

		public void Setno(Memory o0)
		{
			Assembler.Emit(InstructionId.Setno, o0);
		}

		public void Setnp(Memory o0)
		{
			Assembler.Emit(InstructionId.Setnp, o0);
		}

		public void Setns(Memory o0)
		{
			Assembler.Emit(InstructionId.Setns, o0);
		}

		public void Setnz(Memory o0)
		{
			Assembler.Emit(InstructionId.Setnz, o0);
		}

		public void Seto(Memory o0)
		{
			Assembler.Emit(InstructionId.Seto, o0);
		}

		public void Setp(Memory o0)
		{
			Assembler.Emit(InstructionId.Setp, o0);
		}

		public void Setpe(Memory o0)
		{
			Assembler.Emit(InstructionId.Setpe, o0);
		}

		public void Setpo(Memory o0)
		{
			Assembler.Emit(InstructionId.Setpo, o0);
		}

		public void Sets(Memory o0)
		{
			Assembler.Emit(InstructionId.Sets, o0);
		}

		public void Setz(Memory o0)
		{
			Assembler.Emit(InstructionId.Setz, o0);
		}

		public void Shl(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Shl, o0, (Immediate)o1);
		}

		public void Shl(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Shl, o0, (Immediate)o1);
		}

		public void Shl(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Shl, o0, o1);
		}

		public void Shl(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Shl, o0, (Immediate)o1);
		}

		public void Shl(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Shl, o0, (Immediate)o1);
		}

		public void Shr(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Shr, o0, (Immediate)o1);
		}

		public void Shr(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Shr, o0, (Immediate)o1);
		}

		public void Shr(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Shr, o0, o1);
		}

		public void Shr(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Shr, o0, (Immediate)o1);
		}

		public void Shr(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Shr, o0, (Immediate)o1);
		}

		public void Shld(GpRegister o0, GpRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(Memory o0, GpRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(GpRegister o0, GpRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(GpRegister o0, GpRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Shld, o0, o1, (Immediate)o2);
		}

		public void Shld(GpRegister o0, GpRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Shld, o0, o1, (Immediate)o2);
		}

		public void Shld(Memory o0, GpRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Shld, o0, o1, o2);
		}

		public void Shld(Memory o0, GpRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Shld, o0, o1, (Immediate)o2);
		}

		public void Shld(Memory o0, GpRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Shld, o0, o1, (Immediate)o2);
		}

		public void Shrd(GpRegister o0, GpRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(Memory o0, GpRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(GpRegister o0, GpRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(GpRegister o0, GpRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Shrd, o0, o1, (Immediate)o2);
		}

		public void Shrd(GpRegister o0, GpRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Shrd, o0, o1, (Immediate)o2);
		}

		public void Shrd(Memory o0, GpRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Shrd, o0, o1, o2);
		}

		public void Shrd(Memory o0, GpRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Shrd, o0, o1, (Immediate)o2);
		}

		public void Shrd(Memory o0, GpRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Shrd, o0, o1, (Immediate)o2);
		}

		public void Stc()
		{
			Assembler.Emit(InstructionId.Stc);
		}

		public void Std()
		{
			Assembler.Emit(InstructionId.Std);
		}

		public void Stosb()
		{
			Assembler.Emit(InstructionId.StosB);
		}

		public void Stosd()
		{
			Assembler.Emit(InstructionId.StosD);
		}

		public void Stosq()
		{
			Assembler.Emit(InstructionId.StosQ);
		}

		public void Stosw()
		{
			Assembler.Emit(InstructionId.StosW);
		}

		public void Sub(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Sub, o0, (Immediate)o1);
		}

		public void Sub(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Sub, o0, (Immediate)o1);
		}

		public void Sub(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Sub, o0, o1);
		}

		public void Sub(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Sub, o0, (Immediate)o1);
		}

		public void Sub(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Sub, o0, (Immediate)o1);
		}

		public void Test(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Test, o0, (Immediate)o1);
		}

		public void Test(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Test, o0, (Immediate)o1);
		}

		public void Test(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Test, o0, o1);
		}

		public void Test(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Test, o0, (Immediate)o1);
		}

		public void Test(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Test, o0, (Immediate)o1);
		}

		public void Ud2()
		{
			Assembler.Emit(InstructionId.Ud2);
		}

		public void Xadd(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Xadd, o0, o1);
		}

		public void Xadd(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Xadd, o0, o1);
		}

		public void Xchg(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Xchg, o0, o1);
		}

		public void Xchg(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Xchg, o0, o1);
		}

		public void Xchg(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Xchg, o0, o1);
		}

		public void Xor(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(GpRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(GpRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Xor, o0, (Immediate)o1);
		}

		public void Xor(GpRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Xor, o0, (Immediate)o1);
		}

		public void Xor(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Xor, o0, o1);
		}

		public void Xor(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Xor, o0, (Immediate)o1);
		}

		public void Xor(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Xor, o0, (Immediate)o1);
		}

		public void F2xm1()
		{
			Assembler.Emit(InstructionId.F2xm1);
		}

		public void Fabs()
		{
			Assembler.Emit(InstructionId.Fabs);
		}

		public void Fadd(FpRegister o0, FpRegister o1)
		{
			Assembler.Emit(InstructionId.Fadd, o0, o1);
		}

		public void Fadd(Memory o0)
		{
			Assembler.Emit(InstructionId.Fadd, o0);
		}

		public void Faddp(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Faddp, o0);
		}

		public void Faddp()
		{
			Assembler.Emit(InstructionId.Faddp);
		}

		public void Fbld(Memory o0)
		{
			Assembler.Emit(InstructionId.Fbld, o0);
		}

		public void Fbstp(Memory o0)
		{
			Assembler.Emit(InstructionId.Fbstp, o0);
		}

		public void Fchs()
		{
			Assembler.Emit(InstructionId.Fchs);
		}

		public void Fclex()
		{
			Assembler.Emit(InstructionId.Fclex);
		}

		public void Fcmovb(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fcmovb, o0);
		}

		public void Fcmovbe(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fcmovbe, o0);
		}

		public void Fcmove(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fcmove, o0);
		}

		public void Fcmovnb(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fcmovnb, o0);
		}

		public void Fcmovnbe(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fcmovnbe, o0);
		}

		public void Fcmovne(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fcmovne, o0);
		}

		public void Fcmovnu(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fcmovnu, o0);
		}

		public void Fcmovu(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fcmovu, o0);
		}

		public void Fcom(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fcom, o0);
		}

		public void Fcom()
		{
			Assembler.Emit(InstructionId.Fcom);
		}

		public void Fcom(Memory o0)
		{
			Assembler.Emit(InstructionId.Fcom, o0);
		}

		public void Fcomp(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fcomp, o0);
		}

		public void Fcomp()
		{
			Assembler.Emit(InstructionId.Fcomp);
		}

		public void Fcomp(Memory o0)
		{
			Assembler.Emit(InstructionId.Fcomp, o0);
		}

		public void Fcompp()
		{
			Assembler.Emit(InstructionId.Fcompp);
		}

		public void Fcomi(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fcomi, o0);
		}

		public void Fcomip(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fcomip, o0);
		}

		public void Fcos()
		{
			Assembler.Emit(InstructionId.Fcos);
		}

		public void Fdecstp()
		{
			Assembler.Emit(InstructionId.Fdecstp);
		}

		public void Fdiv(FpRegister o0, FpRegister o1)
		{
			Assembler.Emit(InstructionId.Fdiv, o0, o1);
		}

		public void Fdiv(Memory o0)
		{
			Assembler.Emit(InstructionId.Fdiv, o0);
		}

		public void Fdivp(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fdivp, o0);
		}

		public void Fdivp()
		{
			Assembler.Emit(InstructionId.Fdivp);
		}

		public void Fdivr(FpRegister o0, FpRegister o1)
		{
			Assembler.Emit(InstructionId.Fdivr, o0, o1);
		}

		public void Fdivr(Memory o0)
		{
			Assembler.Emit(InstructionId.Fdivr, o0);
		}

		public void Fdivrp(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fdivrp, o0);
		}

		public void Fdivrp()
		{
			Assembler.Emit(InstructionId.Fdivrp);
		}

		public void Ffree(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Ffree, o0);
		}

		public void Fiadd(Memory o0)
		{
			Assembler.Emit(InstructionId.Fiadd, o0);
		}

		public void Ficom(Memory o0)
		{
			Assembler.Emit(InstructionId.Ficom, o0);
		}

		public void Ficomp(Memory o0)
		{
			Assembler.Emit(InstructionId.Ficomp, o0);
		}

		public void Fidiv(Memory o0)
		{
			Assembler.Emit(InstructionId.Fidiv, o0);
		}

		public void Fidivr(Memory o0)
		{
			Assembler.Emit(InstructionId.Fidivr, o0);
		}

		public void Fild(Memory o0)
		{
			Assembler.Emit(InstructionId.Fild, o0);
		}

		public void Fimul(Memory o0)
		{
			Assembler.Emit(InstructionId.Fimul, o0);
		}

		public void Fincstp()
		{
			Assembler.Emit(InstructionId.Fincstp);
		}

		public void Finit()
		{
			Assembler.Emit(InstructionId.Finit);
		}

		public void Fisub(Memory o0)
		{
			Assembler.Emit(InstructionId.Fisub, o0);
		}

		public void Fisubr(Memory o0)
		{
			Assembler.Emit(InstructionId.Fisubr, o0);
		}

		public void Fninit()
		{
			Assembler.Emit(InstructionId.Fninit);
		}

		public void Fist(Memory o0)
		{
			Assembler.Emit(InstructionId.Fist, o0);
		}

		public void Fistp(Memory o0)
		{
			Assembler.Emit(InstructionId.Fistp, o0);
		}

		public void Fld(Memory o0)
		{
			Assembler.Emit(InstructionId.Fld, o0);
		}

		public void Fld(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fld, o0);
		}

		public void Fld1()
		{
			Assembler.Emit(InstructionId.Fld1);
		}

		public void Fldl2t()
		{
			Assembler.Emit(InstructionId.Fldl2t);
		}

		public void Fldl2e()
		{
			Assembler.Emit(InstructionId.Fldl2e);
		}

		public void Fldpi()
		{
			Assembler.Emit(InstructionId.Fldpi);
		}

		public void Fldlg2()
		{
			Assembler.Emit(InstructionId.Fldlg2);
		}

		public void Fldln2()
		{
			Assembler.Emit(InstructionId.Fldln2);
		}

		public void Fldz()
		{
			Assembler.Emit(InstructionId.Fldz);
		}

		public void Fldcw(Memory o0)
		{
			Assembler.Emit(InstructionId.Fldcw, o0);
		}

		public void Fldenv(Memory o0)
		{
			Assembler.Emit(InstructionId.Fldenv, o0);
		}

		public void Fmul(FpRegister o0, FpRegister o1)
		{
			Assembler.Emit(InstructionId.Fmul, o0, o1);
		}

		public void Fmul(Memory o0)
		{
			Assembler.Emit(InstructionId.Fmul, o0);
		}

		public void Fmulp(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fmulp, o0);
		}

		public void Fmulp()
		{
			Assembler.Emit(InstructionId.Fmulp);
		}

		public void Fnclex()
		{
			Assembler.Emit(InstructionId.Fnclex);
		}

		public void Fnop()
		{
			Assembler.Emit(InstructionId.Fnop);
		}

		public void Fnsave(Memory o0)
		{
			Assembler.Emit(InstructionId.Fnsave, o0);
		}

		public void Fnstenv(Memory o0)
		{
			Assembler.Emit(InstructionId.Fnstenv, o0);
		}

		public void Fnstcw(Memory o0)
		{
			Assembler.Emit(InstructionId.Fnstcw, o0);
		}

		public void Fnstsw(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Fnstsw, o0);
		}

		public void Fnstsw(Memory o0)
		{
			Assembler.Emit(InstructionId.Fnstsw, o0);
		}

		public void Fpatan()
		{
			Assembler.Emit(InstructionId.Fpatan);
		}

		public void Fprem()
		{
			Assembler.Emit(InstructionId.Fprem);
		}

		public void Fprem1()
		{
			Assembler.Emit(InstructionId.Fprem1);
		}

		public void Fptan()
		{
			Assembler.Emit(InstructionId.Fptan);
		}

		public void Frndint()
		{
			Assembler.Emit(InstructionId.Frndint);
		}

		public void Frstor(Memory o0)
		{
			Assembler.Emit(InstructionId.Frstor, o0);
		}

		public void Fsave(Memory o0)
		{
			Assembler.Emit(InstructionId.Fsave, o0);
		}

		public void Fscale()
		{
			Assembler.Emit(InstructionId.Fscale);
		}

		public void Fsin()
		{
			Assembler.Emit(InstructionId.Fsin);
		}

		public void Fsincos()
		{
			Assembler.Emit(InstructionId.Fsincos);
		}

		public void Fsqrt()
		{
			Assembler.Emit(InstructionId.Fsqrt);
		}

		public void Fst(Memory o0)
		{
			Assembler.Emit(InstructionId.Fst, o0);
		}

		public void Fst(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fst, o0);
		}

		public void Fstp(Memory o0)
		{
			Assembler.Emit(InstructionId.Fstp, o0);
		}

		public void Fstp(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fstp, o0);
		}

		public void Fstcw(Memory o0)
		{
			Assembler.Emit(InstructionId.Fstcw, o0);
		}

		public void Fstenv(Memory o0)
		{
			Assembler.Emit(InstructionId.Fstenv, o0);
		}

		public void Fstsw(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Fstsw, o0);
		}

		public void Fstsw(Memory o0)
		{
			Assembler.Emit(InstructionId.Fstsw, o0);
		}

		public void Fsub(FpRegister o0, FpRegister o1)
		{
			Assembler.Emit(InstructionId.Fsub, o0, o1);
		}

		public void Fsub(Memory o0)
		{
			Assembler.Emit(InstructionId.Fsub, o0);
		}

		public void Fsubp(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fsubp, o0);
		}

		public void Fsubp()
		{
			Assembler.Emit(InstructionId.Fsubp);
		}

		public void Fsubr(FpRegister o0, FpRegister o1)
		{
			Assembler.Emit(InstructionId.Fsubr, o0, o1);
		}

		public void Fsubr(Memory o0)
		{
			Assembler.Emit(InstructionId.Fsubr, o0);
		}

		public void Fsubrp(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fsubrp, o0);
		}

		public void Fsubrp()
		{
			Assembler.Emit(InstructionId.Fsubrp);
		}

		public void Ftst()
		{
			Assembler.Emit(InstructionId.Ftst);
		}

		public void Fucom(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fucom, o0);
		}

		public void Fucom()
		{
			Assembler.Emit(InstructionId.Fucom);
		}

		public void Fucomi(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fucomi, o0);
		}

		public void Fucomip(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fucomip, o0);
		}

		public void Fucomp(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fucomp, o0);
		}

		public void Fucomp()
		{
			Assembler.Emit(InstructionId.Fucomp);
		}

		public void Fucompp()
		{
			Assembler.Emit(InstructionId.Fucompp);
		}

		public void Fwait()
		{
			Assembler.Emit(InstructionId.Fwait);
		}

		public void Fxam()
		{
			Assembler.Emit(InstructionId.Fxam);
		}

		public void Fxch(FpRegister o0)
		{
			Assembler.Emit(InstructionId.Fxch, o0);
		}

		public void Fxrstor(Memory o0)
		{
			Assembler.Emit(InstructionId.Fxrstor, o0);
		}

		public void Fxsave(Memory o0)
		{
			Assembler.Emit(InstructionId.Fxsave, o0);
		}

		public void Fxtract()
		{
			Assembler.Emit(InstructionId.Fxtract);
		}

		public void Fyl2x()
		{
			Assembler.Emit(InstructionId.Fyl2x);
		}

		public void Fyl2xp1()
		{
			Assembler.Emit(InstructionId.Fyl2xp1);
		}

		public void Movd(Memory o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movd(GpRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movd(MmRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movq(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(Memory o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(GpRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(MmRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Packssdw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Packssdw, o0, o1);
		}

		public void Packssdw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Packssdw, o0, o1);
		}

		public void Packsswb(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Packsswb, o0, o1);
		}

		public void Packsswb(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Packsswb, o0, o1);
		}

		public void Packuswb(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Packuswb, o0, o1);
		}

		public void Packuswb(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Packuswb, o0, o1);
		}

		public void Paddb(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddb, o0, o1);
		}

		public void Paddb(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddb, o0, o1);
		}

		public void Paddd(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddd, o0, o1);
		}

		public void Paddd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddd, o0, o1);
		}

		public void Paddsb(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddsb, o0, o1);
		}

		public void Paddsb(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddsb, o0, o1);
		}

		public void Paddsw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddsw, o0, o1);
		}

		public void Paddsw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddsw, o0, o1);
		}

		public void Paddusb(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddusb, o0, o1);
		}

		public void Paddusb(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddusb, o0, o1);
		}

		public void Paddusw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddusw, o0, o1);
		}

		public void Paddusw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddusw, o0, o1);
		}

		public void Paddw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddw, o0, o1);
		}

		public void Paddw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddw, o0, o1);
		}

		public void Pand(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pand, o0, o1);
		}

		public void Pand(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pand, o0, o1);
		}

		public void Pandn(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pandn, o0, o1);
		}

		public void Pandn(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pandn, o0, o1);
		}

		public void Pcmpeqb(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pcmpeqb, o0, o1);
		}

		public void Pcmpeqb(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pcmpeqb, o0, o1);
		}

		public void Pcmpeqd(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pcmpeqd, o0, o1);
		}

		public void Pcmpeqd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pcmpeqd, o0, o1);
		}

		public void Pcmpeqw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pcmpeqw, o0, o1);
		}

		public void Pcmpeqw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pcmpeqw, o0, o1);
		}

		public void Pcmpgtb(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pcmpgtb, o0, o1);
		}

		public void Pcmpgtb(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pcmpgtb, o0, o1);
		}

		public void Pcmpgtd(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pcmpgtd, o0, o1);
		}

		public void Pcmpgtd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pcmpgtd, o0, o1);
		}

		public void Pcmpgtw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pcmpgtw, o0, o1);
		}

		public void Pcmpgtw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pcmpgtw, o0, o1);
		}

		public void Pmulhw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmulhw, o0, o1);
		}

		public void Pmulhw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmulhw, o0, o1);
		}

		public void Pmullw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmullw, o0, o1);
		}

		public void Pmullw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmullw, o0, o1);
		}

		public void Por(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Por, o0, o1);
		}

		public void Por(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Por, o0, o1);
		}

		public void Pmaddwd(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmaddwd, o0, o1);
		}

		public void Pmaddwd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmaddwd, o0, o1);
		}

		public void Pslld(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(MmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(MmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Pslld, o0, (Immediate)o1);
		}

		public void Pslld(MmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Pslld, o0, (Immediate)o1);
		}

		public void Psllq(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(MmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(MmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psllq, o0, (Immediate)o1);
		}

		public void Psllq(MmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psllq, o0, (Immediate)o1);
		}

		public void Psllw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(MmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(MmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psllw, o0, (Immediate)o1);
		}

		public void Psllw(MmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psllw, o0, (Immediate)o1);
		}

		public void Psrad(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(MmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(MmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psrad, o0, (Immediate)o1);
		}

		public void Psrad(MmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psrad, o0, (Immediate)o1);
		}

		public void Psraw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(MmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(MmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psraw, o0, (Immediate)o1);
		}

		public void Psraw(MmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psraw, o0, (Immediate)o1);
		}

		public void Psrld(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(MmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(MmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psrld, o0, (Immediate)o1);
		}

		public void Psrld(MmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psrld, o0, (Immediate)o1);
		}

		public void Psrlq(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(MmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(MmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psrlq, o0, (Immediate)o1);
		}

		public void Psrlq(MmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psrlq, o0, (Immediate)o1);
		}

		public void Psrlw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(MmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(MmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psrlw, o0, (Immediate)o1);
		}

		public void Psrlw(MmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psrlw, o0, (Immediate)o1);
		}

		public void Psubb(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubb, o0, o1);
		}

		public void Psubb(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubb, o0, o1);
		}

		public void Psubd(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubd, o0, o1);
		}

		public void Psubd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubd, o0, o1);
		}

		public void Psubsb(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubsb, o0, o1);
		}

		public void Psubsb(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubsb, o0, o1);
		}

		public void Psubsw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubsw, o0, o1);
		}

		public void Psubsw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubsw, o0, o1);
		}

		public void Psubusb(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubusb, o0, o1);
		}

		public void Psubusb(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubusb, o0, o1);
		}

		public void Psubusw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubusw, o0, o1);
		}

		public void Psubusw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubusw, o0, o1);
		}

		public void Psubw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubw, o0, o1);
		}

		public void Psubw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubw, o0, o1);
		}

		public void Punpckhbw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Punpckhbw, o0, o1);
		}

		public void Punpckhbw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Punpckhbw, o0, o1);
		}

		public void Punpckhdq(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Punpckhdq, o0, o1);
		}

		public void Punpckhdq(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Punpckhdq, o0, o1);
		}

		public void Punpckhwd(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Punpckhwd, o0, o1);
		}

		public void Punpckhwd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Punpckhwd, o0, o1);
		}

		public void Punpcklbw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Punpcklbw, o0, o1);
		}

		public void Punpcklbw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Punpcklbw, o0, o1);
		}

		public void Punpckldq(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Punpckldq, o0, o1);
		}

		public void Punpckldq(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Punpckldq, o0, o1);
		}

		public void Punpcklwd(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Punpcklwd, o0, o1);
		}

		public void Punpcklwd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Punpcklwd, o0, o1);
		}

		public void Pxor(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pxor, o0, o1);
		}

		public void Pxor(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pxor, o0, o1);
		}

		public void Emms()
		{
			Assembler.Emit(InstructionId.Emms);
		}

		public void Pf2id(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pf2id, o0, o1);
		}

		public void Pf2id(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pf2id, o0, o1);
		}

		public void Pf2iw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pf2iw, o0, o1);
		}

		public void Pf2iw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pf2iw, o0, o1);
		}

		public void Pfacc(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfacc, o0, o1);
		}

		public void Pfacc(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfacc, o0, o1);
		}

		public void Pfadd(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfadd, o0, o1);
		}

		public void Pfadd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfadd, o0, o1);
		}

		public void Pfcmpeq(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfcmpeq, o0, o1);
		}

		public void Pfcmpeq(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfcmpeq, o0, o1);
		}

		public void Pfcmpge(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfcmpge, o0, o1);
		}

		public void Pfcmpge(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfcmpge, o0, o1);
		}

		public void Pfcmpgt(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfcmpgt, o0, o1);
		}

		public void Pfcmpgt(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfcmpgt, o0, o1);
		}

		public void Pfmax(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfmax, o0, o1);
		}

		public void Pfmax(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfmax, o0, o1);
		}

		public void Pfmin(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfmin, o0, o1);
		}

		public void Pfmin(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfmin, o0, o1);
		}

		public void Pfmul(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfmul, o0, o1);
		}

		public void Pfmul(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfmul, o0, o1);
		}

		public void Pfnacc(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfnacc, o0, o1);
		}

		public void Pfnacc(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfnacc, o0, o1);
		}

		public void Pfpnacc(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfpnacc, o0, o1);
		}

		public void Pfpnacc(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfpnacc, o0, o1);
		}

		public void Pfrcp(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfrcp, o0, o1);
		}

		public void Pfrcp(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfrcp, o0, o1);
		}

		public void Pfrcpit1(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfrcpit1, o0, o1);
		}

		public void Pfrcpit1(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfrcpit1, o0, o1);
		}

		public void Pfrcpit2(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfrcpit2, o0, o1);
		}

		public void Pfrcpit2(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfrcpit2, o0, o1);
		}

		public void Pfrsqit1(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfrsqit1, o0, o1);
		}

		public void Pfrsqit1(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfrsqit1, o0, o1);
		}

		public void Pfrsqrt(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfrsqrt, o0, o1);
		}

		public void Pfrsqrt(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfrsqrt, o0, o1);
		}

		public void Pfsub(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfsub, o0, o1);
		}

		public void Pfsub(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfsub, o0, o1);
		}

		public void Pfsubr(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pfsubr, o0, o1);
		}

		public void Pfsubr(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pfsubr, o0, o1);
		}

		public void Pi2fd(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pi2fd, o0, o1);
		}

		public void Pi2fd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pi2fd, o0, o1);
		}

		public void Pi2fw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pi2fw, o0, o1);
		}

		public void Pi2fw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pi2fw, o0, o1);
		}

		public void Pswapd(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pswapd, o0, o1);
		}

		public void Pswapd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pswapd, o0, o1);
		}

		public void Prefetch3dnow(Memory o0)
		{
			Assembler.Emit(InstructionId.Prefetch3dNow, o0);
		}

		public void Prefetchw3dnow(Memory o0)
		{
			Assembler.Emit(InstructionId.Prefetchw3dNow, o0);
		}

		public void Femms()
		{
			Assembler.Emit(InstructionId.Femms);
		}

		public void Addps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Addps, o0, o1);
		}

		public void Addps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Addps, o0, o1);
		}

		public void Addss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Addss, o0, o1);
		}

		public void Addss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Addss, o0, o1);
		}

		public void Andnps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Andnps, o0, o1);
		}

		public void Andnps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Andnps, o0, o1);
		}

		public void Andps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Andps, o0, o1);
		}

		public void Andps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Andps, o0, o1);
		}

		public void Cmpps(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Cmpps, o0, o1, o2);
		}

		public void Cmpps(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Cmpps, o0, o1, (Immediate)o2);
		}

		public void Cmpps(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Cmpps, o0, o1, (Immediate)o2);
		}

		public void Cmpps(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Cmpps, o0, o1, o2);
		}

		public void Cmpps(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Cmpps, o0, o1, (Immediate)o2);
		}

		public void Cmpps(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Cmpps, o0, o1, (Immediate)o2);
		}

		public void Cmpss(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Cmpss, o0, o1, o2);
		}

		public void Cmpss(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Cmpss, o0, o1, (Immediate)o2);
		}

		public void Cmpss(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Cmpss, o0, o1, (Immediate)o2);
		}

		public void Cmpss(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Cmpss, o0, o1, o2);
		}

		public void Cmpss(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Cmpss, o0, o1, (Immediate)o2);
		}

		public void Cmpss(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Cmpss, o0, o1, (Immediate)o2);
		}

		public void Comiss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Comiss, o0, o1);
		}

		public void Comiss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Comiss, o0, o1);
		}

		public void Cvtpi2ps(XmmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtpi2ps, o0, o1);
		}

		public void Cvtpi2ps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtpi2ps, o0, o1);
		}

		public void Cvtps2pi(MmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtps2pi, o0, o1);
		}

		public void Cvtps2pi(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtps2pi, o0, o1);
		}

		public void Cvtsi2ss(XmmRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtsi2ss, o0, o1);
		}

		public void Cvtsi2ss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtsi2ss, o0, o1);
		}

		public void Cvtss2si(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtss2si, o0, o1);
		}

		public void Cvtss2si(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtss2si, o0, o1);
		}

		public void Cvttps2pi(MmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvttps2pi, o0, o1);
		}

		public void Cvttps2pi(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvttps2pi, o0, o1);
		}

		public void Cvttss2si(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvttss2si, o0, o1);
		}

		public void Cvttss2si(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvttss2si, o0, o1);
		}

		public void Divps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Divps, o0, o1);
		}

		public void Divps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Divps, o0, o1);
		}

		public void Divss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Divss, o0, o1);
		}

		public void Divss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Divss, o0, o1);
		}

		public void Ldmxcsr(Memory o0)
		{
			Assembler.Emit(InstructionId.Ldmxcsr, o0);
		}

		public void Maskmovq(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Maskmovq, o0, o1);
		}

		public void Maxps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Maxps, o0, o1);
		}

		public void Maxps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Maxps, o0, o1);
		}

		public void Maxss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Maxss, o0, o1);
		}

		public void Maxss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Maxss, o0, o1);
		}

		public void Minps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Minps, o0, o1);
		}

		public void Minps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Minps, o0, o1);
		}

		public void Minss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Minss, o0, o1);
		}

		public void Minss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Minss, o0, o1);
		}

		public void Movaps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movaps, o0, o1);
		}

		public void Movaps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movaps, o0, o1);
		}

		public void Movaps(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movaps, o0, o1);
		}

		public void Movd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movd(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movd(XmmRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Movd, o0, o1);
		}

		public void Movq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movq(XmmRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Movq, o0, o1);
		}

		public void Movntq(Memory o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Movntq, o0, o1);
		}

		public void Movhlps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movhlps, o0, o1);
		}

		public void Movhps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movhps, o0, o1);
		}

		public void Movhps(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movhps, o0, o1);
		}

		public void Movlhps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movlhps, o0, o1);
		}

		public void Movlps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movlps, o0, o1);
		}

		public void Movlps(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movlps, o0, o1);
		}

		public void Movntps(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movntps, o0, o1);
		}

		public void Movss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movss, o0, o1);
		}

		public void Movss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movss, o0, o1);
		}

		public void Movss(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movss, o0, o1);
		}

		public void Movups(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movups, o0, o1);
		}

		public void Movups(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movups, o0, o1);
		}

		public void Movups(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movups, o0, o1);
		}

		public void Mulps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Mulps, o0, o1);
		}

		public void Mulps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Mulps, o0, o1);
		}

		public void Mulss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Mulss, o0, o1);
		}

		public void Mulss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Mulss, o0, o1);
		}

		public void Orps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Orps, o0, o1);
		}

		public void Orps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Orps, o0, o1);
		}

		public void Pavgb(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pavgb, o0, o1);
		}

		public void Pavgb(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pavgb, o0, o1);
		}

		public void Pavgw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pavgw, o0, o1);
		}

		public void Pavgw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pavgw, o0, o1);
		}

		public void Pextrw(GpRegister o0, MmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(GpRegister o0, MmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pextrw, o0, o1, (Immediate)o2);
		}

		public void Pextrw(GpRegister o0, MmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pextrw, o0, o1, (Immediate)o2);
		}

		public void Pinsrw(MmRegister o0, GpRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(MmRegister o0, GpRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pinsrw, o0, o1, (Immediate)o2);
		}

		public void Pinsrw(MmRegister o0, GpRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pinsrw, o0, o1, (Immediate)o2);
		}

		public void Pinsrw(MmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(MmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pinsrw, o0, o1, (Immediate)o2);
		}

		public void Pinsrw(MmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pinsrw, o0, o1, (Immediate)o2);
		}

		public void Pmaxsw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmaxsw, o0, o1);
		}

		public void Pmaxsw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmaxsw, o0, o1);
		}

		public void Pmaxub(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmaxub, o0, o1);
		}

		public void Pmaxub(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmaxub, o0, o1);
		}

		public void Pminsw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pminsw, o0, o1);
		}

		public void Pminsw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pminsw, o0, o1);
		}

		public void Pminub(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pminub, o0, o1);
		}

		public void Pminub(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pminub, o0, o1);
		}

		public void Pmovmskb(GpRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmovmskb, o0, o1);
		}

		public void Pmulhuw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmulhuw, o0, o1);
		}

		public void Pmulhuw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmulhuw, o0, o1);
		}

		public void Psadbw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psadbw, o0, o1);
		}

		public void Psadbw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psadbw, o0, o1);
		}

		public void Pshufw(MmRegister o0, MmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pshufw, o0, o1, o2);
		}

		public void Pshufw(MmRegister o0, MmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pshufw, o0, o1, (Immediate)o2);
		}

		public void Pshufw(MmRegister o0, MmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pshufw, o0, o1, (Immediate)o2);
		}

		public void Pshufw(MmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pshufw, o0, o1, o2);
		}

		public void Pshufw(MmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pshufw, o0, o1, (Immediate)o2);
		}

		public void Pshufw(MmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pshufw, o0, o1, (Immediate)o2);
		}

		public void Rcpps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Rcpps, o0, o1);
		}

		public void Rcpps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Rcpps, o0, o1);
		}

		public void Rcpss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Rcpss, o0, o1);
		}

		public void Rcpss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Rcpss, o0, o1);
		}

		public void Prefetch(Memory o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Prefetch, o0, o1);
		}

		public void Prefetch(Memory o0, long o1)
		{
			Assembler.Emit(InstructionId.Prefetch, o0, (Immediate)o1);
		}

		public void Prefetch(Memory o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Prefetch, o0, (Immediate)o1);
		}

		public void Psadbw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psadbw, o0, o1);
		}

		public void Psadbw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psadbw, o0, o1);
		}

		public void Rsqrtps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Rsqrtps, o0, o1);
		}

		public void Rsqrtps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Rsqrtps, o0, o1);
		}

		public void Rsqrtss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Rsqrtss, o0, o1);
		}

		public void Rsqrtss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Rsqrtss, o0, o1);
		}

		public void Sfence()
		{
			Assembler.Emit(InstructionId.Sfence);
		}

		public void Shufps(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Shufps, o0, o1, o2);
		}

		public void Shufps(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Shufps, o0, o1, (Immediate)o2);
		}

		public void Shufps(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Shufps, o0, o1, (Immediate)o2);
		}

		public void Shufps(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Shufps, o0, o1, o2);
		}

		public void Shufps(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Shufps, o0, o1, (Immediate)o2);
		}

		public void Shufps(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Shufps, o0, o1, (Immediate)o2);
		}

		public void Sqrtps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Sqrtps, o0, o1);
		}

		public void Sqrtps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Sqrtps, o0, o1);
		}

		public void Sqrtss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Sqrtss, o0, o1);
		}

		public void Sqrtss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Sqrtss, o0, o1);
		}

		public void Stmxcsr(Memory o0)
		{
			Assembler.Emit(InstructionId.Stmxcsr, o0);
		}

		public void Subps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Subps, o0, o1);
		}

		public void Subps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Subps, o0, o1);
		}

		public void Subss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Subss, o0, o1);
		}

		public void Subss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Subss, o0, o1);
		}

		public void Ucomiss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Ucomiss, o0, o1);
		}

		public void Ucomiss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Ucomiss, o0, o1);
		}

		public void Unpckhps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Unpckhps, o0, o1);
		}

		public void Unpckhps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Unpckhps, o0, o1);
		}

		public void Unpcklps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Unpcklps, o0, o1);
		}

		public void Unpcklps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Unpcklps, o0, o1);
		}

		public void Xorps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Xorps, o0, o1);
		}

		public void Xorps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Xorps, o0, o1);
		}

		public void Addpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Addpd, o0, o1);
		}

		public void Addpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Addpd, o0, o1);
		}

		public void Addsd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Addsd, o0, o1);
		}

		public void Addsd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Addsd, o0, o1);
		}

		public void Andnpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Andnpd, o0, o1);
		}

		public void Andnpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Andnpd, o0, o1);
		}

		public void Andpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Andpd, o0, o1);
		}

		public void Andpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Andpd, o0, o1);
		}

		public void Clflush(Memory o0)
		{
			Assembler.Emit(InstructionId.Clflush, o0);
		}

		public void Cmppd(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Cmppd, o0, o1, o2);
		}

		public void Cmppd(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Cmppd, o0, o1, (Immediate)o2);
		}

		public void Cmppd(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Cmppd, o0, o1, (Immediate)o2);
		}

		public void Cmppd(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Cmppd, o0, o1, o2);
		}

		public void Cmppd(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Cmppd, o0, o1, (Immediate)o2);
		}

		public void Cmppd(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Cmppd, o0, o1, (Immediate)o2);
		}

		public void Cmpsd(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Cmpsd, o0, o1, o2);
		}

		public void Cmpsd(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Cmpsd, o0, o1, (Immediate)o2);
		}

		public void Cmpsd(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Cmpsd, o0, o1, (Immediate)o2);
		}

		public void Cmpsd(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Cmpsd, o0, o1, o2);
		}

		public void Cmpsd(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Cmpsd, o0, o1, (Immediate)o2);
		}

		public void Cmpsd(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Cmpsd, o0, o1, (Immediate)o2);
		}

		public void Comisd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Comisd, o0, o1);
		}

		public void Comisd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Comisd, o0, o1);
		}

		public void Cvtdq2pd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtdq2pd, o0, o1);
		}

		public void Cvtdq2pd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtdq2pd, o0, o1);
		}

		public void Cvtdq2ps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtdq2ps, o0, o1);
		}

		public void Cvtdq2ps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtdq2ps, o0, o1);
		}

		public void Cvtpd2dq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtpd2dq, o0, o1);
		}

		public void Cvtpd2dq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtpd2dq, o0, o1);
		}

		public void Cvtpd2pi(MmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtpd2pi, o0, o1);
		}

		public void Cvtpd2pi(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtpd2pi, o0, o1);
		}

		public void Cvtpd2ps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtpd2ps, o0, o1);
		}

		public void Cvtpd2ps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtpd2ps, o0, o1);
		}

		public void Cvtpi2pd(XmmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtpi2pd, o0, o1);
		}

		public void Cvtpi2pd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtpi2pd, o0, o1);
		}

		public void Cvtps2dq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtps2dq, o0, o1);
		}

		public void Cvtps2dq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtps2dq, o0, o1);
		}

		public void Cvtps2pd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtps2pd, o0, o1);
		}

		public void Cvtps2pd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtps2pd, o0, o1);
		}

		public void Cvtsd2si(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtsd2si, o0, o1);
		}

		public void Cvtsd2si(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtsd2si, o0, o1);
		}

		public void Cvtsd2ss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtsd2ss, o0, o1);
		}

		public void Cvtsd2ss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtsd2ss, o0, o1);
		}

		public void Cvtsi2sd(XmmRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtsi2sd, o0, o1);
		}

		public void Cvtsi2sd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtsi2sd, o0, o1);
		}

		public void Cvtss2sd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvtss2sd, o0, o1);
		}

		public void Cvtss2sd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvtss2sd, o0, o1);
		}

		public void Cvttpd2pi(MmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvttpd2pi, o0, o1);
		}

		public void Cvttpd2pi(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvttpd2pi, o0, o1);
		}

		public void Cvttpd2dq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvttpd2dq, o0, o1);
		}

		public void Cvttpd2dq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvttpd2dq, o0, o1);
		}

		public void Cvttps2dq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvttps2dq, o0, o1);
		}

		public void Cvttps2dq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvttps2dq, o0, o1);
		}

		public void Cvttsd2si(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Cvttsd2si, o0, o1);
		}

		public void Cvttsd2si(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Cvttsd2si, o0, o1);
		}

		public void Divpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Divpd, o0, o1);
		}

		public void Divpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Divpd, o0, o1);
		}

		public void Divsd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Divsd, o0, o1);
		}

		public void Divsd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Divsd, o0, o1);
		}

		public void Lfence()
		{
			Assembler.Emit(InstructionId.Lfence);
		}

		public void Maskmovdqu(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Maskmovdqu, o0, o1);
		}

		public void Maxpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Maxpd, o0, o1);
		}

		public void Maxpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Maxpd, o0, o1);
		}

		public void Maxsd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Maxsd, o0, o1);
		}

		public void Maxsd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Maxsd, o0, o1);
		}

		public void Mfence()
		{
			Assembler.Emit(InstructionId.Mfence);
		}

		public void Minpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Minpd, o0, o1);
		}

		public void Minpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Minpd, o0, o1);
		}

		public void Minsd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Minsd, o0, o1);
		}

		public void Minsd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Minsd, o0, o1);
		}

		public void Movdqa(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movdqa, o0, o1);
		}

		public void Movdqa(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movdqa, o0, o1);
		}

		public void Movdqa(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movdqa, o0, o1);
		}

		public void Movdqu(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movdqu, o0, o1);
		}

		public void Movdqu(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movdqu, o0, o1);
		}

		public void Movdqu(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movdqu, o0, o1);
		}

		public void Movmskps(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movmskps, o0, o1);
		}

		public void Movmskpd(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movmskpd, o0, o1);
		}

		public void Movsd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movsd, o0, o1);
		}

		public void Movsd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movsd, o0, o1);
		}

		public void Movsd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movsd, o0, o1);
		}

		public void Movapd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movapd, o0, o1);
		}

		public void Movapd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movapd, o0, o1);
		}

		public void Movapd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movapd, o0, o1);
		}

		public void Movdq2q(MmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movdq2q, o0, o1);
		}

		public void Movq2dq(XmmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Movq2dq, o0, o1);
		}

		public void Movhpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movhpd, o0, o1);
		}

		public void Movhpd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movhpd, o0, o1);
		}

		public void Movlpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movlpd, o0, o1);
		}

		public void Movlpd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movlpd, o0, o1);
		}

		public void Movntdq(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movntdq, o0, o1);
		}

		public void Movnti(Memory o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Movnti, o0, o1);
		}

		public void Movntpd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movntpd, o0, o1);
		}

		public void Movupd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movupd, o0, o1);
		}

		public void Movupd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movupd, o0, o1);
		}

		public void Movupd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movupd, o0, o1);
		}

		public void Mulpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Mulpd, o0, o1);
		}

		public void Mulpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Mulpd, o0, o1);
		}

		public void Mulsd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Mulsd, o0, o1);
		}

		public void Mulsd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Mulsd, o0, o1);
		}

		public void Orpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Orpd, o0, o1);
		}

		public void Orpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Orpd, o0, o1);
		}

		public void Packsswb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Packsswb, o0, o1);
		}

		public void Packsswb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Packsswb, o0, o1);
		}

		public void Packssdw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Packssdw, o0, o1);
		}

		public void Packssdw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Packssdw, o0, o1);
		}

		public void Packuswb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Packuswb, o0, o1);
		}

		public void Packuswb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Packuswb, o0, o1);
		}

		public void Paddb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddb, o0, o1);
		}

		public void Paddb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddb, o0, o1);
		}

		public void Paddw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddw, o0, o1);
		}

		public void Paddw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddw, o0, o1);
		}

		public void Paddd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddd, o0, o1);
		}

		public void Paddd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddd, o0, o1);
		}

		public void Paddq(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddq, o0, o1);
		}

		public void Paddq(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddq, o0, o1);
		}

		public void Paddq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddq, o0, o1);
		}

		public void Paddq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddq, o0, o1);
		}

		public void Paddsb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddsb, o0, o1);
		}

		public void Paddsb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddsb, o0, o1);
		}

		public void Paddsw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddsw, o0, o1);
		}

		public void Paddsw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddsw, o0, o1);
		}

		public void Paddusb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddusb, o0, o1);
		}

		public void Paddusb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddusb, o0, o1);
		}

		public void Paddusw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Paddusw, o0, o1);
		}

		public void Paddusw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Paddusw, o0, o1);
		}

		public void Pand(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pand, o0, o1);
		}

		public void Pand(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pand, o0, o1);
		}

		public void Pandn(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pandn, o0, o1);
		}

		public void Pandn(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pandn, o0, o1);
		}

		public void Pause()
		{
			Assembler.Emit(InstructionId.Pause);
		}

		public void Pavgb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pavgb, o0, o1);
		}

		public void Pavgb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pavgb, o0, o1);
		}

		public void Pavgw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pavgw, o0, o1);
		}

		public void Pavgw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pavgw, o0, o1);
		}

		public void Pcmpeqb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pcmpeqb, o0, o1);
		}

		public void Pcmpeqb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pcmpeqb, o0, o1);
		}

		public void Pcmpeqw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pcmpeqw, o0, o1);
		}

		public void Pcmpeqw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pcmpeqw, o0, o1);
		}

		public void Pcmpeqd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pcmpeqd, o0, o1);
		}

		public void Pcmpeqd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pcmpeqd, o0, o1);
		}

		public void Pcmpgtb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pcmpgtb, o0, o1);
		}

		public void Pcmpgtb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pcmpgtb, o0, o1);
		}

		public void Pcmpgtw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pcmpgtw, o0, o1);
		}

		public void Pcmpgtw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pcmpgtw, o0, o1);
		}

		public void Pcmpgtd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pcmpgtd, o0, o1);
		}

		public void Pcmpgtd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pcmpgtd, o0, o1);
		}

		public void Pextrw(GpRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(GpRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pextrw, o0, o1, (Immediate)o2);
		}

		public void Pextrw(GpRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pextrw, o0, o1, (Immediate)o2);
		}

		public void Pinsrw(XmmRegister o0, GpRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(XmmRegister o0, GpRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pinsrw, o0, o1, (Immediate)o2);
		}

		public void Pinsrw(XmmRegister o0, GpRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pinsrw, o0, o1, (Immediate)o2);
		}

		public void Pinsrw(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pinsrw, o0, o1, o2);
		}

		public void Pinsrw(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pinsrw, o0, o1, (Immediate)o2);
		}

		public void Pinsrw(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pinsrw, o0, o1, (Immediate)o2);
		}

		public void Pmaxsw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmaxsw, o0, o1);
		}

		public void Pmaxsw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmaxsw, o0, o1);
		}

		public void Pmaxub(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmaxub, o0, o1);
		}

		public void Pmaxub(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmaxub, o0, o1);
		}

		public void Pminsw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pminsw, o0, o1);
		}

		public void Pminsw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pminsw, o0, o1);
		}

		public void Pminub(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pminub, o0, o1);
		}

		public void Pminub(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pminub, o0, o1);
		}

		public void Pmovmskb(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmovmskb, o0, o1);
		}

		public void Pmulhw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmulhw, o0, o1);
		}

		public void Pmulhw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmulhw, o0, o1);
		}

		public void Pmulhuw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmulhuw, o0, o1);
		}

		public void Pmulhuw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmulhuw, o0, o1);
		}

		public void Pmullw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmullw, o0, o1);
		}

		public void Pmullw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmullw, o0, o1);
		}

		public void Pmuludq(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmuludq, o0, o1);
		}

		public void Pmuludq(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmuludq, o0, o1);
		}

		public void Pmuludq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmuludq, o0, o1);
		}

		public void Pmuludq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmuludq, o0, o1);
		}

		public void Por(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Por, o0, o1);
		}

		public void Por(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Por, o0, o1);
		}

		public void Pslld(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(XmmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Pslld, o0, o1);
		}

		public void Pslld(XmmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Pslld, o0, (Immediate)o1);
		}

		public void Pslld(XmmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Pslld, o0, (Immediate)o1);
		}

		public void Psllq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(XmmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psllq, o0, o1);
		}

		public void Psllq(XmmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psllq, o0, (Immediate)o1);
		}

		public void Psllq(XmmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psllq, o0, (Immediate)o1);
		}

		public void Psllw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(XmmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psllw, o0, o1);
		}

		public void Psllw(XmmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psllw, o0, (Immediate)o1);
		}

		public void Psllw(XmmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psllw, o0, (Immediate)o1);
		}

		public void Pslldq(XmmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Pslldq, o0, o1);
		}

		public void Pslldq(XmmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Pslldq, o0, (Immediate)o1);
		}

		public void Pslldq(XmmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Pslldq, o0, (Immediate)o1);
		}

		public void Psrad(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(XmmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psrad, o0, o1);
		}

		public void Psrad(XmmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psrad, o0, (Immediate)o1);
		}

		public void Psrad(XmmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psrad, o0, (Immediate)o1);
		}

		public void Psraw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(XmmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psraw, o0, o1);
		}

		public void Psraw(XmmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psraw, o0, (Immediate)o1);
		}

		public void Psraw(XmmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psraw, o0, (Immediate)o1);
		}

		public void Psubb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubb, o0, o1);
		}

		public void Psubb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubb, o0, o1);
		}

		public void Psubd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubd, o0, o1);
		}

		public void Psubd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubd, o0, o1);
		}

		public void Psubq(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubq, o0, o1);
		}

		public void Psubq(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubq, o0, o1);
		}

		public void Psubq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubq, o0, o1);
		}

		public void Psubq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubq, o0, o1);
		}

		public void Psubw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubw, o0, o1);
		}

		public void Psubw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubw, o0, o1);
		}

		public void Pmaddwd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmaddwd, o0, o1);
		}

		public void Pmaddwd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmaddwd, o0, o1);
		}

		public void Pshufd(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pshufd, o0, o1, o2);
		}

		public void Pshufd(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pshufd, o0, o1, (Immediate)o2);
		}

		public void Pshufd(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pshufd, o0, o1, (Immediate)o2);
		}

		public void Pshufd(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pshufd, o0, o1, o2);
		}

		public void Pshufd(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pshufd, o0, o1, (Immediate)o2);
		}

		public void Pshufd(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pshufd, o0, o1, (Immediate)o2);
		}

		public void Pshufhw(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pshufhw, o0, o1, o2);
		}

		public void Pshufhw(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pshufhw, o0, o1, (Immediate)o2);
		}

		public void Pshufhw(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pshufhw, o0, o1, (Immediate)o2);
		}

		public void Pshufhw(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pshufhw, o0, o1, o2);
		}

		public void Pshufhw(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pshufhw, o0, o1, (Immediate)o2);
		}

		public void Pshufhw(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pshufhw, o0, o1, (Immediate)o2);
		}

		public void Pshuflw(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pshuflw, o0, o1, o2);
		}

		public void Pshuflw(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pshuflw, o0, o1, (Immediate)o2);
		}

		public void Pshuflw(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pshuflw, o0, o1, (Immediate)o2);
		}

		public void Pshuflw(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pshuflw, o0, o1, o2);
		}

		public void Pshuflw(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pshuflw, o0, o1, (Immediate)o2);
		}

		public void Pshuflw(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pshuflw, o0, o1, (Immediate)o2);
		}

		public void Psrld(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(XmmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psrld, o0, o1);
		}

		public void Psrld(XmmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psrld, o0, (Immediate)o1);
		}

		public void Psrld(XmmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psrld, o0, (Immediate)o1);
		}

		public void Psrlq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(XmmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psrlq, o0, o1);
		}

		public void Psrlq(XmmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psrlq, o0, (Immediate)o1);
		}

		public void Psrlq(XmmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psrlq, o0, (Immediate)o1);
		}

		public void Psrldq(XmmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psrldq, o0, o1);
		}

		public void Psrldq(XmmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psrldq, o0, (Immediate)o1);
		}

		public void Psrldq(XmmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psrldq, o0, (Immediate)o1);
		}

		public void Psrlw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(XmmRegister o0, Immediate o1)
		{
			Assembler.Emit(InstructionId.Psrlw, o0, o1);
		}

		public void Psrlw(XmmRegister o0, long o1)
		{
			Assembler.Emit(InstructionId.Psrlw, o0, (Immediate)o1);
		}

		public void Psrlw(XmmRegister o0, ulong o1)
		{
			Assembler.Emit(InstructionId.Psrlw, o0, (Immediate)o1);
		}

		public void Psubsb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubsb, o0, o1);
		}

		public void Psubsb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubsb, o0, o1);
		}

		public void Psubsw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubsw, o0, o1);
		}

		public void Psubsw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubsw, o0, o1);
		}

		public void Psubusb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubusb, o0, o1);
		}

		public void Psubusb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubusb, o0, o1);
		}

		public void Psubusw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psubusw, o0, o1);
		}

		public void Psubusw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psubusw, o0, o1);
		}

		public void Punpckhbw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Punpckhbw, o0, o1);
		}

		public void Punpckhbw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Punpckhbw, o0, o1);
		}

		public void Punpckhdq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Punpckhdq, o0, o1);
		}

		public void Punpckhdq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Punpckhdq, o0, o1);
		}

		public void Punpckhqdq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Punpckhqdq, o0, o1);
		}

		public void Punpckhqdq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Punpckhqdq, o0, o1);
		}

		public void Punpckhwd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Punpckhwd, o0, o1);
		}

		public void Punpckhwd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Punpckhwd, o0, o1);
		}

		public void Punpcklbw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Punpcklbw, o0, o1);
		}

		public void Punpcklbw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Punpcklbw, o0, o1);
		}

		public void Punpckldq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Punpckldq, o0, o1);
		}

		public void Punpckldq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Punpckldq, o0, o1);
		}

		public void Punpcklqdq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Punpcklqdq, o0, o1);
		}

		public void Punpcklqdq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Punpcklqdq, o0, o1);
		}

		public void Punpcklwd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Punpcklwd, o0, o1);
		}

		public void Punpcklwd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Punpcklwd, o0, o1);
		}

		public void Pxor(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pxor, o0, o1);
		}

		public void Pxor(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pxor, o0, o1);
		}

		public void Shufpd(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Shufpd, o0, o1, o2);
		}

		public void Shufpd(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Shufpd, o0, o1, (Immediate)o2);
		}

		public void Shufpd(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Shufpd, o0, o1, (Immediate)o2);
		}

		public void Shufpd(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Shufpd, o0, o1, o2);
		}

		public void Shufpd(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Shufpd, o0, o1, (Immediate)o2);
		}

		public void Shufpd(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Shufpd, o0, o1, (Immediate)o2);
		}

		public void Sqrtpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Sqrtpd, o0, o1);
		}

		public void Sqrtpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Sqrtpd, o0, o1);
		}

		public void Sqrtsd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Sqrtsd, o0, o1);
		}

		public void Sqrtsd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Sqrtsd, o0, o1);
		}

		public void Subpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Subpd, o0, o1);
		}

		public void Subpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Subpd, o0, o1);
		}

		public void Subsd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Subsd, o0, o1);
		}

		public void Subsd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Subsd, o0, o1);
		}

		public void Ucomisd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Ucomisd, o0, o1);
		}

		public void Ucomisd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Ucomisd, o0, o1);
		}

		public void Unpckhpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Unpckhpd, o0, o1);
		}

		public void Unpckhpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Unpckhpd, o0, o1);
		}

		public void Unpcklpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Unpcklpd, o0, o1);
		}

		public void Unpcklpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Unpcklpd, o0, o1);
		}

		public void Xorpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Xorpd, o0, o1);
		}

		public void Xorpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Xorpd, o0, o1);
		}

		public void Addsubpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Addsubpd, o0, o1);
		}

		public void Addsubpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Addsubpd, o0, o1);
		}

		public void Addsubps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Addsubps, o0, o1);
		}

		public void Addsubps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Addsubps, o0, o1);
		}

		public void Fisttp(Memory o0)
		{
			Assembler.Emit(InstructionId.Fisttp, o0);
		}

		public void Haddpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Haddpd, o0, o1);
		}

		public void Haddpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Haddpd, o0, o1);
		}

		public void Haddps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Haddps, o0, o1);
		}

		public void Haddps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Haddps, o0, o1);
		}

		public void Hsubpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Hsubpd, o0, o1);
		}

		public void Hsubpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Hsubpd, o0, o1);
		}

		public void Hsubps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Hsubps, o0, o1);
		}

		public void Hsubps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Hsubps, o0, o1);
		}

		public void Lddqu(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Lddqu, o0, o1);
		}

		public void Monitor()
		{
			Assembler.Emit(InstructionId.Monitor);
		}

		public void Movddup(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movddup, o0, o1);
		}

		public void Movddup(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movddup, o0, o1);
		}

		public void Movshdup(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movshdup, o0, o1);
		}

		public void Movshdup(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movshdup, o0, o1);
		}

		public void Movsldup(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movsldup, o0, o1);
		}

		public void Movsldup(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movsldup, o0, o1);
		}

		public void Mwait()
		{
			Assembler.Emit(InstructionId.Mwait);
		}

		public void Psignb(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psignb, o0, o1);
		}

		public void Psignb(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psignb, o0, o1);
		}

		public void Psignb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psignb, o0, o1);
		}

		public void Psignb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psignb, o0, o1);
		}

		public void Psignd(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psignd, o0, o1);
		}

		public void Psignd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psignd, o0, o1);
		}

		public void Psignd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psignd, o0, o1);
		}

		public void Psignd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psignd, o0, o1);
		}

		public void Psignw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Psignw, o0, o1);
		}

		public void Psignw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psignw, o0, o1);
		}

		public void Psignw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Psignw, o0, o1);
		}

		public void Psignw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Psignw, o0, o1);
		}

		public void Phaddd(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Phaddd, o0, o1);
		}

		public void Phaddd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Phaddd, o0, o1);
		}

		public void Phaddd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Phaddd, o0, o1);
		}

		public void Phaddd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Phaddd, o0, o1);
		}

		public void Phaddsw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Phaddsw, o0, o1);
		}

		public void Phaddsw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Phaddsw, o0, o1);
		}

		public void Phaddsw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Phaddsw, o0, o1);
		}

		public void Phaddsw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Phaddsw, o0, o1);
		}

		public void Phaddw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Phaddw, o0, o1);
		}

		public void Phaddw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Phaddw, o0, o1);
		}

		public void Phaddw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Phaddw, o0, o1);
		}

		public void Phaddw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Phaddw, o0, o1);
		}

		public void Phsubd(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Phsubd, o0, o1);
		}

		public void Phsubd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Phsubd, o0, o1);
		}

		public void Phsubd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Phsubd, o0, o1);
		}

		public void Phsubd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Phsubd, o0, o1);
		}

		public void Phsubsw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Phsubsw, o0, o1);
		}

		public void Phsubsw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Phsubsw, o0, o1);
		}

		public void Phsubsw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Phsubsw, o0, o1);
		}

		public void Phsubsw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Phsubsw, o0, o1);
		}

		public void Phsubw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Phsubw, o0, o1);
		}

		public void Phsubw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Phsubw, o0, o1);
		}

		public void Phsubw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Phsubw, o0, o1);
		}

		public void Phsubw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Phsubw, o0, o1);
		}

		public void Pmaddubsw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmaddubsw, o0, o1);
		}

		public void Pmaddubsw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmaddubsw, o0, o1);
		}

		public void Pmaddubsw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmaddubsw, o0, o1);
		}

		public void Pmaddubsw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmaddubsw, o0, o1);
		}

		public void Pabsb(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pabsb, o0, o1);
		}

		public void Pabsb(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pabsb, o0, o1);
		}

		public void Pabsb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pabsb, o0, o1);
		}

		public void Pabsb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pabsb, o0, o1);
		}

		public void Pabsd(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pabsd, o0, o1);
		}

		public void Pabsd(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pabsd, o0, o1);
		}

		public void Pabsd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pabsd, o0, o1);
		}

		public void Pabsd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pabsd, o0, o1);
		}

		public void Pabsw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pabsw, o0, o1);
		}

		public void Pabsw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pabsw, o0, o1);
		}

		public void Pabsw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pabsw, o0, o1);
		}

		public void Pabsw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pabsw, o0, o1);
		}

		public void Pmulhrsw(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmulhrsw, o0, o1);
		}

		public void Pmulhrsw(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmulhrsw, o0, o1);
		}

		public void Pmulhrsw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmulhrsw, o0, o1);
		}

		public void Pmulhrsw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmulhrsw, o0, o1);
		}

		public void Pshufb(MmRegister o0, MmRegister o1)
		{
			Assembler.Emit(InstructionId.Pshufb, o0, o1);
		}

		public void Pshufb(MmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pshufb, o0, o1);
		}

		public void Pshufb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pshufb, o0, o1);
		}

		public void Pshufb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pshufb, o0, o1);
		}

		public void Palignr(MmRegister o0, MmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(MmRegister o0, MmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Palignr, o0, o1, (Immediate)o2);
		}

		public void Palignr(MmRegister o0, MmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Palignr, o0, o1, (Immediate)o2);
		}

		public void Palignr(MmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(MmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Palignr, o0, o1, (Immediate)o2);
		}

		public void Palignr(MmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Palignr, o0, o1, (Immediate)o2);
		}

		public void Palignr(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Palignr, o0, o1, (Immediate)o2);
		}

		public void Palignr(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Palignr, o0, o1, (Immediate)o2);
		}

		public void Palignr(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Palignr, o0, o1, o2);
		}

		public void Palignr(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Palignr, o0, o1, (Immediate)o2);
		}

		public void Palignr(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Palignr, o0, o1, (Immediate)o2);
		}

		public void Blendpd(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Blendpd, o0, o1, o2);
		}

		public void Blendpd(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Blendpd, o0, o1, (Immediate)o2);
		}

		public void Blendpd(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Blendpd, o0, o1, (Immediate)o2);
		}

		public void Blendpd(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Blendpd, o0, o1, o2);
		}

		public void Blendpd(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Blendpd, o0, o1, (Immediate)o2);
		}

		public void Blendpd(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Blendpd, o0, o1, (Immediate)o2);
		}

		public void Blendps(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Blendps, o0, o1, o2);
		}

		public void Blendps(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Blendps, o0, o1, (Immediate)o2);
		}

		public void Blendps(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Blendps, o0, o1, (Immediate)o2);
		}

		public void Blendps(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Blendps, o0, o1, o2);
		}

		public void Blendps(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Blendps, o0, o1, (Immediate)o2);
		}

		public void Blendps(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Blendps, o0, o1, (Immediate)o2);
		}

		public void Blendvpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Blendvpd, o0, o1);
		}

		public void Blendvpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Blendvpd, o0, o1);
		}

		public void Blendvps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Blendvps, o0, o1);
		}

		public void Blendvps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Blendvps, o0, o1);
		}

		public void Dppd(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Dppd, o0, o1, o2);
		}

		public void Dppd(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Dppd, o0, o1, (Immediate)o2);
		}

		public void Dppd(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Dppd, o0, o1, (Immediate)o2);
		}

		public void Dppd(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Dppd, o0, o1, o2);
		}

		public void Dppd(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Dppd, o0, o1, (Immediate)o2);
		}

		public void Dppd(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Dppd, o0, o1, (Immediate)o2);
		}

		public void Dpps(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Dpps, o0, o1, o2);
		}

		public void Dpps(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Dpps, o0, o1, (Immediate)o2);
		}

		public void Dpps(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Dpps, o0, o1, (Immediate)o2);
		}

		public void Dpps(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Dpps, o0, o1, o2);
		}

		public void Dpps(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Dpps, o0, o1, (Immediate)o2);
		}

		public void Dpps(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Dpps, o0, o1, (Immediate)o2);
		}

		public void Extractps(GpRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Extractps, o0, o1, o2);
		}

		public void Extractps(GpRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Extractps, o0, o1, (Immediate)o2);
		}

		public void Extractps(GpRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Extractps, o0, o1, (Immediate)o2);
		}

		public void Extractps(Memory o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Extractps, o0, o1, o2);
		}

		public void Extractps(Memory o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Extractps, o0, o1, (Immediate)o2);
		}

		public void Extractps(Memory o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Extractps, o0, o1, (Immediate)o2);
		}

		public void Insertps(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Insertps, o0, o1, o2);
		}

		public void Insertps(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Insertps, o0, o1, (Immediate)o2);
		}

		public void Insertps(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Insertps, o0, o1, (Immediate)o2);
		}

		public void Insertps(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Insertps, o0, o1, o2);
		}

		public void Insertps(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Insertps, o0, o1, (Immediate)o2);
		}

		public void Insertps(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Insertps, o0, o1, (Immediate)o2);
		}

		public void Movntdqa(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Movntdqa, o0, o1);
		}

		public void Mpsadbw(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Mpsadbw, o0, o1, o2);
		}

		public void Mpsadbw(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Mpsadbw, o0, o1, (Immediate)o2);
		}

		public void Mpsadbw(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Mpsadbw, o0, o1, (Immediate)o2);
		}

		public void Mpsadbw(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Mpsadbw, o0, o1, o2);
		}

		public void Mpsadbw(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Mpsadbw, o0, o1, (Immediate)o2);
		}

		public void Mpsadbw(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Mpsadbw, o0, o1, (Immediate)o2);
		}

		public void Packusdw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Packusdw, o0, o1);
		}

		public void Packusdw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Packusdw, o0, o1);
		}

		public void Pblendvb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pblendvb, o0, o1);
		}

		public void Pblendvb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pblendvb, o0, o1);
		}

		public void Pblendw(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pblendw, o0, o1, o2);
		}

		public void Pblendw(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pblendw, o0, o1, (Immediate)o2);
		}

		public void Pblendw(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pblendw, o0, o1, (Immediate)o2);
		}

		public void Pblendw(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pblendw, o0, o1, o2);
		}

		public void Pblendw(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pblendw, o0, o1, (Immediate)o2);
		}

		public void Pblendw(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pblendw, o0, o1, (Immediate)o2);
		}

		public void Pcmpeqq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pcmpeqq, o0, o1);
		}

		public void Pcmpeqq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pcmpeqq, o0, o1);
		}

		public void Pextrb(GpRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pextrb, o0, o1, o2);
		}

		public void Pextrb(GpRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pextrb, o0, o1, (Immediate)o2);
		}

		public void Pextrb(GpRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pextrb, o0, o1, (Immediate)o2);
		}

		public void Pextrb(Memory o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pextrb, o0, o1, o2);
		}

		public void Pextrb(Memory o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pextrb, o0, o1, (Immediate)o2);
		}

		public void Pextrb(Memory o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pextrb, o0, o1, (Immediate)o2);
		}

		public void Pextrd(GpRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pextrd, o0, o1, o2);
		}

		public void Pextrd(GpRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pextrd, o0, o1, (Immediate)o2);
		}

		public void Pextrd(GpRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pextrd, o0, o1, (Immediate)o2);
		}

		public void Pextrd(Memory o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pextrd, o0, o1, o2);
		}

		public void Pextrd(Memory o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pextrd, o0, o1, (Immediate)o2);
		}

		public void Pextrd(Memory o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pextrd, o0, o1, (Immediate)o2);
		}

		public void Pextrq(GpRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pextrq, o0, o1, o2);
		}

		public void Pextrq(GpRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pextrq, o0, o1, (Immediate)o2);
		}

		public void Pextrq(GpRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pextrq, o0, o1, (Immediate)o2);
		}

		public void Pextrq(Memory o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pextrq, o0, o1, o2);
		}

		public void Pextrq(Memory o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pextrq, o0, o1, (Immediate)o2);
		}

		public void Pextrq(Memory o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pextrq, o0, o1, (Immediate)o2);
		}

		public void Pextrw(Memory o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pextrw, o0, o1, o2);
		}

		public void Pextrw(Memory o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pextrw, o0, o1, (Immediate)o2);
		}

		public void Pextrw(Memory o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pextrw, o0, o1, (Immediate)o2);
		}

		public void Phminposuw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Phminposuw, o0, o1);
		}

		public void Phminposuw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Phminposuw, o0, o1);
		}

		public void Pinsrb(XmmRegister o0, GpRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pinsrb, o0, o1, o2);
		}

		public void Pinsrb(XmmRegister o0, GpRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pinsrb, o0, o1, (Immediate)o2);
		}

		public void Pinsrb(XmmRegister o0, GpRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pinsrb, o0, o1, (Immediate)o2);
		}

		public void Pinsrb(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pinsrb, o0, o1, o2);
		}

		public void Pinsrb(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pinsrb, o0, o1, (Immediate)o2);
		}

		public void Pinsrb(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pinsrb, o0, o1, (Immediate)o2);
		}

		public void Pinsrd(XmmRegister o0, GpRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pinsrd, o0, o1, o2);
		}

		public void Pinsrd(XmmRegister o0, GpRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pinsrd, o0, o1, (Immediate)o2);
		}

		public void Pinsrd(XmmRegister o0, GpRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pinsrd, o0, o1, (Immediate)o2);
		}

		public void Pinsrd(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pinsrd, o0, o1, o2);
		}

		public void Pinsrd(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pinsrd, o0, o1, (Immediate)o2);
		}

		public void Pinsrd(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pinsrd, o0, o1, (Immediate)o2);
		}

		public void Pinsrq(XmmRegister o0, GpRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pinsrq, o0, o1, o2);
		}

		public void Pinsrq(XmmRegister o0, GpRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pinsrq, o0, o1, (Immediate)o2);
		}

		public void Pinsrq(XmmRegister o0, GpRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pinsrq, o0, o1, (Immediate)o2);
		}

		public void Pinsrq(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pinsrq, o0, o1, o2);
		}

		public void Pinsrq(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pinsrq, o0, o1, (Immediate)o2);
		}

		public void Pinsrq(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pinsrq, o0, o1, (Immediate)o2);
		}

		public void Pmaxsb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmaxsb, o0, o1);
		}

		public void Pmaxsb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmaxsb, o0, o1);
		}

		public void Pmaxsd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmaxsd, o0, o1);
		}

		public void Pmaxsd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmaxsd, o0, o1);
		}

		public void Pmaxud(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmaxud, o0, o1);
		}

		public void Pmaxud(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmaxud, o0, o1);
		}

		public void Pmaxuw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmaxuw, o0, o1);
		}

		public void Pmaxuw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmaxuw, o0, o1);
		}

		public void Pminsb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pminsb, o0, o1);
		}

		public void Pminsb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pminsb, o0, o1);
		}

		public void Pminsd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pminsd, o0, o1);
		}

		public void Pminsd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pminsd, o0, o1);
		}

		public void Pminuw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pminuw, o0, o1);
		}

		public void Pminuw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pminuw, o0, o1);
		}

		public void Pminud(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pminud, o0, o1);
		}

		public void Pminud(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pminud, o0, o1);
		}

		public void Pmovsxbd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmovsxbd, o0, o1);
		}

		public void Pmovsxbd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmovsxbd, o0, o1);
		}

		public void Pmovsxbq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmovsxbq, o0, o1);
		}

		public void Pmovsxbq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmovsxbq, o0, o1);
		}

		public void Pmovsxbw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmovsxbw, o0, o1);
		}

		public void Pmovsxbw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmovsxbw, o0, o1);
		}

		public void Pmovsxdq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmovsxdq, o0, o1);
		}

		public void Pmovsxdq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmovsxdq, o0, o1);
		}

		public void Pmovsxwd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmovsxwd, o0, o1);
		}

		public void Pmovsxwd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmovsxwd, o0, o1);
		}

		public void Pmovsxwq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmovsxwq, o0, o1);
		}

		public void Pmovsxwq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmovsxwq, o0, o1);
		}

		public void Pmovzxbd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmovzxbd, o0, o1);
		}

		public void Pmovzxbd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmovzxbd, o0, o1);
		}

		public void Pmovzxbq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmovzxbq, o0, o1);
		}

		public void Pmovzxbq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmovzxbq, o0, o1);
		}

		public void Pmovzxbw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmovzxbw, o0, o1);
		}

		public void Pmovzxbw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmovzxbw, o0, o1);
		}

		public void Pmovzxdq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmovzxdq, o0, o1);
		}

		public void Pmovzxdq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmovzxdq, o0, o1);
		}

		public void Pmovzxwd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmovzxwd, o0, o1);
		}

		public void Pmovzxwd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmovzxwd, o0, o1);
		}

		public void Pmovzxwq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmovzxwq, o0, o1);
		}

		public void Pmovzxwq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmovzxwq, o0, o1);
		}

		public void Pmuldq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmuldq, o0, o1);
		}

		public void Pmuldq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmuldq, o0, o1);
		}

		public void Pmulld(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pmulld, o0, o1);
		}

		public void Pmulld(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pmulld, o0, o1);
		}

		public void Ptest(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Ptest, o0, o1);
		}

		public void Ptest(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Ptest, o0, o1);
		}

		public void Roundpd(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Roundpd, o0, o1, o2);
		}

		public void Roundpd(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Roundpd, o0, o1, (Immediate)o2);
		}

		public void Roundpd(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Roundpd, o0, o1, (Immediate)o2);
		}

		public void Roundpd(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Roundpd, o0, o1, o2);
		}

		public void Roundpd(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Roundpd, o0, o1, (Immediate)o2);
		}

		public void Roundpd(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Roundpd, o0, o1, (Immediate)o2);
		}

		public void Roundps(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Roundps, o0, o1, o2);
		}

		public void Roundps(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Roundps, o0, o1, (Immediate)o2);
		}

		public void Roundps(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Roundps, o0, o1, (Immediate)o2);
		}

		public void Roundps(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Roundps, o0, o1, o2);
		}

		public void Roundps(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Roundps, o0, o1, (Immediate)o2);
		}

		public void Roundps(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Roundps, o0, o1, (Immediate)o2);
		}

		public void Roundsd(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Roundsd, o0, o1, o2);
		}

		public void Roundsd(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Roundsd, o0, o1, (Immediate)o2);
		}

		public void Roundsd(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Roundsd, o0, o1, (Immediate)o2);
		}

		public void Roundsd(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Roundsd, o0, o1, o2);
		}

		public void Roundsd(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Roundsd, o0, o1, (Immediate)o2);
		}

		public void Roundsd(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Roundsd, o0, o1, (Immediate)o2);
		}

		public void Roundss(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Roundss, o0, o1, o2);
		}

		public void Roundss(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Roundss, o0, o1, (Immediate)o2);
		}

		public void Roundss(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Roundss, o0, o1, (Immediate)o2);
		}

		public void Roundss(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Roundss, o0, o1, o2);
		}

		public void Roundss(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Roundss, o0, o1, (Immediate)o2);
		}

		public void Roundss(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Roundss, o0, o1, (Immediate)o2);
		}

		public void Crc32(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Crc32, o0, o1);
		}

		public void Crc32(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Crc32, o0, o1);
		}

		public void Pcmpestri(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pcmpestri, o0, o1, o2);
		}

		public void Pcmpestri(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pcmpestri, o0, o1, (Immediate)o2);
		}

		public void Pcmpestri(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pcmpestri, o0, o1, (Immediate)o2);
		}

		public void Pcmpestri(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pcmpestri, o0, o1, o2);
		}

		public void Pcmpestri(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pcmpestri, o0, o1, (Immediate)o2);
		}

		public void Pcmpestri(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pcmpestri, o0, o1, (Immediate)o2);
		}

		public void Pcmpestrm(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pcmpestrm, o0, o1, o2);
		}

		public void Pcmpestrm(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pcmpestrm, o0, o1, (Immediate)o2);
		}

		public void Pcmpestrm(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pcmpestrm, o0, o1, (Immediate)o2);
		}

		public void Pcmpestrm(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pcmpestrm, o0, o1, o2);
		}

		public void Pcmpestrm(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pcmpestrm, o0, o1, (Immediate)o2);
		}

		public void Pcmpestrm(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pcmpestrm, o0, o1, (Immediate)o2);
		}

		public void Pcmpistri(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pcmpistri, o0, o1, o2);
		}

		public void Pcmpistri(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pcmpistri, o0, o1, (Immediate)o2);
		}

		public void Pcmpistri(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pcmpistri, o0, o1, (Immediate)o2);
		}

		public void Pcmpistri(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pcmpistri, o0, o1, o2);
		}

		public void Pcmpistri(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pcmpistri, o0, o1, (Immediate)o2);
		}

		public void Pcmpistri(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pcmpistri, o0, o1, (Immediate)o2);
		}

		public void Pcmpistrm(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pcmpistrm, o0, o1, o2);
		}

		public void Pcmpistrm(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pcmpistrm, o0, o1, (Immediate)o2);
		}

		public void Pcmpistrm(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pcmpistrm, o0, o1, (Immediate)o2);
		}

		public void Pcmpistrm(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pcmpistrm, o0, o1, o2);
		}

		public void Pcmpistrm(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pcmpistrm, o0, o1, (Immediate)o2);
		}

		public void Pcmpistrm(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pcmpistrm, o0, o1, (Immediate)o2);
		}

		public void Pcmpgtq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Pcmpgtq, o0, o1);
		}

		public void Pcmpgtq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Pcmpgtq, o0, o1);
		}

		public void Extrq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Extrq, o0, o1);
		}

		public void Extrq(XmmRegister o0, Immediate o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Extrq, o0, o1, o2);
		}

		public void Extrq(XmmRegister o0, long o1, long o2)
		{
			Assembler.Emit(InstructionId.Extrq, o0, (Immediate)o1, (Immediate)o2);
		}

		public void Extrq(XmmRegister o0, ulong o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Extrq, o0, (Immediate)o1, (Immediate)o2);
		}

		public void Insertq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Insertq, o0, o1);
		}

		public void Insertq(XmmRegister o0, XmmRegister o1, Immediate o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Insertq, o0, o1, o2, (Immediate)o3);
		}

		public void Insertq(XmmRegister o0, XmmRegister o1, long o2, long o3)
		{
			Assembler.Emit(InstructionId.Insertq, o0, o1, (Immediate)o2, (Immediate)o3);
		}

		public void Insertq(XmmRegister o0, XmmRegister o1, ulong o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Insertq, o0, o1, (Immediate)o2, (Immediate)o3);
		}

		public void Movntsd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movntsd, o0, o1);
		}

		public void Movntss(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Movntss, o0, o1);
		}

		public void Popcnt(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Popcnt, o0, o1);
		}

		public void Popcnt(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Popcnt, o0, o1);
		}

		public void Lzcnt(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Lzcnt, o0, o1);
		}

		public void Lzcnt(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Lzcnt, o0, o1);
		}

		public void Aesdec(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Aesdec, o0, o1);
		}

		public void Aesdec(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Aesdec, o0, o1);
		}

		public void Aesdeclast(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Aesdeclast, o0, o1);
		}

		public void Aesdeclast(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Aesdeclast, o0, o1);
		}

		public void Aesenc(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Aesenc, o0, o1);
		}

		public void Aesenc(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Aesenc, o0, o1);
		}

		public void Aesenclast(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Aesenclast, o0, o1);
		}

		public void Aesenclast(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Aesenclast, o0, o1);
		}

		public void Aesimc(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Aesimc, o0, o1);
		}

		public void Aesimc(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Aesimc, o0, o1);
		}

		public void Aeskeygenassist(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Aeskeygenassist, o0, o1, o2);
		}

		public void Aeskeygenassist(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Aeskeygenassist, o0, o1, (Immediate)o2);
		}

		public void Aeskeygenassist(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Aeskeygenassist, o0, o1, (Immediate)o2);
		}

		public void Aeskeygenassist(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Aeskeygenassist, o0, o1, o2);
		}

		public void Aeskeygenassist(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Aeskeygenassist, o0, o1, (Immediate)o2);
		}

		public void Aeskeygenassist(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Aeskeygenassist, o0, o1, (Immediate)o2);
		}

		public void Pclmulqdq(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pclmulqdq, o0, o1, o2);
		}

		public void Pclmulqdq(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Pclmulqdq, o0, o1, (Immediate)o2);
		}

		public void Pclmulqdq(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pclmulqdq, o0, o1, (Immediate)o2);
		}

		public void Pclmulqdq(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Pclmulqdq, o0, o1, o2);
		}

		public void Pclmulqdq(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Pclmulqdq, o0, o1, (Immediate)o2);
		}

		public void Pclmulqdq(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Pclmulqdq, o0, o1, (Immediate)o2);
		}

		public void Xrstor(Memory o0)
		{
			Assembler.Emit(InstructionId.Xrstor, o0);
		}

		public void Xrstor64(Memory o0)
		{
			Assembler.Emit(InstructionId.Xrstor64, o0);
		}

		public void Xsave(Memory o0)
		{
			Assembler.Emit(InstructionId.Xsave, o0);
		}

		public void Xsave64(Memory o0)
		{
			Assembler.Emit(InstructionId.Xsave64, o0);
		}

		public void Xsaveopt(Memory o0)
		{
			Assembler.Emit(InstructionId.Xsaveopt, o0);
		}

		public void Xsaveopt64(Memory o0)
		{
			Assembler.Emit(InstructionId.Xsaveopt64, o0);
		}

		public void Xgetbv()
		{
			Assembler.Emit(InstructionId.Xgetbv);
		}

		public void Xsetbv()
		{
			Assembler.Emit(InstructionId.Xsetbv);
		}

		public void Vaddpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vaddpd, o0, o1, o2);
		}

		public void Vaddpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vaddpd, o0, o1, o2);
		}

		public void Vaddpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vaddpd, o0, o1, o2);
		}

		public void Vaddpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vaddpd, o0, o1, o2);
		}

		public void Vaddps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vaddps, o0, o1, o2);
		}

		public void Vaddps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vaddps, o0, o1, o2);
		}

		public void Vaddps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vaddps, o0, o1, o2);
		}

		public void Vaddps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vaddps, o0, o1, o2);
		}

		public void Vaddsd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vaddsd, o0, o1, o2);
		}

		public void Vaddsd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vaddsd, o0, o1, o2);
		}

		public void Vaddss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vaddss, o0, o1, o2);
		}

		public void Vaddss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vaddss, o0, o1, o2);
		}

		public void Vaddsubpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vaddsubpd, o0, o1, o2);
		}

		public void Vaddsubpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vaddsubpd, o0, o1, o2);
		}

		public void Vaddsubpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vaddsubpd, o0, o1, o2);
		}

		public void Vaddsubpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vaddsubpd, o0, o1, o2);
		}

		public void Vaddsubps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vaddsubps, o0, o1, o2);
		}

		public void Vaddsubps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vaddsubps, o0, o1, o2);
		}

		public void Vaddsubps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vaddsubps, o0, o1, o2);
		}

		public void Vaddsubps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vaddsubps, o0, o1, o2);
		}

		public void Vandpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vandpd, o0, o1, o2);
		}

		public void Vandpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vandpd, o0, o1, o2);
		}

		public void Vandpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vandpd, o0, o1, o2);
		}

		public void Vandpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vandpd, o0, o1, o2);
		}

		public void Vandps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vandps, o0, o1, o2);
		}

		public void Vandps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vandps, o0, o1, o2);
		}

		public void Vandps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vandps, o0, o1, o2);
		}

		public void Vandps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vandps, o0, o1, o2);
		}

		public void Vandnpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vandnpd, o0, o1, o2);
		}

		public void Vandnpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vandnpd, o0, o1, o2);
		}

		public void Vandnpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vandnpd, o0, o1, o2);
		}

		public void Vandnpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vandnpd, o0, o1, o2);
		}

		public void Vandnps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vandnps, o0, o1, o2);
		}

		public void Vandnps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vandnps, o0, o1, o2);
		}

		public void Vandnps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vandnps, o0, o1, o2);
		}

		public void Vandnps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vandnps, o0, o1, o2);
		}

		public void Vblendpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vblendpd, o0, o1, o2, o3);
		}

		public void Vblendpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vblendpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vblendpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendpd(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vblendpd, o0, o1, o2, o3);
		}

		public void Vblendpd(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vblendpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendpd(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vblendpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vblendpd, o0, o1, o2, o3);
		}

		public void Vblendpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vblendpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vblendpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendpd(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vblendpd, o0, o1, o2, o3);
		}

		public void Vblendpd(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vblendpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendpd(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vblendpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendps(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vblendps, o0, o1, o2, o3);
		}

		public void Vblendps(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vblendps, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendps(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vblendps, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendps(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vblendps, o0, o1, o2, o3);
		}

		public void Vblendps(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vblendps, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendps(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vblendps, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendps(YmmRegister o0, YmmRegister o1, YmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vblendps, o0, o1, o2, o3);
		}

		public void Vblendps(YmmRegister o0, YmmRegister o1, YmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vblendps, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendps(YmmRegister o0, YmmRegister o1, YmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vblendps, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendps(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vblendps, o0, o1, o2, o3);
		}

		public void Vblendps(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vblendps, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendps(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vblendps, o0, o1, o2, (Immediate)o3);
		}

		public void Vblendvpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vblendvpd, o0, o1, o2, o3);
		}

		public void Vblendvpd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vblendvpd, o0, o1, o2, o3);
		}

		public void Vblendvpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vblendvpd, o0, o1, o2, o3);
		}

		public void Vblendvpd(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vblendvpd, o0, o1, o2, o3);
		}

		public void Vblendvps(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vblendvps, o0, o1, o2, o3);
		}

		public void Vblendvps(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vblendvps, o0, o1, o2, o3);
		}

		public void Vblendvps(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vblendvps, o0, o1, o2, o3);
		}

		public void Vblendvps(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vblendvps, o0, o1, o2, o3);
		}

		public void Vbroadcastf128(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vbroadcastf128, o0, o1);
		}

		public void Vbroadcastsd(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vbroadcastsd, o0, o1);
		}

		public void Vbroadcastss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vbroadcastss, o0, o1);
		}

		public void Vbroadcastss(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vbroadcastss, o0, o1);
		}

		public void Vcmppd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vcmppd, o0, o1, o2, o3);
		}

		public void Vcmppd(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vcmppd, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmppd(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vcmppd, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmppd(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vcmppd, o0, o1, o2, o3);
		}

		public void Vcmppd(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vcmppd, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmppd(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vcmppd, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmppd(YmmRegister o0, YmmRegister o1, YmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vcmppd, o0, o1, o2, o3);
		}

		public void Vcmppd(YmmRegister o0, YmmRegister o1, YmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vcmppd, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmppd(YmmRegister o0, YmmRegister o1, YmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vcmppd, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmppd(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vcmppd, o0, o1, o2, o3);
		}

		public void Vcmppd(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vcmppd, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmppd(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vcmppd, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpps(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vcmpps, o0, o1, o2, o3);
		}

		public void Vcmpps(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vcmpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpps(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vcmpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpps(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vcmpps, o0, o1, o2, o3);
		}

		public void Vcmpps(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vcmpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpps(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vcmpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpps(YmmRegister o0, YmmRegister o1, YmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vcmpps, o0, o1, o2, o3);
		}

		public void Vcmpps(YmmRegister o0, YmmRegister o1, YmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vcmpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpps(YmmRegister o0, YmmRegister o1, YmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vcmpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpps(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vcmpps, o0, o1, o2, o3);
		}

		public void Vcmpps(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vcmpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpps(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vcmpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpsd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vcmpsd, o0, o1, o2, o3);
		}

		public void Vcmpsd(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vcmpsd, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpsd(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vcmpsd, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpsd(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vcmpsd, o0, o1, o2, o3);
		}

		public void Vcmpsd(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vcmpsd, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpsd(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vcmpsd, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpss(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vcmpss, o0, o1, o2, o3);
		}

		public void Vcmpss(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vcmpss, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpss(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vcmpss, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpss(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vcmpss, o0, o1, o2, o3);
		}

		public void Vcmpss(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vcmpss, o0, o1, o2, (Immediate)o3);
		}

		public void Vcmpss(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vcmpss, o0, o1, o2, (Immediate)o3);
		}

		public void Vcomisd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcomisd, o0, o1);
		}

		public void Vcomisd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcomisd, o0, o1);
		}

		public void Vcomiss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcomiss, o0, o1);
		}

		public void Vcomiss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcomiss, o0, o1);
		}

		public void Vcvtdq2pd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtdq2pd, o0, o1);
		}

		public void Vcvtdq2pd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvtdq2pd, o0, o1);
		}

		public void Vcvtdq2pd(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtdq2pd, o0, o1);
		}

		public void Vcvtdq2pd(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvtdq2pd, o0, o1);
		}

		public void Vcvtdq2ps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtdq2ps, o0, o1);
		}

		public void Vcvtdq2ps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvtdq2ps, o0, o1);
		}

		public void Vcvtdq2ps(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtdq2ps, o0, o1);
		}

		public void Vcvtdq2ps(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvtdq2ps, o0, o1);
		}

		public void Vcvtpd2dq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtpd2dq, o0, o1);
		}

		public void Vcvtpd2dq(XmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtpd2dq, o0, o1);
		}

		public void Vcvtpd2dq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvtpd2dq, o0, o1);
		}

		public void Vcvtpd2ps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtpd2ps, o0, o1);
		}

		public void Vcvtpd2ps(XmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtpd2ps, o0, o1);
		}

		public void Vcvtpd2ps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvtpd2ps, o0, o1);
		}

		public void Vcvtps2dq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtps2dq, o0, o1);
		}

		public void Vcvtps2dq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvtps2dq, o0, o1);
		}

		public void Vcvtps2dq(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtps2dq, o0, o1);
		}

		public void Vcvtps2dq(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvtps2dq, o0, o1);
		}

		public void Vcvtps2pd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtps2pd, o0, o1);
		}

		public void Vcvtps2pd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvtps2pd, o0, o1);
		}

		public void Vcvtps2pd(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtps2pd, o0, o1);
		}

		public void Vcvtps2pd(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvtps2pd, o0, o1);
		}

		public void Vcvtsd2si(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtsd2si, o0, o1);
		}

		public void Vcvtsd2si(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvtsd2si, o0, o1);
		}

		public void Vcvtsd2ss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vcvtsd2ss, o0, o1, o2);
		}

		public void Vcvtsd2ss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vcvtsd2ss, o0, o1, o2);
		}

		public void Vcvtsi2sd(XmmRegister o0, XmmRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Vcvtsi2sd, o0, o1, o2);
		}

		public void Vcvtsi2sd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vcvtsi2sd, o0, o1, o2);
		}

		public void Vcvtsi2ss(XmmRegister o0, XmmRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Vcvtsi2ss, o0, o1, o2);
		}

		public void Vcvtsi2ss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vcvtsi2ss, o0, o1, o2);
		}

		public void Vcvtss2sd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vcvtss2sd, o0, o1, o2);
		}

		public void Vcvtss2sd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vcvtss2sd, o0, o1, o2);
		}

		public void Vcvtss2si(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtss2si, o0, o1);
		}

		public void Vcvtss2si(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvtss2si, o0, o1);
		}

		public void Vcvttpd2dq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvttpd2dq, o0, o1);
		}

		public void Vcvttpd2dq(XmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvttpd2dq, o0, o1);
		}

		public void Vcvttpd2dq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvttpd2dq, o0, o1);
		}

		public void Vcvttps2dq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvttps2dq, o0, o1);
		}

		public void Vcvttps2dq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvttps2dq, o0, o1);
		}

		public void Vcvttps2dq(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvttps2dq, o0, o1);
		}

		public void Vcvttps2dq(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvttps2dq, o0, o1);
		}

		public void Vcvttsd2si(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvttsd2si, o0, o1);
		}

		public void Vcvttsd2si(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvttsd2si, o0, o1);
		}

		public void Vcvttss2si(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvttss2si, o0, o1);
		}

		public void Vcvttss2si(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvttss2si, o0, o1);
		}

		public void Vdivpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vdivpd, o0, o1, o2);
		}

		public void Vdivpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vdivpd, o0, o1, o2);
		}

		public void Vdivpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vdivpd, o0, o1, o2);
		}

		public void Vdivpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vdivpd, o0, o1, o2);
		}

		public void Vdivps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vdivps, o0, o1, o2);
		}

		public void Vdivps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vdivps, o0, o1, o2);
		}

		public void Vdivps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vdivps, o0, o1, o2);
		}

		public void Vdivps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vdivps, o0, o1, o2);
		}

		public void Vdivsd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vdivsd, o0, o1, o2);
		}

		public void Vdivsd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vdivsd, o0, o1, o2);
		}

		public void Vdivss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vdivss, o0, o1, o2);
		}

		public void Vdivss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vdivss, o0, o1, o2);
		}

		public void Vdppd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vdppd, o0, o1, o2, o3);
		}

		public void Vdppd(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vdppd, o0, o1, o2, (Immediate)o3);
		}

		public void Vdppd(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vdppd, o0, o1, o2, (Immediate)o3);
		}

		public void Vdppd(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vdppd, o0, o1, o2, o3);
		}

		public void Vdppd(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vdppd, o0, o1, o2, (Immediate)o3);
		}

		public void Vdppd(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vdppd, o0, o1, o2, (Immediate)o3);
		}

		public void Vdpps(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vdpps, o0, o1, o2, o3);
		}

		public void Vdpps(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vdpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vdpps(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vdpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vdpps(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vdpps, o0, o1, o2, o3);
		}

		public void Vdpps(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vdpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vdpps(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vdpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vdpps(YmmRegister o0, YmmRegister o1, YmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vdpps, o0, o1, o2, o3);
		}

		public void Vdpps(YmmRegister o0, YmmRegister o1, YmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vdpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vdpps(YmmRegister o0, YmmRegister o1, YmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vdpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vdpps(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vdpps, o0, o1, o2, o3);
		}

		public void Vdpps(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vdpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vdpps(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vdpps, o0, o1, o2, (Immediate)o3);
		}

		public void Vextractf128(XmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vextractf128, o0, o1, o2);
		}

		public void Vextractf128(XmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vextractf128, o0, o1, (Immediate)o2);
		}

		public void Vextractf128(XmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vextractf128, o0, o1, (Immediate)o2);
		}

		public void Vextractf128(Memory o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vextractf128, o0, o1, o2);
		}

		public void Vextractf128(Memory o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vextractf128, o0, o1, (Immediate)o2);
		}

		public void Vextractf128(Memory o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vextractf128, o0, o1, (Immediate)o2);
		}

		public void Vextractps(GpRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vextractps, o0, o1, o2);
		}

		public void Vextractps(GpRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vextractps, o0, o1, (Immediate)o2);
		}

		public void Vextractps(GpRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vextractps, o0, o1, (Immediate)o2);
		}

		public void Vextractps(Memory o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vextractps, o0, o1, o2);
		}

		public void Vextractps(Memory o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vextractps, o0, o1, (Immediate)o2);
		}

		public void Vextractps(Memory o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vextractps, o0, o1, (Immediate)o2);
		}

		public void Vhaddpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vhaddpd, o0, o1, o2);
		}

		public void Vhaddpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vhaddpd, o0, o1, o2);
		}

		public void Vhaddpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vhaddpd, o0, o1, o2);
		}

		public void Vhaddpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vhaddpd, o0, o1, o2);
		}

		public void Vhaddps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vhaddps, o0, o1, o2);
		}

		public void Vhaddps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vhaddps, o0, o1, o2);
		}

		public void Vhaddps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vhaddps, o0, o1, o2);
		}

		public void Vhaddps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vhaddps, o0, o1, o2);
		}

		public void Vhsubpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vhsubpd, o0, o1, o2);
		}

		public void Vhsubpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vhsubpd, o0, o1, o2);
		}

		public void Vhsubpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vhsubpd, o0, o1, o2);
		}

		public void Vhsubpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vhsubpd, o0, o1, o2);
		}

		public void Vhsubps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vhsubps, o0, o1, o2);
		}

		public void Vhsubps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vhsubps, o0, o1, o2);
		}

		public void Vhsubps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vhsubps, o0, o1, o2);
		}

		public void Vhsubps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vhsubps, o0, o1, o2);
		}

		public void Vinsertf128(YmmRegister o0, YmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vinsertf128, o0, o1, o2, o3);
		}

		public void Vinsertf128(YmmRegister o0, YmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vinsertf128, o0, o1, o2, (Immediate)o3);
		}

		public void Vinsertf128(YmmRegister o0, YmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vinsertf128, o0, o1, o2, (Immediate)o3);
		}

		public void Vinsertf128(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vinsertf128, o0, o1, o2, o3);
		}

		public void Vinsertf128(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vinsertf128, o0, o1, o2, (Immediate)o3);
		}

		public void Vinsertf128(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vinsertf128, o0, o1, o2, (Immediate)o3);
		}

		public void Vinsertps(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vinsertps, o0, o1, o2, o3);
		}

		public void Vinsertps(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vinsertps, o0, o1, o2, (Immediate)o3);
		}

		public void Vinsertps(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vinsertps, o0, o1, o2, (Immediate)o3);
		}

		public void Vinsertps(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vinsertps, o0, o1, o2, o3);
		}

		public void Vinsertps(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vinsertps, o0, o1, o2, (Immediate)o3);
		}

		public void Vinsertps(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vinsertps, o0, o1, o2, (Immediate)o3);
		}

		public void Vlddqu(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vlddqu, o0, o1);
		}

		public void Vlddqu(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vlddqu, o0, o1);
		}

		public void Vldmxcsr(Memory o0)
		{
			Assembler.Emit(InstructionId.Vldmxcsr, o0);
		}

		public void Vmaskmovdqu(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmaskmovdqu, o0, o1);
		}

		public void Vmaskmovpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmaskmovpd, o0, o1, o2);
		}

		public void Vmaskmovpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmaskmovpd, o0, o1, o2);
		}

		public void Vmaskmovpd(Memory o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmaskmovpd, o0, o1, o2);
		}

		public void Vmaskmovpd(Memory o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmaskmovpd, o0, o1, o2);
		}

		public void Vmaskmovps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmaskmovps, o0, o1, o2);
		}

		public void Vmaskmovps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmaskmovps, o0, o1, o2);
		}

		public void Vmaskmovps(Memory o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmaskmovps, o0, o1, o2);
		}

		public void Vmaskmovps(Memory o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmaskmovps, o0, o1, o2);
		}

		public void Vmaxpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmaxpd, o0, o1, o2);
		}

		public void Vmaxpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmaxpd, o0, o1, o2);
		}

		public void Vmaxpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmaxpd, o0, o1, o2);
		}

		public void Vmaxpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmaxpd, o0, o1, o2);
		}

		public void Vmaxps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmaxps, o0, o1, o2);
		}

		public void Vmaxps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmaxps, o0, o1, o2);
		}

		public void Vmaxps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmaxps, o0, o1, o2);
		}

		public void Vmaxps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmaxps, o0, o1, o2);
		}

		public void Vmaxsd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmaxsd, o0, o1, o2);
		}

		public void Vmaxsd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmaxsd, o0, o1, o2);
		}

		public void Vmaxss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmaxss, o0, o1, o2);
		}

		public void Vmaxss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmaxss, o0, o1, o2);
		}

		public void Vminpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vminpd, o0, o1, o2);
		}

		public void Vminpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vminpd, o0, o1, o2);
		}

		public void Vminpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vminpd, o0, o1, o2);
		}

		public void Vminpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vminpd, o0, o1, o2);
		}

		public void Vminps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vminps, o0, o1, o2);
		}

		public void Vminps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vminps, o0, o1, o2);
		}

		public void Vminps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vminps, o0, o1, o2);
		}

		public void Vminps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vminps, o0, o1, o2);
		}

		public void Vminsd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vminsd, o0, o1, o2);
		}

		public void Vminsd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vminsd, o0, o1, o2);
		}

		public void Vminss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vminss, o0, o1, o2);
		}

		public void Vminss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vminss, o0, o1, o2);
		}

		public void Vmovapd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovapd, o0, o1);
		}

		public void Vmovapd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovapd, o0, o1);
		}

		public void Vmovapd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovapd, o0, o1);
		}

		public void Vmovapd(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovapd, o0, o1);
		}

		public void Vmovapd(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovapd, o0, o1);
		}

		public void Vmovapd(Memory o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovapd, o0, o1);
		}

		public void Vmovaps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovaps, o0, o1);
		}

		public void Vmovaps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovaps, o0, o1);
		}

		public void Vmovaps(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovaps, o0, o1);
		}

		public void Vmovaps(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovaps, o0, o1);
		}

		public void Vmovaps(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovaps, o0, o1);
		}

		public void Vmovaps(Memory o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovaps, o0, o1);
		}

		public void Vmovd(XmmRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovd, o0, o1);
		}

		public void Vmovd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovd, o0, o1);
		}

		public void Vmovd(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovd, o0, o1);
		}

		public void Vmovd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovd, o0, o1);
		}

		public void Vmovq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovq, o0, o1);
		}

		public void Vmovq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovq, o0, o1);
		}

		public void Vmovq(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovq, o0, o1);
		}

		public void Vmovq(XmmRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovq, o0, o1);
		}

		public void Vmovq(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovq, o0, o1);
		}

		public void Vmovddup(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovddup, o0, o1);
		}

		public void Vmovddup(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovddup, o0, o1);
		}

		public void Vmovddup(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovddup, o0, o1);
		}

		public void Vmovddup(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovddup, o0, o1);
		}

		public void Vmovdqa(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovdqa, o0, o1);
		}

		public void Vmovdqa(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovdqa, o0, o1);
		}

		public void Vmovdqa(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovdqa, o0, o1);
		}

		public void Vmovdqa(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovdqa, o0, o1);
		}

		public void Vmovdqa(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovdqa, o0, o1);
		}

		public void Vmovdqa(Memory o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovdqa, o0, o1);
		}

		public void Vmovdqu(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovdqu, o0, o1);
		}

		public void Vmovdqu(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovdqu, o0, o1);
		}

		public void Vmovdqu(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovdqu, o0, o1);
		}

		public void Vmovdqu(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovdqu, o0, o1);
		}

		public void Vmovdqu(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovdqu, o0, o1);
		}

		public void Vmovdqu(Memory o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovdqu, o0, o1);
		}

		public void Vmovhlps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmovhlps, o0, o1, o2);
		}

		public void Vmovhpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmovhpd, o0, o1, o2);
		}

		public void Vmovhpd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovhpd, o0, o1);
		}

		public void Vmovhps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmovhps, o0, o1, o2);
		}

		public void Vmovhps(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovhps, o0, o1);
		}

		public void Vmovlhps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmovlhps, o0, o1, o2);
		}

		public void Vmovlpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmovlpd, o0, o1, o2);
		}

		public void Vmovlpd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovlpd, o0, o1);
		}

		public void Vmovlps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmovlps, o0, o1, o2);
		}

		public void Vmovlps(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovlps, o0, o1);
		}

		public void Vmovmskpd(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovmskpd, o0, o1);
		}

		public void Vmovmskpd(GpRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovmskpd, o0, o1);
		}

		public void Vmovmskps(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovmskps, o0, o1);
		}

		public void Vmovmskps(GpRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovmskps, o0, o1);
		}

		public void Vmovntdq(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovntdq, o0, o1);
		}

		public void Vmovntdq(Memory o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovntdq, o0, o1);
		}

		public void Vmovntdqa(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovntdqa, o0, o1);
		}

		public void Vmovntpd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovntpd, o0, o1);
		}

		public void Vmovntpd(Memory o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovntpd, o0, o1);
		}

		public void Vmovntps(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovntps, o0, o1);
		}

		public void Vmovntps(Memory o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovntps, o0, o1);
		}

		public void Vmovsd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmovsd, o0, o1, o2);
		}

		public void Vmovsd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovsd, o0, o1);
		}

		public void Vmovsd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovsd, o0, o1);
		}

		public void Vmovshdup(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovshdup, o0, o1);
		}

		public void Vmovshdup(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovshdup, o0, o1);
		}

		public void Vmovshdup(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovshdup, o0, o1);
		}

		public void Vmovshdup(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovshdup, o0, o1);
		}

		public void Vmovsldup(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovsldup, o0, o1);
		}

		public void Vmovsldup(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovsldup, o0, o1);
		}

		public void Vmovsldup(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovsldup, o0, o1);
		}

		public void Vmovsldup(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovsldup, o0, o1);
		}

		public void Vmovss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmovss, o0, o1, o2);
		}

		public void Vmovss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovss, o0, o1);
		}

		public void Vmovss(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovss, o0, o1);
		}

		public void Vmovupd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovupd, o0, o1);
		}

		public void Vmovupd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovupd, o0, o1);
		}

		public void Vmovupd(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovupd, o0, o1);
		}

		public void Vmovupd(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovupd, o0, o1);
		}

		public void Vmovupd(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovupd, o0, o1);
		}

		public void Vmovupd(Memory o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovupd, o0, o1);
		}

		public void Vmovups(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovups, o0, o1);
		}

		public void Vmovups(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovups, o0, o1);
		}

		public void Vmovups(Memory o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovups, o0, o1);
		}

		public void Vmovups(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovups, o0, o1);
		}

		public void Vmovups(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovups, o0, o1);
		}

		public void Vmovups(Memory o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vmovups, o0, o1);
		}

		public void Vmpsadbw(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vmpsadbw, o0, o1, o2, o3);
		}

		public void Vmpsadbw(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vmpsadbw, o0, o1, o2, (Immediate)o3);
		}

		public void Vmpsadbw(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vmpsadbw, o0, o1, o2, (Immediate)o3);
		}

		public void Vmpsadbw(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vmpsadbw, o0, o1, o2, o3);
		}

		public void Vmpsadbw(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vmpsadbw, o0, o1, o2, (Immediate)o3);
		}

		public void Vmpsadbw(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vmpsadbw, o0, o1, o2, (Immediate)o3);
		}

		public void Vmulpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmulpd, o0, o1, o2);
		}

		public void Vmulpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmulpd, o0, o1, o2);
		}

		public void Vmulpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmulpd, o0, o1, o2);
		}

		public void Vmulpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmulpd, o0, o1, o2);
		}

		public void Vmulps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmulps, o0, o1, o2);
		}

		public void Vmulps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmulps, o0, o1, o2);
		}

		public void Vmulps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmulps, o0, o1, o2);
		}

		public void Vmulps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmulps, o0, o1, o2);
		}

		public void Vmulsd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmulsd, o0, o1, o2);
		}

		public void Vmulsd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmulsd, o0, o1, o2);
		}

		public void Vmulss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vmulss, o0, o1, o2);
		}

		public void Vmulss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vmulss, o0, o1, o2);
		}

		public void Vorpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vorpd, o0, o1, o2);
		}

		public void Vorpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vorpd, o0, o1, o2);
		}

		public void Vorpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vorpd, o0, o1, o2);
		}

		public void Vorpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vorpd, o0, o1, o2);
		}

		public void Vorps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vorps, o0, o1, o2);
		}

		public void Vorps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vorps, o0, o1, o2);
		}

		public void Vorps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vorps, o0, o1, o2);
		}

		public void Vorps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vorps, o0, o1, o2);
		}

		public void Vpabsb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpabsb, o0, o1);
		}

		public void Vpabsb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpabsb, o0, o1);
		}

		public void Vpabsd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpabsd, o0, o1);
		}

		public void Vpabsd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpabsd, o0, o1);
		}

		public void Vpabsw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpabsw, o0, o1);
		}

		public void Vpabsw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpabsw, o0, o1);
		}

		public void Vpackssdw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpackssdw, o0, o1, o2);
		}

		public void Vpackssdw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpackssdw, o0, o1, o2);
		}

		public void Vpacksswb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpacksswb, o0, o1, o2);
		}

		public void Vpacksswb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpacksswb, o0, o1, o2);
		}

		public void Vpackusdw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpackusdw, o0, o1, o2);
		}

		public void Vpackusdw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpackusdw, o0, o1, o2);
		}

		public void Vpackuswb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpackuswb, o0, o1, o2);
		}

		public void Vpackuswb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpackuswb, o0, o1, o2);
		}

		public void Vpaddb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddb, o0, o1, o2);
		}

		public void Vpaddb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddb, o0, o1, o2);
		}

		public void Vpaddd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddd, o0, o1, o2);
		}

		public void Vpaddd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddd, o0, o1, o2);
		}

		public void Vpaddq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddq, o0, o1, o2);
		}

		public void Vpaddq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddq, o0, o1, o2);
		}

		public void Vpaddw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddw, o0, o1, o2);
		}

		public void Vpaddw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddw, o0, o1, o2);
		}

		public void Vpaddsb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddsb, o0, o1, o2);
		}

		public void Vpaddsb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddsb, o0, o1, o2);
		}

		public void Vpaddsw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddsw, o0, o1, o2);
		}

		public void Vpaddsw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddsw, o0, o1, o2);
		}

		public void Vpaddusb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddusb, o0, o1, o2);
		}

		public void Vpaddusb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddusb, o0, o1, o2);
		}

		public void Vpaddusw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddusw, o0, o1, o2);
		}

		public void Vpaddusw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddusw, o0, o1, o2);
		}

		public void Vpalignr(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpalignr, o0, o1, o2, o3);
		}

		public void Vpalignr(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpalignr, o0, o1, o2, (Immediate)o3);
		}

		public void Vpalignr(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpalignr, o0, o1, o2, (Immediate)o3);
		}

		public void Vpalignr(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpalignr, o0, o1, o2, o3);
		}

		public void Vpalignr(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpalignr, o0, o1, o2, (Immediate)o3);
		}

		public void Vpalignr(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpalignr, o0, o1, o2, (Immediate)o3);
		}

		public void Vpand(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpand, o0, o1, o2);
		}

		public void Vpand(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpand, o0, o1, o2);
		}

		public void Vpandn(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpandn, o0, o1, o2);
		}

		public void Vpandn(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpandn, o0, o1, o2);
		}

		public void Vpavgb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpavgb, o0, o1, o2);
		}

		public void Vpavgb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpavgb, o0, o1, o2);
		}

		public void Vpavgw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpavgw, o0, o1, o2);
		}

		public void Vpavgw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpavgw, o0, o1, o2);
		}

		public void Vpblendvb(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpblendvb, o0, o1, o2, o3);
		}

		public void Vpblendvb(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpblendvb, o0, o1, o2, o3);
		}

		public void Vpblendw(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpblendw, o0, o1, o2, o3);
		}

		public void Vpblendw(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpblendw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpblendw(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpblendw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpblendw(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpblendw, o0, o1, o2, o3);
		}

		public void Vpblendw(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpblendw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpblendw(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpblendw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcmpeqb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqb, o0, o1, o2);
		}

		public void Vpcmpeqb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqb, o0, o1, o2);
		}

		public void Vpcmpeqd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqd, o0, o1, o2);
		}

		public void Vpcmpeqd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqd, o0, o1, o2);
		}

		public void Vpcmpeqq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqq, o0, o1, o2);
		}

		public void Vpcmpeqq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqq, o0, o1, o2);
		}

		public void Vpcmpeqw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqw, o0, o1, o2);
		}

		public void Vpcmpeqw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqw, o0, o1, o2);
		}

		public void Vpcmpgtb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtb, o0, o1, o2);
		}

		public void Vpcmpgtb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtb, o0, o1, o2);
		}

		public void Vpcmpgtd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtd, o0, o1, o2);
		}

		public void Vpcmpgtd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtd, o0, o1, o2);
		}

		public void Vpcmpgtq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtq, o0, o1, o2);
		}

		public void Vpcmpgtq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtq, o0, o1, o2);
		}

		public void Vpcmpgtw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtw, o0, o1, o2);
		}

		public void Vpcmpgtw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtw, o0, o1, o2);
		}

		public void Vpcmpestri(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpcmpestri, o0, o1, o2);
		}

		public void Vpcmpestri(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpcmpestri, o0, o1, (Immediate)o2);
		}

		public void Vpcmpestri(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpcmpestri, o0, o1, (Immediate)o2);
		}

		public void Vpcmpestri(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpcmpestri, o0, o1, o2);
		}

		public void Vpcmpestri(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpcmpestri, o0, o1, (Immediate)o2);
		}

		public void Vpcmpestri(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpcmpestri, o0, o1, (Immediate)o2);
		}

		public void Vpcmpestrm(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpcmpestrm, o0, o1, o2);
		}

		public void Vpcmpestrm(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpcmpestrm, o0, o1, (Immediate)o2);
		}

		public void Vpcmpestrm(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpcmpestrm, o0, o1, (Immediate)o2);
		}

		public void Vpcmpestrm(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpcmpestrm, o0, o1, o2);
		}

		public void Vpcmpestrm(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpcmpestrm, o0, o1, (Immediate)o2);
		}

		public void Vpcmpestrm(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpcmpestrm, o0, o1, (Immediate)o2);
		}

		public void Vpcmpistri(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpcmpistri, o0, o1, o2);
		}

		public void Vpcmpistri(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpcmpistri, o0, o1, (Immediate)o2);
		}

		public void Vpcmpistri(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpcmpistri, o0, o1, (Immediate)o2);
		}

		public void Vpcmpistri(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpcmpistri, o0, o1, o2);
		}

		public void Vpcmpistri(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpcmpistri, o0, o1, (Immediate)o2);
		}

		public void Vpcmpistri(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpcmpistri, o0, o1, (Immediate)o2);
		}

		public void Vpcmpistrm(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpcmpistrm, o0, o1, o2);
		}

		public void Vpcmpistrm(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpcmpistrm, o0, o1, (Immediate)o2);
		}

		public void Vpcmpistrm(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpcmpistrm, o0, o1, (Immediate)o2);
		}

		public void Vpcmpistrm(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpcmpistrm, o0, o1, o2);
		}

		public void Vpcmpistrm(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpcmpistrm, o0, o1, (Immediate)o2);
		}

		public void Vpcmpistrm(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpcmpistrm, o0, o1, (Immediate)o2);
		}

		public void Vpermilpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, o2);
		}

		public void Vpermilpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, o2);
		}

		public void Vpermilpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, o2);
		}

		public void Vpermilpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, o2);
		}

		public void Vpermilpd(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, o2);
		}

		public void Vpermilpd(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, (Immediate)o2);
		}

		public void Vpermilpd(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, (Immediate)o2);
		}

		public void Vpermilpd(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, o2);
		}

		public void Vpermilpd(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, (Immediate)o2);
		}

		public void Vpermilpd(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, (Immediate)o2);
		}

		public void Vpermilpd(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, o2);
		}

		public void Vpermilpd(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, (Immediate)o2);
		}

		public void Vpermilpd(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, (Immediate)o2);
		}

		public void Vpermilpd(YmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, o2);
		}

		public void Vpermilpd(YmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, (Immediate)o2);
		}

		public void Vpermilpd(YmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpermilpd, o0, o1, (Immediate)o2);
		}

		public void Vpermilps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, o2);
		}

		public void Vpermilps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, o2);
		}

		public void Vpermilps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, o2);
		}

		public void Vpermilps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, o2);
		}

		public void Vpermilps(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, o2);
		}

		public void Vpermilps(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, (Immediate)o2);
		}

		public void Vpermilps(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, (Immediate)o2);
		}

		public void Vpermilps(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, o2);
		}

		public void Vpermilps(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, (Immediate)o2);
		}

		public void Vpermilps(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, (Immediate)o2);
		}

		public void Vpermilps(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, o2);
		}

		public void Vpermilps(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, (Immediate)o2);
		}

		public void Vpermilps(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, (Immediate)o2);
		}

		public void Vpermilps(YmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, o2);
		}

		public void Vpermilps(YmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, (Immediate)o2);
		}

		public void Vpermilps(YmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpermilps, o0, o1, (Immediate)o2);
		}

		public void Vperm2f128(YmmRegister o0, YmmRegister o1, YmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vperm2f128, o0, o1, o2, o3);
		}

		public void Vperm2f128(YmmRegister o0, YmmRegister o1, YmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vperm2f128, o0, o1, o2, (Immediate)o3);
		}

		public void Vperm2f128(YmmRegister o0, YmmRegister o1, YmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vperm2f128, o0, o1, o2, (Immediate)o3);
		}

		public void Vperm2f128(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vperm2f128, o0, o1, o2, o3);
		}

		public void Vperm2f128(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vperm2f128, o0, o1, o2, (Immediate)o3);
		}

		public void Vperm2f128(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vperm2f128, o0, o1, o2, (Immediate)o3);
		}

		public void Vpextrb(GpRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpextrb, o0, o1, o2);
		}

		public void Vpextrb(GpRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpextrb, o0, o1, (Immediate)o2);
		}

		public void Vpextrb(GpRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpextrb, o0, o1, (Immediate)o2);
		}

		public void Vpextrb(Memory o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpextrb, o0, o1, o2);
		}

		public void Vpextrb(Memory o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpextrb, o0, o1, (Immediate)o2);
		}

		public void Vpextrb(Memory o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpextrb, o0, o1, (Immediate)o2);
		}

		public void Vpextrd(GpRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpextrd, o0, o1, o2);
		}

		public void Vpextrd(GpRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpextrd, o0, o1, (Immediate)o2);
		}

		public void Vpextrd(GpRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpextrd, o0, o1, (Immediate)o2);
		}

		public void Vpextrd(Memory o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpextrd, o0, o1, o2);
		}

		public void Vpextrd(Memory o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpextrd, o0, o1, (Immediate)o2);
		}

		public void Vpextrd(Memory o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpextrd, o0, o1, (Immediate)o2);
		}

		public void Vpextrq(GpRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpextrq, o0, o1, o2);
		}

		public void Vpextrq(GpRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpextrq, o0, o1, (Immediate)o2);
		}

		public void Vpextrq(GpRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpextrq, o0, o1, (Immediate)o2);
		}

		public void Vpextrq(Memory o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpextrq, o0, o1, o2);
		}

		public void Vpextrq(Memory o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpextrq, o0, o1, (Immediate)o2);
		}

		public void Vpextrq(Memory o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpextrq, o0, o1, (Immediate)o2);
		}

		public void Vpextrw(GpRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpextrw, o0, o1, o2);
		}

		public void Vpextrw(GpRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpextrw, o0, o1, (Immediate)o2);
		}

		public void Vpextrw(GpRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpextrw, o0, o1, (Immediate)o2);
		}

		public void Vpextrw(Memory o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpextrw, o0, o1, o2);
		}

		public void Vpextrw(Memory o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpextrw, o0, o1, (Immediate)o2);
		}

		public void Vpextrw(Memory o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpextrw, o0, o1, (Immediate)o2);
		}

		public void Vphaddd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vphaddd, o0, o1, o2);
		}

		public void Vphaddd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vphaddd, o0, o1, o2);
		}

		public void Vphaddsw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vphaddsw, o0, o1, o2);
		}

		public void Vphaddsw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vphaddsw, o0, o1, o2);
		}

		public void Vphaddw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vphaddw, o0, o1, o2);
		}

		public void Vphaddw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vphaddw, o0, o1, o2);
		}

		public void Vphminposuw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphminposuw, o0, o1);
		}

		public void Vphminposuw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphminposuw, o0, o1);
		}

		public void Vphsubd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vphsubd, o0, o1, o2);
		}

		public void Vphsubd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vphsubd, o0, o1, o2);
		}

		public void Vphsubsw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vphsubsw, o0, o1, o2);
		}

		public void Vphsubsw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vphsubsw, o0, o1, o2);
		}

		public void Vphsubw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vphsubw, o0, o1, o2);
		}

		public void Vphsubw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vphsubw, o0, o1, o2);
		}

		public void Vpinsrb(XmmRegister o0, XmmRegister o1, GpRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpinsrb, o0, o1, o2, o3);
		}

		public void Vpinsrb(XmmRegister o0, XmmRegister o1, GpRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpinsrb, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrb(XmmRegister o0, XmmRegister o1, GpRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpinsrb, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrb(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpinsrb, o0, o1, o2, o3);
		}

		public void Vpinsrb(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpinsrb, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrb(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpinsrb, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrd(XmmRegister o0, XmmRegister o1, GpRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpinsrd, o0, o1, o2, o3);
		}

		public void Vpinsrd(XmmRegister o0, XmmRegister o1, GpRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpinsrd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrd(XmmRegister o0, XmmRegister o1, GpRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpinsrd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrd(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpinsrd, o0, o1, o2, o3);
		}

		public void Vpinsrd(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpinsrd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrd(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpinsrd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrq(XmmRegister o0, XmmRegister o1, GpRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpinsrq, o0, o1, o2, o3);
		}

		public void Vpinsrq(XmmRegister o0, XmmRegister o1, GpRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpinsrq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrq(XmmRegister o0, XmmRegister o1, GpRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpinsrq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrq(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpinsrq, o0, o1, o2, o3);
		}

		public void Vpinsrq(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpinsrq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrq(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpinsrq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrw(XmmRegister o0, XmmRegister o1, GpRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpinsrw, o0, o1, o2, o3);
		}

		public void Vpinsrw(XmmRegister o0, XmmRegister o1, GpRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpinsrw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrw(XmmRegister o0, XmmRegister o1, GpRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpinsrw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrw(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpinsrw, o0, o1, o2, o3);
		}

		public void Vpinsrw(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpinsrw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpinsrw(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpinsrw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpmaddubsw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaddubsw, o0, o1, o2);
		}

		public void Vpmaddubsw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaddubsw, o0, o1, o2);
		}

		public void Vpmaddwd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaddwd, o0, o1, o2);
		}

		public void Vpmaddwd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaddwd, o0, o1, o2);
		}

		public void Vpmaxsb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaxsb, o0, o1, o2);
		}

		public void Vpmaxsb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaxsb, o0, o1, o2);
		}

		public void Vpmaxsd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaxsd, o0, o1, o2);
		}

		public void Vpmaxsd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaxsd, o0, o1, o2);
		}

		public void Vpmaxsw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaxsw, o0, o1, o2);
		}

		public void Vpmaxsw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaxsw, o0, o1, o2);
		}

		public void Vpmaxub(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaxub, o0, o1, o2);
		}

		public void Vpmaxub(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaxub, o0, o1, o2);
		}

		public void Vpmaxud(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaxud, o0, o1, o2);
		}

		public void Vpmaxud(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaxud, o0, o1, o2);
		}

		public void Vpmaxuw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaxuw, o0, o1, o2);
		}

		public void Vpmaxuw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaxuw, o0, o1, o2);
		}

		public void Vpminsb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpminsb, o0, o1, o2);
		}

		public void Vpminsb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpminsb, o0, o1, o2);
		}

		public void Vpminsd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpminsd, o0, o1, o2);
		}

		public void Vpminsd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpminsd, o0, o1, o2);
		}

		public void Vpminsw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpminsw, o0, o1, o2);
		}

		public void Vpminsw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpminsw, o0, o1, o2);
		}

		public void Vpminub(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpminub, o0, o1, o2);
		}

		public void Vpminub(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpminub, o0, o1, o2);
		}

		public void Vpminud(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpminud, o0, o1, o2);
		}

		public void Vpminud(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpminud, o0, o1, o2);
		}

		public void Vpminuw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpminuw, o0, o1, o2);
		}

		public void Vpminuw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpminuw, o0, o1, o2);
		}

		public void Vpmovmskb(GpRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovmskb, o0, o1);
		}

		public void Vpmovsxbd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxbd, o0, o1);
		}

		public void Vpmovsxbd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxbd, o0, o1);
		}

		public void Vpmovsxbq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxbq, o0, o1);
		}

		public void Vpmovsxbq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxbq, o0, o1);
		}

		public void Vpmovsxbw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxbw, o0, o1);
		}

		public void Vpmovsxbw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxbw, o0, o1);
		}

		public void Vpmovsxdq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxdq, o0, o1);
		}

		public void Vpmovsxdq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxdq, o0, o1);
		}

		public void Vpmovsxwd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxwd, o0, o1);
		}

		public void Vpmovsxwd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxwd, o0, o1);
		}

		public void Vpmovsxwq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxwq, o0, o1);
		}

		public void Vpmovsxwq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxwq, o0, o1);
		}

		public void Vpmovzxbd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxbd, o0, o1);
		}

		public void Vpmovzxbd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxbd, o0, o1);
		}

		public void Vpmovzxbq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxbq, o0, o1);
		}

		public void Vpmovzxbq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxbq, o0, o1);
		}

		public void Vpmovzxbw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxbw, o0, o1);
		}

		public void Vpmovzxbw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxbw, o0, o1);
		}

		public void Vpmovzxdq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxdq, o0, o1);
		}

		public void Vpmovzxdq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxdq, o0, o1);
		}

		public void Vpmovzxwd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxwd, o0, o1);
		}

		public void Vpmovzxwd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxwd, o0, o1);
		}

		public void Vpmovzxwq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxwq, o0, o1);
		}

		public void Vpmovzxwq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxwq, o0, o1);
		}

		public void Vpmuldq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmuldq, o0, o1, o2);
		}

		public void Vpmuldq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmuldq, o0, o1, o2);
		}

		public void Vpmulhrsw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmulhrsw, o0, o1, o2);
		}

		public void Vpmulhrsw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmulhrsw, o0, o1, o2);
		}

		public void Vpmulhuw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmulhuw, o0, o1, o2);
		}

		public void Vpmulhuw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmulhuw, o0, o1, o2);
		}

		public void Vpmulhw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmulhw, o0, o1, o2);
		}

		public void Vpmulhw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmulhw, o0, o1, o2);
		}

		public void Vpmulld(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmulld, o0, o1, o2);
		}

		public void Vpmulld(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmulld, o0, o1, o2);
		}

		public void Vpmullw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmullw, o0, o1, o2);
		}

		public void Vpmullw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmullw, o0, o1, o2);
		}

		public void Vpmuludq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmuludq, o0, o1, o2);
		}

		public void Vpmuludq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmuludq, o0, o1, o2);
		}

		public void Vpor(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpor, o0, o1, o2);
		}

		public void Vpor(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpor, o0, o1, o2);
		}

		public void Vpsadbw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsadbw, o0, o1, o2);
		}

		public void Vpsadbw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsadbw, o0, o1, o2);
		}

		public void Vpshufb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshufb, o0, o1, o2);
		}

		public void Vpshufb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpshufb, o0, o1, o2);
		}

		public void Vpshufd(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpshufd, o0, o1, o2);
		}

		public void Vpshufd(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpshufd, o0, o1, (Immediate)o2);
		}

		public void Vpshufd(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpshufd, o0, o1, (Immediate)o2);
		}

		public void Vpshufd(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpshufd, o0, o1, o2);
		}

		public void Vpshufd(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpshufd, o0, o1, (Immediate)o2);
		}

		public void Vpshufd(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpshufd, o0, o1, (Immediate)o2);
		}

		public void Vpshufhw(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpshufhw, o0, o1, o2);
		}

		public void Vpshufhw(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpshufhw, o0, o1, (Immediate)o2);
		}

		public void Vpshufhw(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpshufhw, o0, o1, (Immediate)o2);
		}

		public void Vpshufhw(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpshufhw, o0, o1, o2);
		}

		public void Vpshufhw(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpshufhw, o0, o1, (Immediate)o2);
		}

		public void Vpshufhw(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpshufhw, o0, o1, (Immediate)o2);
		}

		public void Vpshuflw(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpshuflw, o0, o1, o2);
		}

		public void Vpshuflw(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpshuflw, o0, o1, (Immediate)o2);
		}

		public void Vpshuflw(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpshuflw, o0, o1, (Immediate)o2);
		}

		public void Vpshuflw(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpshuflw, o0, o1, o2);
		}

		public void Vpshuflw(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpshuflw, o0, o1, (Immediate)o2);
		}

		public void Vpshuflw(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpshuflw, o0, o1, (Immediate)o2);
		}

		public void Vpsignb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsignb, o0, o1, o2);
		}

		public void Vpsignb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsignb, o0, o1, o2);
		}

		public void Vpsignd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsignd, o0, o1, o2);
		}

		public void Vpsignd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsignd, o0, o1, o2);
		}

		public void Vpsignw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsignw, o0, o1, o2);
		}

		public void Vpsignw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsignw, o0, o1, o2);
		}

		public void Vpslld(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpslld, o0, o1, o2);
		}

		public void Vpslld(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpslld, o0, o1, o2);
		}

		public void Vpslld(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpslld, o0, o1, o2);
		}

		public void Vpslld(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpslld, o0, o1, (Immediate)o2);
		}

		public void Vpslld(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpslld, o0, o1, (Immediate)o2);
		}

		public void Vpslldq(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpslldq, o0, o1, o2);
		}

		public void Vpslldq(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpslldq, o0, o1, (Immediate)o2);
		}

		public void Vpslldq(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpslldq, o0, o1, (Immediate)o2);
		}

		public void Vpsllq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsllq, o0, o1, o2);
		}

		public void Vpsllq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsllq, o0, o1, o2);
		}

		public void Vpsllq(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsllq, o0, o1, o2);
		}

		public void Vpsllq(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsllq, o0, o1, (Immediate)o2);
		}

		public void Vpsllq(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsllq, o0, o1, (Immediate)o2);
		}

		public void Vpsllw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsllw, o0, o1, o2);
		}

		public void Vpsllw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsllw, o0, o1, o2);
		}

		public void Vpsllw(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsllw, o0, o1, o2);
		}

		public void Vpsllw(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsllw, o0, o1, (Immediate)o2);
		}

		public void Vpsllw(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsllw, o0, o1, (Immediate)o2);
		}

		public void Vpsrad(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsrad, o0, o1, o2);
		}

		public void Vpsrad(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsrad, o0, o1, o2);
		}

		public void Vpsrad(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsrad, o0, o1, o2);
		}

		public void Vpsrad(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsrad, o0, o1, (Immediate)o2);
		}

		public void Vpsrad(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsrad, o0, o1, (Immediate)o2);
		}

		public void Vpsraw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsraw, o0, o1, o2);
		}

		public void Vpsraw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsraw, o0, o1, o2);
		}

		public void Vpsraw(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsraw, o0, o1, o2);
		}

		public void Vpsraw(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsraw, o0, o1, (Immediate)o2);
		}

		public void Vpsraw(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsraw, o0, o1, (Immediate)o2);
		}

		public void Vpsrld(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsrld, o0, o1, o2);
		}

		public void Vpsrld(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsrld, o0, o1, o2);
		}

		public void Vpsrld(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsrld, o0, o1, o2);
		}

		public void Vpsrld(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsrld, o0, o1, (Immediate)o2);
		}

		public void Vpsrld(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsrld, o0, o1, (Immediate)o2);
		}

		public void Vpsrldq(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsrldq, o0, o1, o2);
		}

		public void Vpsrldq(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsrldq, o0, o1, (Immediate)o2);
		}

		public void Vpsrldq(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsrldq, o0, o1, (Immediate)o2);
		}

		public void Vpsrlq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsrlq, o0, o1, o2);
		}

		public void Vpsrlq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsrlq, o0, o1, o2);
		}

		public void Vpsrlq(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsrlq, o0, o1, o2);
		}

		public void Vpsrlq(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsrlq, o0, o1, (Immediate)o2);
		}

		public void Vpsrlq(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsrlq, o0, o1, (Immediate)o2);
		}

		public void Vpsrlw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsrlw, o0, o1, o2);
		}

		public void Vpsrlw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsrlw, o0, o1, o2);
		}

		public void Vpsrlw(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsrlw, o0, o1, o2);
		}

		public void Vpsrlw(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsrlw, o0, o1, (Immediate)o2);
		}

		public void Vpsrlw(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsrlw, o0, o1, (Immediate)o2);
		}

		public void Vpsubb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubb, o0, o1, o2);
		}

		public void Vpsubb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubb, o0, o1, o2);
		}

		public void Vpsubd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubd, o0, o1, o2);
		}

		public void Vpsubd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubd, o0, o1, o2);
		}

		public void Vpsubq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubq, o0, o1, o2);
		}

		public void Vpsubq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubq, o0, o1, o2);
		}

		public void Vpsubw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubw, o0, o1, o2);
		}

		public void Vpsubw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubw, o0, o1, o2);
		}

		public void Vpsubsb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubsb, o0, o1, o2);
		}

		public void Vpsubsb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubsb, o0, o1, o2);
		}

		public void Vpsubsw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubsw, o0, o1, o2);
		}

		public void Vpsubsw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubsw, o0, o1, o2);
		}

		public void Vpsubusb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubusb, o0, o1, o2);
		}

		public void Vpsubusb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubusb, o0, o1, o2);
		}

		public void Vpsubusw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubusw, o0, o1, o2);
		}

		public void Vpsubusw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubusw, o0, o1, o2);
		}

		public void Vptest(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vptest, o0, o1);
		}

		public void Vptest(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vptest, o0, o1);
		}

		public void Vptest(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vptest, o0, o1);
		}

		public void Vptest(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vptest, o0, o1);
		}

		public void Vpunpckhbw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhbw, o0, o1, o2);
		}

		public void Vpunpckhbw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhbw, o0, o1, o2);
		}

		public void Vpunpckhdq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhdq, o0, o1, o2);
		}

		public void Vpunpckhdq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhdq, o0, o1, o2);
		}

		public void Vpunpckhqdq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhqdq, o0, o1, o2);
		}

		public void Vpunpckhqdq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhqdq, o0, o1, o2);
		}

		public void Vpunpckhwd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhwd, o0, o1, o2);
		}

		public void Vpunpckhwd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhwd, o0, o1, o2);
		}

		public void Vpunpcklbw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpcklbw, o0, o1, o2);
		}

		public void Vpunpcklbw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpcklbw, o0, o1, o2);
		}

		public void Vpunpckldq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpckldq, o0, o1, o2);
		}

		public void Vpunpckldq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpckldq, o0, o1, o2);
		}

		public void Vpunpcklqdq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpcklqdq, o0, o1, o2);
		}

		public void Vpunpcklqdq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpcklqdq, o0, o1, o2);
		}

		public void Vpunpcklwd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpcklwd, o0, o1, o2);
		}

		public void Vpunpcklwd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpcklwd, o0, o1, o2);
		}

		public void Vpxor(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpxor, o0, o1, o2);
		}

		public void Vpxor(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpxor, o0, o1, o2);
		}

		public void Vrcpps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vrcpps, o0, o1);
		}

		public void Vrcpps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vrcpps, o0, o1);
		}

		public void Vrcpps(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vrcpps, o0, o1);
		}

		public void Vrcpps(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vrcpps, o0, o1);
		}

		public void Vrcpss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vrcpss, o0, o1, o2);
		}

		public void Vrcpss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vrcpss, o0, o1, o2);
		}

		public void Vrsqrtps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vrsqrtps, o0, o1);
		}

		public void Vrsqrtps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vrsqrtps, o0, o1);
		}

		public void Vrsqrtps(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vrsqrtps, o0, o1);
		}

		public void Vrsqrtps(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vrsqrtps, o0, o1);
		}

		public void Vrsqrtss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vrsqrtss, o0, o1, o2);
		}

		public void Vrsqrtss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vrsqrtss, o0, o1, o2);
		}

		public void Vroundpd(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vroundpd, o0, o1, o2);
		}

		public void Vroundpd(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vroundpd, o0, o1, (Immediate)o2);
		}

		public void Vroundpd(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vroundpd, o0, o1, (Immediate)o2);
		}

		public void Vroundpd(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vroundpd, o0, o1, o2);
		}

		public void Vroundpd(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vroundpd, o0, o1, (Immediate)o2);
		}

		public void Vroundpd(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vroundpd, o0, o1, (Immediate)o2);
		}

		public void Vroundpd(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vroundpd, o0, o1, o2);
		}

		public void Vroundpd(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vroundpd, o0, o1, (Immediate)o2);
		}

		public void Vroundpd(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vroundpd, o0, o1, (Immediate)o2);
		}

		public void Vroundpd(YmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vroundpd, o0, o1, o2);
		}

		public void Vroundpd(YmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vroundpd, o0, o1, (Immediate)o2);
		}

		public void Vroundpd(YmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vroundpd, o0, o1, (Immediate)o2);
		}

		public void Vroundps(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vroundps, o0, o1, o2);
		}

		public void Vroundps(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vroundps, o0, o1, (Immediate)o2);
		}

		public void Vroundps(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vroundps, o0, o1, (Immediate)o2);
		}

		public void Vroundps(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vroundps, o0, o1, o2);
		}

		public void Vroundps(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vroundps, o0, o1, (Immediate)o2);
		}

		public void Vroundps(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vroundps, o0, o1, (Immediate)o2);
		}

		public void Vroundps(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vroundps, o0, o1, o2);
		}

		public void Vroundps(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vroundps, o0, o1, (Immediate)o2);
		}

		public void Vroundps(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vroundps, o0, o1, (Immediate)o2);
		}

		public void Vroundps(YmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vroundps, o0, o1, o2);
		}

		public void Vroundps(YmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vroundps, o0, o1, (Immediate)o2);
		}

		public void Vroundps(YmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vroundps, o0, o1, (Immediate)o2);
		}

		public void Vroundsd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vroundsd, o0, o1, o2, o3);
		}

		public void Vroundsd(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vroundsd, o0, o1, o2, (Immediate)o3);
		}

		public void Vroundsd(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vroundsd, o0, o1, o2, (Immediate)o3);
		}

		public void Vroundsd(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vroundsd, o0, o1, o2, o3);
		}

		public void Vroundsd(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vroundsd, o0, o1, o2, (Immediate)o3);
		}

		public void Vroundsd(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vroundsd, o0, o1, o2, (Immediate)o3);
		}

		public void Vroundss(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vroundss, o0, o1, o2, o3);
		}

		public void Vroundss(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vroundss, o0, o1, o2, (Immediate)o3);
		}

		public void Vroundss(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vroundss, o0, o1, o2, (Immediate)o3);
		}

		public void Vroundss(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vroundss, o0, o1, o2, o3);
		}

		public void Vroundss(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vroundss, o0, o1, o2, (Immediate)o3);
		}

		public void Vroundss(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vroundss, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vshufpd, o0, o1, o2, o3);
		}

		public void Vshufpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vshufpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vshufpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufpd(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vshufpd, o0, o1, o2, o3);
		}

		public void Vshufpd(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vshufpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufpd(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vshufpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vshufpd, o0, o1, o2, o3);
		}

		public void Vshufpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vshufpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vshufpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufpd(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vshufpd, o0, o1, o2, o3);
		}

		public void Vshufpd(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vshufpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufpd(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vshufpd, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufps(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vshufps, o0, o1, o2, o3);
		}

		public void Vshufps(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vshufps, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufps(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vshufps, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufps(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vshufps, o0, o1, o2, o3);
		}

		public void Vshufps(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vshufps, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufps(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vshufps, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufps(YmmRegister o0, YmmRegister o1, YmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vshufps, o0, o1, o2, o3);
		}

		public void Vshufps(YmmRegister o0, YmmRegister o1, YmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vshufps, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufps(YmmRegister o0, YmmRegister o1, YmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vshufps, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufps(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vshufps, o0, o1, o2, o3);
		}

		public void Vshufps(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vshufps, o0, o1, o2, (Immediate)o3);
		}

		public void Vshufps(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vshufps, o0, o1, o2, (Immediate)o3);
		}

		public void Vsqrtpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vsqrtpd, o0, o1);
		}

		public void Vsqrtpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vsqrtpd, o0, o1);
		}

		public void Vsqrtpd(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vsqrtpd, o0, o1);
		}

		public void Vsqrtpd(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vsqrtpd, o0, o1);
		}

		public void Vsqrtps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vsqrtps, o0, o1);
		}

		public void Vsqrtps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vsqrtps, o0, o1);
		}

		public void Vsqrtps(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vsqrtps, o0, o1);
		}

		public void Vsqrtps(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vsqrtps, o0, o1);
		}

		public void Vsqrtsd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vsqrtsd, o0, o1, o2);
		}

		public void Vsqrtsd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vsqrtsd, o0, o1, o2);
		}

		public void Vsqrtss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vsqrtss, o0, o1, o2);
		}

		public void Vsqrtss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vsqrtss, o0, o1, o2);
		}

		public void Vstmxcsr(Memory o0)
		{
			Assembler.Emit(InstructionId.Vstmxcsr, o0);
		}

		public void Vsubpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vsubpd, o0, o1, o2);
		}

		public void Vsubpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vsubpd, o0, o1, o2);
		}

		public void Vsubpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vsubpd, o0, o1, o2);
		}

		public void Vsubpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vsubpd, o0, o1, o2);
		}

		public void Vsubps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vsubps, o0, o1, o2);
		}

		public void Vsubps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vsubps, o0, o1, o2);
		}

		public void Vsubps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vsubps, o0, o1, o2);
		}

		public void Vsubps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vsubps, o0, o1, o2);
		}

		public void Vsubsd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vsubsd, o0, o1, o2);
		}

		public void Vsubsd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vsubsd, o0, o1, o2);
		}

		public void Vsubss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vsubss, o0, o1, o2);
		}

		public void Vsubss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vsubss, o0, o1, o2);
		}

		public void Vtestpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vtestpd, o0, o1);
		}

		public void Vtestpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vtestpd, o0, o1);
		}

		public void Vtestpd(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vtestpd, o0, o1);
		}

		public void Vtestpd(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vtestpd, o0, o1);
		}

		public void Vtestps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vtestps, o0, o1);
		}

		public void Vtestps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vtestps, o0, o1);
		}

		public void Vtestps(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vtestps, o0, o1);
		}

		public void Vtestps(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vtestps, o0, o1);
		}

		public void Vucomisd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vucomisd, o0, o1);
		}

		public void Vucomisd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vucomisd, o0, o1);
		}

		public void Vucomiss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vucomiss, o0, o1);
		}

		public void Vucomiss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vucomiss, o0, o1);
		}

		public void Vunpckhpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vunpckhpd, o0, o1, o2);
		}

		public void Vunpckhpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vunpckhpd, o0, o1, o2);
		}

		public void Vunpckhpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vunpckhpd, o0, o1, o2);
		}

		public void Vunpckhpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vunpckhpd, o0, o1, o2);
		}

		public void Vunpckhps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vunpckhps, o0, o1, o2);
		}

		public void Vunpckhps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vunpckhps, o0, o1, o2);
		}

		public void Vunpckhps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vunpckhps, o0, o1, o2);
		}

		public void Vunpckhps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vunpckhps, o0, o1, o2);
		}

		public void Vunpcklpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vunpcklpd, o0, o1, o2);
		}

		public void Vunpcklpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vunpcklpd, o0, o1, o2);
		}

		public void Vunpcklpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vunpcklpd, o0, o1, o2);
		}

		public void Vunpcklpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vunpcklpd, o0, o1, o2);
		}

		public void Vunpcklps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vunpcklps, o0, o1, o2);
		}

		public void Vunpcklps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vunpcklps, o0, o1, o2);
		}

		public void Vunpcklps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vunpcklps, o0, o1, o2);
		}

		public void Vunpcklps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vunpcklps, o0, o1, o2);
		}

		public void Vxorpd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vxorpd, o0, o1, o2);
		}

		public void Vxorpd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vxorpd, o0, o1, o2);
		}

		public void Vxorpd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vxorpd, o0, o1, o2);
		}

		public void Vxorpd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vxorpd, o0, o1, o2);
		}

		public void Vxorps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vxorps, o0, o1, o2);
		}

		public void Vxorps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vxorps, o0, o1, o2);
		}

		public void Vxorps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vxorps, o0, o1, o2);
		}

		public void Vxorps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vxorps, o0, o1, o2);
		}

		public void Vzeroall()
		{
			Assembler.Emit(InstructionId.Vzeroall);
		}

		public void Vzeroupper()
		{
			Assembler.Emit(InstructionId.Vzeroupper);
		}

		public void Vaesdec(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vaesdec, o0, o1, o2);
		}

		public void Vaesdec(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vaesdec, o0, o1, o2);
		}

		public void Vaesdeclast(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vaesdeclast, o0, o1, o2);
		}

		public void Vaesdeclast(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vaesdeclast, o0, o1, o2);
		}

		public void Vaesenc(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vaesenc, o0, o1, o2);
		}

		public void Vaesenc(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vaesenc, o0, o1, o2);
		}

		public void Vaesenclast(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vaesenclast, o0, o1, o2);
		}

		public void Vaesenclast(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vaesenclast, o0, o1, o2);
		}

		public void Vaesimc(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vaesimc, o0, o1);
		}

		public void Vaesimc(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vaesimc, o0, o1);
		}

		public void Vaeskeygenassist(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vaeskeygenassist, o0, o1, o2);
		}

		public void Vaeskeygenassist(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vaeskeygenassist, o0, o1, (Immediate)o2);
		}

		public void Vaeskeygenassist(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vaeskeygenassist, o0, o1, (Immediate)o2);
		}

		public void Vaeskeygenassist(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vaeskeygenassist, o0, o1, o2);
		}

		public void Vaeskeygenassist(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vaeskeygenassist, o0, o1, (Immediate)o2);
		}

		public void Vaeskeygenassist(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vaeskeygenassist, o0, o1, (Immediate)o2);
		}

		public void Vpclmulqdq(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpclmulqdq, o0, o1, o2, o3);
		}

		public void Vpclmulqdq(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpclmulqdq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpclmulqdq(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpclmulqdq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpclmulqdq(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpclmulqdq, o0, o1, o2, o3);
		}

		public void Vpclmulqdq(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpclmulqdq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpclmulqdq(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpclmulqdq, o0, o1, o2, (Immediate)o3);
		}

		public void Vbroadcasti128(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vbroadcasti128, o0, o1);
		}

		public void Vbroadcastsd(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vbroadcastsd, o0, o1);
		}

		public void Vbroadcastss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vbroadcastss, o0, o1);
		}

		public void Vbroadcastss(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vbroadcastss, o0, o1);
		}

		public void Vextracti128(XmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vextracti128, o0, o1, o2);
		}

		public void Vextracti128(XmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vextracti128, o0, o1, (Immediate)o2);
		}

		public void Vextracti128(XmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vextracti128, o0, o1, (Immediate)o2);
		}

		public void Vextracti128(Memory o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vextracti128, o0, o1, o2);
		}

		public void Vextracti128(Memory o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vextracti128, o0, o1, (Immediate)o2);
		}

		public void Vextracti128(Memory o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vextracti128, o0, o1, (Immediate)o2);
		}

		public void Vgatherdpd(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vgatherdpd, o0, o1, o2);
		}

		public void Vgatherdpd(YmmRegister o0, Memory o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vgatherdpd, o0, o1, o2);
		}

		public void Vgatherdps(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vgatherdps, o0, o1, o2);
		}

		public void Vgatherdps(YmmRegister o0, Memory o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vgatherdps, o0, o1, o2);
		}

		public void Vgatherqpd(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vgatherqpd, o0, o1, o2);
		}

		public void Vgatherqpd(YmmRegister o0, Memory o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vgatherqpd, o0, o1, o2);
		}

		public void Vgatherqps(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vgatherqps, o0, o1, o2);
		}

		public void Vinserti128(YmmRegister o0, YmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vinserti128, o0, o1, o2, o3);
		}

		public void Vinserti128(YmmRegister o0, YmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vinserti128, o0, o1, o2, (Immediate)o3);
		}

		public void Vinserti128(YmmRegister o0, YmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vinserti128, o0, o1, o2, (Immediate)o3);
		}

		public void Vinserti128(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vinserti128, o0, o1, o2, o3);
		}

		public void Vinserti128(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vinserti128, o0, o1, o2, (Immediate)o3);
		}

		public void Vinserti128(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vinserti128, o0, o1, o2, (Immediate)o3);
		}

		public void Vmovntdqa(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vmovntdqa, o0, o1);
		}

		public void Vmpsadbw(YmmRegister o0, YmmRegister o1, YmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vmpsadbw, o0, o1, o2, o3);
		}

		public void Vmpsadbw(YmmRegister o0, YmmRegister o1, YmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vmpsadbw, o0, o1, o2, (Immediate)o3);
		}

		public void Vmpsadbw(YmmRegister o0, YmmRegister o1, YmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vmpsadbw, o0, o1, o2, (Immediate)o3);
		}

		public void Vmpsadbw(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vmpsadbw, o0, o1, o2, o3);
		}

		public void Vmpsadbw(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vmpsadbw, o0, o1, o2, (Immediate)o3);
		}

		public void Vmpsadbw(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vmpsadbw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpabsb(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpabsb, o0, o1);
		}

		public void Vpabsb(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpabsb, o0, o1);
		}

		public void Vpabsd(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpabsd, o0, o1);
		}

		public void Vpabsd(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpabsd, o0, o1);
		}

		public void Vpabsw(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpabsw, o0, o1);
		}

		public void Vpabsw(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpabsw, o0, o1);
		}

		public void Vpackssdw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpackssdw, o0, o1, o2);
		}

		public void Vpackssdw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpackssdw, o0, o1, o2);
		}

		public void Vpacksswb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpacksswb, o0, o1, o2);
		}

		public void Vpacksswb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpacksswb, o0, o1, o2);
		}

		public void Vpackusdw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpackusdw, o0, o1, o2);
		}

		public void Vpackusdw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpackusdw, o0, o1, o2);
		}

		public void Vpackuswb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpackuswb, o0, o1, o2);
		}

		public void Vpackuswb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpackuswb, o0, o1, o2);
		}

		public void Vpaddb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddb, o0, o1, o2);
		}

		public void Vpaddb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddb, o0, o1, o2);
		}

		public void Vpaddd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddd, o0, o1, o2);
		}

		public void Vpaddd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddd, o0, o1, o2);
		}

		public void Vpaddq(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddq, o0, o1, o2);
		}

		public void Vpaddq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddq, o0, o1, o2);
		}

		public void Vpaddw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddw, o0, o1, o2);
		}

		public void Vpaddw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddw, o0, o1, o2);
		}

		public void Vpaddsb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddsb, o0, o1, o2);
		}

		public void Vpaddsb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddsb, o0, o1, o2);
		}

		public void Vpaddsw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddsw, o0, o1, o2);
		}

		public void Vpaddsw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddsw, o0, o1, o2);
		}

		public void Vpaddusb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddusb, o0, o1, o2);
		}

		public void Vpaddusb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddusb, o0, o1, o2);
		}

		public void Vpaddusw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpaddusw, o0, o1, o2);
		}

		public void Vpaddusw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpaddusw, o0, o1, o2);
		}

		public void Vpalignr(YmmRegister o0, YmmRegister o1, YmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpalignr, o0, o1, o2, o3);
		}

		public void Vpalignr(YmmRegister o0, YmmRegister o1, YmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpalignr, o0, o1, o2, (Immediate)o3);
		}

		public void Vpalignr(YmmRegister o0, YmmRegister o1, YmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpalignr, o0, o1, o2, (Immediate)o3);
		}

		public void Vpalignr(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpalignr, o0, o1, o2, o3);
		}

		public void Vpalignr(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpalignr, o0, o1, o2, (Immediate)o3);
		}

		public void Vpalignr(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpalignr, o0, o1, o2, (Immediate)o3);
		}

		public void Vpand(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpand, o0, o1, o2);
		}

		public void Vpand(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpand, o0, o1, o2);
		}

		public void Vpandn(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpandn, o0, o1, o2);
		}

		public void Vpandn(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpandn, o0, o1, o2);
		}

		public void Vpavgb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpavgb, o0, o1, o2);
		}

		public void Vpavgb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpavgb, o0, o1, o2);
		}

		public void Vpavgw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpavgw, o0, o1, o2);
		}

		public void Vpavgw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpavgw, o0, o1, o2);
		}

		public void Vpblendd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpblendd, o0, o1, o2, o3);
		}

		public void Vpblendd(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpblendd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpblendd(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpblendd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpblendd(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpblendd, o0, o1, o2, o3);
		}

		public void Vpblendd(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpblendd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpblendd(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpblendd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpblendd(YmmRegister o0, YmmRegister o1, YmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpblendd, o0, o1, o2, o3);
		}

		public void Vpblendd(YmmRegister o0, YmmRegister o1, YmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpblendd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpblendd(YmmRegister o0, YmmRegister o1, YmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpblendd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpblendd(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpblendd, o0, o1, o2, o3);
		}

		public void Vpblendd(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpblendd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpblendd(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpblendd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpblendvb(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpblendvb, o0, o1, o2, o3);
		}

		public void Vpblendvb(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpblendvb, o0, o1, o2, o3);
		}

		public void Vpblendw(YmmRegister o0, YmmRegister o1, YmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpblendw, o0, o1, o2, o3);
		}

		public void Vpblendw(YmmRegister o0, YmmRegister o1, YmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpblendw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpblendw(YmmRegister o0, YmmRegister o1, YmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpblendw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpblendw(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpblendw, o0, o1, o2, o3);
		}

		public void Vpblendw(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpblendw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpblendw(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpblendw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpbroadcastb(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastb, o0, o1);
		}

		public void Vpbroadcastb(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastb, o0, o1);
		}

		public void Vpbroadcastb(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastb, o0, o1);
		}

		public void Vpbroadcastb(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastb, o0, o1);
		}

		public void Vpbroadcastd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastd, o0, o1);
		}

		public void Vpbroadcastd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastd, o0, o1);
		}

		public void Vpbroadcastd(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastd, o0, o1);
		}

		public void Vpbroadcastd(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastd, o0, o1);
		}

		public void Vpbroadcastq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastq, o0, o1);
		}

		public void Vpbroadcastq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastq, o0, o1);
		}

		public void Vpbroadcastq(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastq, o0, o1);
		}

		public void Vpbroadcastq(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastq, o0, o1);
		}

		public void Vpbroadcastw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastw, o0, o1);
		}

		public void Vpbroadcastw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastw, o0, o1);
		}

		public void Vpbroadcastw(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastw, o0, o1);
		}

		public void Vpbroadcastw(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpbroadcastw, o0, o1);
		}

		public void Vpcmpeqb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqb, o0, o1, o2);
		}

		public void Vpcmpeqb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqb, o0, o1, o2);
		}

		public void Vpcmpeqd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqd, o0, o1, o2);
		}

		public void Vpcmpeqd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqd, o0, o1, o2);
		}

		public void Vpcmpeqq(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqq, o0, o1, o2);
		}

		public void Vpcmpeqq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqq, o0, o1, o2);
		}

		public void Vpcmpeqw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqw, o0, o1, o2);
		}

		public void Vpcmpeqw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpeqw, o0, o1, o2);
		}

		public void Vpcmpgtb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtb, o0, o1, o2);
		}

		public void Vpcmpgtb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtb, o0, o1, o2);
		}

		public void Vpcmpgtd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtd, o0, o1, o2);
		}

		public void Vpcmpgtd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtd, o0, o1, o2);
		}

		public void Vpcmpgtq(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtq, o0, o1, o2);
		}

		public void Vpcmpgtq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtq, o0, o1, o2);
		}

		public void Vpcmpgtw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtw, o0, o1, o2);
		}

		public void Vpcmpgtw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpcmpgtw, o0, o1, o2);
		}

		public void Vperm2i128(YmmRegister o0, YmmRegister o1, YmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vperm2i128, o0, o1, o2, o3);
		}

		public void Vperm2i128(YmmRegister o0, YmmRegister o1, YmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vperm2i128, o0, o1, o2, (Immediate)o3);
		}

		public void Vperm2i128(YmmRegister o0, YmmRegister o1, YmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vperm2i128, o0, o1, o2, (Immediate)o3);
		}

		public void Vperm2i128(YmmRegister o0, YmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vperm2i128, o0, o1, o2, o3);
		}

		public void Vperm2i128(YmmRegister o0, YmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vperm2i128, o0, o1, o2, (Immediate)o3);
		}

		public void Vperm2i128(YmmRegister o0, YmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vperm2i128, o0, o1, o2, (Immediate)o3);
		}

		public void Vpermd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpermd, o0, o1, o2);
		}

		public void Vpermd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpermd, o0, o1, o2);
		}

		public void Vpermpd(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpermpd, o0, o1, o2);
		}

		public void Vpermpd(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpermpd, o0, o1, (Immediate)o2);
		}

		public void Vpermpd(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpermpd, o0, o1, (Immediate)o2);
		}

		public void Vpermpd(YmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpermpd, o0, o1, o2);
		}

		public void Vpermpd(YmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpermpd, o0, o1, (Immediate)o2);
		}

		public void Vpermpd(YmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpermpd, o0, o1, (Immediate)o2);
		}

		public void Vpermps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpermps, o0, o1, o2);
		}

		public void Vpermps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpermps, o0, o1, o2);
		}

		public void Vpermq(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpermq, o0, o1, o2);
		}

		public void Vpermq(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpermq, o0, o1, (Immediate)o2);
		}

		public void Vpermq(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpermq, o0, o1, (Immediate)o2);
		}

		public void Vpermq(YmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpermq, o0, o1, o2);
		}

		public void Vpermq(YmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpermq, o0, o1, (Immediate)o2);
		}

		public void Vpermq(YmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpermq, o0, o1, (Immediate)o2);
		}

		public void Vpgatherdd(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpgatherdd, o0, o1, o2);
		}

		public void Vpgatherdd(YmmRegister o0, Memory o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpgatherdd, o0, o1, o2);
		}

		public void Vpgatherdq(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpgatherdq, o0, o1, o2);
		}

		public void Vpgatherdq(YmmRegister o0, Memory o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpgatherdq, o0, o1, o2);
		}

		public void Vpgatherqd(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpgatherqd, o0, o1, o2);
		}

		public void Vpgatherqq(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpgatherqq, o0, o1, o2);
		}

		public void Vpgatherqq(YmmRegister o0, Memory o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpgatherqq, o0, o1, o2);
		}

		public void Vphaddd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vphaddd, o0, o1, o2);
		}

		public void Vphaddd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vphaddd, o0, o1, o2);
		}

		public void Vphaddsw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vphaddsw, o0, o1, o2);
		}

		public void Vphaddsw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vphaddsw, o0, o1, o2);
		}

		public void Vphaddw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vphaddw, o0, o1, o2);
		}

		public void Vphaddw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vphaddw, o0, o1, o2);
		}

		public void Vphsubd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vphsubd, o0, o1, o2);
		}

		public void Vphsubd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vphsubd, o0, o1, o2);
		}

		public void Vphsubsw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vphsubsw, o0, o1, o2);
		}

		public void Vphsubsw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vphsubsw, o0, o1, o2);
		}

		public void Vphsubw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vphsubw, o0, o1, o2);
		}

		public void Vphsubw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vphsubw, o0, o1, o2);
		}

		public void Vpmovmskb(GpRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovmskb, o0, o1);
		}

		public void Vpmovsxbd(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxbd, o0, o1);
		}

		public void Vpmovsxbd(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxbd, o0, o1);
		}

		public void Vpmovsxbq(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxbq, o0, o1);
		}

		public void Vpmovsxbq(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxbq, o0, o1);
		}

		public void Vpmovsxbw(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxbw, o0, o1);
		}

		public void Vpmovsxbw(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxbw, o0, o1);
		}

		public void Vpmovsxdq(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxdq, o0, o1);
		}

		public void Vpmovsxdq(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxdq, o0, o1);
		}

		public void Vpmovsxwd(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxwd, o0, o1);
		}

		public void Vpmovsxwd(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxwd, o0, o1);
		}

		public void Vpmovsxwq(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxwq, o0, o1);
		}

		public void Vpmovsxwq(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovsxwq, o0, o1);
		}

		public void Vpmovzxbd(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxbd, o0, o1);
		}

		public void Vpmovzxbd(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxbd, o0, o1);
		}

		public void Vpmovzxbq(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxbq, o0, o1);
		}

		public void Vpmovzxbq(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxbq, o0, o1);
		}

		public void Vpmovzxbw(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxbw, o0, o1);
		}

		public void Vpmovzxbw(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxbw, o0, o1);
		}

		public void Vpmovzxdq(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxdq, o0, o1);
		}

		public void Vpmovzxdq(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxdq, o0, o1);
		}

		public void Vpmovzxwd(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxwd, o0, o1);
		}

		public void Vpmovzxwd(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxwd, o0, o1);
		}

		public void Vpmovzxwq(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxwq, o0, o1);
		}

		public void Vpmovzxwq(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vpmovzxwq, o0, o1);
		}

		public void Vpmaddubsw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaddubsw, o0, o1, o2);
		}

		public void Vpmaddubsw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaddubsw, o0, o1, o2);
		}

		public void Vpmaddwd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaddwd, o0, o1, o2);
		}

		public void Vpmaddwd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaddwd, o0, o1, o2);
		}

		public void Vpmaskmovd(Memory o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaskmovd, o0, o1, o2);
		}

		public void Vpmaskmovd(Memory o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaskmovd, o0, o1, o2);
		}

		public void Vpmaskmovd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaskmovd, o0, o1, o2);
		}

		public void Vpmaskmovd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaskmovd, o0, o1, o2);
		}

		public void Vpmaskmovq(Memory o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaskmovq, o0, o1, o2);
		}

		public void Vpmaskmovq(Memory o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaskmovq, o0, o1, o2);
		}

		public void Vpmaskmovq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaskmovq, o0, o1, o2);
		}

		public void Vpmaskmovq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaskmovq, o0, o1, o2);
		}

		public void Vpmaxsb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaxsb, o0, o1, o2);
		}

		public void Vpmaxsb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaxsb, o0, o1, o2);
		}

		public void Vpmaxsd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaxsd, o0, o1, o2);
		}

		public void Vpmaxsd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaxsd, o0, o1, o2);
		}

		public void Vpmaxsw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaxsw, o0, o1, o2);
		}

		public void Vpmaxsw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaxsw, o0, o1, o2);
		}

		public void Vpmaxub(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaxub, o0, o1, o2);
		}

		public void Vpmaxub(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaxub, o0, o1, o2);
		}

		public void Vpmaxud(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaxud, o0, o1, o2);
		}

		public void Vpmaxud(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaxud, o0, o1, o2);
		}

		public void Vpmaxuw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmaxuw, o0, o1, o2);
		}

		public void Vpmaxuw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmaxuw, o0, o1, o2);
		}

		public void Vpminsb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpminsb, o0, o1, o2);
		}

		public void Vpminsb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpminsb, o0, o1, o2);
		}

		public void Vpminsd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpminsd, o0, o1, o2);
		}

		public void Vpminsd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpminsd, o0, o1, o2);
		}

		public void Vpminsw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpminsw, o0, o1, o2);
		}

		public void Vpminsw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpminsw, o0, o1, o2);
		}

		public void Vpminub(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpminub, o0, o1, o2);
		}

		public void Vpminub(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpminub, o0, o1, o2);
		}

		public void Vpminud(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpminud, o0, o1, o2);
		}

		public void Vpminud(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpminud, o0, o1, o2);
		}

		public void Vpminuw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpminuw, o0, o1, o2);
		}

		public void Vpminuw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpminuw, o0, o1, o2);
		}

		public void Vpmuldq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmuldq, o0, o1, o2);
		}

		public void Vpmuldq(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmuldq, o0, o1, o2);
		}

		public void Vpmulhrsw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmulhrsw, o0, o1, o2);
		}

		public void Vpmulhrsw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmulhrsw, o0, o1, o2);
		}

		public void Vpmulhuw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmulhuw, o0, o1, o2);
		}

		public void Vpmulhuw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmulhuw, o0, o1, o2);
		}

		public void Vpmulhw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmulhw, o0, o1, o2);
		}

		public void Vpmulhw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmulhw, o0, o1, o2);
		}

		public void Vpmulld(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmulld, o0, o1, o2);
		}

		public void Vpmulld(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmulld, o0, o1, o2);
		}

		public void Vpmullw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmullw, o0, o1, o2);
		}

		public void Vpmullw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmullw, o0, o1, o2);
		}

		public void Vpmuludq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpmuludq, o0, o1, o2);
		}

		public void Vpmuludq(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpmuludq, o0, o1, o2);
		}

		public void Vpor(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpor, o0, o1, o2);
		}

		public void Vpor(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpor, o0, o1, o2);
		}

		public void Vpsadbw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsadbw, o0, o1, o2);
		}

		public void Vpsadbw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsadbw, o0, o1, o2);
		}

		public void Vpshufb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpshufb, o0, o1, o2);
		}

		public void Vpshufb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshufb, o0, o1, o2);
		}

		public void Vpshufd(YmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpshufd, o0, o1, o2);
		}

		public void Vpshufd(YmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpshufd, o0, o1, (Immediate)o2);
		}

		public void Vpshufd(YmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpshufd, o0, o1, (Immediate)o2);
		}

		public void Vpshufd(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpshufd, o0, o1, o2);
		}

		public void Vpshufd(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpshufd, o0, o1, (Immediate)o2);
		}

		public void Vpshufd(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpshufd, o0, o1, (Immediate)o2);
		}

		public void Vpshufhw(YmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpshufhw, o0, o1, o2);
		}

		public void Vpshufhw(YmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpshufhw, o0, o1, (Immediate)o2);
		}

		public void Vpshufhw(YmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpshufhw, o0, o1, (Immediate)o2);
		}

		public void Vpshufhw(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpshufhw, o0, o1, o2);
		}

		public void Vpshufhw(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpshufhw, o0, o1, (Immediate)o2);
		}

		public void Vpshufhw(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpshufhw, o0, o1, (Immediate)o2);
		}

		public void Vpshuflw(YmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpshuflw, o0, o1, o2);
		}

		public void Vpshuflw(YmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpshuflw, o0, o1, (Immediate)o2);
		}

		public void Vpshuflw(YmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpshuflw, o0, o1, (Immediate)o2);
		}

		public void Vpshuflw(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpshuflw, o0, o1, o2);
		}

		public void Vpshuflw(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpshuflw, o0, o1, (Immediate)o2);
		}

		public void Vpshuflw(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpshuflw, o0, o1, (Immediate)o2);
		}

		public void Vpsignb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsignb, o0, o1, o2);
		}

		public void Vpsignb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsignb, o0, o1, o2);
		}

		public void Vpsignd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsignd, o0, o1, o2);
		}

		public void Vpsignd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsignd, o0, o1, o2);
		}

		public void Vpsignw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsignw, o0, o1, o2);
		}

		public void Vpsignw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsignw, o0, o1, o2);
		}

		public void Vpslld(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpslld, o0, o1, o2);
		}

		public void Vpslld(YmmRegister o0, YmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpslld, o0, o1, o2);
		}

		public void Vpslld(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpslld, o0, o1, o2);
		}

		public void Vpslld(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpslld, o0, o1, (Immediate)o2);
		}

		public void Vpslld(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpslld, o0, o1, (Immediate)o2);
		}

		public void Vpslldq(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpslldq, o0, o1, o2);
		}

		public void Vpslldq(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpslldq, o0, o1, (Immediate)o2);
		}

		public void Vpslldq(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpslldq, o0, o1, (Immediate)o2);
		}

		public void Vpsllq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsllq, o0, o1, o2);
		}

		public void Vpsllq(YmmRegister o0, YmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsllq, o0, o1, o2);
		}

		public void Vpsllq(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsllq, o0, o1, o2);
		}

		public void Vpsllq(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsllq, o0, o1, (Immediate)o2);
		}

		public void Vpsllq(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsllq, o0, o1, (Immediate)o2);
		}

		public void Vpsllvd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsllvd, o0, o1, o2);
		}

		public void Vpsllvd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsllvd, o0, o1, o2);
		}

		public void Vpsllvd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsllvd, o0, o1, o2);
		}

		public void Vpsllvd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsllvd, o0, o1, o2);
		}

		public void Vpsllvq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsllvq, o0, o1, o2);
		}

		public void Vpsllvq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsllvq, o0, o1, o2);
		}

		public void Vpsllvq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsllvq, o0, o1, o2);
		}

		public void Vpsllvq(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsllvq, o0, o1, o2);
		}

		public void Vpsllw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsllw, o0, o1, o2);
		}

		public void Vpsllw(YmmRegister o0, YmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsllw, o0, o1, o2);
		}

		public void Vpsllw(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsllw, o0, o1, o2);
		}

		public void Vpsllw(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsllw, o0, o1, (Immediate)o2);
		}

		public void Vpsllw(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsllw, o0, o1, (Immediate)o2);
		}

		public void Vpsrad(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsrad, o0, o1, o2);
		}

		public void Vpsrad(YmmRegister o0, YmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsrad, o0, o1, o2);
		}

		public void Vpsrad(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsrad, o0, o1, o2);
		}

		public void Vpsrad(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsrad, o0, o1, (Immediate)o2);
		}

		public void Vpsrad(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsrad, o0, o1, (Immediate)o2);
		}

		public void Vpsravd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsravd, o0, o1, o2);
		}

		public void Vpsravd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsravd, o0, o1, o2);
		}

		public void Vpsravd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsravd, o0, o1, o2);
		}

		public void Vpsravd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsravd, o0, o1, o2);
		}

		public void Vpsraw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsraw, o0, o1, o2);
		}

		public void Vpsraw(YmmRegister o0, YmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsraw, o0, o1, o2);
		}

		public void Vpsraw(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsraw, o0, o1, o2);
		}

		public void Vpsraw(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsraw, o0, o1, (Immediate)o2);
		}

		public void Vpsraw(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsraw, o0, o1, (Immediate)o2);
		}

		public void Vpsrld(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsrld, o0, o1, o2);
		}

		public void Vpsrld(YmmRegister o0, YmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsrld, o0, o1, o2);
		}

		public void Vpsrld(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsrld, o0, o1, o2);
		}

		public void Vpsrld(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsrld, o0, o1, (Immediate)o2);
		}

		public void Vpsrld(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsrld, o0, o1, (Immediate)o2);
		}

		public void Vpsrldq(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsrldq, o0, o1, o2);
		}

		public void Vpsrldq(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsrldq, o0, o1, (Immediate)o2);
		}

		public void Vpsrldq(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsrldq, o0, o1, (Immediate)o2);
		}

		public void Vpsrlq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsrlq, o0, o1, o2);
		}

		public void Vpsrlq(YmmRegister o0, YmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsrlq, o0, o1, o2);
		}

		public void Vpsrlq(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsrlq, o0, o1, o2);
		}

		public void Vpsrlq(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsrlq, o0, o1, (Immediate)o2);
		}

		public void Vpsrlq(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsrlq, o0, o1, (Immediate)o2);
		}

		public void Vpsrlvd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsrlvd, o0, o1, o2);
		}

		public void Vpsrlvd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsrlvd, o0, o1, o2);
		}

		public void Vpsrlvd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsrlvd, o0, o1, o2);
		}

		public void Vpsrlvd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsrlvd, o0, o1, o2);
		}

		public void Vpsrlvq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsrlvq, o0, o1, o2);
		}

		public void Vpsrlvq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsrlvq, o0, o1, o2);
		}

		public void Vpsrlvq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsrlvq, o0, o1, o2);
		}

		public void Vpsrlvq(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsrlvq, o0, o1, o2);
		}

		public void Vpsrlw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsrlw, o0, o1, o2);
		}

		public void Vpsrlw(YmmRegister o0, YmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsrlw, o0, o1, o2);
		}

		public void Vpsrlw(YmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vpsrlw, o0, o1, o2);
		}

		public void Vpsrlw(YmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vpsrlw, o0, o1, (Immediate)o2);
		}

		public void Vpsrlw(YmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vpsrlw, o0, o1, (Immediate)o2);
		}

		public void Vpsubb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubb, o0, o1, o2);
		}

		public void Vpsubb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubb, o0, o1, o2);
		}

		public void Vpsubd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubd, o0, o1, o2);
		}

		public void Vpsubd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubd, o0, o1, o2);
		}

		public void Vpsubq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubq, o0, o1, o2);
		}

		public void Vpsubq(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubq, o0, o1, o2);
		}

		public void Vpsubsb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubsb, o0, o1, o2);
		}

		public void Vpsubsb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubsb, o0, o1, o2);
		}

		public void Vpsubsw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubsw, o0, o1, o2);
		}

		public void Vpsubsw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubsw, o0, o1, o2);
		}

		public void Vpsubusb(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubusb, o0, o1, o2);
		}

		public void Vpsubusb(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubusb, o0, o1, o2);
		}

		public void Vpsubusw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubusw, o0, o1, o2);
		}

		public void Vpsubusw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubusw, o0, o1, o2);
		}

		public void Vpsubw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpsubw, o0, o1, o2);
		}

		public void Vpsubw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpsubw, o0, o1, o2);
		}

		public void Vpunpckhbw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhbw, o0, o1, o2);
		}

		public void Vpunpckhbw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhbw, o0, o1, o2);
		}

		public void Vpunpckhdq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhdq, o0, o1, o2);
		}

		public void Vpunpckhdq(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhdq, o0, o1, o2);
		}

		public void Vpunpckhqdq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhqdq, o0, o1, o2);
		}

		public void Vpunpckhqdq(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhqdq, o0, o1, o2);
		}

		public void Vpunpckhwd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhwd, o0, o1, o2);
		}

		public void Vpunpckhwd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpckhwd, o0, o1, o2);
		}

		public void Vpunpcklbw(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpcklbw, o0, o1, o2);
		}

		public void Vpunpcklbw(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpcklbw, o0, o1, o2);
		}

		public void Vpunpckldq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpckldq, o0, o1, o2);
		}

		public void Vpunpckldq(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpckldq, o0, o1, o2);
		}

		public void Vpunpcklqdq(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpcklqdq, o0, o1, o2);
		}

		public void Vpunpcklqdq(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpcklqdq, o0, o1, o2);
		}

		public void Vpunpcklwd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpunpcklwd, o0, o1, o2);
		}

		public void Vpunpcklwd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpunpcklwd, o0, o1, o2);
		}

		public void Vpxor(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpxor, o0, o1, o2);
		}

		public void Vpxor(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpxor, o0, o1, o2);
		}

		public void Vfmadd132pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd132pd, o0, o1, o2);
		}

		public void Vfmadd132pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd132pd, o0, o1, o2);
		}

		public void Vfmadd132pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd132pd, o0, o1, o2);
		}

		public void Vfmadd132pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd132pd, o0, o1, o2);
		}

		public void Vfmadd132ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd132ps, o0, o1, o2);
		}

		public void Vfmadd132ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd132ps, o0, o1, o2);
		}

		public void Vfmadd132ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd132ps, o0, o1, o2);
		}

		public void Vfmadd132ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd132ps, o0, o1, o2);
		}

		public void Vfmadd132sd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd132sd, o0, o1, o2);
		}

		public void Vfmadd132sd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd132sd, o0, o1, o2);
		}

		public void Vfmadd132ss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd132ss, o0, o1, o2);
		}

		public void Vfmadd132ss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd132ss, o0, o1, o2);
		}

		public void Vfmadd213pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd213pd, o0, o1, o2);
		}

		public void Vfmadd213pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd213pd, o0, o1, o2);
		}

		public void Vfmadd213pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd213pd, o0, o1, o2);
		}

		public void Vfmadd213pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd213pd, o0, o1, o2);
		}

		public void Vfmadd213ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd213ps, o0, o1, o2);
		}

		public void Vfmadd213ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd213ps, o0, o1, o2);
		}

		public void Vfmadd213ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd213ps, o0, o1, o2);
		}

		public void Vfmadd213ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd213ps, o0, o1, o2);
		}

		public void Vfmadd213sd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd213sd, o0, o1, o2);
		}

		public void Vfmadd213sd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd213sd, o0, o1, o2);
		}

		public void Vfmadd213ss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd213ss, o0, o1, o2);
		}

		public void Vfmadd213ss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd213ss, o0, o1, o2);
		}

		public void Vfmadd231pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd231pd, o0, o1, o2);
		}

		public void Vfmadd231pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd231pd, o0, o1, o2);
		}

		public void Vfmadd231pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd231pd, o0, o1, o2);
		}

		public void Vfmadd231pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd231pd, o0, o1, o2);
		}

		public void Vfmadd231ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd231ps, o0, o1, o2);
		}

		public void Vfmadd231ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd231ps, o0, o1, o2);
		}

		public void Vfmadd231ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd231ps, o0, o1, o2);
		}

		public void Vfmadd231ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd231ps, o0, o1, o2);
		}

		public void Vfmadd231sd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd231sd, o0, o1, o2);
		}

		public void Vfmadd231sd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd231sd, o0, o1, o2);
		}

		public void Vfmadd231ss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmadd231ss, o0, o1, o2);
		}

		public void Vfmadd231ss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmadd231ss, o0, o1, o2);
		}

		public void Vfmaddsub132pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub132pd, o0, o1, o2);
		}

		public void Vfmaddsub132pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub132pd, o0, o1, o2);
		}

		public void Vfmaddsub132pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub132pd, o0, o1, o2);
		}

		public void Vfmaddsub132pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub132pd, o0, o1, o2);
		}

		public void Vfmaddsub132ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub132ps, o0, o1, o2);
		}

		public void Vfmaddsub132ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub132ps, o0, o1, o2);
		}

		public void Vfmaddsub132ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub132ps, o0, o1, o2);
		}

		public void Vfmaddsub132ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub132ps, o0, o1, o2);
		}

		public void Vfmaddsub213pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub213pd, o0, o1, o2);
		}

		public void Vfmaddsub213pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub213pd, o0, o1, o2);
		}

		public void Vfmaddsub213pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub213pd, o0, o1, o2);
		}

		public void Vfmaddsub213pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub213pd, o0, o1, o2);
		}

		public void Vfmaddsub213ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub213ps, o0, o1, o2);
		}

		public void Vfmaddsub213ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub213ps, o0, o1, o2);
		}

		public void Vfmaddsub213ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub213ps, o0, o1, o2);
		}

		public void Vfmaddsub213ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub213ps, o0, o1, o2);
		}

		public void Vfmaddsub231pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub231pd, o0, o1, o2);
		}

		public void Vfmaddsub231pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub231pd, o0, o1, o2);
		}

		public void Vfmaddsub231pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub231pd, o0, o1, o2);
		}

		public void Vfmaddsub231pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub231pd, o0, o1, o2);
		}

		public void Vfmaddsub231ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub231ps, o0, o1, o2);
		}

		public void Vfmaddsub231ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub231ps, o0, o1, o2);
		}

		public void Vfmaddsub231ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub231ps, o0, o1, o2);
		}

		public void Vfmaddsub231ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmaddsub231ps, o0, o1, o2);
		}

		public void Vfmsub132pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub132pd, o0, o1, o2);
		}

		public void Vfmsub132pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub132pd, o0, o1, o2);
		}

		public void Vfmsub132pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub132pd, o0, o1, o2);
		}

		public void Vfmsub132pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub132pd, o0, o1, o2);
		}

		public void Vfmsub132ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub132ps, o0, o1, o2);
		}

		public void Vfmsub132ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub132ps, o0, o1, o2);
		}

		public void Vfmsub132ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub132ps, o0, o1, o2);
		}

		public void Vfmsub132ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub132ps, o0, o1, o2);
		}

		public void Vfmsub132sd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub132sd, o0, o1, o2);
		}

		public void Vfmsub132sd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub132sd, o0, o1, o2);
		}

		public void Vfmsub132ss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub132ss, o0, o1, o2);
		}

		public void Vfmsub132ss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub132ss, o0, o1, o2);
		}

		public void Vfmsub213pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub213pd, o0, o1, o2);
		}

		public void Vfmsub213pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub213pd, o0, o1, o2);
		}

		public void Vfmsub213pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub213pd, o0, o1, o2);
		}

		public void Vfmsub213pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub213pd, o0, o1, o2);
		}

		public void Vfmsub213ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub213ps, o0, o1, o2);
		}

		public void Vfmsub213ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub213ps, o0, o1, o2);
		}

		public void Vfmsub213ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub213ps, o0, o1, o2);
		}

		public void Vfmsub213ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub213ps, o0, o1, o2);
		}

		public void Vfmsub213sd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub213sd, o0, o1, o2);
		}

		public void Vfmsub213sd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub213sd, o0, o1, o2);
		}

		public void Vfmsub213ss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub213ss, o0, o1, o2);
		}

		public void Vfmsub213ss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub213ss, o0, o1, o2);
		}

		public void Vfmsub231pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub231pd, o0, o1, o2);
		}

		public void Vfmsub231pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub231pd, o0, o1, o2);
		}

		public void Vfmsub231pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub231pd, o0, o1, o2);
		}

		public void Vfmsub231pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub231pd, o0, o1, o2);
		}

		public void Vfmsub231ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub231ps, o0, o1, o2);
		}

		public void Vfmsub231ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub231ps, o0, o1, o2);
		}

		public void Vfmsub231ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub231ps, o0, o1, o2);
		}

		public void Vfmsub231ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub231ps, o0, o1, o2);
		}

		public void Vfmsub231sd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub231sd, o0, o1, o2);
		}

		public void Vfmsub231sd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub231sd, o0, o1, o2);
		}

		public void Vfmsub231ss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsub231ss, o0, o1, o2);
		}

		public void Vfmsub231ss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsub231ss, o0, o1, o2);
		}

		public void Vfmsubadd132pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd132pd, o0, o1, o2);
		}

		public void Vfmsubadd132pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd132pd, o0, o1, o2);
		}

		public void Vfmsubadd132pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd132pd, o0, o1, o2);
		}

		public void Vfmsubadd132pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd132pd, o0, o1, o2);
		}

		public void Vfmsubadd132ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd132ps, o0, o1, o2);
		}

		public void Vfmsubadd132ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd132ps, o0, o1, o2);
		}

		public void Vfmsubadd132ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd132ps, o0, o1, o2);
		}

		public void Vfmsubadd132ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd132ps, o0, o1, o2);
		}

		public void Vfmsubadd213pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd213pd, o0, o1, o2);
		}

		public void Vfmsubadd213pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd213pd, o0, o1, o2);
		}

		public void Vfmsubadd213pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd213pd, o0, o1, o2);
		}

		public void Vfmsubadd213pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd213pd, o0, o1, o2);
		}

		public void Vfmsubadd213ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd213ps, o0, o1, o2);
		}

		public void Vfmsubadd213ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd213ps, o0, o1, o2);
		}

		public void Vfmsubadd213ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd213ps, o0, o1, o2);
		}

		public void Vfmsubadd213ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd213ps, o0, o1, o2);
		}

		public void Vfmsubadd231pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd231pd, o0, o1, o2);
		}

		public void Vfmsubadd231pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd231pd, o0, o1, o2);
		}

		public void Vfmsubadd231pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd231pd, o0, o1, o2);
		}

		public void Vfmsubadd231pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd231pd, o0, o1, o2);
		}

		public void Vfmsubadd231ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd231ps, o0, o1, o2);
		}

		public void Vfmsubadd231ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd231ps, o0, o1, o2);
		}

		public void Vfmsubadd231ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd231ps, o0, o1, o2);
		}

		public void Vfmsubadd231ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfmsubadd231ps, o0, o1, o2);
		}

		public void Vfnmadd132pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd132pd, o0, o1, o2);
		}

		public void Vfnmadd132pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd132pd, o0, o1, o2);
		}

		public void Vfnmadd132pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd132pd, o0, o1, o2);
		}

		public void Vfnmadd132pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd132pd, o0, o1, o2);
		}

		public void Vfnmadd132ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd132ps, o0, o1, o2);
		}

		public void Vfnmadd132ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd132ps, o0, o1, o2);
		}

		public void Vfnmadd132ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd132ps, o0, o1, o2);
		}

		public void Vfnmadd132ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd132ps, o0, o1, o2);
		}

		public void Vfnmadd132sd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd132sd, o0, o1, o2);
		}

		public void Vfnmadd132sd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd132sd, o0, o1, o2);
		}

		public void Vfnmadd132ss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd132ss, o0, o1, o2);
		}

		public void Vfnmadd132ss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd132ss, o0, o1, o2);
		}

		public void Vfnmadd213pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd213pd, o0, o1, o2);
		}

		public void Vfnmadd213pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd213pd, o0, o1, o2);
		}

		public void Vfnmadd213pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd213pd, o0, o1, o2);
		}

		public void Vfnmadd213pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd213pd, o0, o1, o2);
		}

		public void Vfnmadd213ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd213ps, o0, o1, o2);
		}

		public void Vfnmadd213ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd213ps, o0, o1, o2);
		}

		public void Vfnmadd213ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd213ps, o0, o1, o2);
		}

		public void Vfnmadd213ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd213ps, o0, o1, o2);
		}

		public void Vfnmadd213sd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd213sd, o0, o1, o2);
		}

		public void Vfnmadd213sd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd213sd, o0, o1, o2);
		}

		public void Vfnmadd213ss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd213ss, o0, o1, o2);
		}

		public void Vfnmadd213ss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd213ss, o0, o1, o2);
		}

		public void Vfnmadd231pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd231pd, o0, o1, o2);
		}

		public void Vfnmadd231pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd231pd, o0, o1, o2);
		}

		public void Vfnmadd231pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd231pd, o0, o1, o2);
		}

		public void Vfnmadd231pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd231pd, o0, o1, o2);
		}

		public void Vfnmadd231ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd231ps, o0, o1, o2);
		}

		public void Vfnmadd231ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd231ps, o0, o1, o2);
		}

		public void Vfnmadd231ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd231ps, o0, o1, o2);
		}

		public void Vfnmadd231ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd231ps, o0, o1, o2);
		}

		public void Vfnmadd231sd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd231sd, o0, o1, o2);
		}

		public void Vfnmadd231sd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd231sd, o0, o1, o2);
		}

		public void Vfnmadd231ss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd231ss, o0, o1, o2);
		}

		public void Vfnmadd231ss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmadd231ss, o0, o1, o2);
		}

		public void Vfnmsub132pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub132pd, o0, o1, o2);
		}

		public void Vfnmsub132pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub132pd, o0, o1, o2);
		}

		public void Vfnmsub132pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub132pd, o0, o1, o2);
		}

		public void Vfnmsub132pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub132pd, o0, o1, o2);
		}

		public void Vfnmsub132ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub132ps, o0, o1, o2);
		}

		public void Vfnmsub132ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub132ps, o0, o1, o2);
		}

		public void Vfnmsub132ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub132ps, o0, o1, o2);
		}

		public void Vfnmsub132ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub132ps, o0, o1, o2);
		}

		public void Vfnmsub132sd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub132sd, o0, o1, o2);
		}

		public void Vfnmsub132sd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub132sd, o0, o1, o2);
		}

		public void Vfnmsub132ss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub132ss, o0, o1, o2);
		}

		public void Vfnmsub132ss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub132ss, o0, o1, o2);
		}

		public void Vfnmsub213pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub213pd, o0, o1, o2);
		}

		public void Vfnmsub213pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub213pd, o0, o1, o2);
		}

		public void Vfnmsub213pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub213pd, o0, o1, o2);
		}

		public void Vfnmsub213pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub213pd, o0, o1, o2);
		}

		public void Vfnmsub213ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub213ps, o0, o1, o2);
		}

		public void Vfnmsub213ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub213ps, o0, o1, o2);
		}

		public void Vfnmsub213ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub213ps, o0, o1, o2);
		}

		public void Vfnmsub213ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub213ps, o0, o1, o2);
		}

		public void Vfnmsub213sd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub213sd, o0, o1, o2);
		}

		public void Vfnmsub213sd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub213sd, o0, o1, o2);
		}

		public void Vfnmsub213ss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub213ss, o0, o1, o2);
		}

		public void Vfnmsub213ss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub213ss, o0, o1, o2);
		}

		public void Vfnmsub231pd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub231pd, o0, o1, o2);
		}

		public void Vfnmsub231pd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub231pd, o0, o1, o2);
		}

		public void Vfnmsub231pd(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub231pd, o0, o1, o2);
		}

		public void Vfnmsub231pd(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub231pd, o0, o1, o2);
		}

		public void Vfnmsub231ps(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub231ps, o0, o1, o2);
		}

		public void Vfnmsub231ps(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub231ps, o0, o1, o2);
		}

		public void Vfnmsub231ps(YmmRegister o0, YmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub231ps, o0, o1, o2);
		}

		public void Vfnmsub231ps(YmmRegister o0, YmmRegister o1, YmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub231ps, o0, o1, o2);
		}

		public void Vfnmsub231sd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub231sd, o0, o1, o2);
		}

		public void Vfnmsub231sd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub231sd, o0, o1, o2);
		}

		public void Vfnmsub231ss(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub231ss, o0, o1, o2);
		}

		public void Vfnmsub231ss(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vfnmsub231ss, o0, o1, o2);
		}

		public void Vfmaddpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddpd, o0, o1, o2, o3);
		}

		public void Vfmaddpd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddpd, o0, o1, o2, o3);
		}

		public void Vfmaddpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmaddpd, o0, o1, o2, o3);
		}

		public void Vfmaddpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddpd, o0, o1, o2, o3);
		}

		public void Vfmaddpd(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddpd, o0, o1, o2, o3);
		}

		public void Vfmaddpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmaddpd, o0, o1, o2, o3);
		}

		public void Vfmaddps(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddps, o0, o1, o2, o3);
		}

		public void Vfmaddps(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddps, o0, o1, o2, o3);
		}

		public void Vfmaddps(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmaddps, o0, o1, o2, o3);
		}

		public void Vfmaddps(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddps, o0, o1, o2, o3);
		}

		public void Vfmaddps(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddps, o0, o1, o2, o3);
		}

		public void Vfmaddps(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmaddps, o0, o1, o2, o3);
		}

		public void Vfmaddsd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsd, o0, o1, o2, o3);
		}

		public void Vfmaddsd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsd, o0, o1, o2, o3);
		}

		public void Vfmaddsd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsd, o0, o1, o2, o3);
		}

		public void Vfmaddss(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddss, o0, o1, o2, o3);
		}

		public void Vfmaddss(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddss, o0, o1, o2, o3);
		}

		public void Vfmaddss(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmaddss, o0, o1, o2, o3);
		}

		public void Vfmaddsubpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsubpd, o0, o1, o2, o3);
		}

		public void Vfmaddsubpd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsubpd, o0, o1, o2, o3);
		}

		public void Vfmaddsubpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsubpd, o0, o1, o2, o3);
		}

		public void Vfmaddsubpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsubpd, o0, o1, o2, o3);
		}

		public void Vfmaddsubpd(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsubpd, o0, o1, o2, o3);
		}

		public void Vfmaddsubpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsubpd, o0, o1, o2, o3);
		}

		public void Vfmaddsubps(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsubps, o0, o1, o2, o3);
		}

		public void Vfmaddsubps(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsubps, o0, o1, o2, o3);
		}

		public void Vfmaddsubps(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsubps, o0, o1, o2, o3);
		}

		public void Vfmaddsubps(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsubps, o0, o1, o2, o3);
		}

		public void Vfmaddsubps(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsubps, o0, o1, o2, o3);
		}

		public void Vfmaddsubps(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmaddsubps, o0, o1, o2, o3);
		}

		public void Vfmsubaddpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubaddpd, o0, o1, o2, o3);
		}

		public void Vfmsubaddpd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubaddpd, o0, o1, o2, o3);
		}

		public void Vfmsubaddpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmsubaddpd, o0, o1, o2, o3);
		}

		public void Vfmsubaddpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubaddpd, o0, o1, o2, o3);
		}

		public void Vfmsubaddpd(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubaddpd, o0, o1, o2, o3);
		}

		public void Vfmsubaddpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmsubaddpd, o0, o1, o2, o3);
		}

		public void Vfmsubaddps(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubaddps, o0, o1, o2, o3);
		}

		public void Vfmsubaddps(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubaddps, o0, o1, o2, o3);
		}

		public void Vfmsubaddps(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmsubaddps, o0, o1, o2, o3);
		}

		public void Vfmsubaddps(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubaddps, o0, o1, o2, o3);
		}

		public void Vfmsubaddps(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubaddps, o0, o1, o2, o3);
		}

		public void Vfmsubaddps(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmsubaddps, o0, o1, o2, o3);
		}

		public void Vfmsubpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubpd, o0, o1, o2, o3);
		}

		public void Vfmsubpd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubpd, o0, o1, o2, o3);
		}

		public void Vfmsubpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmsubpd, o0, o1, o2, o3);
		}

		public void Vfmsubpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubpd, o0, o1, o2, o3);
		}

		public void Vfmsubpd(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubpd, o0, o1, o2, o3);
		}

		public void Vfmsubpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmsubpd, o0, o1, o2, o3);
		}

		public void Vfmsubps(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubps, o0, o1, o2, o3);
		}

		public void Vfmsubps(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubps, o0, o1, o2, o3);
		}

		public void Vfmsubps(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmsubps, o0, o1, o2, o3);
		}

		public void Vfmsubps(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubps, o0, o1, o2, o3);
		}

		public void Vfmsubps(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubps, o0, o1, o2, o3);
		}

		public void Vfmsubps(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmsubps, o0, o1, o2, o3);
		}

		public void Vfmsubsd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubsd, o0, o1, o2, o3);
		}

		public void Vfmsubsd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubsd, o0, o1, o2, o3);
		}

		public void Vfmsubsd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmsubsd, o0, o1, o2, o3);
		}

		public void Vfmsubss(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubss, o0, o1, o2, o3);
		}

		public void Vfmsubss(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfmsubss, o0, o1, o2, o3);
		}

		public void Vfmsubss(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfmsubss, o0, o1, o2, o3);
		}

		public void Vfnmaddpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddpd, o0, o1, o2, o3);
		}

		public void Vfnmaddpd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddpd, o0, o1, o2, o3);
		}

		public void Vfnmaddpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddpd, o0, o1, o2, o3);
		}

		public void Vfnmaddpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddpd, o0, o1, o2, o3);
		}

		public void Vfnmaddpd(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddpd, o0, o1, o2, o3);
		}

		public void Vfnmaddpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddpd, o0, o1, o2, o3);
		}

		public void Vfnmaddps(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddps, o0, o1, o2, o3);
		}

		public void Vfnmaddps(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddps, o0, o1, o2, o3);
		}

		public void Vfnmaddps(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddps, o0, o1, o2, o3);
		}

		public void Vfnmaddps(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddps, o0, o1, o2, o3);
		}

		public void Vfnmaddps(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddps, o0, o1, o2, o3);
		}

		public void Vfnmaddps(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddps, o0, o1, o2, o3);
		}

		public void Vfnmaddsd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddsd, o0, o1, o2, o3);
		}

		public void Vfnmaddsd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddsd, o0, o1, o2, o3);
		}

		public void Vfnmaddsd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddsd, o0, o1, o2, o3);
		}

		public void Vfnmaddss(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddss, o0, o1, o2, o3);
		}

		public void Vfnmaddss(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddss, o0, o1, o2, o3);
		}

		public void Vfnmaddss(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfnmaddss, o0, o1, o2, o3);
		}

		public void Vfnmsubpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubpd, o0, o1, o2, o3);
		}

		public void Vfnmsubpd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubpd, o0, o1, o2, o3);
		}

		public void Vfnmsubpd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubpd, o0, o1, o2, o3);
		}

		public void Vfnmsubpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubpd, o0, o1, o2, o3);
		}

		public void Vfnmsubpd(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubpd, o0, o1, o2, o3);
		}

		public void Vfnmsubpd(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubpd, o0, o1, o2, o3);
		}

		public void Vfnmsubps(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubps, o0, o1, o2, o3);
		}

		public void Vfnmsubps(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubps, o0, o1, o2, o3);
		}

		public void Vfnmsubps(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubps, o0, o1, o2, o3);
		}

		public void Vfnmsubps(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubps, o0, o1, o2, o3);
		}

		public void Vfnmsubps(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubps, o0, o1, o2, o3);
		}

		public void Vfnmsubps(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubps, o0, o1, o2, o3);
		}

		public void Vfnmsubsd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubsd, o0, o1, o2, o3);
		}

		public void Vfnmsubsd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubsd, o0, o1, o2, o3);
		}

		public void Vfnmsubsd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubsd, o0, o1, o2, o3);
		}

		public void Vfnmsubss(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubss, o0, o1, o2, o3);
		}

		public void Vfnmsubss(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubss, o0, o1, o2, o3);
		}

		public void Vfnmsubss(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vfnmsubss, o0, o1, o2, o3);
		}

		public void Vfrczpd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vfrczpd, o0, o1);
		}

		public void Vfrczpd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vfrczpd, o0, o1);
		}

		public void Vfrczpd(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vfrczpd, o0, o1);
		}

		public void Vfrczpd(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vfrczpd, o0, o1);
		}

		public void Vfrczps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vfrczps, o0, o1);
		}

		public void Vfrczps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vfrczps, o0, o1);
		}

		public void Vfrczps(YmmRegister o0, YmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vfrczps, o0, o1);
		}

		public void Vfrczps(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vfrczps, o0, o1);
		}

		public void Vfrczsd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vfrczsd, o0, o1);
		}

		public void Vfrczsd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vfrczsd, o0, o1);
		}

		public void Vfrczss(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vfrczss, o0, o1);
		}

		public void Vfrczss(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vfrczss, o0, o1);
		}

		public void Vpcmov(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpcmov, o0, o1, o2, o3);
		}

		public void Vpcmov(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpcmov, o0, o1, o2, o3);
		}

		public void Vpcmov(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vpcmov, o0, o1, o2, o3);
		}

		public void Vpcmov(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpcmov, o0, o1, o2, o3);
		}

		public void Vpcmov(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpcmov, o0, o1, o2, o3);
		}

		public void Vpcmov(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vpcmov, o0, o1, o2, o3);
		}

		public void Vpcomb(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomb, o0, o1, o2, o3);
		}

		public void Vpcomb(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomb, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomb(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomb, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomb(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomb, o0, o1, o2, o3);
		}

		public void Vpcomb(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomb, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomb(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomb, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomd, o0, o1, o2, o3);
		}

		public void Vpcomd(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomd(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomd(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomd, o0, o1, o2, o3);
		}

		public void Vpcomd(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomd(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomd, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomq(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomq, o0, o1, o2, o3);
		}

		public void Vpcomq(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomq(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomq(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomq, o0, o1, o2, o3);
		}

		public void Vpcomq(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomq(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomw(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomw, o0, o1, o2, o3);
		}

		public void Vpcomw(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomw(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomw(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomw, o0, o1, o2, o3);
		}

		public void Vpcomw(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomw(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomub(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomub, o0, o1, o2, o3);
		}

		public void Vpcomub(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomub, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomub(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomub, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomub(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomub, o0, o1, o2, o3);
		}

		public void Vpcomub(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomub, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomub(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomub, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomud(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomud, o0, o1, o2, o3);
		}

		public void Vpcomud(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomud, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomud(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomud, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomud(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomud, o0, o1, o2, o3);
		}

		public void Vpcomud(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomud, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomud(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomud, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomuq(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomuq, o0, o1, o2, o3);
		}

		public void Vpcomuq(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomuq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomuq(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomuq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomuq(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomuq, o0, o1, o2, o3);
		}

		public void Vpcomuq(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomuq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomuq(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomuq, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomuw(XmmRegister o0, XmmRegister o1, XmmRegister o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomuw, o0, o1, o2, o3);
		}

		public void Vpcomuw(XmmRegister o0, XmmRegister o1, XmmRegister o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomuw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomuw(XmmRegister o0, XmmRegister o1, XmmRegister o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomuw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomuw(XmmRegister o0, XmmRegister o1, Memory o2, Immediate o3)
		{
			Assembler.Emit(InstructionId.Vpcomuw, o0, o1, o2, o3);
		}

		public void Vpcomuw(XmmRegister o0, XmmRegister o1, Memory o2, long o3)
		{
			Assembler.Emit(InstructionId.Vpcomuw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpcomuw(XmmRegister o0, XmmRegister o1, Memory o2, ulong o3)
		{
			Assembler.Emit(InstructionId.Vpcomuw, o0, o1, o2, (Immediate)o3);
		}

		public void Vpermil2pd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpermil2pd, o0, o1, o2, o3);
		}

		public void Vpermil2pd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpermil2pd, o0, o1, o2, o3);
		}

		public void Vpermil2pd(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vpermil2pd, o0, o1, o2, o3);
		}

		public void Vpermil2pd(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpermil2pd, o0, o1, o2, o3);
		}

		public void Vpermil2pd(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpermil2pd, o0, o1, o2, o3);
		}

		public void Vpermil2pd(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vpermil2pd, o0, o1, o2, o3);
		}

		public void Vpermil2ps(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpermil2ps, o0, o1, o2, o3);
		}

		public void Vpermil2ps(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpermil2ps, o0, o1, o2, o3);
		}

		public void Vpermil2ps(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vpermil2ps, o0, o1, o2, o3);
		}

		public void Vpermil2ps(YmmRegister o0, YmmRegister o1, YmmRegister o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpermil2ps, o0, o1, o2, o3);
		}

		public void Vpermil2ps(YmmRegister o0, YmmRegister o1, Memory o2, YmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpermil2ps, o0, o1, o2, o3);
		}

		public void Vpermil2ps(YmmRegister o0, YmmRegister o1, YmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vpermil2ps, o0, o1, o2, o3);
		}

		public void Vphaddbd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphaddbd, o0, o1);
		}

		public void Vphaddbd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphaddbd, o0, o1);
		}

		public void Vphaddbq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphaddbq, o0, o1);
		}

		public void Vphaddbq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphaddbq, o0, o1);
		}

		public void Vphaddbw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphaddbw, o0, o1);
		}

		public void Vphaddbw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphaddbw, o0, o1);
		}

		public void Vphadddq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphadddq, o0, o1);
		}

		public void Vphadddq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphadddq, o0, o1);
		}

		public void Vphaddwd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphaddwd, o0, o1);
		}

		public void Vphaddwd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphaddwd, o0, o1);
		}

		public void Vphaddwq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphaddwq, o0, o1);
		}

		public void Vphaddwq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphaddwq, o0, o1);
		}

		public void Vphaddubd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphaddubd, o0, o1);
		}

		public void Vphaddubd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphaddubd, o0, o1);
		}

		public void Vphaddubq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphaddubq, o0, o1);
		}

		public void Vphaddubq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphaddubq, o0, o1);
		}

		public void Vphaddubw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphaddubw, o0, o1);
		}

		public void Vphaddubw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphaddubw, o0, o1);
		}

		public void Vphaddudq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphaddudq, o0, o1);
		}

		public void Vphaddudq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphaddudq, o0, o1);
		}

		public void Vphadduwd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphadduwd, o0, o1);
		}

		public void Vphadduwd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphadduwd, o0, o1);
		}

		public void Vphadduwq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphadduwq, o0, o1);
		}

		public void Vphadduwq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphadduwq, o0, o1);
		}

		public void Vphsubbw(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphsubbw, o0, o1);
		}

		public void Vphsubbw(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphsubbw, o0, o1);
		}

		public void Vphsubdq(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphsubdq, o0, o1);
		}

		public void Vphsubdq(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphsubdq, o0, o1);
		}

		public void Vphsubwd(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vphsubwd, o0, o1);
		}

		public void Vphsubwd(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vphsubwd, o0, o1);
		}

		public void Vpmacsdd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacsdd, o0, o1, o2, o3);
		}

		public void Vpmacsdd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacsdd, o0, o1, o2, o3);
		}

		public void Vpmacsdqh(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacsdqh, o0, o1, o2, o3);
		}

		public void Vpmacsdqh(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacsdqh, o0, o1, o2, o3);
		}

		public void Vpmacsdql(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacsdql, o0, o1, o2, o3);
		}

		public void Vpmacsdql(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacsdql, o0, o1, o2, o3);
		}

		public void Vpmacswd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacswd, o0, o1, o2, o3);
		}

		public void Vpmacswd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacswd, o0, o1, o2, o3);
		}

		public void Vpmacsww(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacsww, o0, o1, o2, o3);
		}

		public void Vpmacsww(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacsww, o0, o1, o2, o3);
		}

		public void Vpmacssdd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacssdd, o0, o1, o2, o3);
		}

		public void Vpmacssdd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacssdd, o0, o1, o2, o3);
		}

		public void Vpmacssdqh(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacssdqh, o0, o1, o2, o3);
		}

		public void Vpmacssdqh(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacssdqh, o0, o1, o2, o3);
		}

		public void Vpmacssdql(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacssdql, o0, o1, o2, o3);
		}

		public void Vpmacssdql(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacssdql, o0, o1, o2, o3);
		}

		public void Vpmacsswd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacsswd, o0, o1, o2, o3);
		}

		public void Vpmacsswd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacsswd, o0, o1, o2, o3);
		}

		public void Vpmacssww(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacssww, o0, o1, o2, o3);
		}

		public void Vpmacssww(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmacssww, o0, o1, o2, o3);
		}

		public void Vpmadcsswd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmadcsswd, o0, o1, o2, o3);
		}

		public void Vpmadcsswd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmadcsswd, o0, o1, o2, o3);
		}

		public void Vpmadcswd(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmadcswd, o0, o1, o2, o3);
		}

		public void Vpmadcswd(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpmadcswd, o0, o1, o2, o3);
		}

		public void Vpperm(XmmRegister o0, XmmRegister o1, XmmRegister o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpperm, o0, o1, o2, o3);
		}

		public void Vpperm(XmmRegister o0, XmmRegister o1, Memory o2, XmmRegister o3)
		{
			Assembler.Emit(InstructionId.Vpperm, o0, o1, o2, o3);
		}

		public void Vpperm(XmmRegister o0, XmmRegister o1, XmmRegister o2, Memory o3)
		{
			Assembler.Emit(InstructionId.Vpperm, o0, o1, o2, o3);
		}

		public void Vprotb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vprotb, o0, o1, o2);
		}

		public void Vprotb(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vprotb, o0, o1, o2);
		}

		public void Vprotb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vprotb, o0, o1, o2);
		}

		public void Vprotb(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vprotb, o0, o1, o2);
		}

		public void Vprotb(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vprotb, o0, o1, (Immediate)o2);
		}

		public void Vprotb(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vprotb, o0, o1, (Immediate)o2);
		}

		public void Vprotb(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vprotb, o0, o1, o2);
		}

		public void Vprotb(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vprotb, o0, o1, (Immediate)o2);
		}

		public void Vprotb(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vprotb, o0, o1, (Immediate)o2);
		}

		public void Vprotd(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vprotd, o0, o1, o2);
		}

		public void Vprotd(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vprotd, o0, o1, o2);
		}

		public void Vprotd(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vprotd, o0, o1, o2);
		}

		public void Vprotd(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vprotd, o0, o1, o2);
		}

		public void Vprotd(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vprotd, o0, o1, (Immediate)o2);
		}

		public void Vprotd(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vprotd, o0, o1, (Immediate)o2);
		}

		public void Vprotd(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vprotd, o0, o1, o2);
		}

		public void Vprotd(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vprotd, o0, o1, (Immediate)o2);
		}

		public void Vprotd(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vprotd, o0, o1, (Immediate)o2);
		}

		public void Vprotq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vprotq, o0, o1, o2);
		}

		public void Vprotq(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vprotq, o0, o1, o2);
		}

		public void Vprotq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vprotq, o0, o1, o2);
		}

		public void Vprotq(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vprotq, o0, o1, o2);
		}

		public void Vprotq(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vprotq, o0, o1, (Immediate)o2);
		}

		public void Vprotq(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vprotq, o0, o1, (Immediate)o2);
		}

		public void Vprotq(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vprotq, o0, o1, o2);
		}

		public void Vprotq(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vprotq, o0, o1, (Immediate)o2);
		}

		public void Vprotq(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vprotq, o0, o1, (Immediate)o2);
		}

		public void Vprotw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vprotw, o0, o1, o2);
		}

		public void Vprotw(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vprotw, o0, o1, o2);
		}

		public void Vprotw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vprotw, o0, o1, o2);
		}

		public void Vprotw(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vprotw, o0, o1, o2);
		}

		public void Vprotw(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vprotw, o0, o1, (Immediate)o2);
		}

		public void Vprotw(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vprotw, o0, o1, (Immediate)o2);
		}

		public void Vprotw(XmmRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vprotw, o0, o1, o2);
		}

		public void Vprotw(XmmRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Vprotw, o0, o1, (Immediate)o2);
		}

		public void Vprotw(XmmRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vprotw, o0, o1, (Immediate)o2);
		}

		public void Vpshab(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshab, o0, o1, o2);
		}

		public void Vpshab(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshab, o0, o1, o2);
		}

		public void Vpshab(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpshab, o0, o1, o2);
		}

		public void Vpshad(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshad, o0, o1, o2);
		}

		public void Vpshad(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshad, o0, o1, o2);
		}

		public void Vpshad(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpshad, o0, o1, o2);
		}

		public void Vpshaq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshaq, o0, o1, o2);
		}

		public void Vpshaq(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshaq, o0, o1, o2);
		}

		public void Vpshaq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpshaq, o0, o1, o2);
		}

		public void Vpshaw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshaw, o0, o1, o2);
		}

		public void Vpshaw(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshaw, o0, o1, o2);
		}

		public void Vpshaw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpshaw, o0, o1, o2);
		}

		public void Vpshlb(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshlb, o0, o1, o2);
		}

		public void Vpshlb(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshlb, o0, o1, o2);
		}

		public void Vpshlb(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpshlb, o0, o1, o2);
		}

		public void Vpshld(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshld, o0, o1, o2);
		}

		public void Vpshld(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshld, o0, o1, o2);
		}

		public void Vpshld(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpshld, o0, o1, o2);
		}

		public void Vpshlq(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshlq, o0, o1, o2);
		}

		public void Vpshlq(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshlq, o0, o1, o2);
		}

		public void Vpshlq(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpshlq, o0, o1, o2);
		}

		public void Vpshlw(XmmRegister o0, XmmRegister o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshlw, o0, o1, o2);
		}

		public void Vpshlw(XmmRegister o0, Memory o1, XmmRegister o2)
		{
			Assembler.Emit(InstructionId.Vpshlw, o0, o1, o2);
		}

		public void Vpshlw(XmmRegister o0, XmmRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Vpshlw, o0, o1, o2);
		}

		public void Andn(GpRegister o0, GpRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Andn, o0, o1, o2);
		}

		public void Andn(GpRegister o0, GpRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Andn, o0, o1, o2);
		}

		public void Bextr(GpRegister o0, GpRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Bextr, o0, o1, o2);
		}

		public void Bextr(GpRegister o0, Memory o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Bextr, o0, o1, o2);
		}

		public void Blsi(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Blsi, o0, o1);
		}

		public void Blsi(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Blsi, o0, o1);
		}

		public void Blsmsk(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Blsmsk, o0, o1);
		}

		public void Blsmsk(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Blsmsk, o0, o1);
		}

		public void Blsr(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Blsr, o0, o1);
		}

		public void Blsr(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Blsr, o0, o1);
		}

		public void Tzcnt(GpRegister o0, GpRegister o1)
		{
			Assembler.Emit(InstructionId.Tzcnt, o0, o1);
		}

		public void Tzcnt(GpRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Tzcnt, o0, o1);
		}

		public void Bzhi(GpRegister o0, GpRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Bzhi, o0, o1, o2);
		}

		public void Bzhi(GpRegister o0, Memory o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Bzhi, o0, o1, o2);
		}

		public void Mulx(GpRegister o0, GpRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Mulx, o0, o1, o2);
		}

		public void Mulx(GpRegister o0, GpRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Mulx, o0, o1, o2);
		}

		public void Pdep(GpRegister o0, GpRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Pdep, o0, o1, o2);
		}

		public void Pdep(GpRegister o0, GpRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Pdep, o0, o1, o2);
		}

		public void Pext(GpRegister o0, GpRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Pext, o0, o1, o2);
		}

		public void Pext(GpRegister o0, GpRegister o1, Memory o2)
		{
			Assembler.Emit(InstructionId.Pext, o0, o1, o2);
		}

		public void Rorx(GpRegister o0, GpRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Rorx, o0, o1, o2);
		}

		public void Rorx(GpRegister o0, GpRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Rorx, o0, o1, (Immediate)o2);
		}

		public void Rorx(GpRegister o0, GpRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Rorx, o0, o1, (Immediate)o2);
		}

		public void Rorx(GpRegister o0, Memory o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Rorx, o0, o1, o2);
		}

		public void Rorx(GpRegister o0, Memory o1, long o2)
		{
			Assembler.Emit(InstructionId.Rorx, o0, o1, (Immediate)o2);
		}

		public void Rorx(GpRegister o0, Memory o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Rorx, o0, o1, (Immediate)o2);
		}

		public void Sarx(GpRegister o0, GpRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Sarx, o0, o1, o2);
		}

		public void Sarx(GpRegister o0, Memory o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Sarx, o0, o1, o2);
		}

		public void Shlx(GpRegister o0, GpRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Shlx, o0, o1, o2);
		}

		public void Shlx(GpRegister o0, Memory o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Shlx, o0, o1, o2);
		}

		public void Shrx(GpRegister o0, GpRegister o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Shrx, o0, o1, o2);
		}

		public void Shrx(GpRegister o0, Memory o1, GpRegister o2)
		{
			Assembler.Emit(InstructionId.Shrx, o0, o1, o2);
		}

		public void Rdrand(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Rdrand, o0);
		}

		public void Vcvtph2ps(XmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtph2ps, o0, o1);
		}

		public void Vcvtph2ps(XmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvtph2ps, o0, o1);
		}

		public void Vcvtph2ps(YmmRegister o0, XmmRegister o1)
		{
			Assembler.Emit(InstructionId.Vcvtph2ps, o0, o1);
		}

		public void Vcvtph2ps(YmmRegister o0, Memory o1)
		{
			Assembler.Emit(InstructionId.Vcvtph2ps, o0, o1);
		}

		public void Vcvtps2ph(XmmRegister o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vcvtps2ph, o0, o1, o2);
		}

		public void Vcvtps2ph(XmmRegister o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vcvtps2ph, o0, o1, (Immediate)o2);
		}

		public void Vcvtps2ph(XmmRegister o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vcvtps2ph, o0, o1, (Immediate)o2);
		}

		public void Vcvtps2ph(Memory o0, XmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vcvtps2ph, o0, o1, o2);
		}

		public void Vcvtps2ph(Memory o0, XmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vcvtps2ph, o0, o1, (Immediate)o2);
		}

		public void Vcvtps2ph(Memory o0, XmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vcvtps2ph, o0, o1, (Immediate)o2);
		}

		public void Vcvtps2ph(XmmRegister o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vcvtps2ph, o0, o1, o2);
		}

		public void Vcvtps2ph(XmmRegister o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vcvtps2ph, o0, o1, (Immediate)o2);
		}

		public void Vcvtps2ph(XmmRegister o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vcvtps2ph, o0, o1, (Immediate)o2);
		}

		public void Vcvtps2ph(Memory o0, YmmRegister o1, Immediate o2)
		{
			Assembler.Emit(InstructionId.Vcvtps2ph, o0, o1, o2);
		}

		public void Vcvtps2ph(Memory o0, YmmRegister o1, long o2)
		{
			Assembler.Emit(InstructionId.Vcvtps2ph, o0, o1, (Immediate)o2);
		}

		public void Vcvtps2ph(Memory o0, YmmRegister o1, ulong o2)
		{
			Assembler.Emit(InstructionId.Vcvtps2ph, o0, o1, (Immediate)o2);
		}

		public void Rdfsbase(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Rdfsbase, o0);
		}

		public void Rdgsbase(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Rdgsbase, o0);
		}

		public void Wrfsbase(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Wrfsbase, o0);
		}

		public void Wrgsbase(GpRegister o0)
		{
			Assembler.Emit(InstructionId.Wrgsbase, o0);
		}
	}
}
