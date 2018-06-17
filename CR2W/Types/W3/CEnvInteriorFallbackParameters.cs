
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvInteriorFallbackParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("colorAmbientMul")]
		public SSimpleCurve ColorAmbientMul { get; set; }

		[W3Type("colorReflectionLow")]
		public SSimpleCurve ColorReflectionLow { get; set; }

		[W3Type("colorReflectionMiddle")]
		public SSimpleCurve ColorReflectionMiddle { get; set; }

		[W3Type("colorReflectionHigh")]
		public SSimpleCurve ColorReflectionHigh { get; set; }

	}
}
