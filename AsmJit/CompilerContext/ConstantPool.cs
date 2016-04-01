using System;
using AsmJit.Common;

namespace AsmJit.CompilerContext
{
	internal class ConstantPool
	{
		internal interface IVisitor
		{
			void Visit(Node node);
		}

		internal class Gap
		{
			internal Gap Next { get; set; }

			internal int Offset { get; set; }

			internal int Length { get; set; }
		}

		internal class Tree
		{
			internal const int HeightLimit = 64;

			internal Node Root { get; set; }

			internal int Length { get; set; }

			internal int DataSize { get; set; }

			internal Tree(int dataSize = 0)
			{
				DataSize = dataSize;
			}

			internal void Reset()
			{
				Root = null;
				Length = 0;
			}

			internal bool Empty
			{
				get { return Length == 0; }
			}

			internal void Iterate(IVisitor visitor)
			{
				var node = Root;
				var stack = new Node[HeightLimit];
				if (node == null) return;

				var top = 0;

				for (; ; )
				{
					var link = node.Link[0];

					if (link != null)
					{
						if (!(top != HeightLimit)) { throw new ArgumentException(); }
						stack[top++] = node;

						node = link;
						continue;
					}

				_Visit:
					visitor.Visit(node);
					link = node.Link[1];

					if (link != null)
					{
						node = link;
						continue;
					}

					if (top == 0) break;

					node = stack[--top];
					goto _Visit;
				}
			}

			internal static Node NewNode(Pointer data, int size, int offset, bool shared)
			{
				var node = new Node();
				node.Link[0] = null;
				node.Link[1] = null;
				node.Level = 1;
				node.Shared = shared;
				node.Offset = offset;
				node.Data = UnsafeMemory.Allocate(size);
				UnsafeMemory.Copy(node.Data, data, size);
				return node;
			}

			internal Node Get(Pointer data)
			{
				var node = Root;
				var dataSize = DataSize;

				while (node != null)
				{
					var c = UnsafeMemory.Compare(node.Data, data, dataSize);
					if (c == 0)
					{
						return node;
					}
					node = node.Link[c < 0 ? 1 : 0];
				}

				return null;
			}

			internal void Put(Node newNode)
			{
				var dataSize = DataSize;

				Length++;
				if (Root == null)
				{
					Root = newNode;
					return;
				}

				var node = Root;
				var stack = new Node[HeightLimit];

				var top = 0;
				int dir;

				// Find a spot and save the stack.
				for (; ; )
				{
					stack[top++] = node;
					dir = UnsafeMemory.Compare(node.Data, newNode.Data, dataSize) < 0 ? 1 : 0;

					var link = node.Link[dir];
					if (link == null) break;

					node = link;
				}

				// Link and rebalance.
				node.Link[dir] = newNode;

				while (top > 0)
				{
					// Which child?
					node = stack[--top];

					if (top != 0)
					{
						dir = stack[top - 1].Link[1] == node ? 1 : 0;
					}

					node = SkewNode(node);
					node = SplitNode(node);

					// Fix the parent.
					if (top != 0)
					{
						stack[top - 1].Link[dir] = node;
					}
					else
					{
						Root = node;
					}
				}
			}
		}

		internal class Node
		{
			internal Node[] Link { get; private set; }

			internal int Level { get; set; }

			internal bool Shared { get; set; }

			internal int Offset { get; set; }

			internal Pointer Data { get; set; }

			internal Node()
			{
				Link = new Node[2];
			}
		}

		internal enum Index
		{
			Index1 = 0,
			Index2 = 1,
			Index4 = 2,
			Index8 = 3,
			Index16 = 4,
			Index32 = 5,
			IndexCount = 6
		}

		private Tree[] _tree = new Tree[(int)Index.IndexCount];
		private Gap[] _gaps = new Gap[(int)Index.IndexCount];
		private Gap _gapPool;

		internal ConstantPool()
		{
			var dataSize = 1;
			for (var i = 0; i < _tree.Length; i++)
			{
				_tree[i] = new Tree(dataSize);
				_gaps[i] = null;
				dataSize <<= 1;
			}

			_gapPool = null;
			Size = 0;
			Alignment = 0;
		}

		internal int Size { get; private set; }

		internal int Alignment { get; private set; }

		internal void Reset()
		{
			for (var i = 0; i < _tree.Length; i++)
			{
				_tree[i].Reset();
				_gaps[i] = null;
			}

			_gapPool = null;
			Size = 0;
			Alignment = 0;
		}

		internal static Node SkewNode(Node node)
		{
			var link = node.Link[0];
			var level = node.Level;

			if (level == 0 || link == null || link.Level != level)
			{
				return node;
			}
			node.Link[0] = link.Link[1];
			link.Link[1] = node;

			node = link;

			return node;
		}

		internal static Node SplitNode(Node node)
		{
			var link = node.Link[1];
			var level = node.Level;

			if (level == 0 || link == null || link.Link[1] == null || link.Link[1].Level != level)
			{
				return node;
			}
			node.Link[1] = link.Link[0];
			link.Link[0] = node;

			node = link;
			node.Level++;

			return node;
		}

		internal Gap AllocGap()
		{
			var gap = _gapPool;
			if (gap == null)
			{
				return new Gap();
			}
			_gapPool = gap.Next;
			return gap;
		}

		internal void FreeGap(Gap gap)
		{
			gap.Next = _gapPool;
			_gapPool = gap;
		}

		internal void AddGap(int offset, int length)
		{
			while (length > 0)
			{
				int gapIndex;
				int gapLength;

				if (length >= 16 && offset.IsAligned(16))
				{
					gapIndex = (int)Index.Index16;
					gapLength = 16;
				}
				else if (length >= 8 && offset.IsAligned(8))
				{
					gapIndex = (int)Index.Index8;
					gapLength = 8;
				}
				else if (length >= 4 && offset.IsAligned(4))
				{
					gapIndex = (int)Index.Index4;
					gapLength = 4;
				}
				else if (length >= 2 && offset.IsAligned(2))
				{
					gapIndex = (int)Index.Index2;
					gapLength = 2;
				}
				else
				{
					gapIndex = (int)Index.Index1;
					gapLength = 1;
				}

				// We don't have to check for errors here, if this failed nothing really
				// happened (just the gap won't be visible) and it will fail again at
				// place where checking will cause kErrorNoHeapMemory.
				var gap = AllocGap();
				if (gap == null) return;

				gap.Next = _gaps[gapIndex];
				_gaps[gapIndex] = gap;

				gap.Offset = offset;
				gap.Length = gapLength;

				offset += gapLength;
				length -= gapLength;
			}
		}

		internal void Add(Pointer data, int size, ref int dstOffset)
		{
			int treeIndex;
			switch (size)
			{
				case 32:
					treeIndex = (int)Index.Index32;
					break;
				case 16:
					treeIndex = (int)Index.Index16;
					break;
				case 8:
					treeIndex = (int)Index.Index8;
					break;
				case 4:
					treeIndex = (int)Index.Index4;
					break;
				case 2:
					treeIndex = (int)Index.Index2;
					break;
				case 1:
					treeIndex = (int)Index.Index1;
					break;
				default:
					throw new ArgumentException();
			}

			var node = _tree[treeIndex].Get(data);
			if (node != null)
			{
				dstOffset = node.Offset;
				return;
			}

			// Before incrementing the current offset try if there is a gap that can
			// be used for the requested data.
			var offset = int.MinValue;
			var gapIndex = treeIndex;

			while (gapIndex != (int)Index.IndexCount - 1)
			{
				var gap = _gaps[treeIndex];

				// Check if there is a gap.
				if (gap != null)
				{
					var gapOffset = gap.Offset;
					var gapLength = gap.Length;

					// Destroy the gap for now.
					_gaps[treeIndex] = gap.Next;
					FreeGap(gap);

					offset = gapOffset;
					if (!offset.IsAligned(size))
					{
						throw new Exception("Alignment required");
					}

					gapLength -= size;
					if (gapLength > 0)
					{
						AddGap(gapOffset, gapLength);
					}
				}

				gapIndex++;
			}

			if (offset == int.MinValue)
			{
				// Get how many bytes have to be skipped so the address is aligned accordingly
				// to the 'size'.
				var diff = Size.AlignDiff(size);

				if (diff != 0)
				{
					AddGap(Size, diff);
					Size += diff;
				}

				offset = Size;
				Size += size;
			}

			// Add the initial node to the right index.
			node = Tree.NewNode(data, size, offset, false);
			if (node == null)
			{
				throw new OutOfMemoryException();
			}

			_tree[treeIndex].Put(node);
			Alignment = Math.Max(Alignment, size);

			dstOffset = offset;

			// Now create a bunch of shared constants that are based on the data pattern.
			// We stop at size 4, it probably doesn't make sense to split constants down
			// to 1 byte.
			var count = 1;
			while (size > 4)
			{
				size >>= 1;
				count <<= 1;

				if (treeIndex == 0)
				{
					throw new IndexOutOfRangeException();
				}
				treeIndex--;

				var pData = data;
				for (var i = 0; i < count; i++, pData += size)
				{
					node = _tree[treeIndex].Get(pData);

					if (node != null)
						continue;

					node = Tree.NewNode(pData, size, offset + (i * size), true);
					_tree[treeIndex].Put(node);
				}
			}
		}

		internal struct ConstPoolFill : IVisitor
		{
			public Pointer Dst;
			public int DataSize;

			public ConstPoolFill(Pointer dst, int dataSize)
			{
				Dst = dst;
				DataSize = dataSize;
			}

			public void Visit(Node node)
			{
				if (!node.Shared)
				{
					UnsafeMemory.Copy(Dst + node.Offset, node.Data, DataSize);
				}
			}
		}

		internal void Fill(Pointer dst)
		{
			UnsafeMemory.Fill(dst, 0, Size);
			var filler = new ConstPoolFill(dst, 1);
			foreach (var t in _tree)
			{
				t.Iterate(filler);
				filler.DataSize <<= 1;
			}
		}
	}
}
