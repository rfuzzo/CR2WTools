
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvBloomNewParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("brightPassWeights")]
		public SSimpleCurve BrightPassWeights { get; set; }

		[W3Type("color")]
		public SSimpleCurve Color { get; set; }

		[W3Type("dirtColor")]
		public SSimpleCurve DirtColor { get; set; }

		[W3Type("threshold")]
		public SSimpleCurve Threshold { get; set; }

		[W3Type("thresholdRange")]
		public SSimpleCurve ThresholdRange { get; set; }

		[W3Type("brightnessMax")]
		public SSimpleCurve BrightnessMax { get; set; }

		[W3Type("shaftsColor")]
		public SSimpleCurve ShaftsColor { get; set; }

		[W3Type("shaftsRadius")]
		public SSimpleCurve ShaftsRadius { get; set; }

		[W3Type("shaftsShapeExp")]
		public SSimpleCurve ShaftsShapeExp { get; set; }

		[W3Type("shaftsShapeInvSquare")]
		public SSimpleCurve ShaftsShapeInvSquare { get; set; }

		[W3Type("shaftsThreshold")]
		public SSimpleCurve ShaftsThreshold { get; set; }

		[W3Type("shaftsThresholdRange")]
		public SSimpleCurve ShaftsThresholdRange { get; set; }

	}
}
