using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAreaEnvironmentParams 
{
#region RED Properties

[REDProp("m_finalColorBalance")]
public CEnvFinalColorBalanceParameters M_finalColorBalance { get; set;}

[REDProp("m_sharpen")]
public CEnvSharpenParameters M_sharpen { get; set;}

[REDProp("m_paintEffect")]
public CEnvPaintEffectParameters M_paintEffect { get; set;}

[REDProp("m_ssaoNV")]
public CEnvNVSSAOParameters M_ssaoNV { get; set;}

[REDProp("m_ssaoMS")]
public CEnvMSSSAOParameters M_ssaoMS { get; set;}

[REDProp("m_globalLight")]
public CEnvGlobalLightParameters M_globalLight { get; set;}

[REDProp("m_interiorFallback")]
public CEnvInteriorFallbackParameters M_interiorFallback { get; set;}

[REDProp("m_speedTree")]
public CEnvSpeedTreeParameters M_speedTree { get; set;}

[REDProp("m_toneMapping")]
public CEnvToneMappingParameters M_toneMapping { get; set;}

[REDProp("m_bloomNew")]
public CEnvBloomNewParameters M_bloomNew { get; set;}

[REDProp("m_globalFog")]
public CEnvGlobalFogParameters M_globalFog { get; set;}

[REDProp("m_sky")]
public CEnvGlobalSkyParameters M_sky { get; set;}

[REDProp("m_depthOfField")]
public CEnvDepthOfFieldParameters M_depthOfField { get; set;}

[REDProp("m_colorModTransparency")]
public CEnvColorModTransparencyParameters M_colorModTransparency { get; set;}

[REDProp("m_shadows")]
public CEnvShadowsParameters M_shadows { get; set;}

[REDProp("m_water")]
public CEnvWaterParameters M_water { get; set;}

[REDProp("m_colorGroups")]
public CEnvColorGroupsParameters M_colorGroups { get; set;}

[REDProp("m_flareColorGroups")]
public CEnvFlareColorGroupsParameters M_flareColorGroups { get; set;}

[REDProp("m_sunAndMoonParams")]
public CEnvSunAndMoonParameters M_sunAndMoonParams { get; set;}

[REDProp("m_windParams")]
public CEnvWindParameters M_windParams { get; set;}

[REDProp("m_gameplayEffects")]
public CEnvGameplayEffectsParameters M_gameplayEffects { get; set;}

[REDProp("m_motionBlur")]
public CEnvMotionBlurParameters M_motionBlur { get; set;}

[REDProp("m_cameraLightsSetup")]
public CEnvCameraLightsSetupParameters M_cameraLightsSetup { get; set;}

[REDProp("m_dialogLightParams")]
public CEnvDialogLightParameters M_dialogLightParams { get; set;}

#endregion
}
}