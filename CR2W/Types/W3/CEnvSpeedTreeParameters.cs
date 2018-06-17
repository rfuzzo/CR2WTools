
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvSpeedTreeParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("diffuse")]
		public SSimpleCurve Diffuse { get; set; }

		[W3Type("specularScale")]
		public SSimpleCurve SpecularScale { get; set; }

		[W3Type("translucencyScale")]
		public SSimpleCurve TranslucencyScale { get; set; }

		[W3Type("ambientOcclusionScale")]
		public SSimpleCurve AmbientOcclusionScale { get; set; }

		[W3Type("billboardsColor")]
		public SSimpleCurve BillboardsColor { get; set; }

		[W3Type("billboardsTranslucency")]
		public SSimpleCurve BillboardsTranslucency { get; set; }

		[W3Type("randomColorsTrees")]
		public CEnvSpeedTreeRandomColorParameters RandomColorsTrees { get; set; }

		[W3Type("randomColorsBranches")]
		public CEnvSpeedTreeRandomColorParameters RandomColorsBranches { get; set; }

		[W3Type("randomColorsGrass")]
		public CEnvSpeedTreeRandomColorParameters RandomColorsGrass { get; set; }

		[W3Type("randomColorsFallback")]
		public SSimpleCurve RandomColorsFallback { get; set; }

		[W3Type("pigmentBrightness")]
		public SSimpleCurve PigmentBrightness { get; set; }

		[W3Type("pigmentFloodStartDist")]
		public SSimpleCurve PigmentFloodStartDist { get; set; }

		[W3Type("pigmentFloodRange")]
		public SSimpleCurve PigmentFloodRange { get; set; }

		[W3Type("billboardsLightBleed")]
		public SSimpleCurve BillboardsLightBleed { get; set; }

	}
}
