
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvColorGroupsParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("defaultGroup")]
		public SSimpleCurve DefaultGroup { get; set; }

		[REDProp("lightsDefault")]
		public SSimpleCurve LightsDefault { get; set; }

		[REDProp("lightsDawn")]
		public SSimpleCurve LightsDawn { get; set; }

		[REDProp("lightsNoon")]
		public SSimpleCurve LightsNoon { get; set; }

		[REDProp("lightsEvening")]
		public SSimpleCurve LightsEvening { get; set; }

		[REDProp("lightsNight")]
		public SSimpleCurve LightsNight { get; set; }

		[REDProp("fxDefault")]
		public SSimpleCurve FxDefault { get; set; }

		[REDProp("fxFire")]
		public SSimpleCurve FxFire { get; set; }

		[REDProp("fxFireFlares")]
		public SSimpleCurve FxFireFlares { get; set; }

		[REDProp("fxFireLight")]
		public SSimpleCurve FxFireLight { get; set; }

		[REDProp("fxSmoke")]
		public SSimpleCurve FxSmoke { get; set; }

		[REDProp("fxSmokeExplosion")]
		public SSimpleCurve FxSmokeExplosion { get; set; }

		[REDProp("fxSky")]
		public SSimpleCurve FxSky { get; set; }

		[REDProp("fxSkyAlpha")]
		public SSimpleCurve FxSkyAlpha { get; set; }

		[REDProp("fxSkyNight")]
		public SSimpleCurve FxSkyNight { get; set; }

		[REDProp("fxSkyNightAlpha")]
		public SSimpleCurve FxSkyNightAlpha { get; set; }

		[REDProp("fxSkyDawn")]
		public SSimpleCurve FxSkyDawn { get; set; }

		[REDProp("fxSkyDawnAlpha")]
		public SSimpleCurve FxSkyDawnAlpha { get; set; }

		[REDProp("fxSkyNoon")]
		public SSimpleCurve FxSkyNoon { get; set; }

		[REDProp("fxSkyNoonAlpha")]
		public SSimpleCurve FxSkyNoonAlpha { get; set; }

		[REDProp("fxSkySunset")]
		public SSimpleCurve FxSkySunset { get; set; }

		[REDProp("fxSkySunsetAlpha")]
		public SSimpleCurve FxSkySunsetAlpha { get; set; }

		[REDProp("fxSkyRain")]
		public SSimpleCurve FxSkyRain { get; set; }

		[REDProp("fxSkyRainAlpha")]
		public SSimpleCurve FxSkyRainAlpha { get; set; }

		[REDProp("mainCloudsMiddle")]
		public SSimpleCurve MainCloudsMiddle { get; set; }

		[REDProp("mainCloudsMiddleAlpha")]
		public SSimpleCurve MainCloudsMiddleAlpha { get; set; }

		[REDProp("mainCloudsFront")]
		public SSimpleCurve MainCloudsFront { get; set; }

		[REDProp("mainCloudsFrontAlpha")]
		public SSimpleCurve MainCloudsFrontAlpha { get; set; }

		[REDProp("mainCloudsBack")]
		public SSimpleCurve MainCloudsBack { get; set; }

		[REDProp("mainCloudsBackAlpha")]
		public SSimpleCurve MainCloudsBackAlpha { get; set; }

		[REDProp("mainCloudsRim")]
		public SSimpleCurve MainCloudsRim { get; set; }

		[REDProp("mainCloudsRimAlpha")]
		public SSimpleCurve MainCloudsRimAlpha { get; set; }

		[REDProp("backgroundCloudsFront")]
		public SSimpleCurve BackgroundCloudsFront { get; set; }

		[REDProp("backgroundCloudsFrontAlpha")]
		public SSimpleCurve BackgroundCloudsFrontAlpha { get; set; }

		[REDProp("backgroundCloudsBack")]
		public SSimpleCurve BackgroundCloudsBack { get; set; }

		[REDProp("backgroundCloudsBackAlpha")]
		public SSimpleCurve BackgroundCloudsBackAlpha { get; set; }

		[REDProp("backgroundHazeFront")]
		public SSimpleCurve BackgroundHazeFront { get; set; }

		[REDProp("backgroundHazeFrontAlpha")]
		public SSimpleCurve BackgroundHazeFrontAlpha { get; set; }

		[REDProp("backgroundHazeBack")]
		public SSimpleCurve BackgroundHazeBack { get; set; }

		[REDProp("backgroundHazeBackAlpha")]
		public SSimpleCurve BackgroundHazeBackAlpha { get; set; }

		[REDProp("fxBlood")]
		public SSimpleCurve FxBlood { get; set; }

		[REDProp("fxWater")]
		public SSimpleCurve FxWater { get; set; }

		[REDProp("fxFog")]
		public SSimpleCurve FxFog { get; set; }

		[REDProp("fxTrails")]
		public SSimpleCurve FxTrails { get; set; }

		[REDProp("fxScreenParticles")]
		public SSimpleCurve FxScreenParticles { get; set; }

		[REDProp("fxLightShaft")]
		public SSimpleCurve FxLightShaft { get; set; }

		[REDProp("fxLightShaftSun")]
		public SSimpleCurve FxLightShaftSun { get; set; }

		[REDProp("fxLightShaftInteriorDawn")]
		public SSimpleCurve FxLightShaftInteriorDawn { get; set; }

		[REDProp("fxLightShaftSpotlightDawn")]
		public SSimpleCurve FxLightShaftSpotlightDawn { get; set; }

		[REDProp("fxLightShaftReflectionLightDawn")]
		public SSimpleCurve FxLightShaftReflectionLightDawn { get; set; }

		[REDProp("fxLightShaftInteriorNoon")]
		public SSimpleCurve FxLightShaftInteriorNoon { get; set; }

		[REDProp("fxLightShaftSpotlightNoon")]
		public SSimpleCurve FxLightShaftSpotlightNoon { get; set; }

		[REDProp("fxLightShaftReflectionLightNoon")]
		public SSimpleCurve FxLightShaftReflectionLightNoon { get; set; }

		[REDProp("fxLightShaftInteriorEvening")]
		public SSimpleCurve FxLightShaftInteriorEvening { get; set; }

		[REDProp("fxLightShaftSpotlightEvening")]
		public SSimpleCurve FxLightShaftSpotlightEvening { get; set; }

		[REDProp("fxLightShaftReflectionLightEvening")]
		public SSimpleCurve FxLightShaftReflectionLightEvening { get; set; }

		[REDProp("fxLightShaftInteriorNight")]
		public SSimpleCurve FxLightShaftInteriorNight { get; set; }

		[REDProp("fxLightShaftSpotlightNight")]
		public SSimpleCurve FxLightShaftSpotlightNight { get; set; }

		[REDProp("fxLightShaftReflectionLightNight")]
		public SSimpleCurve FxLightShaftReflectionLightNight { get; set; }

		[REDProp("activatedCustom0")]
		public bool ActivatedCustom0 { get; set; }

		[REDProp("customGroup0")]
		public SSimpleCurve CustomGroup0 { get; set; }

		[REDProp("activatedCustom1")]
		public bool ActivatedCustom1 { get; set; }

		[REDProp("customGroup1")]
		public SSimpleCurve CustomGroup1 { get; set; }

		[REDProp("activatedCustom2")]
		public bool ActivatedCustom2 { get; set; }

		[REDProp("customGroup2")]
		public SSimpleCurve CustomGroup2 { get; set; }

	}
}
