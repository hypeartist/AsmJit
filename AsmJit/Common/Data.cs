using System;

namespace AsmJit.Common
{
	public class Data
	{
		private Data() {}

		public static Data Of(params byte[] v)
		{
			var d = new Data {ByteData = new byte[v.Length*sizeof(byte)]};
			Buffer.BlockCopy(v, 0, d.ByteData, 0, d.ByteData.Length);
			return d;
		}

		public static Data Of(params sbyte[] v)
		{
			var d = new Data { ByteData = new byte[v.Length * sizeof(sbyte)] };
			Buffer.BlockCopy(v, 0, d.ByteData, 0, d.ByteData.Length);
			return d;
		}

		public static Data Of(params short[] v)
		{
			var d = new Data { ByteData = new byte[v.Length * sizeof(short)] };
			Buffer.BlockCopy(v, 0, d.ByteData, 0, d.ByteData.Length);
			return d;
		}

		public static Data Of(params ushort[] v)
		{
			var d = new Data { ByteData = new byte[v.Length * sizeof(ushort)] };
			Buffer.BlockCopy(v, 0, d.ByteData, 0, d.ByteData.Length);
			return d;
		}

		public static Data Of(params uint[] v)
		{
			var d = new Data { ByteData = new byte[v.Length * sizeof(uint)] };
			Buffer.BlockCopy(v, 0, d.ByteData, 0, d.ByteData.Length);
			return d;
		}

		public static Data Of(params int[] v)
		{
			var d = new Data { ByteData = new byte[v.Length * sizeof(int)] };
			Buffer.BlockCopy(v, 0, d.ByteData, 0, d.ByteData.Length);
			return d;
		}

		public static Data Of(params ulong[] v)
		{
			var d = new Data { ByteData = new byte[v.Length * sizeof(ulong)] };
			Buffer.BlockCopy(v, 0, d.ByteData, 0, d.ByteData.Length);
			return d;
		}

		public static Data Of(params long[] v)
		{
			var d = new Data { ByteData = new byte[v.Length * sizeof(long)] };
			Buffer.BlockCopy(v, 0, d.ByteData, 0, d.ByteData.Length);
			return d;
		}

		public static Data Of(params float[] v)
		{
			var d = new Data { ByteData = new byte[v.Length * sizeof(float)] };
			Buffer.BlockCopy(v, 0, d.ByteData, 0, d.ByteData.Length);
			return d;
		}

		public static Data Of(params double[] v)
		{
			var d = new Data { ByteData = new byte[v.Length * sizeof(double)] };
			Buffer.BlockCopy(v, 0, d.ByteData, 0, d.ByteData.Length);
			return d;
		}

		internal byte[] ByteData { get; private set; }
	}
}