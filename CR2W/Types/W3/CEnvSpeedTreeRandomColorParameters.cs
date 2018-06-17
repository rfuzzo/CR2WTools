
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvSpeedTreeRandomColorParameters
	{
		[W3Type("luminanceWeights")]
		public SSimpleCurve LuminanceWeights { get; set; }

		[W3Type("randomColor0")]
		public SSimpleCurve RandomColor0 { get; set; }

		[W3Type("saturation0")]
		public SSimpleCurve Saturation0 { get; set; }

		[W3Type("randomColor1")]
		public SSimpleCurve RandomColor1 { get; set; }

		[W3Type("saturation1")]
		public SSimpleCurve Saturation1 { get; set; }

		[W3Type("randomColor2")]
		public SSimpleCurve RandomColor2 { get; set; }

		[W3Type("saturation2")]
		public SSimpleCurve Saturation2 { get; set; }

	}
}
