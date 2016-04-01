using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsmJit.Common.Operands;

namespace AsmJit.CompilerContext
{
	public partial class CodeContext
	{
		public class Intrinisics
		{
			private CodeContext c;

			public XmmVariable _mm_add_ss(XmmVariable a, XmmVariable b)
			{
				c.Addss(a,b);
				return a;
			}

			public XmmVariable _mm_add_ps(XmmVariable a, XmmVariable b)
			{
				c.Addps(a, b);
				return a;
			}

			public XmmVariable _mm_sub_ss(XmmVariable a, XmmVariable b)
			{
				c.Subss(a, b);
				return a;
			}

			public XmmVariable _mm_sub_ps(XmmVariable a, XmmVariable b)
			{
				c.Subps(a, b);
				return a;
			}

			public XmmVariable _mm_mul_ss(XmmVariable a, XmmVariable b)
			{
				c.Mulss(a, b);
				return a;
			}

			public XmmVariable _mm_mul_ps(XmmVariable a, XmmVariable b)
			{
				c.Mulps(a, b);
				return a;
			}

			public XmmVariable _mm_div_ss(XmmVariable a, XmmVariable b)
			{
				c.Divss(a, b);
				return a;
			}

			public XmmVariable _mm_div_ps(XmmVariable a, XmmVariable b)
			{
				c.Divps(a, b);
				return a;
			}

			public XmmVariable _mm_sqrt_ss(XmmVariable a)
			{
				var r = c.Xmm();
				c.Sqrtss(r, a);
				return r;
			}

			public XmmVariable _mm_sqrt_ps(XmmVariable a)
			{
				var r = c.Xmm();
				c.Sqrtps(r, a);
				return r;
			}

			public XmmVariable _mm_rcp_ss(XmmVariable a)
			{
				var r = c.Xmm();
				c.Rcpss(r, a);
				return r;
			}

			public XmmVariable _mm_rcp_ps(XmmVariable a)
			{
				var r = c.Xmm();
				c.Rcpps(r, a);
				return r;
			}

			public XmmVariable _mm_rsqrt_ss(XmmVariable a)
			{
				var r = c.Xmm();
				c.Rsqrtss(r, a);
				return r;
			}

			public XmmVariable _mm_rsqrt_ps(XmmVariable a)
			{
				var r = c.Xmm();
				c.Rsqrtps(r, a);
				return r;
			}

			public XmmVariable _mm_min_ss(XmmVariable a, XmmVariable b)
			{
				c.Minss(a, b);
				return a;
			}

			public XmmVariable _mm_min_ps(XmmVariable a, XmmVariable b)
			{
				c.Minps(a, b);
				return a;
			}

			public XmmVariable _mm_max_ss(XmmVariable a, XmmVariable b)
			{
				c.Maxss(a, b);
				return a;
			}

			public XmmVariable _mm_max_ps(XmmVariable a, XmmVariable b)
			{
				c.Maxps(a, b);
				return a;
			}

			public XmmVariable _mm_and_ps(XmmVariable a, XmmVariable b)
			{
				c.Andps(a, b);
				return a;
			}

			public XmmVariable _mm_andnot_ps(XmmVariable a, XmmVariable b)
			{
				c.Andnps(a, b);
				return a;
			}

			public XmmVariable _mm_or_ps(XmmVariable a, XmmVariable b)
			{
				c.Orps(a, b);
				return a;
			}

			public XmmVariable _mm_xor_ps(XmmVariable a, XmmVariable b)
			{
				c.Xorps(a, b);
				return a;
			}
		}
	}
}
