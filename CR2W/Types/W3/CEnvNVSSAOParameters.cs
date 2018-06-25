
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvNVSSAOParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("radius")]
		public SSimpleCurve Radius { get; set; }

		[REDProp("bias")]
		public SSimpleCurve Bias { get; set; }

		[REDProp("detailStrength")]
		public SSimpleCurve DetailStrength { get; set; }

		[REDProp("coarseStrength")]
		public SSimpleCurve CoarseStrength { get; set; }

		[REDProp("powerExponent")]
		public SSimpleCurve PowerExponent { get; set; }

		[REDProp("blurSharpness")]
		public SSimpleCurve BlurSharpness { get; set; }

		[REDProp("valueClamp")]
		public SSimpleCurve ValueClamp { get; set; }

		[REDProp("ssaoColor")]
		public SSimpleCurve SsaoColor { get; set; }

		[REDProp("nonAmbientInfluence")]
		public SSimpleCurve NonAmbientInfluence { get; set; }

		[REDProp("translucencyInfluence")]
		public SSimpleCurve TranslucencyInfluence { get; set; }

	}
}
