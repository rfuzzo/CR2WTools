
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvToneMappingCurveParameters
	{
		[W3Type("shoulderStrength")]
		public SSimpleCurve ShoulderStrength { get; set; }

		[W3Type("linearStrength")]
		public SSimpleCurve LinearStrength { get; set; }

		[W3Type("linearAngle")]
		public SSimpleCurve LinearAngle { get; set; }

		[W3Type("toeStrength")]
		public SSimpleCurve ToeStrength { get; set; }

		[W3Type("toeNumerator")]
		public SSimpleCurve ToeNumerator { get; set; }

		[W3Type("toeDenominator")]
		public SSimpleCurve ToeDenominator { get; set; }

	}
}
