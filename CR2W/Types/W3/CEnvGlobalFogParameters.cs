
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvGlobalFogParameters
	{
		[W3Type("fogActivated")]
		public bool FogActivated { get; set; }

		[W3Type("fogAppearDistance")]
		public SSimpleCurve FogAppearDistance { get; set; }

		[W3Type("fogAppearRange")]
		public SSimpleCurve FogAppearRange { get; set; }

		[W3Type("fogColorFront")]
		public SSimpleCurve FogColorFront { get; set; }

		[W3Type("fogColorMiddle")]
		public SSimpleCurve FogColorMiddle { get; set; }

		[W3Type("fogColorBack")]
		public SSimpleCurve FogColorBack { get; set; }

		[W3Type("fogDensity")]
		public SSimpleCurve FogDensity { get; set; }

		[W3Type("fogFinalExp")]
		public SSimpleCurve FogFinalExp { get; set; }

		[W3Type("fogDistClamp")]
		public SSimpleCurve FogDistClamp { get; set; }

		[W3Type("fogVertOffset")]
		public SSimpleCurve FogVertOffset { get; set; }

		[W3Type("fogVertDensity")]
		public SSimpleCurve FogVertDensity { get; set; }

		[W3Type("fogVertDensityLightFront")]
		public SSimpleCurve FogVertDensityLightFront { get; set; }

		[W3Type("fogVertDensityLightBack")]
		public SSimpleCurve FogVertDensityLightBack { get; set; }

		[W3Type("fogSkyDensityScale")]
		public SSimpleCurve FogSkyDensityScale { get; set; }

		[W3Type("fogCloudsDensityScale")]
		public SSimpleCurve FogCloudsDensityScale { get; set; }

		[W3Type("fogSkyVertDensityLightFrontScale")]
		public SSimpleCurve FogSkyVertDensityLightFrontScale { get; set; }

		[W3Type("fogSkyVertDensityLightBackScale")]
		public SSimpleCurve FogSkyVertDensityLightBackScale { get; set; }

		[W3Type("fogVertDensityRimRange")]
		public SSimpleCurve FogVertDensityRimRange { get; set; }

		[W3Type("fogCustomColor")]
		public SSimpleCurve FogCustomColor { get; set; }

		[W3Type("fogCustomColorStart")]
		public SSimpleCurve FogCustomColorStart { get; set; }

		[W3Type("fogCustomColorRange")]
		public SSimpleCurve FogCustomColorRange { get; set; }

		[W3Type("fogCustomAmountScale")]
		public SSimpleCurve FogCustomAmountScale { get; set; }

		[W3Type("fogCustomAmountScaleStart")]
		public SSimpleCurve FogCustomAmountScaleStart { get; set; }

		[W3Type("fogCustomAmountScaleRange")]
		public SSimpleCurve FogCustomAmountScaleRange { get; set; }

		[W3Type("aerialColorFront")]
		public SSimpleCurve AerialColorFront { get; set; }

		[W3Type("aerialColorMiddle")]
		public SSimpleCurve AerialColorMiddle { get; set; }

		[W3Type("aerialColorBack")]
		public SSimpleCurve AerialColorBack { get; set; }

		[W3Type("aerialFinalExp")]
		public SSimpleCurve AerialFinalExp { get; set; }

		[W3Type("ssaoImpactClamp")]
		public SSimpleCurve SsaoImpactClamp { get; set; }

		[W3Type("ssaoImpactNearValue")]
		public SSimpleCurve SsaoImpactNearValue { get; set; }

		[W3Type("ssaoImpactFarValue")]
		public SSimpleCurve SsaoImpactFarValue { get; set; }

		[W3Type("ssaoImpactNearDistance")]
		public SSimpleCurve SsaoImpactNearDistance { get; set; }

		[W3Type("ssaoImpactFarDistance")]
		public SSimpleCurve SsaoImpactFarDistance { get; set; }

		[W3Type("distantLightsIntensityScale")]
		public SSimpleCurve DistantLightsIntensityScale { get; set; }

	}
}
