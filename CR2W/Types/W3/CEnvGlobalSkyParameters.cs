
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvGlobalSkyParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("activatedActivateFactor")]
		public bool ActivatedActivateFactor { get; set; }

		[W3Type("activateFactor")]
		public float ActivateFactor { get; set; }

		[W3Type("skyColor")]
		public SSimpleCurve SkyColor { get; set; }

		[W3Type("skyColorHorizon")]
		public SSimpleCurve SkyColorHorizon { get; set; }

		[W3Type("horizonVerticalAttenuation")]
		public SSimpleCurve HorizonVerticalAttenuation { get; set; }

		[W3Type("sunColorSky")]
		public SSimpleCurve SunColorSky { get; set; }

		[W3Type("sunColorSkyBrightness")]
		public SSimpleCurve SunColorSkyBrightness { get; set; }

		[W3Type("sunAreaSkySize")]
		public SSimpleCurve SunAreaSkySize { get; set; }

		[W3Type("sunColorHorizon")]
		public SSimpleCurve SunColorHorizon { get; set; }

		[W3Type("sunColorHorizonHorizontalScale")]
		public SSimpleCurve SunColorHorizonHorizontalScale { get; set; }

		[W3Type("sunBackHorizonColor")]
		public SSimpleCurve SunBackHorizonColor { get; set; }

		[W3Type("sunInfluence")]
		public SSimpleCurve SunInfluence { get; set; }

		[W3Type("moonColorSky")]
		public SSimpleCurve MoonColorSky { get; set; }

		[W3Type("moonColorSkyBrightness")]
		public SSimpleCurve MoonColorSkyBrightness { get; set; }

		[W3Type("moonAreaSkySize")]
		public SSimpleCurve MoonAreaSkySize { get; set; }

		[W3Type("moonColorHorizon")]
		public SSimpleCurve MoonColorHorizon { get; set; }

		[W3Type("moonColorHorizonHorizontalScale")]
		public SSimpleCurve MoonColorHorizonHorizontalScale { get; set; }

		[W3Type("moonBackHorizonColor")]
		public SSimpleCurve MoonBackHorizonColor { get; set; }

		[W3Type("moonInfluence")]
		public SSimpleCurve MoonInfluence { get; set; }

		[W3Type("globalSkyBrightness")]
		public SSimpleCurve GlobalSkyBrightness { get; set; }

	}
}
