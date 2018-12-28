using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStripeComponent : CDrawableComponent
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

[REDProp("diffuseTexture2")]
public Handle<CBitmapTexture> DiffuseTexture2 { get; set;}

[REDProp("normalTexture")]
public Handle<CBitmapTexture> NormalTexture { get; set;}

[REDProp("normalTexture2")]
public Handle<CBitmapTexture> NormalTexture2 { get; set;}

[REDProp("blendTexture")]
public Handle<CBitmapTexture> BlendTexture { get; set;}

[REDProp("depthTexture")]
public Handle<CBitmapTexture> DepthTexture { get; set;}

[REDProp("rotateTexture")]
public bool RotateTexture { get; set;}

[REDProp("autoHideDistance")]
public float AutoHideDistance { get; set;}

[REDProp("textureLength")]
public float TextureLength { get; set;}

[REDProp("blendTextureLength")]
public float BlendTextureLength { get; set;}

[REDProp("points")]
public Array<SStripeControlPoint> Points { get; set;}

[REDProp("width")]
public float Width { get; set;}

[REDProp("alphaScale")]
public float AlphaScale { get; set;}

[REDProp("endpointAlpha")]
public float EndpointAlpha { get; set;}

[REDProp("stripeColor")]
public Color StripeColor { get; set;}

[REDProp("density")]
public float Density { get; set;}

[REDProp("projectToTerrain")]
public bool ProjectToTerrain { get; set;}

[REDProp("exposedToNavigation")]
public bool ExposedToNavigation { get; set;}

[REDProp("cookedVertices")]
public DataBuffer CookedVertices { get; set;}

[REDProp("cookedIndices")]
public DataBuffer CookedIndices { get; set;}

[REDProp("cookedVertexCount")]
public uint CookedVertexCount { get; set;}

[REDProp("cookedIndexCount")]
public uint CookedIndexCount { get; set;}

[REDProp("cookedBoundingBox")]
public Box CookedBoundingBox { get; set;}

#endregion
}
}