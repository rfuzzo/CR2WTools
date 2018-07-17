
using System;


namespace CR2W.Types.W3
{
	public class CEnvParametricBalanceParameters
	{
		[REDProp("saturation")]
		public SSimpleCurve Saturation { get; set; }

		[REDProp("color")]
		public SSimpleCurve Color { get; set; }

	}
}
