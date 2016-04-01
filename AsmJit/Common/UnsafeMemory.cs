using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace AsmJit.Common
{
	public static unsafe class UnsafeMemory
	{
		private static Action<IntPtr, byte, int> _memsetDelegate;
		private static Action<IntPtr, IntPtr, int> _memcopyDelegate;
		private static Pointer _processHandle;
		private static int _pageSize;

		static UnsafeMemory()
		{
			var methodMemset = new DynamicMethod("Memset", MethodAttributes.Public | MethodAttributes.Static, CallingConventions.Standard, null, new[] { typeof(IntPtr), typeof(byte), typeof(int) }, typeof(UnsafeMemory), true);
			var methodMemcopy = new DynamicMethod("Memcopy", MethodAttributes.Public | MethodAttributes.Static, CallingConventions.Standard, null, new[] { typeof(IntPtr), typeof(IntPtr), typeof(int) }, typeof(UnsafeMemory), true);

			var generator1 = methodMemset.GetILGenerator();
			generator1.Emit(OpCodes.Ldarg_0);
			generator1.Emit(OpCodes.Ldarg_1);
			generator1.Emit(OpCodes.Ldarg_2);
			generator1.Emit(OpCodes.Initblk);
			generator1.Emit(OpCodes.Ret);

			_memsetDelegate = (Action<IntPtr, byte, int>)methodMemset.CreateDelegate(typeof(Action<IntPtr, byte, int>));

			var generator2 = methodMemcopy.GetILGenerator();
			generator2.Emit(OpCodes.Ldarg_0);
			generator2.Emit(OpCodes.Ldarg_1);
			generator2.Emit(OpCodes.Ldarg_2);
			generator2.Emit(OpCodes.Cpblk);
			generator2.Emit(OpCodes.Ret);

			_memcopyDelegate = (Action<IntPtr, IntPtr, int>)methodMemcopy.CreateDelegate(typeof(Action<IntPtr, IntPtr, int>));

			Win32.SystemInfo info;
			Win32.NativeMethods.GetSystemInfo(out info);

			_pageSize = ((int)info.PageSize).AlignToPowerOf2();
			_processHandle = Win32.NativeMethods.GetCurrentProcess();
		}

		internal static Pointer Allocate(int count, bool @protected = false)
		{
			if (!@protected)
			{
				return new Pointer((byte*)Marshal.AllocHGlobal(count), count);
			}
			const ProtectedMemoryMode mode = ProtectedMemoryMode.Executable | ProtectedMemoryMode.Writable;
			// VirtualAlloc rounds allocated size to a page size automatically.
			var size = count.AlignTo(_pageSize);

			// Windows XP SP2 / Vista allow Data Excution Prevention (DEP).
			Win32.MemoryProtectionType protectFlags = 0;

			if (mode.IsSet(ProtectedMemoryMode.Executable))
			{
				protectFlags |= mode.IsSet(ProtectedMemoryMode.Writable) ? Win32.MemoryProtectionType.ExecuteReadWrite : Win32.MemoryProtectionType.ExecuteRead;
			}
			else
			{
				protectFlags |= mode.IsSet(ProtectedMemoryMode.Writable) ? Win32.MemoryProtectionType.ReadWrite : Win32.MemoryProtectionType.ReadOnly;
			}

			var @base = Win32.NativeMethods.VirtualAllocEx(_processHandle, IntPtr.Zero, (UIntPtr)size, Win32.VirtualAllocType.Commit | Win32.VirtualAllocType.Reserve, protectFlags);
			if (@base.IsInvalid)
			{
				return Pointer.Invalid;
			}
			var handle = @base.DangerousGetHandle();
			return new Pointer(handle, count, PointerFlags.Aligned | PointerFlags.Protected);
		}

		internal static Pointer Allocate(int count, int alignment)
		{
			// Allocation of aligned memory block. Default alignment is 16. (Is it good or?)
			byte* tmp;
			if ((tmp = (byte*)Marshal.AllocHGlobal(count + alignment)) == (void*)0)
			{
				return Pointer.Invalid;
			}
			var ptr = (byte*)((uint)(tmp + alignment - 1) & (~(uint)(alignment - 1)));

			if (ptr == tmp)
			{
				ptr += alignment;
			}
			*(ptr - 1) = (byte)(ptr - tmp);
			return new Pointer(ptr, count, PointerFlags.Aligned);
		}

		internal static Pointer Reallocate(Pointer p, int size)
		{
			if (p.Flags.IsSet(PointerFlags.Protected))
			{
				throw new ArgumentException("Protected memory cannot be realocated");
			}
			var tmp = Allocate(size);
			if (p != Pointer.Invalid)
			{
				Copy(tmp, p, p.DataSize > size ? size : p.DataSize);
			}
			Free(p);
			return tmp;
		}

		internal static void Free(Pointer ptr)
		{
			if (!ptr.Flags.IsSet(PointerFlags.Protected))
			{
				if (ptr.Flags.IsSet(PointerFlags.Aligned))
				{
					var p = (byte*)(IntPtr)ptr;
					Marshal.FreeHGlobal((IntPtr)(p - *(p - 1)));
				}
				else
				{
					Marshal.FreeHGlobal(ptr);
				}	
			}
			else
			{
				Win32.NativeMethods.VirtualFreeEx(_processHandle, ptr, (UIntPtr) 0, Win32.VirtualFreeType.Release);
			}
		}

		public static void Copy(Pointer dest, Pointer src, int count)
		{
			// Can't decide which way is better (or optimized?) delegate or manual one
			_memcopyDelegate(dest, src, count);

			//			var blocks = count >> 5;
			//			var dll = (Int128*)dest;
			//			var sll = (Int128*)src;
			//			while (blocks-- != 0)
			//			{
			//				*dll++ = *sll++;
			//			}
			//			var c = count - ((count >> 5) << 5);
			//			if (c == 0) return;
			//			var db = (byte*)dll;
			//			var sb = (byte*)sll;
			//			do
			//			{
			//				*db++ = *sb++;
			//			} while (--c != 0);
		}

		[DllImport("Kernel32.dll", EntryPoint = "RtlMoveMemory", SetLastError = false)]
		internal static extern void Move(Pointer dest, Pointer src, int size);

		[DllImport("msvcrt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
		static extern int memcmp(IntPtr b1, IntPtr b2, UIntPtr count);

		internal static int Compare(Pointer p1, Pointer p2, int count)
		{
			return memcmp(p1, p2, (UIntPtr)count);
		}

		internal static void Fill(Pointer ptr, byte value, int count)
		{
			_memsetDelegate(ptr, value, count);
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct Int128
		{
			internal long V1;
			internal long V2;
			internal long V3;
			internal long V4;
		}

		internal static void FillWithInt32(void* dest, int value, int count)
		{
			if (count < 2)
			{
				*(int*)dest = value;
			}
			else
			{
				var v = (value & 0xffffffff);
				var pv = (v << 32) | v;

				if (count < 8)
				{
					var blocks = count >> 1;
					var l = (long*)dest;
					do
					{
						*l++ = pv;
					} while (--blocks != 0);
					dest = l;
					var c = count - ((count >> 1) << 1);
					var i = (int*)dest;
					while (c-- != 0)
					{
						*i++ = value;
					}
				}
				else
				{
					var int128 = new Int128
					{
						V1 = pv,
						V2 = pv,
						V3 = pv,
						V4 = pv
					};

					var blocks = count >> 3;
					var l = (Int128*)dest;
					do
					{
						*l++ = int128;
					} while (--blocks != 0);
					dest = l;
					var c = count - ((count >> 3) << 3);
					var i = (int*)dest;
					while (c-- != 0)
					{
						*i++ = value;
					}
				}
			}
		}
	}
}
