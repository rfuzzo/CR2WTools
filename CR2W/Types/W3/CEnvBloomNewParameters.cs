
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvBloomNewParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("brightPassWeights")]
		public SSimpleCurve BrightPassWeights { get; set; }

		[REDProp("color")]
		public SSimpleCurve Color { get; set; }

		[REDProp("dirtColor")]
		public SSimpleCurve DirtColor { get; set; }

		[REDProp("threshold")]
		public SSimpleCurve Threshold { get; set; }

		[REDProp("thresholdRange")]
		public SSimpleCurve ThresholdRange { get; set; }

		[REDProp("brightnessMax")]
		public SSimpleCurve BrightnessMax { get; set; }

		[REDProp("shaftsColor")]
		public SSimpleCurve ShaftsColor { get; set; }

		[REDProp("shaftsRadius")]
		public SSimpleCurve ShaftsRadius { get; set; }

		[REDProp("shaftsShapeExp")]
		public SSimpleCurve ShaftsShapeExp { get; set; }

		[REDProp("shaftsShapeInvSquare")]
		public SSimpleCurve ShaftsShapeInvSquare { get; set; }

		[REDProp("shaftsThreshold")]
		public SSimpleCurve ShaftsThreshold { get; set; }

		[REDProp("shaftsThresholdRange")]
		public SSimpleCurve ShaftsThresholdRange { get; set; }

	}
}
