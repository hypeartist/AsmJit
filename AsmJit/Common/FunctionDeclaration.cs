using System;
using System.ComponentModel;
using AsmJit.AssemblerContext;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext;

namespace AsmJit.Common
{
	internal sealed class FunctionDeclaration
	{
		internal const int MaxArgumentCount = 16;

		private int[] _passedOrderGp = new int[8].InitializeWith(() => -1);
		private int[] _passedOrderXyz = new int[8].InitializeWith(() => -1);

		private FunctionInOut[] _arguments;
		private FunctionInOut[] _returns;

		private ArgumentPassingDirection _argumentPassingDirection;

		internal FunctionDeclaration(CallingConvention callingConvention, VariableType[] arguments, VariableType @return)
		{
			Used = new RegisterMask();
			Passed = new RegisterMask();
			Preserved = new RegisterMask();
			CallingConvention = callingConvention == CallingConvention.Default ? Constants.DefaultCallingConvention : callingConvention;
			_returns = new FunctionInOut[2];
			_arguments = new FunctionInOut[arguments.Length];
			Init(arguments, @return);
		}

		internal CallingConvention CallingConvention { get; private set; }

		internal bool CalleePopsStack { get; private set; }

		internal int ArgumentCount
		{
			get { return _arguments.Length; }
		}

		internal int ReturnCount { get; private set; }

		internal int ArgumentsStackSize { get; private set; }

		internal int RedZoneSize { get; private set; }

		internal int SpillZoneSize { get; private set; }

		public RegisterMask Preserved { get; private set; }

		public RegisterMask Passed { get; private set; }

		public RegisterMask Used { get; private set; }

		internal FunctionInOut GetArgument(int index)
		{
			if (!(index >= 0 && index < _arguments.Length)) { throw new ArgumentException(); }
			return _arguments[index];
		}

		internal FunctionInOut GetReturn(int index)
		{
			if (!(index >= 0 && index < _returns.Length)) { throw new ArgumentException(); }
			return _returns[index];
		}

		private void Init(VariableType[] arguments, VariableType @return)
		{
			if (_arguments.Length > MaxArgumentCount)
			{
				throw new ArgumentException();
			}
			InitCallingConvention();
			InitFunction(@return, arguments);
		}

		private void InitCallingConvention()
		{
			ArgumentsStackSize = 0;
			RedZoneSize = 0;
			SpillZoneSize = 0;

			CalleePopsStack = false;

			Passed.Reset();
			Preserved.Reset();

			if (Constants.X64)
			{
				switch (CallingConvention)
				{
					case CallingConvention.X64Win:
						SpillZoneSize = 32;
						Passed.Set(RegisterClass.Gp, Utils.Mask(RegisterIndex.Cx, RegisterIndex.Dx, 8, 9));
						_passedOrderGp[0] = RegisterIndex.Cx;
						_passedOrderGp[1] = RegisterIndex.Dx;
						_passedOrderGp[2] = 8;
						_passedOrderGp[3] = 9;

						Passed.Set(RegisterClass.Xyz, Utils.Mask(0, 1, 2, 3));
						_passedOrderXyz[0] = 0;
						_passedOrderXyz[1] = 1;
						_passedOrderXyz[2] = 2;
						_passedOrderXyz[3] = 3;

						Preserved.Set(RegisterClass.Gp, Utils.Mask(RegisterIndex.Bx, RegisterIndex.Sp, RegisterIndex.Bp, RegisterIndex.Si, RegisterIndex.Di, 12, 13, 14, 15));
						Preserved.Set(RegisterClass.Xyz, Utils.Mask(6, 7, 8, 9, 10, 11, 12, 13, 14, 15));
						break;
					case CallingConvention.X64Unix:
						RedZoneSize = 128;

						Passed.Set(RegisterClass.Gp, Utils.Mask(7, 6, 2, 1, 8, 9));
						_passedOrderGp[0] = 7;
						_passedOrderGp[1] = 6;
						_passedOrderGp[2] = 2;
						_passedOrderGp[3] = 1;
						_passedOrderGp[4] = 8;
						_passedOrderGp[5] = 9;

						Passed.Set(RegisterClass.Xyz, Utils.Mask(0, 1, 2, 3, 4, 5, 6, 7));
						_passedOrderXyz[0] = 0;
						_passedOrderXyz[1] = 1;
						_passedOrderXyz[2] = 2;
						_passedOrderXyz[3] = 3;
						_passedOrderXyz[4] = 4;
						_passedOrderXyz[5] = 5;
						_passedOrderXyz[6] = 6;
						_passedOrderXyz[7] = 7;

						Preserved.Set(RegisterClass.Gp, Utils.Mask(3, 4, 5, 12, 13, 14, 15));
						break;
				}
			}
			else
			{
				_argumentPassingDirection = ArgumentPassingDirection.RightToLeft;

				Preserved.Set(RegisterClass.Gp, Utils.Mask(3, 4, 5, 6, 7));
				switch (CallingConvention)
				{
					case CallingConvention.X86CDecl:
						break;
					case CallingConvention.X86StdCall:
						CalleePopsStack = true;
						break;
					case CallingConvention.X86MsThisCall:
						CalleePopsStack = true;
						Passed.Set(RegisterClass.Gp, Utils.Mask(1));
						_passedOrderGp[0] = 1;
						break;
					case CallingConvention.X86MsFastCall:
						CalleePopsStack = true;
						Passed.Set(RegisterClass.Gp, Utils.Mask(1, 1));
						_passedOrderGp[0] = 1;
						_passedOrderGp[1] = 2;
						break;
					case CallingConvention.X86BorlandFastCall:
						CalleePopsStack = true;
						_argumentPassingDirection = ArgumentPassingDirection.LeftToRight;
						Passed.Set(RegisterClass.Gp, Utils.Mask(0, 2, 1));
						_passedOrderGp[0] = 0;
						_passedOrderGp[1] = 2;
						_passedOrderGp[2] = 1;
						break;
					case CallingConvention.X86GccFastCall:
						CalleePopsStack = true;
						Passed.Set(RegisterClass.Gp, Utils.Mask(1, 2));
						_passedOrderGp[0] = 1;
						_passedOrderGp[1] = 2;
						break;
					case CallingConvention.X86GccRegParm1:
						Passed.Set(RegisterClass.Gp, Utils.Mask(0));
						_passedOrderGp[0] = 0;
						break;
					case CallingConvention.X86GccRegParm2:
						Passed.Set(RegisterClass.Gp, Utils.Mask(0, 2));
						_passedOrderGp[0] = 0;
						_passedOrderGp[1] = 2;
						break;
					case CallingConvention.X86GccRegParm3:
						Passed.Set(RegisterClass.Gp, Utils.Mask(0, 2, 1));
						_passedOrderGp[0] = 0;
						_passedOrderGp[1] = 2;
						_passedOrderGp[2] = 1;
						break;
				}
			}
		}

		private void InitFunction(VariableType ret, VariableType[] args)
		{
			var callConv = CallingConvention;

			int i;
			var gpPos = 0;
			var xmmPos = 0;
			var stackOffset = 0;
			ReturnCount = 0;

			var argumets = new ValueSet<VariableType, int, int>[args.Length];
			for (i = 0; i < args.Length; i++)
			{
				argumets[i] = new ValueSet<VariableType, int, int>
				{
					Value0 = args[i].GetMappedType(),
					Value1 = Constants.InvalidValue,
					Value2 = Constants.InvalidValue
				};
			}

			ArgumentsStackSize = 0;
			Used.Reset();

			if (ret != VariableType.Invalid)
			{
				switch (ret)
				{
					case VariableType.Int8:
					case VariableType.UInt8:
					case VariableType.Int16:
					case VariableType.UInt16:
					case VariableType.Int32:
					case VariableType.UInt32:
						ReturnCount = 1;
						_returns[0] = new FunctionInOut(ret, 0);
						break;
					case VariableType.Int64:
						if (Constants.X64)
						{
							ReturnCount = 1;
							_returns[0] = new FunctionInOut(ret, 0);
						}
						else
						{
							ReturnCount = 2;
							_returns[0] = new FunctionInOut(VariableType.UInt32, 0);
							_returns[1] = new FunctionInOut(VariableType.Int32, 2);
						}
						break;
					case VariableType.UInt64:
						if (Constants.X64)
						{
							ReturnCount = 1;
							_returns[0] = new FunctionInOut(ret, 0);
						}
						else
						{
							ReturnCount = 2;
							_returns[0] = new FunctionInOut(VariableType.UInt32, 0);
							_returns[1] = new FunctionInOut(VariableType.UInt32, 2);
						}
						break;
					case VariableType.Fp32:
						ReturnCount = 1;
						if (Constants.X64)
						{
							_returns[0] = new FunctionInOut(VariableType.XmmSs, 0);
						}
						else
						{
							_returns[0] = new FunctionInOut(VariableType.Fp32, 0);
						}
						break;
					case VariableType.Fp64:
						ReturnCount = 1;
						if (Constants.X64)
						{
							_returns[0] = new FunctionInOut(VariableType.XmmSd, 0);
						}
						else
						{
							_returns[0] = new FunctionInOut(VariableType.Fp64, 0);
						}
						break;
					case VariableType.Mm:
					case VariableType.Xmm:
					case VariableType.XmmSs:
					case VariableType.XmmPs:
					case VariableType.XmmSd:
					case VariableType.XmmPd:
						ReturnCount = 1;
						_returns[0] = new FunctionInOut(ret, 0);
						break;
					default:
						throw new InvalidEnumArgumentException();
				}
			}

			if (args.Length == 0) return;

			VariableType varType;

			if (Constants.X64)
			{
				if (callConv == CallingConvention.X64Win)
				{
					var argMax = Math.Min(args.Length, 4);

					// Register arguments (Gp/Xmm), always left-to-right.
					for (i = 0; i != argMax; i++)
					{
						varType = argumets[i].Value0.GetMappedType();

						if (varType.IsInt() && i < _passedOrderGp.Length)
						{
							argumets[i].Value1 = _passedOrderGp[i];
							Used.Or(RegisterClass.Gp, Utils.Mask(argumets[i].Value1));
							continue;
						}

						if (!varType.IsFp() || i >= _passedOrderXyz.Length) continue;
						argumets[i].Value0 = varType.ToXmm();
						argumets[i].Value1 = _passedOrderXyz[i];
						Used.Or(RegisterClass.Xyz, Utils.Mask(argumets[i].Value1));
					}

					// Stack arguments (always right-to-left).
					for (i = args.Length - 1; i != -1; i--)
					{
						varType = argumets[i].Value0.GetMappedType();

						if (argumets[i].Value1 != Constants.InvalidValue) continue;

						if (varType.IsInt())
						{
							stackOffset -= 8; // Always 8 bytes.
							argumets[i].Value2 = stackOffset;
						}
						else if (varType.IsFp())
						{
							stackOffset -= 8; // Always 8 bytes (float/double).
							argumets[i].Value2 = stackOffset;
						}
					}
					// 32 bytes shadow space (X64W calling convention specific).
					stackOffset -= 4 * 8;
				}
				else
				{
					// Register arguments (Gp), always left-to-right.
					for (i = 0; i != args.Length; i++)
					{
						varType = argumets[i].Value0.GetMappedType();

						if (!varType.IsInt() || gpPos >= _passedOrderGp.Length) continue;

						if (_passedOrderGp[gpPos] == -1) continue;

						argumets[i].Value1 = _passedOrderGp[gpPos++];
						Used.Or(RegisterClass.Gp, Utils.Mask(argumets[i].Value1));
					}

					// Register arguments (Xmm), always left-to-right.
					for (i = 0; i != args.Length; i++)
					{
						varType = argumets[i].Value0.GetMappedType();

						if (!varType.IsFp()) continue;
						argumets[i].Value0 = varType.ToXmm();
						argumets[i].Value1 = _passedOrderXyz[xmmPos++];
						Used.Or(RegisterClass.Xyz, Utils.Mask(argumets[i].Value1));
					}

					// Stack arguments.
					for (i = args.Length - 1; i != -1; i--)
					{
						varType = argumets[i].Value0.GetMappedType();

						if (argumets[i].Value1 != Constants.InvalidValue) continue;

						if (varType.IsInt())
						{
							stackOffset -= 8;
							argumets[i].Value2 = stackOffset;
						}
						else if (varType.IsFp())
						{
							var size = varType.GetVariableInfo().Size;

							stackOffset -= size;
							argumets[i].Value2 = stackOffset;
						}
					}
				}
			}
			else
			{
				for (i = 0; i != args.Length; i++)
				{
					varType = args[i].GetMappedType();

					if (!varType.IsInt() || gpPos >= _passedOrderGp.Length) continue;

					if (_passedOrderGp[gpPos] == -1) continue;

					argumets[i].Value1 = _passedOrderGp[gpPos++];
					Used.Or(RegisterClass.Gp, Utils.Mask(argumets[i].Value1));
				}

				// Stack arguments.
				var start = args.Length - 1;
				var end = -1;
				var step = -1;

				if (_argumentPassingDirection == ArgumentPassingDirection.LeftToRight)
				{
					start = 0;
					end = args.Length;
					step = 1;
				}

				for (i = start; i != end; i += step)
				{
					varType = args[i].GetMappedType();

					if (argumets[i].Value1 != Constants.InvalidValue) continue;

					if (varType.IsInt())
					{
						stackOffset -= 4;
						argumets[i].Value2 = stackOffset;
					}
					else if (varType.IsFp())
					{
						var size = varType.GetVariableInfo().Size;
						stackOffset -= size;
						argumets[i].Value2 = stackOffset;
					}
				}
			}

			// Modify the stack offset, thus in result all parameters would have positive
			// non-zero stack offset.
			for (i = 0; i < args.Length; i++)
			{
				if (argumets[i].Value1 == Constants.InvalidValue)
				{
					argumets[i].Value2 += Cpu.Info.RegisterSize - stackOffset;
				}
				_arguments[i] = new FunctionInOut(argumets[i].Value0, argumets[i].Value1, argumets[i].Value2);
			}

			ArgumentsStackSize = -stackOffset;
		}
	}
}