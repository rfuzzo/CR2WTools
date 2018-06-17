
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CAreaEnvironmentParams
	{
		[W3Type("m_finalColorBalance")]
		public CEnvFinalColorBalanceParameters M_finalColorBalance { get; set; }

		[W3Type("m_sharpen")]
		public CEnvSharpenParameters M_sharpen { get; set; }

		[W3Type("m_paintEffect")]
		public CEnvPaintEffectParameters M_paintEffect { get; set; }

		[W3Type("m_ssaoNV")]
		public CEnvNVSSAOParameters M_ssaoNV { get; set; }

		[W3Type("m_ssaoMS")]
		public CEnvMSSSAOParameters M_ssaoMS { get; set; }

		[W3Type("m_globalLight")]
		public CEnvGlobalLightParameters M_globalLight { get; set; }

		[W3Type("m_interiorFallback")]
		public CEnvInteriorFallbackParameters M_interiorFallback { get; set; }

		[W3Type("m_speedTree")]
		public CEnvSpeedTreeParameters M_speedTree { get; set; }

		[W3Type("m_toneMapping")]
		public CEnvToneMappingParameters M_toneMapping { get; set; }

		[W3Type("m_bloomNew")]
		public CEnvBloomNewParameters M_bloomNew { get; set; }

		[W3Type("m_globalFog")]
		public CEnvGlobalFogParameters M_globalFog { get; set; }

		[W3Type("m_sky")]
		public CEnvGlobalSkyParameters M_sky { get; set; }

		[W3Type("m_depthOfField")]
		public CEnvDepthOfFieldParameters M_depthOfField { get; set; }

		[W3Type("m_colorModTransparency")]
		public CEnvColorModTransparencyParameters M_colorModTransparency { get; set; }

		[W3Type("m_shadows")]
		public CEnvShadowsParameters M_shadows { get; set; }

		[W3Type("m_water")]
		public CEnvWaterParameters M_water { get; set; }

		[W3Type("m_colorGroups")]
		public CEnvColorGroupsParameters M_colorGroups { get; set; }

		[W3Type("m_flareColorGroups")]
		public CEnvFlareColorGroupsParameters M_flareColorGroups { get; set; }

		[W3Type("m_sunAndMoonParams")]
		public CEnvSunAndMoonParameters M_sunAndMoonParams { get; set; }

		[W3Type("m_windParams")]
		public CEnvWindParameters M_windParams { get; set; }

		[W3Type("m_gameplayEffects")]
		public CEnvGameplayEffectsParameters M_gameplayEffects { get; set; }

		[W3Type("m_motionBlur")]
		public CEnvMotionBlurParameters M_motionBlur { get; set; }

		[W3Type("m_cameraLightsSetup")]
		public CEnvCameraLightsSetupParameters M_cameraLightsSetup { get; set; }

		[W3Type("m_dialogLightParams")]
		public CEnvDialogLightParameters M_dialogLightParams { get; set; }

	}
}
