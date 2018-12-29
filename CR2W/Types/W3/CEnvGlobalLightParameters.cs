
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvGlobalLightParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("activatedGlobalLightActivated")]
		public bool ActivatedGlobalLightActivated { get; set; }

		[REDProp("globalLightActivated")]
		public float GlobalLightActivated { get; set; }

		[REDProp("activatedActivatedFactorLightDir")]
		public bool ActivatedActivatedFactorLightDir { get; set; }

		[REDProp("activatedFactorLightDir")]
		public float ActivatedFactorLightDir { get; set; }

		[REDProp("sunColor")]
		public SSimpleCurve SunColor { get; set; }

		[REDProp("sunColorLightSide")]
		public SSimpleCurve SunColorLightSide { get; set; }

		[REDProp("sunColorLightOppositeSide")]
		public SSimpleCurve SunColorLightOppositeSide { get; set; }

		[REDProp("sunColorCenterArea")]
		public SSimpleCurve SunColorCenterArea { get; set; }

		[REDProp("sunColorSidesMargin")]
		public SSimpleCurve SunColorSidesMargin { get; set; }

		[REDProp("sunColorBottomHeight")]
		public SSimpleCurve SunColorBottomHeight { get; set; }

		[REDProp("sunColorTopHeight")]
		public SSimpleCurve SunColorTopHeight { get; set; }

		[REDProp("forcedLightDirAnglesYaw")]
		public SSimpleCurve ForcedLightDirAnglesYaw { get; set; }

		[REDProp("forcedLightDirAnglesPitch")]
		public SSimpleCurve ForcedLightDirAnglesPitch { get; set; }

		[REDProp("forcedLightDirAnglesRoll")]
		public SSimpleCurve ForcedLightDirAnglesRoll { get; set; }

		[REDProp("forcedSunDirAnglesYaw")]
		public SSimpleCurve ForcedSunDirAnglesYaw { get; set; }

		[REDProp("forcedSunDirAnglesPitch")]
		public SSimpleCurve ForcedSunDirAnglesPitch { get; set; }

		[REDProp("forcedSunDirAnglesRoll")]
		public SSimpleCurve ForcedSunDirAnglesRoll { get; set; }

		[REDProp("forcedMoonDirAnglesYaw")]
		public SSimpleCurve ForcedMoonDirAnglesYaw { get; set; }

		[REDProp("forcedMoonDirAnglesPitch")]
		public SSimpleCurve ForcedMoonDirAnglesPitch { get; set; }

		[REDProp("forcedMoonDirAnglesRoll")]
		public SSimpleCurve ForcedMoonDirAnglesRoll { get; set; }

		[REDProp("translucencyViewDependency")]
		public SSimpleCurve TranslucencyViewDependency { get; set; }

		[REDProp("translucencyBaseFlatness")]
		public SSimpleCurve TranslucencyBaseFlatness { get; set; }

		[REDProp("translucencyFlatBrightness")]
		public SSimpleCurve TranslucencyFlatBrightness { get; set; }

		[REDProp("translucencyGainBrightness")]
		public SSimpleCurve TranslucencyGainBrightness { get; set; }

		[REDProp("translucencyFresnelScaleLight")]
		public SSimpleCurve TranslucencyFresnelScaleLight { get; set; }

		[REDProp("translucencyFresnelScaleReflection")]
		public SSimpleCurve TranslucencyFresnelScaleReflection { get; set; }

		[REDProp("envProbeBaseLightingAmbient")]
		public CEnvAmbientProbesGenParameters EnvProbeBaseLightingAmbient { get; set; }

		[REDProp("envProbeBaseLightingReflection")]
		public CEnvReflectionProbesGenParameters EnvProbeBaseLightingReflection { get; set; }

		[REDProp("charactersLightingBoostAmbientLight")]
		public SSimpleCurve CharactersLightingBoostAmbientLight { get; set; }

		[REDProp("charactersLightingBoostAmbientShadow")]
		public SSimpleCurve CharactersLightingBoostAmbientShadow { get; set; }

		[REDProp("charactersLightingBoostReflectionLight")]
		public SSimpleCurve CharactersLightingBoostReflectionLight { get; set; }

		[REDProp("charactersLightingBoostReflectionShadow")]
		public SSimpleCurve CharactersLightingBoostReflectionShadow { get; set; }

		[REDProp("charactersEyeBlicksColor")]
		public SSimpleCurve CharactersEyeBlicksColor { get; set; }

		[REDProp("charactersEyeBlicksShadowedScale")]
		public SSimpleCurve CharactersEyeBlicksShadowedScale { get; set; }

		[REDProp("envProbeAmbientScaleLight")]
		public SSimpleCurve EnvProbeAmbientScaleLight { get; set; }

		[REDProp("envProbeAmbientScaleShadow")]
		public SSimpleCurve EnvProbeAmbientScaleShadow { get; set; }

		[REDProp("envProbeReflectionScaleLight")]
		public SSimpleCurve EnvProbeReflectionScaleLight { get; set; }

		[REDProp("envProbeReflectionScaleShadow")]
		public SSimpleCurve EnvProbeReflectionScaleShadow { get; set; }

		[REDProp("envProbeDistantScaleFactor")]
		public SSimpleCurve EnvProbeDistantScaleFactor { get; set; }

	}
}
