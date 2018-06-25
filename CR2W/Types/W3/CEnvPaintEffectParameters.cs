
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvPaintEffectParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("amount")]
		public SSimpleCurve Amount { get; set; }

	}
}
