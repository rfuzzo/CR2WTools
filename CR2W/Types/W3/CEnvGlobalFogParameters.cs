
using System;


namespace CR2W.Types.W3
{
	public class CEnvGlobalFogParameters
	{
		[REDProp("fogActivated")]
		public bool FogActivated { get; set; }

		[REDProp("fogAppearDistance")]
		public SSimpleCurve FogAppearDistance { get; set; }

		[REDProp("fogAppearRange")]
		public SSimpleCurve FogAppearRange { get; set; }

		[REDProp("fogColorFront")]
		public SSimpleCurve FogColorFront { get; set; }

		[REDProp("fogColorMiddle")]
		public SSimpleCurve FogColorMiddle { get; set; }

		[REDProp("fogColorBack")]
		public SSimpleCurve FogColorBack { get; set; }

		[REDProp("fogDensity")]
		public SSimpleCurve FogDensity { get; set; }

		[REDProp("fogFinalExp")]
		public SSimpleCurve FogFinalExp { get; set; }

		[REDProp("fogDistClamp")]
		public SSimpleCurve FogDistClamp { get; set; }

		[REDProp("fogVertOffset")]
		public SSimpleCurve FogVertOffset { get; set; }

		[REDProp("fogVertDensity")]
		public SSimpleCurve FogVertDensity { get; set; }

		[REDProp("fogVertDensityLightFront")]
		public SSimpleCurve FogVertDensityLightFront { get; set; }

		[REDProp("fogVertDensityLightBack")]
		public SSimpleCurve FogVertDensityLightBack { get; set; }

		[REDProp("fogSkyDensityScale")]
		public SSimpleCurve FogSkyDensityScale { get; set; }

		[REDProp("fogCloudsDensityScale")]
		public SSimpleCurve FogCloudsDensityScale { get; set; }

		[REDProp("fogSkyVertDensityLightFrontScale")]
		public SSimpleCurve FogSkyVertDensityLightFrontScale { get; set; }

		[REDProp("fogSkyVertDensityLightBackScale")]
		public SSimpleCurve FogSkyVertDensityLightBackScale { get; set; }

		[REDProp("fogVertDensityRimRange")]
		public SSimpleCurve FogVertDensityRimRange { get; set; }

		[REDProp("fogCustomColor")]
		public SSimpleCurve FogCustomColor { get; set; }

		[REDProp("fogCustomColorStart")]
		public SSimpleCurve FogCustomColorStart { get; set; }

		[REDProp("fogCustomColorRange")]
		public SSimpleCurve FogCustomColorRange { get; set; }

		[REDProp("fogCustomAmountScale")]
		public SSimpleCurve FogCustomAmountScale { get; set; }

		[REDProp("fogCustomAmountScaleStart")]
		public SSimpleCurve FogCustomAmountScaleStart { get; set; }

		[REDProp("fogCustomAmountScaleRange")]
		public SSimpleCurve FogCustomAmountScaleRange { get; set; }

		[REDProp("aerialColorFront")]
		public SSimpleCurve AerialColorFront { get; set; }

		[REDProp("aerialColorMiddle")]
		public SSimpleCurve AerialColorMiddle { get; set; }

		[REDProp("aerialColorBack")]
		public SSimpleCurve AerialColorBack { get; set; }

		[REDProp("aerialFinalExp")]
		public SSimpleCurve AerialFinalExp { get; set; }

		[REDProp("ssaoImpactClamp")]
		public SSimpleCurve SsaoImpactClamp { get; set; }

		[REDProp("ssaoImpactNearValue")]
		public SSimpleCurve SsaoImpactNearValue { get; set; }

		[REDProp("ssaoImpactFarValue")]
		public SSimpleCurve SsaoImpactFarValue { get; set; }

		[REDProp("ssaoImpactNearDistance")]
		public SSimpleCurve SsaoImpactNearDistance { get; set; }

		[REDProp("ssaoImpactFarDistance")]
		public SSimpleCurve SsaoImpactFarDistance { get; set; }

		[REDProp("distantLightsIntensityScale")]
		public SSimpleCurve DistantLightsIntensityScale { get; set; }

	}
}
