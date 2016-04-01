using System;
using System.Collections.Generic;
using System.Linq;
using AsmJit.Common;
using AsmJit.Common.Operands;

namespace AsmJit.AssemblerContext
{
	public sealed class Assembler
	{
		internal const int MaxLookAhead = 64;

		private static int _idGenerator;

		private List<LabelData> _labels = new List<LabelData>();
		private AssemblerFeatures _features;
		private InstructionOptions _instructionOptions;
		private CodeBuffer _codeBuffer;
		private int _id;
		private CodeContext _codeContext;
		private List<DataBlock> _data = new List<DataBlock>();

		internal Assembler()
		{
			_codeBuffer = new CodeBuffer(this);
			_codeContext = new CodeContext(this);

			if (Constants.X64)
			{
				Zdi = new GpRegister(Cpu.Registers.Rdi);
				Zsi = new GpRegister(Cpu.Registers.Rsi);
				Zbp = new GpRegister(Cpu.Registers.Rbp);
				Zsp = new GpRegister(Cpu.Registers.Rsp);
				Zbx = new GpRegister(Cpu.Registers.Rbx);
				Zdx = new GpRegister(Cpu.Registers.Rdx);
				Zcx = new GpRegister(Cpu.Registers.Rcx);
				Zax = new GpRegister(Cpu.Registers.Rax);
			}
			else
			{
				Zdi = new GpRegister(Cpu.Registers.Edi);
				Zsi = new GpRegister(Cpu.Registers.Esi);
				Zbp = new GpRegister(Cpu.Registers.Ebp);
				Zsp = new GpRegister(Cpu.Registers.Esp);
				Zbx = new GpRegister(Cpu.Registers.Ebx);
				Zdx = new GpRegister(Cpu.Registers.Edx);
				Zcx = new GpRegister(Cpu.Registers.Ecx);
				Zax = new GpRegister(Cpu.Registers.Eax);
			}

			_id = _idGenerator++;
			_features |= AssemblerFeatures.OptimizedAlign;
			_instructionOptions = InstructionOptions.None;
		}

		public static CodeContext<T> CreateContext<T>()
		{
			var t = typeof(T);

			var args = new Type[0];
			Type delType;
			if (t == typeof(Action))
			{
				delType = DelegateCreator.NewDelegateType(args);
			}
			else if (Utils.Actions.Contains(t.GetGenericTypeDefinition()))
			{
				var gargs = t.GetGenericArguments();
				args = new Type[gargs.Length].InitializeWith(i => gargs[i]);
				delType = DelegateCreator.NewDelegateType(args);
			}
			else if (Utils.Funcs.Contains(t.GetGenericTypeDefinition()))
			{
				var gargs = t.GetGenericArguments();
				args = new Type[gargs.Length - 1].InitializeWith(i => gargs[i]);
				var ret = gargs.Last();
				delType = DelegateCreator.NewDelegateType(ret, args);
			}
			else
			{
				throw new ArgumentException();
			}
			var asm = new Assembler();
			var ctx = new CodeContext<T>(asm, delType);
			asm._codeContext = ctx;
			return ctx;
		}

		internal GpRegister Zax { get; private set; }

		internal GpRegister Zcx { get; private set; }

		internal GpRegister Zdx { get; private set; }

		internal GpRegister Zbx { get; private set; }

		internal GpRegister Zsp { get; private set; }

		internal GpRegister Zbp { get; private set; }

		internal GpRegister Zsi { get; private set; }

		internal GpRegister Zdi { get; private set; }

		internal bool HasFeature(AssemblerFeatures feature)
		{
			return _features.IsSet(feature);
		}

		internal Pointer BaseAddress { get; set; }

		internal InstructionOptions GetInstructionOptionsAndReset()
		{
			var options = _instructionOptions;
			_instructionOptions = InstructionOptions.None;
			return options;
		}

		public void Data(Label label, int alignment, params Data[] data)
		{
			_data.Add(new DataBlock(label, alignment, data));
		}

		internal LabelData CreateLabelData(out int id)
		{
			var data = new LabelData(_id);
			id = _labels.Count;
			_labels.Add(data);
			return data;
		}

		internal LabelData GetLabelData(long id)
		{
			return _labels[(int)id];
		}

		internal void Unfollow()
		{
			_instructionOptions |= InstructionOptions.Unfollow;
		}

		internal Label CreateLabel()
		{
			int id;
			CreateLabelData(out id);
			return new Label(id);
		}

		internal void Embed(Pointer data, int size)
		{
			_codeBuffer.Embed(data, size);
		}

		internal void Align(AligningMode alignMode, int offset)
		{
			_codeBuffer.Align(alignMode, offset);
		}

		internal void Bind(int labelId)
		{
			_codeBuffer.Bind(labelId);
		}

		internal Pointer Make()
		{
			unsafe
			{
				foreach (var dataItem in _data)
				{
					if (dataItem.Label == null)
					{
						throw new ArgumentException();
					}
					Align(AligningMode.Data, dataItem.Alignment);
					Bind(dataItem.Label.Id);
					foreach (var v in dataItem.Data)
					{
						fixed (byte* pv = v.ByteData)
						{
							Embed(pv, v.ByteData.Length);
						}
					}
				}
			}
			return _codeBuffer.Make();
		}

		internal Pointer Make(out int codeSize)
		{
			return _codeBuffer.Make(out codeSize);
		}

		internal void Emit(InstructionId instructionId)
		{
			_codeBuffer.Emit(instructionId, Operand.Invalid, Operand.Invalid, Operand.Invalid, Operand.Invalid, _instructionOptions);
		}

		internal void Emit(InstructionId instructionId, Operand o0)
		{
			o0 = o0 ?? Operand.Invalid;
			_codeBuffer.Emit(instructionId, o0, Operand.Invalid, Operand.Invalid, Operand.Invalid, _instructionOptions);
		}

		internal void Emit(InstructionId instructionId, Operand o0, Operand o1)
		{
			o0 = o0 ?? Operand.Invalid;
			o1 = o1 ?? Operand.Invalid;
			_codeBuffer.Emit(instructionId, o0, o1, Operand.Invalid, Operand.Invalid, _instructionOptions);
		}

		internal void Emit(InstructionId instructionId, Operand o0, Operand o1, Operand o2)
		{
			o0 = o0 ?? Operand.Invalid;
			o1 = o1 ?? Operand.Invalid;
			o2 = o2 ?? Operand.Invalid;
			_codeBuffer.Emit(instructionId, o0, o1, o2, Operand.Invalid, _instructionOptions);
		}

		internal void Emit(InstructionId instructionId, Operand o0, Operand o1, Operand o2, Operand o3)
		{
			o0 = o0 ?? Operand.Invalid;
			o1 = o1 ?? Operand.Invalid;
			o2 = o2 ?? Operand.Invalid;
			o3 = o3 ?? Operand.Invalid;
			_codeBuffer.Emit(instructionId, o0, o1, o2, o3, _instructionOptions);
		}

		internal void Emit(InstructionId instructionId, Operand o0, Operand o1, Operand o2, Operand o3, InstructionOptions options)
		{
			_instructionOptions = options;
			Emit(instructionId, o0, o1, o2, o3);
		}
	}
}
