
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvColorGroupsParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("defaultGroup")]
		public SSimpleCurve DefaultGroup { get; set; }

		[W3Type("lightsDefault")]
		public SSimpleCurve LightsDefault { get; set; }

		[W3Type("lightsDawn")]
		public SSimpleCurve LightsDawn { get; set; }

		[W3Type("lightsNoon")]
		public SSimpleCurve LightsNoon { get; set; }

		[W3Type("lightsEvening")]
		public SSimpleCurve LightsEvening { get; set; }

		[W3Type("lightsNight")]
		public SSimpleCurve LightsNight { get; set; }

		[W3Type("fxDefault")]
		public SSimpleCurve FxDefault { get; set; }

		[W3Type("fxFire")]
		public SSimpleCurve FxFire { get; set; }

		[W3Type("fxFireFlares")]
		public SSimpleCurve FxFireFlares { get; set; }

		[W3Type("fxFireLight")]
		public SSimpleCurve FxFireLight { get; set; }

		[W3Type("fxSmoke")]
		public SSimpleCurve FxSmoke { get; set; }

		[W3Type("fxSmokeExplosion")]
		public SSimpleCurve FxSmokeExplosion { get; set; }

		[W3Type("fxSky")]
		public SSimpleCurve FxSky { get; set; }

		[W3Type("fxSkyAlpha")]
		public SSimpleCurve FxSkyAlpha { get; set; }

		[W3Type("fxSkyNight")]
		public SSimpleCurve FxSkyNight { get; set; }

		[W3Type("fxSkyNightAlpha")]
		public SSimpleCurve FxSkyNightAlpha { get; set; }

		[W3Type("fxSkyDawn")]
		public SSimpleCurve FxSkyDawn { get; set; }

		[W3Type("fxSkyDawnAlpha")]
		public SSimpleCurve FxSkyDawnAlpha { get; set; }

		[W3Type("fxSkyNoon")]
		public SSimpleCurve FxSkyNoon { get; set; }

		[W3Type("fxSkyNoonAlpha")]
		public SSimpleCurve FxSkyNoonAlpha { get; set; }

		[W3Type("fxSkySunset")]
		public SSimpleCurve FxSkySunset { get; set; }

		[W3Type("fxSkySunsetAlpha")]
		public SSimpleCurve FxSkySunsetAlpha { get; set; }

		[W3Type("fxSkyRain")]
		public SSimpleCurve FxSkyRain { get; set; }

		[W3Type("fxSkyRainAlpha")]
		public SSimpleCurve FxSkyRainAlpha { get; set; }

		[W3Type("mainCloudsMiddle")]
		public SSimpleCurve MainCloudsMiddle { get; set; }

		[W3Type("mainCloudsMiddleAlpha")]
		public SSimpleCurve MainCloudsMiddleAlpha { get; set; }

		[W3Type("mainCloudsFront")]
		public SSimpleCurve MainCloudsFront { get; set; }

		[W3Type("mainCloudsFrontAlpha")]
		public SSimpleCurve MainCloudsFrontAlpha { get; set; }

		[W3Type("mainCloudsBack")]
		public SSimpleCurve MainCloudsBack { get; set; }

		[W3Type("mainCloudsBackAlpha")]
		public SSimpleCurve MainCloudsBackAlpha { get; set; }

		[W3Type("mainCloudsRim")]
		public SSimpleCurve MainCloudsRim { get; set; }

		[W3Type("mainCloudsRimAlpha")]
		public SSimpleCurve MainCloudsRimAlpha { get; set; }

		[W3Type("backgroundCloudsFront")]
		public SSimpleCurve BackgroundCloudsFront { get; set; }

		[W3Type("backgroundCloudsFrontAlpha")]
		public SSimpleCurve BackgroundCloudsFrontAlpha { get; set; }

		[W3Type("backgroundCloudsBack")]
		public SSimpleCurve BackgroundCloudsBack { get; set; }

		[W3Type("backgroundCloudsBackAlpha")]
		public SSimpleCurve BackgroundCloudsBackAlpha { get; set; }

		[W3Type("backgroundHazeFront")]
		public SSimpleCurve BackgroundHazeFront { get; set; }

		[W3Type("backgroundHazeFrontAlpha")]
		public SSimpleCurve BackgroundHazeFrontAlpha { get; set; }

		[W3Type("backgroundHazeBack")]
		public SSimpleCurve BackgroundHazeBack { get; set; }

		[W3Type("backgroundHazeBackAlpha")]
		public SSimpleCurve BackgroundHazeBackAlpha { get; set; }

		[W3Type("fxBlood")]
		public SSimpleCurve FxBlood { get; set; }

		[W3Type("fxWater")]
		public SSimpleCurve FxWater { get; set; }

		[W3Type("fxFog")]
		public SSimpleCurve FxFog { get; set; }

		[W3Type("fxTrails")]
		public SSimpleCurve FxTrails { get; set; }

		[W3Type("fxScreenParticles")]
		public SSimpleCurve FxScreenParticles { get; set; }

		[W3Type("fxLightShaft")]
		public SSimpleCurve FxLightShaft { get; set; }

		[W3Type("fxLightShaftSun")]
		public SSimpleCurve FxLightShaftSun { get; set; }

		[W3Type("fxLightShaftInteriorDawn")]
		public SSimpleCurve FxLightShaftInteriorDawn { get; set; }

		[W3Type("fxLightShaftSpotlightDawn")]
		public SSimpleCurve FxLightShaftSpotlightDawn { get; set; }

		[W3Type("fxLightShaftReflectionLightDawn")]
		public SSimpleCurve FxLightShaftReflectionLightDawn { get; set; }

		[W3Type("fxLightShaftInteriorNoon")]
		public SSimpleCurve FxLightShaftInteriorNoon { get; set; }

		[W3Type("fxLightShaftSpotlightNoon")]
		public SSimpleCurve FxLightShaftSpotlightNoon { get; set; }

		[W3Type("fxLightShaftReflectionLightNoon")]
		public SSimpleCurve FxLightShaftReflectionLightNoon { get; set; }

		[W3Type("fxLightShaftInteriorEvening")]
		public SSimpleCurve FxLightShaftInteriorEvening { get; set; }

		[W3Type("fxLightShaftSpotlightEvening")]
		public SSimpleCurve FxLightShaftSpotlightEvening { get; set; }

		[W3Type("fxLightShaftReflectionLightEvening")]
		public SSimpleCurve FxLightShaftReflectionLightEvening { get; set; }

		[W3Type("fxLightShaftInteriorNight")]
		public SSimpleCurve FxLightShaftInteriorNight { get; set; }

		[W3Type("fxLightShaftSpotlightNight")]
		public SSimpleCurve FxLightShaftSpotlightNight { get; set; }

		[W3Type("fxLightShaftReflectionLightNight")]
		public SSimpleCurve FxLightShaftReflectionLightNight { get; set; }

		[W3Type("activatedCustom0")]
		public bool ActivatedCustom0 { get; set; }

		[W3Type("customGroup0")]
		public SSimpleCurve CustomGroup0 { get; set; }

		[W3Type("activatedCustom1")]
		public bool ActivatedCustom1 { get; set; }

		[W3Type("customGroup1")]
		public SSimpleCurve CustomGroup1 { get; set; }

		[W3Type("activatedCustom2")]
		public bool ActivatedCustom2 { get; set; }

		[W3Type("customGroup2")]
		public SSimpleCurve CustomGroup2 { get; set; }

	}
}
