using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CAreaEnvironmentParams
	{
		[REDProp("m_finalColorBalance")]
		public CEnvFinalColorBalanceParameters FinalColorBalance { get; set; }

		[REDProp("m_sharpen")]
		public CEnvSharpenParameters Sharpen { get; set; }

		[REDProp("m_paintEffect")]
		public CEnvPaintEffectParameters PaintEffect { get; set; }

		[REDProp("m_ssaoNV")]
		public CEnvNVSSAOParameters SSAONV { get; set; }

		[REDProp("m_ssaoMS")]
		public CEnvMSSSAOParameters SSAOMS { get; set; }

		[REDProp("m_globalLight")]
		public CEnvGlobalLightParameters GlobalLight { get; set; }

		[REDProp("m_interiorFallback")]
		public CEnvInteriorFallbackParameters InteriorFallback { get; set; }

		[REDProp("m_speedTree")]
		public CEnvSpeedTreeParameters SpeedTree { get; set; }

		[REDProp("m_toneMapping")]
		public CEnvToneMappingParameters ToneMapping { get; set; }

		[REDProp("m_bloomNew")]
		public CEnvBloomNewParameters BloomNew { get; set; }

		[REDProp("m_globalFog")]
		public CEnvGlobalFogParameters GlobalFog { get; set; }

		[REDProp("m_sky")]
		public CEnvGlobalSkyParameters Sky { get; set; }

		[REDProp("m_depthOfField")]
		public CEnvDepthOfFieldParameters DepthOfField { get; set; }

		[REDProp("m_colorModTransparency")]
		public CEnvColorModTransparencyParameters ColorModTransparency { get; set; }

		[REDProp("m_shadows")]
		public CEnvShadowsParameters Shadows { get; set; }

		[REDProp("m_water")]
		public CEnvWaterParameters Water { get; set; }

		[REDProp("m_colorGroups")]
		public CEnvColorGroupsParameters ColorGroups { get; set; }

		[REDProp("m_flareColorGroups")]
		public CEnvFlareColorGroupsParameters FlareColorGroups { get; set; }

		[REDProp("m_sunAndMoonParams")]
		public CEnvSunAndMoonParameters SunAndMoonParams { get; set; }

		[REDProp("m_windParams")]
		public CEnvWindParameters WindParams { get; set; }

		[REDProp("m_gameplayEffects")]
		public CEnvGameplayEffectsParameters GameplayEffects { get; set; }

		[REDProp("m_motionBlur")]
		public CEnvMotionBlurParameters MotionBlur { get; set; }

		[REDProp("m_cameraLightsSetup")]
		public CEnvCameraLightsSetupParameters CameraLightsSetup { get; set; }

		[REDProp("m_dialogLightParams")]
		public CEnvDialogLightParameters DialogLightParams { get; set; }

	}
}
