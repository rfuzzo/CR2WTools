
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvAmbientProbesGenParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("colorAmbient")]
		public SSimpleCurve ColorAmbient { get; set; }

		[W3Type("colorSceneAdd")]
		public SSimpleCurve ColorSceneAdd { get; set; }

		[W3Type("colorSkyTop")]
		public SSimpleCurve ColorSkyTop { get; set; }

		[W3Type("colorSkyHorizon")]
		public SSimpleCurve ColorSkyHorizon { get; set; }

		[W3Type("skyShape")]
		public SSimpleCurve SkyShape { get; set; }

	}
}
