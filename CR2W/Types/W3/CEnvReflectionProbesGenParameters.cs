
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvReflectionProbesGenParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("colorAmbient")]
		public SSimpleCurve ColorAmbient { get; set; }

		[REDProp("colorSceneMul")]
		public SSimpleCurve ColorSceneMul { get; set; }

		[REDProp("colorSceneAdd")]
		public SSimpleCurve ColorSceneAdd { get; set; }

		[REDProp("colorSkyMul")]
		public SSimpleCurve ColorSkyMul { get; set; }

		[REDProp("colorSkyAdd")]
		public SSimpleCurve ColorSkyAdd { get; set; }

		[REDProp("remapOffset")]
		public SSimpleCurve RemapOffset { get; set; }

		[REDProp("remapStrength")]
		public SSimpleCurve RemapStrength { get; set; }

		[REDProp("remapClamp")]
		public SSimpleCurve RemapClamp { get; set; }

	}
}
