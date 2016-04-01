using AsmJit.CompilerContext;

namespace AsmJit.Common.Operands
{
	public sealed class GpVariable : Variable
	{
		internal GpVariable(GpVariableType type)
			:base((VariableType) type)
		{			
		}

		internal GpVariable(GpVariableType type, int id)
			: base((VariableType) type)
		{
			Id = id;
			var varInfo = ((VariableType) type).GetVariableInfo();
			RegisterType = varInfo.RegisterType;
			Size = varInfo.Size;
		}

		internal GpVariable(GpVariable other)
			: base(other)
		{
		}

		private GpVariable(GpVariable other, GpRegisterType registerType, int size)
			:base(other)
		{
			RegisterType = (RegisterType) registerType;
			Size = size;
		}

		public Memory ToMemory(int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, disp, Size);
		}

		public Memory ToMemory(GpVariable index, int shift = 0, int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, index, shift, disp, Size);
		}

		public Memory ToMemory8(int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, disp, 1);
		}

		public Memory ToMemory8(GpVariable index, int shift = 0, int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, index, shift, disp, 1);
		}

		public Memory ToMemory16(int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, disp, 2);
		}

		public Memory ToMemory16(GpVariable index, int shift = 0, int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, index, shift, disp, 2);
		}

		public Memory ToMemory32(int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, disp, 4);
		}

		public Memory ToMemory32(GpVariable index, int shift = 0, int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, index, shift, disp, 4);
		}

		public Memory ToMemory64(int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, disp, 8);
		}

		public Memory ToMemory64(GpVariable index, int shift = 0, int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, index, shift, disp, 8);
		}

		public Memory ToMemory80(int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, disp, 10);
		}

		public Memory ToMemory80(GpVariable index, int shift = 0, int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, index, shift, disp, 10);
		}

		public Memory ToMemory128(int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, disp, 16);
		}

		public Memory ToMemory128(GpVariable index, int shift = 0, int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, index, shift, disp, 16);
		}

		public Memory ToMemory256(int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, disp, 32);
		}

		public Memory ToMemory256(GpVariable index, int shift = 0, int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, index, shift, disp, 32);
		}

		public Memory ToMemory512(int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, disp, 64);
		}

		public Memory ToMemory512(GpVariable index, int shift = 0, int disp = 0)
		{
			return new Memory(MemoryType.StackIndex, this, index, shift, disp, 64);
		}

		public GpVariable As8()
		{
			return new GpVariable(this, GpRegisterType.GpbLo, 1);
		}

		public GpVariable As8Lo()
		{
			return new GpVariable(this, GpRegisterType.GpbLo, 1);
		}

		public GpVariable As8Hi()
		{
			return new GpVariable(this, GpRegisterType.GpbHi, 1);
		}

		public GpVariable As16()
		{
			return new GpVariable(this, GpRegisterType.Gpw, 2);
		}

		public GpVariable As32()
		{
			return new GpVariable(this, GpRegisterType.Gpd, 4);
		}

		public GpVariable As64()
		{
			return new GpVariable(this, GpRegisterType.Gpq, 8);
		}
	}
}