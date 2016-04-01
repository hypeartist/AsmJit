using System;
using AsmJit.Common;
using AsmJit.CompilerContext.CodeTree;

namespace AsmJit.CompilerContext
{
	internal sealed class LivenessAnalyzer
	{
		private FunctionNode _functionNode;
		private VariableContext _variableContext;

		private class LivenessTarget
		{
			public LivenessTarget Previous { get; set; }

			public LabelNode Node { get; set; }

			public JumpNode From { get; set; }
		}

		public LivenessAnalyzer(FunctionNode func, VariableContext ctx)
		{
			_functionNode = func;
			_variableContext = ctx;
		}

		public void Run()
		{
			var bLen = (_variableContext.ContextVd.Count + BitArray.EntityBits - 1) / BitArray.EntityBits;
			if (bLen == 0) return;
			var retPtr = 0;
			var node = _variableContext.ReturningList[retPtr];
			var bCur = new BitArray(bLen);

			OnVisit(node, null, null, null, bCur, bLen, ref retPtr);
		}

		private void OnVisit(CodeNode node, JumpNode from, LivenessTarget ltCur, LivenessTarget ltUnused, BitArray bCur, int bLen, ref int retPtr)
		{
			for (; ; )
			{
				if (node.Liveness != null)
				{
					if (bCur.AddBitsDelSource(node.Liveness, bCur, bLen))
					{
						OnPatch(node, from, ltCur, ltUnused, bCur, bLen, ref retPtr);
						return;
					}
					OnDone(from, ltCur, ltUnused, bCur, bLen, ref retPtr);
					return;
				}
				var bTmp = new BitArray(bLen);
				bTmp.CopyBits(bCur, bLen);
				node.Liveness = bTmp;
				var map = node.VariableMap;
				if (map != null)
				{
					var vaCount = map.Attributes.Length;
					var vaList = map.Attributes;

					for (var i = 0; i < vaCount; i++)
					{
						var va = vaList[i];
						var vd = va.VariableData;

						var flags = va.Flags;
						var localId = vd.LocalId;

						if ((flags & VariableFlags.WAll) != 0 && (flags & VariableFlags.RAll) == 0)
						{
							// Write-Only.
							bTmp.SetBit(localId);
							bCur.DelBit(localId);
						}
						else
						{
							// Read-Only or Read/Write.
							bTmp.SetBit(localId);
							bCur.SetBit(localId);
						}
					}
				}
				if (node.Type == CodeNodeType.Label)
				{
					OnTarget(node, from, ltCur, ltUnused, bCur, bLen, ref retPtr);
					return;
				}

				if (node == _functionNode)
				{
					OnDone(from, ltCur, ltUnused, bCur, bLen, ref retPtr);
					return;
				}

				if (node.Previous == null)
				{
					throw new ArgumentNullException();
				}
				node = node.Previous;
			}
		}

		private void OnPatch(CodeNode node, JumpNode from, LivenessTarget ltCur, LivenessTarget ltUnused, BitArray bCur, int bLen, ref int retPtr)
		{
			for (; ; )
			{
				if (node.Liveness == null)
				{
					throw new ArgumentNullException();
				}
				var bNode = node.Liveness;

				if (!bNode.AddBitsDelSource(bCur, bLen))
				{
					OnDone(from, ltCur, ltUnused, bCur, bLen, ref retPtr);
					return;
				}

				if (node.Type == CodeNodeType.Label)
				{
					OnTarget(node, from, ltCur, ltUnused, bCur, bLen, ref retPtr);
					return;
				}

				if (node == _functionNode)
				{
					OnDone(from, ltCur, ltUnused, bCur, bLen, ref retPtr);
					return;
				}

				node = node.Previous;
			}
		}

		private void OnTarget(CodeNode node, JumpNode from, LivenessTarget ltCur, LivenessTarget ltUnused, BitArray bCur, int bLen, ref int retPtr, bool jumpNext = false)
		{
			var label = node.As<LabelNode>();
			if (label.ReferenceCount != 0 || jumpNext)
			{
				if (!jumpNext)
				{
					// Push a new LivenessTarget onto the stack if needed.
					if (ltCur == null || ltCur.Node != node)
					{
						// Allocate a new LivenessTarget object (from pool or zone).
						var ltTmp = ltUnused;

						if (ltTmp != null)
						{
							ltUnused = ltUnused.Previous;
						}
						else
						{
							ltTmp = new LivenessTarget();
						}

						// Initialize and make current - ltTmp->from will be set later on.
						ltTmp.Previous = ltCur;
						ltTmp.Node = label;
						ltCur = ltTmp;

						from = label.From;
						if (from == null)
						{
							throw new ArgumentNullException();
						}
					}
					else
					{
						from = ltCur.From;
						OnTarget(node, from, ltCur, ltUnused, bCur, bLen, ref retPtr, true);
						return;
						//					goto _OnJumpNext;
					}
				}

				// Visit/Patch.
				do
				{
					if (!jumpNext)
					{
						ltCur.From = from;
						bCur.CopyBits(node.Liveness, bLen);

						if (from.Liveness == null)
						{
							node = from;
							OnVisit(node, from, ltCur, ltUnused, bCur, bLen, ref retPtr);
						}
						//						jumpNext = true;
					}

					// Issue #25: Moved '_OnJumpNext' here since it's important to patch
					// code again if there are more live variables than before.
					jumpNext = false;
					if (bCur.DelBits(from.Liveness, bLen))
					{
						node = from;
						OnPatch(node, from, ltCur, ltUnused, bCur, bLen, ref retPtr);
						return;
					}

					from = from.NextJump;
				} while (from != null);

				{
					// Pop the current LivenessTarget from the stack.
					var ltTmp = ltCur;

					ltCur = ltCur.Previous;
					ltTmp.Previous = ltUnused;
					ltUnused = ltTmp;
				}
			}

			bCur.CopyBits(node.Liveness, bLen);
			node = node.Previous;

			if (node.Flags.IsSet(CodeNodeFlags.Jmp) || !node.IsFetched())
			{
				OnDone(from, ltCur, ltUnused, bCur, bLen, ref retPtr);
				return;
			}

			if (node.Liveness == null)
			{
				OnVisit(node, from, ltCur, ltUnused, bCur, bLen, ref retPtr);
				return;
			}

			if (bCur.DelBits(node.Liveness, bLen))
			{
				OnPatch(node, from, ltCur, ltUnused, bCur, bLen, ref retPtr);
				return;
			}
			OnDone(from, ltCur, ltUnused, bCur, bLen, ref retPtr);
		}

		private void OnDone(JumpNode from, LivenessTarget ltCur, LivenessTarget ltUnused, BitArray bCur, int bLen, ref int retPtr)
		{
			CodeNode node;
			if (ltCur != null)
			{
				node = ltCur.Node;
				from = ltCur.From;

				OnTarget(node, from, ltCur, ltUnused, bCur, bLen, ref retPtr, true);
				return;
			}

			retPtr++;
			if (retPtr >= _variableContext.ReturningList.Count) return;
			node = _variableContext.ReturningList[retPtr];
			OnVisit(node, @from, null, ltUnused, bCur, bLen, ref retPtr);
		}
	}
}