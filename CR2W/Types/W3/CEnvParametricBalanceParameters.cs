
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvParametricBalanceParameters
	{
		[W3Type("saturation")]
		public SSimpleCurve Saturation { get; set; }

		[W3Type("color")]
		public SSimpleCurve Color { get; set; }

	}
}
