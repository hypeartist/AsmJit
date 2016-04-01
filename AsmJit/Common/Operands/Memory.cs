using System;

namespace AsmJit.Common.Operands
{
	public class Memory : Operand
	{
		internal Memory()
			: base(OperandType.Memory)
		{
			Index = RegisterIndex.Invalid;
			Base = RegisterIndex.Invalid;
			Displacement = 0;
			MemoryType = MemoryType.BaseIndex;
		}

		internal Memory(Memory other)
			: base(other)
		{
		}

		internal Memory(Memory other, int size)
			: base(other)
		{
			Size = size;
		}

		internal Memory(Label label, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			Id = label.Id;
			MemoryType = MemoryType.Label;
			Displacement = disp;
			Index = RegisterIndex.Invalid;
		}

		internal Memory(Label label, GpRegister index, int shift, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			Id = label.Id;
			MemoryType = MemoryType.Label;
			Displacement = disp;
			Index = index.Index;
			Flags = (Constants.X86.MemVSibGpz << Constants.X86.MemVSibIndex) + (shift << Constants.X86.MemShiftIndex);
		}

		internal Memory(RipRegister rip, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			MemoryType = MemoryType.Rip;
			Displacement = disp;
			Index = RegisterIndex.Invalid;
		}

		internal Memory(GpRegister @base, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			Id = @base.Index;
			MemoryType = MemoryType.BaseIndex;
			Displacement = disp;
			Flags = GetGpdFlags(@base) + (Constants.X86.MemVSibGpz << Constants.X86.MemVSibIndex);
			Index = RegisterIndex.Invalid;
		}

		internal Memory(GpVariable @base, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			Id = @base.Id;
			MemoryType = MemoryType.BaseIndex;
			Displacement = disp;
			Flags = GetGpdFlags(@base) + (Constants.X86.MemVSibGpz << Constants.X86.MemVSibIndex);
			Index = RegisterIndex.Invalid;
		}

		internal Memory(Variable index, int shift, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			var flags = shift << Constants.X86.MemShiftIndex;

			var indexRegType = index.RegisterType;

			if (indexRegType <= RegisterType.Gpq)
			{
				flags |= GetGpdFlags(index);
			}
			else switch (indexRegType)
			{
				case RegisterType.Xmm:
					flags |= Constants.X86.MemVSibXmm << Constants.X86.MemVSibIndex;
					break;
				case RegisterType.Ymm:
					flags |= Constants.X86.MemVSibYmm << Constants.X86.MemVSibIndex;
					break;
			}

			MemoryType = MemoryType.Absolute;
			Displacement = disp;
			Flags = flags;
			Index = index.Id;
		}

		internal Memory(GpRegister @base, GpRegister index, int shift, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			Id = @base.Index;
			MemoryType = MemoryType.BaseIndex;
			Displacement = disp;
			Index = index.Index;
			Flags = GetGpdFlags(@base) + (shift << Constants.X86.MemShiftIndex);
		}

		internal Memory(GpRegister @base, XmmRegister index, int shift, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			Id = @base.Index;
			MemoryType = MemoryType.BaseIndex;
			Displacement = disp;
			Index = index.Index;
			Flags = GetGpdFlags(@base) + (Constants.X86.MemVSibXmm << Constants.X86.MemVSibIndex) + (shift << Constants.X86.MemShiftIndex);
		}

		internal Memory(GpRegister @base, YmmRegister index, int shift, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			Id = @base.Index;
			MemoryType = MemoryType.BaseIndex;
			Displacement = disp;
			Index = index.Index;
			Flags = GetGpdFlags(@base) + (Constants.X86.MemVSibYmm << Constants.X86.MemVSibIndex) + (shift << Constants.X86.MemShiftIndex);
		}

		internal Memory(Label label, GpVariable index, int shift, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			Id = label.Id;
			MemoryType = MemoryType.Label;
			Displacement = disp;
			Index = index.Id;
			Flags = GetGpdFlags(index) + (shift << Constants.X86.MemShiftIndex);
		}

		internal Memory(GpVariable @base, XmmVariable index, int shift, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			Id = @base.Id;
			MemoryType = MemoryType.Label;
			Displacement = disp;
			Index = index.Id;
			Flags = GetGpdFlags(@base) + (Constants.X86.MemVSibXmm << Constants.X86.MemVSibIndex) + (shift << Constants.X86.MemShiftIndex);
		}

		internal Memory(GpVariable @base, YmmVariable index, int shift, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			Id = @base.Id;
			MemoryType = MemoryType.Label;
			Displacement = disp;
			Index = index.Id;
			Flags = GetGpdFlags(@base) + (Constants.X86.MemVSibYmm << Constants.X86.MemVSibIndex) + (shift << Constants.X86.MemShiftIndex);
		}

		internal Memory(GpVariable @base, GpVariable index, int shift, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			Id = @base.Id;
			MemoryType = MemoryType.BaseIndex;
			Displacement = disp;
			Index = index.Id;
			Flags = GetGpdFlags(@base) + (shift << Constants.X86.MemShiftIndex);
		}

		internal Memory(MemoryType memType)
			: base(OperandType.Memory)
		{
			MemoryType = memType;
			Displacement = 0;
			Index = RegisterIndex.Invalid;
		}

		internal Memory(MemoryType memType, int disp, int size)
			: base(OperandType.Memory, size)
		{
			MemoryType = memType;
			Displacement = disp;
			Index = RegisterIndex.Invalid;
		}

		internal Memory(MemoryType memType, GpVariable @base, int disp, int size)
			: base(OperandType.Memory, size)
		{
			Id = @base.Id;
			MemoryType = memType;
			Displacement = disp;
			Index = RegisterIndex.Invalid;
		}

		internal Memory(MemoryType memType, Register index, int shift, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			MemoryType = memType;
			Displacement = disp;
			Index = index.Index;
			var flags = shift << Constants.X86.MemShiftIndex;

			if (index.IsGp())
			{
				flags |= GetGpdFlags(index);
			}
			else if (index.IsXmm())
			{
				flags |= Constants.X86.MemVSibXmm << Constants.X86.MemVSibIndex;
			}
			else if (index.IsYmm())
			{
				flags |= Constants.X86.MemVSibYmm << Constants.X86.MemVSibIndex;
			}

			Flags = flags;
		}

		internal Memory(MemoryType memType, GpVariable index, int shift, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			MemoryType = memType;
			Displacement = disp;
			Index = index.RegisterIndex;
			var flags = shift << Constants.X86.MemShiftIndex;

			if (index.IsGp())
			{
				flags |= GetGpdFlags(index);
			}
			else if (index.IsXmm())
			{
				flags |= Constants.X86.MemVSibXmm << Constants.X86.MemVSibIndex;
			}
			else if (index.IsYmm())
			{
				flags |= Constants.X86.MemVSibYmm << Constants.X86.MemVSibIndex;
			}

			Flags = flags;
		}

		internal Memory(MemoryType memType, GpVariable @base, GpVariable index, int shift, int disp, int size = 0)
			: base(OperandType.Memory, size)
		{
			Id = @base.Id;
			MemoryType = memType;
			Displacement = disp;
			Index = index.Id;
			Flags = shift << Constants.X86.MemShiftIndex;
		}

		private int GetGpdFlags(Operand @base)
		{
			return (@base.Size & 4) << (Constants.X86.MemGpdIndex - 2);
		}

		internal void SetGpdBase(int b)
		{
			Flags = (Flags & Constants.X86.MemGpdMask) + (b << Constants.X86.MemGpdIndex);
		}

		internal Memory Adjust(int disp)
		{
			Displacement += disp;
			return this;
		}

		internal int Base
		{
			get { return Id; }
			set { Id = value; }
		}

		internal MemoryType MemoryType
		{
			get { return (MemoryType)Reserved0; }
			set { Reserved0 = (int)value; }
		}

		internal int Flags
		{
			get { return Reserved1; }
			set { Reserved1 = value; }
		}

		internal int Index
		{
			get { return Reserved2; }
			set { Reserved2 = value; }
		}

		internal int Displacement
		{
			get { return Reserved3; }
			set { Reserved3 = value; }
		}

		public long VSib
		{
			get { return (Flags >> Constants.X86.MemVSibIndex) & Constants.X86.MemVSibBits; }
			set { Flags = (int)((Flags & Constants.X86.MemVSibMask) + (value << Constants.X86.MemVSibIndex)); }
		}

		public long Segment
		{
			get { return (Flags >> Constants.X86.MemSegIndex) & Constants.X86.MemSegBits; }
			set { Flags = (int)((Flags & Constants.X86.MemSegMask) + (value << Constants.X86.MemSegIndex)); }
		}

		public long Shift
		{
			get { return (Flags >> Constants.X86.MemShiftIndex) & Constants.X86.MemShiftBits; }
			set { Flags = (int)((Flags & Constants.X86.MemShiftMask) + (value << Constants.X86.MemShiftIndex)); }
		}

		public bool HasSegment
		{
			get { return (Flags & Constants.X86.MemSegMask) != Constants.X86.SegDefault << Constants.X86.MemSegIndex; }
		}

		public bool HasGdpBase
		{
			get { return (Flags & Constants.X86.MemGpdMask) != 0; }
		}

		public static FnPointer Fn(Delegate d, CallingConvention convention = CallingConvention.Default)
		{
			return new FnPointer(d, convention);
		}

		public static FnPointer Fn<T>(Pointer fnPtr, CallingConvention convention = CallingConvention.Default)
		{
			return new FnPointer<T>(fnPtr, convention);
		}

		internal static Memory Ptr(GpRegister @base, int disp = 0, int size = 0)
		{
			return new Memory(@base, disp, size);
		}

		internal static Memory Ptr(GpRegister @base, GpRegister index, int shift = 0, int disp = 0, int size = 0)
		{
			return new Memory(@base, index, shift, disp, size);
		}

		internal static Memory Ptr(GpRegister @base, XmmRegister index, int shift = 0, int disp = 0, int size = 0)
		{
			return new Memory(@base, index, shift, disp, size);
		}

		internal static Memory Ptr(GpRegister @base, YmmRegister index, int shift = 0, int disp = 0, int size = 0)
		{
			return new Memory(@base, index, shift, disp, size);
		}

		public static Memory Ptr(Label label, int disp = 0, int size = 0)
		{
			return new Memory(label, disp, size);
		}

		public static Memory Ptr(Label label, GpRegister index, int shift, int disp = 0, int size = 0)
		{
			return new Memory(label, index, shift, disp, size);
		}

		internal static Memory Ptr(RipRegister rip, int disp = 0, int size = 0)
		{
			return new Memory(rip, disp, size);
		}

		public static Memory Ptr(GpVariable @base, int disp = 0, int size = 0)
		{
			return new Memory(@base, disp, size);
		}

		public static Memory Ptr(GpVariable @base, GpVariable index, int shift = 0, int disp = 0, int size = 0)
		{
			return new Memory(@base, index, shift, disp, size);
		}

		public static Memory Ptr(GpVariable @base, XmmVariable index, int shift = 0, int disp = 0, int size = 0)
		{
			return new Memory(@base, index, shift, disp, size);
		}

		public static Memory Ptr(GpVariable @base, YmmVariable index, int shift = 0, int disp = 0, int size = 0)
		{
			return new Memory(@base, index, shift, disp, size);
		}

		public static Memory Ptr(Label label, GpVariable index, int shift, int disp = 0, int size = 0)
		{
			return new Memory(label, index, shift, disp, size);
		}

		public static Memory PtrAbs(IntPtr pAbs, int disp, int i)
		{
			return new Memory(MemoryType.Absolute, (int)(pAbs + disp), i);
		}

		internal static Memory PtrAbs(IntPtr pAbs, Register index, int shift, int disp, int i)
		{
			return new Memory(MemoryType.Absolute, index, shift, (int)(pAbs + disp), i);
		}

		public static Memory PtrAbs(IntPtr pAbs, Variable index, int shift, int disp, int size)
		{
			return new Memory(index, (int)(pAbs + disp), shift, size);
		}

		public static Memory Byte(GpRegister @base, int disp = 0)
		{
			return new Memory(@base, disp, 1);
		}

		public static Memory Byte(GpRegister @base, GpRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 1);
		}

		public static Memory Byte(GpRegister @base, XmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 1);
		}

		public static Memory Byte(GpRegister @base, YmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 1);
		}

		public static Memory Byte(Label label, int disp = 0)
		{
			return Ptr(label, disp, 1);
		}

		public static Memory Byte(Label label, GpRegister index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 1);
		}

		public static Memory Byte(RipRegister rip, int disp = 0)
		{
			return Ptr(rip, disp, 1);
		}

		public static Memory ByteAbs(IntPtr pAbs, int disp = 0)
		{
			return PtrAbs(pAbs, disp, 1);
		}

		public static Memory ByteAbs(IntPtr pAbs, GpRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 1);
		}

		public static Memory ByteAbs(IntPtr pAbs, XmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 1);
		}

		public static Memory ByteAbs(IntPtr pAbs, YmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 1);
		}

		public static Memory Word(GpRegister @base, int disp = 0)
		{
			return new Memory(@base, disp, 2);
		}

		public static Memory Word(GpRegister @base, GpRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 2);
		}

		public static Memory Word(GpRegister @base, XmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 2);
		}

		public static Memory Word(GpRegister @base, YmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 2);
		}

		public static Memory Word(Label label, int disp = 0)
		{
			return Ptr(label, disp, 2);
		}

		public static Memory Word(Label label, GpRegister index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 2);
		}

		public static Memory Word(RipRegister rip, int disp = 0)
		{
			return Ptr(rip, disp, 2);
		}

		public static Memory WordAbs(IntPtr pAbs, int disp = 0)
		{
			return PtrAbs(pAbs, disp, 2);
		}

		public static Memory WordAbs(IntPtr pAbs, GpRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 2);
		}

		public static Memory WordAbs(IntPtr pAbs, XmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 2);
		}

		public static Memory WordAbs(IntPtr pAbs, YmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 2);
		}

		public static Memory DWord(GpRegister @base, int disp = 0)
		{
			return new Memory(@base, disp, 4);
		}

		public static Memory DWord(GpRegister @base, GpRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 4);
		}

		public static Memory DWord(GpRegister @base, XmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 4);
		}

		public static Memory DWord(GpRegister @base, YmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 4);
		}

		public static Memory DWord(Label label, int disp = 0)
		{
			return Ptr(label, disp, 4);
		}

		public static Memory DWord(Label label, GpRegister index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 4);
		}

		public static Memory DWord(RipRegister rip, int disp = 0)
		{
			return Ptr(rip, disp, 4);
		}

		public static Memory DWordAbs(IntPtr pAbs, int disp = 0)
		{
			return PtrAbs(pAbs, disp, 4);
		}

		public static Memory DWordAbs(IntPtr pAbs, GpRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 4);
		}

		public static Memory DWordAbs(IntPtr pAbs, XmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 4);
		}

		public static Memory DWordAbs(IntPtr pAbs, YmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 4);
		}

		public static Memory QWord(GpRegister @base, int disp = 0)
		{
			return new Memory(@base, disp, 8);
		}

		public static Memory QWord(GpRegister @base, GpRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 8);
		}

		public static Memory QWord(GpRegister @base, XmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 8);
		}

		public static Memory QWord(GpRegister @base, YmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 8);
		}

		public static Memory QWord(Label label, int disp = 0)
		{
			return Ptr(label, disp, 8);
		}

		public static Memory QWord(Label label, GpRegister index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 8);
		}

		public static Memory QWord(RipRegister rip, int disp = 0)
		{
			return Ptr(rip, disp, 8);
		}

		public static Memory QWordAbs(IntPtr pAbs, int disp = 0)
		{
			return PtrAbs(pAbs, disp, 8);
		}

		public static Memory QWordAbs(IntPtr pAbs, GpRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 8);
		}

		public static Memory QWordAbs(IntPtr pAbs, XmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 8);
		}

		public static Memory QWordAbs(IntPtr pAbs, YmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 8);
		}

		public static Memory TWord(GpRegister @base, int disp = 0)
		{
			return new Memory(@base, disp, 10);
		}

		public static Memory TWord(GpRegister @base, GpRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 10);
		}

		public static Memory TWord(GpRegister @base, XmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 10);
		}

		public static Memory TWord(GpRegister @base, YmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 10);
		}

		public static Memory TWord(Label label, int disp = 0)
		{
			return Ptr(label, disp, 10);
		}

		public static Memory TWord(Label label, GpRegister index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 10);
		}

		public static Memory TWord(RipRegister rip, int disp = 0)
		{
			return Ptr(rip, disp, 10);
		}

		public static Memory TWordPtrAbs(IntPtr pAbs, int disp = 0)
		{
			return PtrAbs(pAbs, disp, 10);
		}

		public static Memory TWordPtrAbs(IntPtr pAbs, GpRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 10);
		}

		public static Memory TWordPtrAbs(IntPtr pAbs, XmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 10);
		}

		public static Memory TWordPtrAbs(IntPtr pAbs, YmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 10);
		}

		public static Memory OWordPtr(GpRegister @base, int disp = 0)
		{
			return new Memory(@base, disp, 16);
		}

		public static Memory OWordPtr(GpRegister @base, GpRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 16);
		}

		public static Memory OWordPtr(GpRegister @base, XmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 16);
		}

		public static Memory OWordPtr(GpRegister @base, YmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 16);
		}

		public static Memory OWordPtr(Label label, int disp = 0)
		{
			return Ptr(label, disp, 16);
		}

		public static Memory OWordPtr(Label label, GpRegister index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 16);
		}

		public static Memory OWordPtr(RipRegister rip, int disp = 0)
		{
			return Ptr(rip, disp, 16);
		}

		public static Memory OWordPtrAbs(IntPtr pAbs, int disp = 0)
		{
			return PtrAbs(pAbs, disp, 16);
		}

		public static Memory OWordPtrAbs(IntPtr pAbs, GpRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 16);
		}

		public static Memory OWordPtrAbs(IntPtr pAbs, XmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 16);
		}

		public static Memory OWordPtrAbs(IntPtr pAbs, YmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 16);
		}

		public static Memory YWordPtr(GpRegister @base, int disp = 0)
		{
			return new Memory(@base, disp, 32);
		}

		public static Memory YWordPtr(GpRegister @base, GpRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 32);
		}

		public static Memory YWordPtr(GpRegister @base, XmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 32);
		}

		public static Memory YWordPtr(GpRegister @base, YmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 32);
		}

		public static Memory YWordPtr(Label label, int disp = 0)
		{
			return Ptr(label, disp, 32);
		}

		public static Memory YWordPtr(Label label, GpRegister index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 32);
		}

		public static Memory YWordPtr(RipRegister rip, int disp = 0)
		{
			return Ptr(rip, disp, 32);
		}

		public static Memory YWordPtrAbs(IntPtr pAbs, int disp = 0)
		{
			return PtrAbs(pAbs, disp, 32);
		}

		public static Memory YWordPtrAbs(IntPtr pAbs, GpRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 32);
		}

		public static Memory YWordPtrAbs(IntPtr pAbs, XmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 32);
		}

		public static Memory YWordPtrAbs(IntPtr pAbs, YmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 32);
		}

		public static Memory ZWordPtr(GpRegister @base, int disp = 0)
		{
			return new Memory(@base, disp, 64);
		}

		public static Memory ZWordPtr(GpRegister @base, GpRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 64);
		}

		public static Memory ZWordPtr(GpRegister @base, XmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 64);
		}

		public static Memory ZWordPtr(GpRegister @base, YmmRegister index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 64);
		}

		public static Memory ZWordPtr(Label label, int disp = 0)
		{
			return Ptr(label, disp, 64);
		}

		public static Memory ZWordPtr(Label label, GpRegister index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 64);
		}

		public static Memory ZWordPtr(RipRegister rip, int disp = 0)
		{
			return Ptr(rip, disp, 64);
		}

		public static Memory ZWordPtrAbs(IntPtr pAbs, int disp = 0)
		{
			return PtrAbs(pAbs, disp, 64);
		}

		public static Memory ZWordPtrAbs(IntPtr pAbs, GpRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 64);
		}

		public static Memory ZWordPtrAbs(IntPtr pAbs, XmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 64);
		}

		public static Memory ZWordPtrAbs(IntPtr pAbs, YmmRegister index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, index, shift, disp, 64);
		}

		public static Memory Byte(GpVariable @base, int disp = 0)
		{
			return new Memory(@base, disp, 1);
		}

		public static Memory Byte(GpVariable @base, GpVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 1);
		}

		public static Memory Byte(GpVariable @base, XmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 1);
		}

		public static Memory Byte(GpVariable @base, YmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 1);
		}

		public static Memory Byte(Label label, GpVariable index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 1);
		}

		public static Memory ByteAbs(IntPtr pAbs, GpVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 1);
		}

		public static Memory ByteAbs(IntPtr pAbs, XmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 1);
		}

		public static Memory ByteAbs(IntPtr pAbs, YmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 1);
		}

		public static Memory Word(GpVariable @base, int disp = 0)
		{
			return new Memory(@base, disp, 2);
		}

		public static Memory Word(GpVariable @base, GpVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 2);
		}

		public static Memory Word(GpVariable @base, XmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 2);
		}

		public static Memory Word(GpVariable @base, YmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 2);
		}

		public static Memory Word(Label label, GpVariable index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 2);
		}

		public static Memory WordAbs(IntPtr pAbs, GpVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 2);
		}

		public static Memory WordAbs(IntPtr pAbs, XmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 2);
		}

		public static Memory WordAbs(IntPtr pAbs, YmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 2);
		}

		public static Memory DWord(GpVariable @base, int disp = 0)
		{
			return new Memory(@base, disp, 4);
		}

		public static Memory DWord(GpVariable @base, GpVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 4);
		}

		public static Memory DWord(GpVariable @base, XmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 4);
		}

		public static Memory DWord(GpVariable @base, YmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 4);
		}

		public static Memory DWord(Label label, GpVariable index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 4);
		}

		public static Memory DWordAbs(IntPtr pAbs, GpVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 4);
		}

		public static Memory DWordAbs(IntPtr pAbs, XmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 4);
		}

		public static Memory DWordAbs(IntPtr pAbs, YmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 4);
		}

		public static Memory QWord(GpVariable @base, int disp = 0)
		{
			return new Memory(@base, disp, 8);
		}

		public static Memory QWord(GpVariable @base, GpVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 8);
		}

		public static Memory QWord(GpVariable @base, XmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 8);
		}

		public static Memory QWord(GpVariable @base, YmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 8);
		}

		public static Memory QWord(Label label, GpVariable index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 8);
		}

		public static Memory QWordAbs(IntPtr pAbs, GpVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 8);
		}

		public static Memory QWordAbs(IntPtr pAbs, XmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 8);
		}

		public static Memory QWordAbs(IntPtr pAbs, YmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 8);
		}

		public static Memory TWord(GpVariable @base, int disp = 0)
		{
			return new Memory(@base, disp, 10);
		}

		public static Memory TWord(GpVariable @base, GpVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 10);
		}

		public static Memory TWord(GpVariable @base, XmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 10);
		}

		public static Memory TWord(GpVariable @base, YmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 10);
		}

		public static Memory TWord(Label label, GpVariable index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 10);
		}

		public static Memory TWordAbs(IntPtr pAbs, GpVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 10);
		}

		public static Memory TWordAbs(IntPtr pAbs, XmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 10);
		}

		public static Memory TWordAbs(IntPtr pAbs, YmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 10);
		}

		public static Memory OWord(GpVariable @base, int disp = 0)
		{
			return new Memory(@base, disp, 16);
		}

		public static Memory OWord(GpVariable @base, GpVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 16);
		}

		public static Memory OWord(GpVariable @base, XmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 16);
		}

		public static Memory OWord(GpVariable @base, YmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 16);
		}

		public static Memory OWord(Label label, GpVariable index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 16);
		}

		public static Memory OWord(IntPtr pAbs, GpVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 16);
		}

		public static Memory OWord(IntPtr pAbs, XmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 16);
		}

		public static Memory OWord(IntPtr pAbs, YmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 16);
		}

		public static Memory YWord(GpVariable @base, int disp = 0)
		{
			return new Memory(@base, disp, 32);
		}

		public static Memory YWord(GpVariable @base, GpVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 32);
		}

		public static Memory YWord(GpVariable @base, XmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 32);
		}

		public static Memory YWord(GpVariable @base, YmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 32);
		}

		public static Memory YWord(Label label, GpVariable index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 32);
		}

		public static Memory YWordAbs(IntPtr pAbs, GpVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 32);
		}

		public static Memory YWordAbs(IntPtr pAbs, XmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 32);
		}

		public static Memory YWordAbs(IntPtr pAbs, YmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 32);
		}

		public static Memory ZWord(GpVariable @base, int disp = 0)
		{
			return new Memory(@base, disp, 64);
		}

		public static Memory ZWord(GpVariable @base, GpVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 64);
		}

		public static Memory ZWord(GpVariable @base, XmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 64);
		}

		public static Memory ZWord(GpVariable @base, YmmVariable index, int shift = 0, int disp = 0)
		{
			return Ptr(@base, index, shift, disp, 64);
		}

		public static Memory ZWord(Label label, GpVariable index, int shift, int disp = 0)
		{
			return Ptr(label, index, shift, disp, 64);
		}

		public static Memory ZWordAbs(IntPtr pAbs, GpVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 64);
		}

		public static Memory ZWordAbs(IntPtr pAbs, XmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 64);
		}

		public static Memory ZWordAbs(IntPtr pAbs, YmmVariable index, int shift = 0, int disp = 0)
		{
			return PtrAbs(pAbs, (index), shift, disp, 64);
		}
	}
}