using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SWorldEnvironmentParameters 
{
#region RED Properties

[REDProp("vignetteTexture")]
public Handle<CBitmapTexture> VignetteTexture { get; set;}

[REDProp("cameraDirtTexture")]
public Handle<CBitmapTexture> CameraDirtTexture { get; set;}

[REDProp("interiorFallbackAmbientTexture")]
public Handle<CCubeTexture> InteriorFallbackAmbientTexture { get; set;}

[REDProp("interiorFallbackReflectionTexture")]
public Handle<CCubeTexture> InteriorFallbackReflectionTexture { get; set;}

[REDProp("cameraDirtNumVerticalTiles")]
public float CameraDirtNumVerticalTiles { get; set;}

[REDProp("globalLightingTrajectory")]
public CGlobalLightingTrajectory GlobalLightingTrajectory { get; set;}

[REDProp("toneMappingAdaptationSpeedUp")]
public float ToneMappingAdaptationSpeedUp { get; set;}

[REDProp("toneMappingAdaptationSpeedDown")]
public float ToneMappingAdaptationSpeedDown { get; set;}

[REDProp("environmentDefinition")]
public Handle<CEnvironmentDefinition> EnvironmentDefinition { get; set;}

[REDProp("scenesEnvironmentDefinition")]
public Handle<CEnvironmentDefinition> ScenesEnvironmentDefinition { get; set;}

[REDProp("speedTreeParameters")]
public SGlobalSpeedTreeParameters SpeedTreeParameters { get; set;}

[REDProp("weatherTemplate")]
public Handle<C2dArray> WeatherTemplate { get; set;}

[REDProp("disableWaterShaders")]
public bool DisableWaterShaders { get; set;}

[REDProp("skybox")]
public SWorldSkyboxParameters Skybox { get; set;}

[REDProp("lensFlare")]
public SLensFlareGroupsParameters LensFlare { get; set;}

[REDProp("renderSettings")]
public SWorldRenderSettings RenderSettings { get; set;}

[REDProp("localWindDampers")]
public Handle<CResourceSimplexTree> LocalWindDampers { get; set;}

[REDProp("localWaterVisibility")]
public Handle<CResourceSimplexTree> LocalWaterVisibility { get; set;}

#endregion
}
}