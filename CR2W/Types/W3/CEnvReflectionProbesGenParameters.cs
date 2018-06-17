
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvReflectionProbesGenParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("colorAmbient")]
		public SSimpleCurve ColorAmbient { get; set; }

		[W3Type("colorSceneMul")]
		public SSimpleCurve ColorSceneMul { get; set; }

		[W3Type("colorSceneAdd")]
		public SSimpleCurve ColorSceneAdd { get; set; }

		[W3Type("colorSkyMul")]
		public SSimpleCurve ColorSkyMul { get; set; }

		[W3Type("colorSkyAdd")]
		public SSimpleCurve ColorSkyAdd { get; set; }

		[W3Type("remapOffset")]
		public SSimpleCurve RemapOffset { get; set; }

		[W3Type("remapStrength")]
		public SSimpleCurve RemapStrength { get; set; }

		[W3Type("remapClamp")]
		public SSimpleCurve RemapClamp { get; set; }

	}
}
