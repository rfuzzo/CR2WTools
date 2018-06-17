
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvNVSSAOParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("radius")]
		public SSimpleCurve Radius { get; set; }

		[W3Type("bias")]
		public SSimpleCurve Bias { get; set; }

		[W3Type("detailStrength")]
		public SSimpleCurve DetailStrength { get; set; }

		[W3Type("coarseStrength")]
		public SSimpleCurve CoarseStrength { get; set; }

		[W3Type("powerExponent")]
		public SSimpleCurve PowerExponent { get; set; }

		[W3Type("blurSharpness")]
		public SSimpleCurve BlurSharpness { get; set; }

		[W3Type("valueClamp")]
		public SSimpleCurve ValueClamp { get; set; }

		[W3Type("ssaoColor")]
		public SSimpleCurve SsaoColor { get; set; }

		[W3Type("nonAmbientInfluence")]
		public SSimpleCurve NonAmbientInfluence { get; set; }

		[W3Type("translucencyInfluence")]
		public SSimpleCurve TranslucencyInfluence { get; set; }

	}
}
