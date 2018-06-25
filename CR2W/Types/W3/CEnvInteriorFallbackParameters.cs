
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvInteriorFallbackParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("colorAmbientMul")]
		public SSimpleCurve ColorAmbientMul { get; set; }

		[REDProp("colorReflectionLow")]
		public SSimpleCurve ColorReflectionLow { get; set; }

		[REDProp("colorReflectionMiddle")]
		public SSimpleCurve ColorReflectionMiddle { get; set; }

		[REDProp("colorReflectionHigh")]
		public SSimpleCurve ColorReflectionHigh { get; set; }

	}
}
