
using System;


namespace CR2W.Types.W3
{
	public class CEnvSpeedTreeParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("diffuse")]
		public SSimpleCurve Diffuse { get; set; }

		[REDProp("specularScale")]
		public SSimpleCurve SpecularScale { get; set; }

		[REDProp("translucencyScale")]
		public SSimpleCurve TranslucencyScale { get; set; }

		[REDProp("ambientOcclusionScale")]
		public SSimpleCurve AmbientOcclusionScale { get; set; }

		[REDProp("billboardsColor")]
		public SSimpleCurve BillboardsColor { get; set; }

		[REDProp("billboardsTranslucency")]
		public SSimpleCurve BillboardsTranslucency { get; set; }

		[REDProp("randomColorsTrees")]
		public CEnvSpeedTreeRandomColorParameters RandomColorsTrees { get; set; }

		[REDProp("randomColorsBranches")]
		public CEnvSpeedTreeRandomColorParameters RandomColorsBranches { get; set; }

		[REDProp("randomColorsGrass")]
		public CEnvSpeedTreeRandomColorParameters RandomColorsGrass { get; set; }

		[REDProp("randomColorsFallback")]
		public SSimpleCurve RandomColorsFallback { get; set; }

		[REDProp("pigmentBrightness")]
		public SSimpleCurve PigmentBrightness { get; set; }

		[REDProp("pigmentFloodStartDist")]
		public SSimpleCurve PigmentFloodStartDist { get; set; }

		[REDProp("pigmentFloodRange")]
		public SSimpleCurve PigmentFloodRange { get; set; }

		[REDProp("billboardsLightBleed")]
		public SSimpleCurve BillboardsLightBleed { get; set; }

	}
}
