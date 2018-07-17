
using System;


namespace CR2W.Types.W3
{
	public class CEnvSpeedTreeRandomColorParameters
	{
		[REDProp("luminanceWeights")]
		public SSimpleCurve LuminanceWeights { get; set; }

		[REDProp("randomColor0")]
		public SSimpleCurve RandomColor0 { get; set; }

		[REDProp("saturation0")]
		public SSimpleCurve Saturation0 { get; set; }

		[REDProp("randomColor1")]
		public SSimpleCurve RandomColor1 { get; set; }

		[REDProp("saturation1")]
		public SSimpleCurve Saturation1 { get; set; }

		[REDProp("randomColor2")]
		public SSimpleCurve RandomColor2 { get; set; }

		[REDProp("saturation2")]
		public SSimpleCurve Saturation2 { get; set; }

	}
}
