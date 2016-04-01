using System;
using System.Runtime.InteropServices;
using AsmJit.Common;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest.TestCases
{
	public sealed class AllocBlend : CompilerTestCase<Action<IntPtr, IntPtr, UIntPtr>>
	{
		protected override void Compile(CodeContext c)
		{
			var dst = c.IntPtr("dst");
			var src = c.IntPtr("src");

			var i = c.IntPtr("i");
			var j = c.IntPtr("j");
			var t = c.IntPtr("t");

			var cZero = c.Xmm("cZero");
			var cMul255A = c.Xmm("cMul255A");
			var cMul255M = c.Xmm("cMul255M");

			var x0 = c.Xmm("x0");
			var x1 = c.Xmm("x1");
			var y0 = c.Xmm("y0");
			var a0 = c.Xmm("a0");
			var a1 = c.Xmm("a1");

			var smallLoop = c.Label();
			var smallEnd = c.Label();

			var largeLoop = c.Label();
			var largeEnd = c.Label();

			var data = c.Label();

			c.SetArgument(0, dst);
			c.SetArgument(1, src);
			c.SetArgument(2, i);

			c.Allocate(dst);
			c.Allocate(src);
			c.Allocate(i);

			// How many pixels have to be processed to make the loop aligned.
			c.Lea(t, Memory.Ptr(data));
			c.Xor(j, j);
			c.Xorps(cZero, cZero);

			c.Sub(j, dst);
			c.Movaps(cMul255A, Memory.Ptr(t, 0));

			c.And(j, 15);
			c.Movaps(cMul255M, Memory.Ptr(t, 16));

			c.Shr(j, 2);
			c.Jz(smallEnd);

			// j = min(i, j).
			c.Cmp(j, i);
			c.Cmovg(j, i);

			// i -= j.
			c.Sub(i, j);

			// Small loop.
			c.Bind(smallLoop);

			c.Pcmpeqb(a0, a0);
			c.Movd(y0, Memory.Ptr(src));

			c.Pxor(a0, y0);
			c.Movd(x0, Memory.Ptr(dst));

			c.Psrlw(a0, 8);
			c.Punpcklbw(x0, cZero);

			c.Pshuflw(a0, a0, AsmJit.Common.Utils.Shuffle(1, 1, 1, 1));
			c.Punpcklbw(y0, cZero);

			c.Pmullw(x0, a0);
			c.Paddsw(x0, cMul255A);
			c.Pmulhuw(x0, cMul255M);

			c.Paddw(x0, y0);
			c.Packuswb(x0, x0);

			c.Movd(Memory.Ptr(dst), x0);

			c.Add(dst, 4);
			c.Add(src, 4);

			c.Dec(j);
			c.Jnz(smallLoop);

			// Second section, prepare for an aligned loop.
			c.Bind(smallEnd);

			c.Test(i, i);
			c.Mov(j, i);
			c.Jz(c.Exit);

			c.And(j, 3);
			c.Shr(i, 2);
			c.Jz(largeEnd);

			// Aligned loop.
			c.Bind(largeLoop);

			c.Movups(y0, Memory.Ptr(src));
			c.Pcmpeqb(a0, a0);
			c.Movaps(x0, Memory.Ptr(dst));

			c.Xorps(a0, y0);
			c.Movaps(x1, x0);

			c.Psrlw(a0, 8);
			c.Punpcklbw(x0, cZero);

			c.Movaps(a1, a0);
			c.Punpcklwd(a0, a0);

			c.Punpckhbw(x1, cZero);
			c.Punpckhwd(a1, a1);

			c.Pshufd(a0, a0, AsmJit.Common.Utils.Shuffle(3, 3, 1, 1));
			c.Pshufd(a1, a1, AsmJit.Common.Utils.Shuffle(3, 3, 1, 1));

			c.Pmullw(x0, a0);
			c.Pmullw(x1, a1);

			c.Paddsw(x0, cMul255A);
			c.Paddsw(x1, cMul255A);

			c.Pmulhuw(x0, cMul255M);
			c.Pmulhuw(x1, cMul255M);

			c.Add(src, 16);
			c.Packuswb(x0, x1);

			c.Paddw(x0, y0);
			c.Movaps(Memory.Ptr(dst), x0);

			c.Add(dst, 16);

			c.Dec(i);
			c.Jnz(largeLoop);

			c.Bind(largeEnd);
			c.Test(j, j);
			c.Jnz(smallLoop);

			// Data
			c.Data(data, 16, 
				Data.Of(0x0080008000800080, 0x0080008000800080),
				Data.Of(0x0101010101010101, 0x0080008000800080));
		}

		protected override unsafe void Execute(Action<IntPtr, IntPtr, UIntPtr> fn, out string result, out string expected)
		{
			const int cnt = 17;

			var d = new uint[] { 0x00000000, 0x10101010, 0x20100804, 0x30200003, 0x40204040, 0x5000004D, 0x60302E2C, 0x706F6E6D, 0x807F4F2F, 0x90349001, 0xA0010203, 0xB03204AB, 0xC023AFBD, 0xD0D0D0C0, 0xE0AABBCC, 0xFFFFFFFF, 0xF8F4F2F1 };
			var s = new uint[] { 0xE0E0E0E0, 0xA0008080, 0x341F1E1A, 0xFEFEFEFE, 0x80302010, 0x49490A0B, 0x998F7798, 0x00000000, 0x01010101, 0xA0264733, 0xBAB0B1B9, 0xFF000000, 0xDAB0A0C1, 0xE0BACFDA, 0x99887766, 0xFFFFFF80, 0xEE0A5FEC };

			var rawptr = Marshal.AllocHGlobal((cnt + 3) * sizeof(uint) + 8);
			var pdst = new IntPtr(16 * (((long)rawptr + 15) / 16));

			rawptr = Marshal.AllocHGlobal((cnt + 3) * sizeof(uint) + 8);
			var psrc = new IntPtr(16 * (((long)rawptr + 15) / 16));

			UnsafeMemory.Copy(pdst, Marshal.UnsafeAddrOfPinnedArrayElement(d, 0), cnt * sizeof(uint));
			UnsafeMemory.Copy(psrc, Marshal.UnsafeAddrOfPinnedArrayElement(s, 0), cnt * sizeof(uint));

			var e = new uint[cnt];
			for (var z = 0; z < cnt; z++)
			{
				e[z] = BlendSrcOver(d[z], s[z]);				
			}

			fn(pdst, psrc, (UIntPtr)cnt);

			UnsafeMemory.Copy(Marshal.UnsafeAddrOfPinnedArrayElement(d, 0), pdst, cnt*sizeof(uint));

			result = string.Join(",", d);
			expected = string.Join(",", e);
		}

		private static uint BlendSrcOver(uint d, uint s)
		{
			var saInv = ~s >> 24;

			var d20 = (d) & 0x00FF00FF;
			var d31 = (d >> 8) & 0x00FF00FF;

			d20 *= saInv;
			d31 *= saInv;

			d20 = ((d20 + ((d20 >> 8) & 0x00FF00FFU) + 0x00800080U) & 0xFF00FF00U) >> 8;
			d31 = ((d31 + ((d31 >> 8) & 0x00FF00FFU) + 0x00800080U) & 0xFF00FF00U);

			return d20 + d31 + s;
		}
	}
}