using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSpotLightComponent : CLightComponent
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("transformParent")]
public Ptr<CHardAttachment> TransformParent { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("isStreamed")]
public bool IsStreamed { get; set;}

[REDProp("isVisible")]
public bool IsVisible { get; set;}

[REDProp("icon")]
public Handle<CBitmapTexture> Icon { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("shadowCastingMode")]
public ELightShadowCastingMode ShadowCastingMode { get; set;}

[REDProp("shadowFadeDistance")]
public float ShadowFadeDistance { get; set;}

[REDProp("shadowFadeRange")]
public float ShadowFadeRange { get; set;}

[REDProp("shadowBlendFactor")]
public float ShadowBlendFactor { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("brightness")]
public float Brightness { get; set;}

[REDProp("attenuation")]
public float Attenuation { get; set;}

[REDProp("color")]
public Color Color { get; set;}

[REDProp("envColorGroup")]
public EEnvColorGroup EnvColorGroup { get; set;}

[REDProp("autoHideDistance")]
public float AutoHideDistance { get; set;}

[REDProp("autoHideRange")]
public float AutoHideRange { get; set;}

[REDProp("lightFlickering")]
public SLightFlickering LightFlickering { get; set;}

[REDProp("allowDistantFade")]
public bool AllowDistantFade { get; set;}

[REDProp("lightUsageMask")]
public ELightUsageMask LightUsageMask { get; set;}

[REDProp("innerAngle")]
public float InnerAngle { get; set;}

[REDProp("outerAngle")]
public float OuterAngle { get; set;}

[REDProp("softness")]
public float Softness { get; set;}

[REDProp("projectionTexture")]
public Handle<CBitmapTexture> ProjectionTexture { get; set;}

[REDProp("projectionTextureAngle")]
public float ProjectionTextureAngle { get; set;}

[REDProp("projectionTexureUBias")]
public float ProjectionTexureUBias { get; set;}

[REDProp("projectionTexureVBias")]
public float ProjectionTexureVBias { get; set;}

#endregion
}
}