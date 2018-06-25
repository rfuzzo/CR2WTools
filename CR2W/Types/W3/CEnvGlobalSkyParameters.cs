
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvGlobalSkyParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("activatedActivateFactor")]
		public bool ActivatedActivateFactor { get; set; }

		[REDProp("activateFactor")]
		public float ActivateFactor { get; set; }

		[REDProp("skyColor")]
		public SSimpleCurve SkyColor { get; set; }

		[REDProp("skyColorHorizon")]
		public SSimpleCurve SkyColorHorizon { get; set; }

		[REDProp("horizonVerticalAttenuation")]
		public SSimpleCurve HorizonVerticalAttenuation { get; set; }

		[REDProp("sunColorSky")]
		public SSimpleCurve SunColorSky { get; set; }

		[REDProp("sunColorSkyBrightness")]
		public SSimpleCurve SunColorSkyBrightness { get; set; }

		[REDProp("sunAreaSkySize")]
		public SSimpleCurve SunAreaSkySize { get; set; }

		[REDProp("sunColorHorizon")]
		public SSimpleCurve SunColorHorizon { get; set; }

		[REDProp("sunColorHorizonHorizontalScale")]
		public SSimpleCurve SunColorHorizonHorizontalScale { get; set; }

		[REDProp("sunBackHorizonColor")]
		public SSimpleCurve SunBackHorizonColor { get; set; }

		[REDProp("sunInfluence")]
		public SSimpleCurve SunInfluence { get; set; }

		[REDProp("moonColorSky")]
		public SSimpleCurve MoonColorSky { get; set; }

		[REDProp("moonColorSkyBrightness")]
		public SSimpleCurve MoonColorSkyBrightness { get; set; }

		[REDProp("moonAreaSkySize")]
		public SSimpleCurve MoonAreaSkySize { get; set; }

		[REDProp("moonColorHorizon")]
		public SSimpleCurve MoonColorHorizon { get; set; }

		[REDProp("moonColorHorizonHorizontalScale")]
		public SSimpleCurve MoonColorHorizonHorizontalScale { get; set; }

		[REDProp("moonBackHorizonColor")]
		public SSimpleCurve MoonBackHorizonColor { get; set; }

		[REDProp("moonInfluence")]
		public SSimpleCurve MoonInfluence { get; set; }

		[REDProp("globalSkyBrightness")]
		public SSimpleCurve GlobalSkyBrightness { get; set; }

	}
}
