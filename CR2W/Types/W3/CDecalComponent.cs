using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CDecalComponent : CDrawableComponent
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

[REDProp("boundingBox")]
public Box BoundingBox { get; set;}

[REDProp("drawableFlags")]
public EDrawableFlags DrawableFlags { get; set;}

[REDProp("lightChannels")]
public ELightChannel LightChannels { get; set;}

[REDProp("renderingPlane")]
public ERenderingPlane RenderingPlane { get; set;}

[REDProp("diffuseTexture")]
public Handle<CBitmapTexture> DiffuseTexture { get; set;}

[REDProp("specularity")]
public float Specularity { get; set;}

[REDProp("specularColor")]
public Color SpecularColor { get; set;}

[REDProp("normalThreshold")]
public float NormalThreshold { get; set;}

[REDProp("autoHideDistance")]
public float AutoHideDistance { get; set;}

[REDProp("verticalFlip")]
public bool VerticalFlip { get; set;}

[REDProp("horizontalFlip")]
public bool HorizontalFlip { get; set;}

[REDProp("fadeTime")]
public float FadeTime { get; set;}

#endregion
}
}