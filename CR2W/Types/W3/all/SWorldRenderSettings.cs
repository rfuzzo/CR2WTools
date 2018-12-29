using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SWorldRenderSettings 
{
#region RED Properties

[REDProp("cameraNearPlane")]
public float CameraNearPlane { get; set;}

[REDProp("cameraFarPlane")]
public float CameraFarPlane { get; set;}

[REDProp("ssaoBlurEnable")]
public bool SsaoBlurEnable { get; set;}

[REDProp("ssaoNormalsEnable")]
public bool SsaoNormalsEnable { get; set;}

[REDProp("envProbeSecondAmbientFilterSize")]
public float EnvProbeSecondAmbientFilterSize { get; set;}

[REDProp("fakeCloudsShadowSize")]
public float FakeCloudsShadowSize { get; set;}

[REDProp("fakeCloudsShadowSpeed")]
public float FakeCloudsShadowSpeed { get; set;}

[REDProp("fakeCloudsShadowTexture")]
public Handle<CTextureArray> FakeCloudsShadowTexture { get; set;}

[REDProp("bloomLevelsRange")]
public uint BloomLevelsRange { get; set;}

[REDProp("bloomLevelsOffset")]
public uint BloomLevelsOffset { get; set;}

[REDProp("bloomScaleConst")]
public float BloomScaleConst { get; set;}

[REDProp("bloomDownscaleDivBase")]
public float BloomDownscaleDivBase { get; set;}

[REDProp("bloomDownscaleDivExp")]
public float BloomDownscaleDivExp { get; set;}

[REDProp("bloomLevelScale0")]
public float BloomLevelScale0 { get; set;}

[REDProp("bloomLevelScale1")]
public float BloomLevelScale1 { get; set;}

[REDProp("bloomLevelScale2")]
public float BloomLevelScale2 { get; set;}

[REDProp("bloomLevelScale3")]
public float BloomLevelScale3 { get; set;}

[REDProp("bloomLevelScale4")]
public float BloomLevelScale4 { get; set;}

[REDProp("bloomLevelScale5")]
public float BloomLevelScale5 { get; set;}

[REDProp("bloomLevelScale6")]
public float BloomLevelScale6 { get; set;}

[REDProp("bloomLevelScale7")]
public float BloomLevelScale7 { get; set;}

[REDProp("bloomPrecision")]
public float BloomPrecision { get; set;}

[REDProp("shaftsLevelIndex")]
public uint ShaftsLevelIndex { get; set;}

[REDProp("shaftsIntensity")]
public float ShaftsIntensity { get; set;}

[REDProp("shaftsThresholdsScale")]
public float ShaftsThresholdsScale { get; set;}

[REDProp("fresnelScaleLights")]
public float FresnelScaleLights { get; set;}

[REDProp("fresnelScaleEnvProbes")]
public float FresnelScaleEnvProbes { get; set;}

[REDProp("fresnelRoughnessShape")]
public float FresnelRoughnessShape { get; set;}

[REDProp("interiorDimmerAmbientLevel")]
public float InteriorDimmerAmbientLevel { get; set;}

[REDProp("interiorVolumeSmoothExtent")]
public float InteriorVolumeSmoothExtent { get; set;}

[REDProp("interiorVolumeSmoothRemovalRange")]
public float InteriorVolumeSmoothRemovalRange { get; set;}

[REDProp("interiorVolumesFadeStartDist")]
public float InteriorVolumesFadeStartDist { get; set;}

[REDProp("interiorVolumesFadeRange")]
public float InteriorVolumesFadeRange { get; set;}

[REDProp("interiorVolumesFadeEncodeRange")]
public float InteriorVolumesFadeEncodeRange { get; set;}

[REDProp("distantLightStartDistance")]
public float DistantLightStartDistance { get; set;}

[REDProp("distantLightFadeDistance")]
public float DistantLightFadeDistance { get; set;}

[REDProp("globalFlaresTransparencyThreshold")]
public float GlobalFlaresTransparencyThreshold { get; set;}

[REDProp("globalFlaresTransparencyRange")]
public float GlobalFlaresTransparencyRange { get; set;}

[REDProp("motionBlurSettings")]
public SWorldMotionBlurSettings MotionBlurSettings { get; set;}

[REDProp("chromaticAberrationStart")]
public float ChromaticAberrationStart { get; set;}

[REDProp("chromaticAberrationRange")]
public float ChromaticAberrationRange { get; set;}

[REDProp("interiorFallbackReflectionThresholdLow")]
public float InteriorFallbackReflectionThresholdLow { get; set;}

[REDProp("interiorFallbackReflectionThresholdHigh")]
public float InteriorFallbackReflectionThresholdHigh { get; set;}

[REDProp("interiorFallbackReflectionBlendLow")]
public float InteriorFallbackReflectionBlendLow { get; set;}

[REDProp("interiorFallbackReflectionBlendHigh")]
public float InteriorFallbackReflectionBlendHigh { get; set;}

[REDProp("enableEnvProbeLights")]
public bool EnableEnvProbeLights { get; set;}

#endregion
}
}