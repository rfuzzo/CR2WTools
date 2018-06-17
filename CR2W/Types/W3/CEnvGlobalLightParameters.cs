
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvGlobalLightParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("activatedGlobalLightActivated")]
		public bool ActivatedGlobalLightActivated { get; set; }

		[W3Type("globalLightActivated")]
		public float GlobalLightActivated { get; set; }

		[W3Type("activatedActivatedFactorLightDir")]
		public bool ActivatedActivatedFactorLightDir { get; set; }

		[W3Type("activatedFactorLightDir")]
		public float ActivatedFactorLightDir { get; set; }

		[W3Type("sunColor")]
		public SSimpleCurve SunColor { get; set; }

		[W3Type("sunColorLightSide")]
		public SSimpleCurve SunColorLightSide { get; set; }

		[W3Type("sunColorLightOppositeSide")]
		public SSimpleCurve SunColorLightOppositeSide { get; set; }

		[W3Type("sunColorCenterArea")]
		public SSimpleCurve SunColorCenterArea { get; set; }

		[W3Type("sunColorSidesMargin")]
		public SSimpleCurve SunColorSidesMargin { get; set; }

		[W3Type("sunColorBottomHeight")]
		public SSimpleCurve SunColorBottomHeight { get; set; }

		[W3Type("sunColorTopHeight")]
		public SSimpleCurve SunColorTopHeight { get; set; }

		[W3Type("forcedLightDirAnglesYaw")]
		public SSimpleCurve ForcedLightDirAnglesYaw { get; set; }

		[W3Type("forcedLightDirAnglesPitch")]
		public SSimpleCurve ForcedLightDirAnglesPitch { get; set; }

		[W3Type("forcedLightDirAnglesRoll")]
		public SSimpleCurve ForcedLightDirAnglesRoll { get; set; }

		[W3Type("forcedSunDirAnglesYaw")]
		public SSimpleCurve ForcedSunDirAnglesYaw { get; set; }

		[W3Type("forcedSunDirAnglesPitch")]
		public SSimpleCurve ForcedSunDirAnglesPitch { get; set; }

		[W3Type("forcedSunDirAnglesRoll")]
		public SSimpleCurve ForcedSunDirAnglesRoll { get; set; }

		[W3Type("forcedMoonDirAnglesYaw")]
		public SSimpleCurve ForcedMoonDirAnglesYaw { get; set; }

		[W3Type("forcedMoonDirAnglesPitch")]
		public SSimpleCurve ForcedMoonDirAnglesPitch { get; set; }

		[W3Type("forcedMoonDirAnglesRoll")]
		public SSimpleCurve ForcedMoonDirAnglesRoll { get; set; }

		[W3Type("translucencyViewDependency")]
		public SSimpleCurve TranslucencyViewDependency { get; set; }

		[W3Type("translucencyBaseFlatness")]
		public SSimpleCurve TranslucencyBaseFlatness { get; set; }

		[W3Type("translucencyFlatBrightness")]
		public SSimpleCurve TranslucencyFlatBrightness { get; set; }

		[W3Type("translucencyGainBrightness")]
		public SSimpleCurve TranslucencyGainBrightness { get; set; }

		[W3Type("translucencyFresnelScaleLight")]
		public SSimpleCurve TranslucencyFresnelScaleLight { get; set; }

		[W3Type("translucencyFresnelScaleReflection")]
		public SSimpleCurve TranslucencyFresnelScaleReflection { get; set; }

		[W3Type("envProbeBaseLightingAmbient")]
		public CEnvAmbientProbesGenParameters EnvProbeBaseLightingAmbient { get; set; }

		[W3Type("envProbeBaseLightingReflection")]
		public CEnvReflectionProbesGenParameters EnvProbeBaseLightingReflection { get; set; }

		[W3Type("charactersLightingBoostAmbientLight")]
		public SSimpleCurve CharactersLightingBoostAmbientLight { get; set; }

		[W3Type("charactersLightingBoostAmbientShadow")]
		public SSimpleCurve CharactersLightingBoostAmbientShadow { get; set; }

		[W3Type("charactersLightingBoostReflectionLight")]
		public SSimpleCurve CharactersLightingBoostReflectionLight { get; set; }

		[W3Type("charactersLightingBoostReflectionShadow")]
		public SSimpleCurve CharactersLightingBoostReflectionShadow { get; set; }

		[W3Type("charactersEyeBlicksColor")]
		public SSimpleCurve CharactersEyeBlicksColor { get; set; }

		[W3Type("charactersEyeBlicksShadowedScale")]
		public SSimpleCurve CharactersEyeBlicksShadowedScale { get; set; }

		[W3Type("envProbeAmbientScaleLight")]
		public SSimpleCurve EnvProbeAmbientScaleLight { get; set; }

		[W3Type("envProbeAmbientScaleShadow")]
		public SSimpleCurve EnvProbeAmbientScaleShadow { get; set; }

		[W3Type("envProbeReflectionScaleLight")]
		public SSimpleCurve EnvProbeReflectionScaleLight { get; set; }

		[W3Type("envProbeReflectionScaleShadow")]
		public SSimpleCurve EnvProbeReflectionScaleShadow { get; set; }

		[W3Type("envProbeDistantScaleFactor")]
		public SSimpleCurve EnvProbeDistantScaleFactor { get; set; }

	}
}
