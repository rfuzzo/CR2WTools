using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCameraComponent : CSpriteComponent
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

[REDProp("fov")]
public float Fov { get; set;}

[REDProp("nearPlane")]
public ENearPlaneDistance NearPlane { get; set;}

[REDProp("farPlane")]
public EFarPlaneDistance FarPlane { get; set;}

[REDProp("customClippingPlanes")]
public SCustomClippingPlanes CustomClippingPlanes { get; set;}

[REDProp("aspect")]
public float Aspect { get; set;}

[REDProp("lockAspect")]
public bool LockAspect { get; set;}

[REDProp("defaultCamera")]
public bool DefaultCamera { get; set;}

#endregion
}
}