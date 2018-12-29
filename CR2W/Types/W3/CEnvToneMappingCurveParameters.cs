
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvToneMappingCurveParameters
	{
		[REDProp("shoulderStrength")]
		public SSimpleCurve ShoulderStrength { get; set; }

		[REDProp("linearStrength")]
		public SSimpleCurve LinearStrength { get; set; }

		[REDProp("linearAngle")]
		public SSimpleCurve LinearAngle { get; set; }

		[REDProp("toeStrength")]
		public SSimpleCurve ToeStrength { get; set; }

		[REDProp("toeNumerator")]
		public SSimpleCurve ToeNumerator { get; set; }

		[REDProp("toeDenominator")]
		public SSimpleCurve ToeDenominator { get; set; }

	}
}
