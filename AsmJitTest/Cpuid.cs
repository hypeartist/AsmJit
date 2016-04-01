using System;
using System.Linq;
using System.Text;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJitTest
{
	public sealed class Cpuid
	{
		enum Register
		{
			Eax = 0,
			Ebx = 1,
			Ecx = 2,
			Edx = 3,
		};

		enum Bit
		{
			// Ordinary:
			// Edx:
			SSE = 1 << 25,
			SSE2 = 1 << 26,

			// Ecx:
			SSSE3 = 1 << 9,
			SSE41 = 1 << 19,
			SSE42 = 1 << 20,
			OSXSAVE = 1 << 27,
			AVX = 1 << 28,

			// Extended:
			// Ebx:
			AVX2 = 1 << 5,
			AVX512F = 1 << 16,
			AVX512BW = 1 << 30,

			// Ecx:
			AVX512VBMI = 1 << 1,
		}

		static bool CheckBit(uint[] registers, Register index, Bit bit)
		{
			return (registers[(int)index] & (int)bit) == (int)bit;
		}

		private static Cpuid _instance;

		private Cpuid() { }

		public static Cpuid Get()
		{
			if (_instance != null)
			{
				return _instance;
			}

			_instance = new Cpuid();

			var c = Compiler.CreateContext<Action<IntPtr, IntPtr, IntPtr, IntPtr>>();
			var eax = c.UInt32();
			var ebx = c.UInt32();
			var ecx = c.UInt32();
			var edx = c.UInt32();

			var r0 = c.UInt32();
			var r1 = c.UInt32();
			var r2 = c.UInt32();
			var r3 = c.UInt32();

			c.SetArgument(0, r0);
			c.SetArgument(1, r1);
			c.SetArgument(2, r2);
			c.SetArgument(3, r3);

			c.Mov(eax, Memory.DWord(r0));
			c.Mov(ebx, Memory.DWord(r1));
			c.Mov(ecx, Memory.DWord(r2));
			c.Mov(edx, Memory.DWord(r3));

			c.Cpuid(eax, ebx, ecx, edx);

			c.Mov(Memory.DWord(r0), eax);
			c.Mov(Memory.DWord(r1), ebx);
			c.Mov(Memory.DWord(r2), ecx);
			c.Mov(Memory.DWord(r3), edx);

			c.Ret();

			var fn = c.Compile();

			var regs = new uint[4];

			unsafe
			{
				regs[0] = 1;
				fixed (uint* pregs = regs)
				{
					fn((IntPtr)pregs, (IntPtr)(pregs + 1), (IntPtr)(pregs + 2), (IntPtr)(pregs + 3));
				}
			}

			_instance.Sse = CheckBit(regs, Register.Edx, Bit.SSE);
			_instance.Sse2 = CheckBit(regs, Register.Edx, Bit.SSE2);
			_instance.Sse3 = CheckBit(regs, Register.Ecx, Bit.SSSE3);
			_instance.Sse41 = CheckBit(regs, Register.Ecx, Bit.SSE41);
			_instance.Sse42 = CheckBit(regs, Register.Ecx, Bit.SSE42);
			_instance.Avx = CheckBit(regs, Register.Ecx, Bit.OSXSAVE) && CheckBit(regs, Register.Ecx, Bit.AVX);
			_instance.Avx2 = CheckBit(regs, Register.Ecx, Bit.OSXSAVE) && CheckBit(regs, Register.Ecx, Bit.AVX2);

			regs = new uint[4];
			unsafe
			{
				regs[0] = 0x80000002;
				fixed (uint* pregs = regs)
				{
					fn((IntPtr)pregs, (IntPtr)(pregs + 1), (IntPtr)(pregs + 2), (IntPtr)(pregs + 3));
				}
				_instance.Cpu += Encoding.Default.GetString(BitConverter.GetBytes(regs[0]));
				_instance.Cpu += Encoding.Default.GetString(BitConverter.GetBytes(regs[1]));
				_instance.Cpu += Encoding.Default.GetString(BitConverter.GetBytes(regs[2]));
				_instance.Cpu += Encoding.Default.GetString(BitConverter.GetBytes(regs[3]));
				regs[0] = 0x80000003;
				fixed (uint* pregs = regs)
				{
					fn((IntPtr)pregs, (IntPtr)(pregs + 1), (IntPtr)(pregs + 2), (IntPtr)(pregs + 3));
				}
				_instance.Cpu += Encoding.Default.GetString(BitConverter.GetBytes(regs[0]));
				_instance.Cpu += Encoding.Default.GetString(BitConverter.GetBytes(regs[1]));
				_instance.Cpu += Encoding.Default.GetString(BitConverter.GetBytes(regs[2]));
				_instance.Cpu += Encoding.Default.GetString(BitConverter.GetBytes(regs[3]));
				regs[0] = 0x80000004;
				fixed (uint* pregs = regs)
				{
					fn((IntPtr)pregs, (IntPtr)(pregs + 1), (IntPtr)(pregs + 2), (IntPtr)(pregs + 3));
				}
				_instance.Cpu += Encoding.Default.GetString(BitConverter.GetBytes(regs[0]));
				_instance.Cpu += Encoding.Default.GetString(BitConverter.GetBytes(regs[1]));
				_instance.Cpu += Encoding.Default.GetString(BitConverter.GetBytes(regs[2]));
				_instance.Cpu += Encoding.Default.GetString(BitConverter.GetBytes(regs[3]));
				_instance.Cpu = _instance.Cpu.Replace('\0', ' ').Trim();
				regs[0] = 0x80000006;
				fixed (uint* pregs = regs)
				{
					fn((IntPtr)pregs, (IntPtr)(pregs + 1), (IntPtr)(pregs + 2), (IntPtr)(pregs + 3));
				}
				_instance.CacheLineSize = (int)(regs[2] & 0xff);
				_instance.CacheSize = (int)((regs[2] >> 16) & 0xffff);
			}

			return _instance;
		}

		public string Cpu { get; private set; }
		
		public int CacheLineSize { get; private set; }

		public int CacheSize { get; private set; }

		public bool Sse { get; private set; }

		public bool Sse2 { get; private set; }
		
		public bool Sse3 { get; private set; }

		public bool Sse41 { get; private set; }
		
		public bool Sse42 { get; private set; }
		
		public bool Avx { get; private set; }
		
		public bool Avx2 { get; private set; }
	}
}