using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace AsmJit.Common
{
	internal class Win32
	{
		internal struct CriticalSection
		{
			public IntPtr DebugInfo;
			public long LockCount;
			public long RecursionCount;
			public IntPtr OwningThread;
			public IntPtr LockSemaphore;
			public ulong SpinCount;
		}

		internal enum ProcessorArchitecture : ushort
		{
			Amd64 = 9,
			Ia64 = 6,
			Intel = 0,
			Unknown = 0xffff
		}

		internal enum ProcessorType : uint
		{
			Intel386 = 386,
			Intel486 = 486,
			IntelPentium = 586,
			IntelIa64 = 2200,
			AmdX8664 = 8664
		}

		[Flags]
		internal enum VirtualAllocType : uint
		{
			Commit = 0x1000,
			Reserve = 0x2000,
			Reset = 0x80000,
			LargePages = 0x20000000,
			Physical = 0x400000,
			TopDown = 0x100000,
			WriteWatch = 0x200000
		}

		[Flags]
		internal enum VirtualFreeType : uint
		{
			Decommit = 0x4000,
			Release = 0x8000
		}

		[Flags]
		internal enum MemoryProtectionType : uint
		{
			NoAccess = 0x01,
			ReadOnly = 0x02,
			ReadWrite = 0x04,
			WriteCopy = 0x08,
			Execute = 0x10,
			ExecuteRead = 0x20,
			ExecuteReadWrite = 0x40,
			ExecuteWriteCopy = 0x80,
			Guard = 0x100,
			NoCache = 0x200,
			WriteCombine = 0x400
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct MemoryBasicInformation
		{
			public UIntPtr BaseAddress;
			public UIntPtr AllocationBase;
			public uint AllocationProtect;
			public IntPtr RegionSize;
			public uint State;
			public uint Protect;
			public uint Type;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 2)]
		internal struct SystemInfo
		{
			public ProcessorArchitecture ProcessorArchitecture;
			private ushort Reserved;
			public uint PageSize;
			public IntPtr MinimumApplicationAddress;
			public IntPtr MaximumApplicationAddress;
			public IntPtr ActiveProcessorMask;
			public uint NumberOfProcessors;
			public ProcessorType ProcessorType;
			public uint AllocationGranularity;
			public ushort ProcessorLevel;
			public ushort ProcessorRevision;
		}

		[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
		internal class VirtualAllocRegion : SafeHandle
		{
			private VirtualAllocRegion()
				: base(IntPtr.Zero, true)
			{
			}

			public override bool IsInvalid
			{
				get { return handle == IntPtr.Zero; }
			}

			protected override bool ReleaseHandle()
			{
				return NativeMethods.VirtualFree(handle, (UIntPtr)0, VirtualFreeType.Release);
			}
		}

		internal static class NativeMethods
		{
			[SuppressUnmanagedCodeSecurity]
			[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
			public static extern IntPtr GetCurrentProcess();

			[SuppressUnmanagedCodeSecurity]
			[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool FlushInstructionCache(IntPtr processHandle, IntPtr address, uint regionSize);

			[SuppressUnmanagedCodeSecurity]
			[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
			public static extern void GetSystemInfo(out SystemInfo info);

			[SuppressUnmanagedCodeSecurity]
			[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
			public static extern VirtualAllocRegion VirtualAlloc(IntPtr address, UIntPtr size, VirtualAllocType allocType, MemoryProtectionType protectionType);

			//[SuppressUnmanagedCodeSecurity]
			//[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
			//public static extern VirtualAllocRegion VirtualAllocEx(IntPtr hProcess, IntPtr address, UIntPtr size, VirtualAllocType allocType, MemoryProtectionType protectionType);

			[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool VirtualFree(IntPtr address, UIntPtr size, VirtualFreeType allocType);

			[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr address, UIntPtr size, VirtualFreeType allocType);

			[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool VirtualProtect(IntPtr address, UIntPtr size, MemoryProtectionType protectionType, out MemoryProtectionType oldProtectionType);

			[DllImport("kernel32.dll")]
			public static extern int VirtualQuery(IntPtr lpAddress, ref MemoryBasicInformation lpBuffer, int dwLength
			);

			[DllImport("kernel32.dll")]
			public static extern void InitializeCriticalSection(out CriticalSection lpCriticalSection);

			[DllImport("kernel32.dll")]
			public static extern void EnterCriticalSection(ref CriticalSection lpCriticalSection);

			[DllImport("kernel32.dll")]
			public static extern void LeaveCriticalSection(ref CriticalSection lpCriticalSection);

			[DllImport("kernel32.dll")]
			public static extern void DeleteCriticalSection(ref CriticalSection lpCriticalSection);

			/// <summary>
			/// Allow copying memory from one IntPtr to another. Required as the <see cref="System.Runtime.InteropServices.Marshal.Copy(System.IntPtr, System.IntPtr[], int, int)"/> implementation does not provide an appropriate override.
			/// </summary>
			/// <param name="dest"></param>
			/// <param name="src"></param>
			/// <param name="count"></param>
			[DllImport("kernel32.dll", EntryPoint = "CopyMemory", SetLastError = false)]
			[SecurityCritical]
			internal static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);

			[DllImport("kernel32.dll", EntryPoint = "CopyMemory", SetLastError = false)]
			[SecurityCritical]
			internal static extern unsafe void CopyMemoryPtr(void* dest, void* src, uint count);
		}

		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct CPUInfo
		{
			public uint eax;
			public uint ebx;
			public uint ecx;
			public uint edx;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct XGetBVInfo
		{
			public uint eax;
			public uint edx;
			public uint ecx;
		}
	}
}
