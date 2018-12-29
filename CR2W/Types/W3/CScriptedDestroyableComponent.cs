using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CScriptedDestroyableComponent : CRigidMeshComponent
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

[REDProp("forceLODLevel")]
public int ForceLODLevel { get; set;}

[REDProp("forceAutoHideDistance")]
public UInt16 ForceAutoHideDistance { get; set;}

[REDProp("shadowImportanceBias")]
public EMeshShadowImportanceBias ShadowImportanceBias { get; set;}

[REDProp("defaultEffectParams")]
public Vector DefaultEffectParams { get; set;}

[REDProp("defaultEffectColor")]
public Color DefaultEffectColor { get; set;}

[REDProp("mesh")]
public Handle<CMesh> Mesh { get; set;}

[REDProp("pathLibCollisionType")]
public EPathLibCollision PathLibCollisionType { get; set;}

[REDProp("fadeOnCameraCollision")]
public bool FadeOnCameraCollision { get; set;}

[REDProp("physicalCollisionType")]
public CPhysicalCollision PhysicalCollisionType { get; set;}

[REDProp("motionType")]
public EMotionType MotionType { get; set;}

[REDProp("linearDamping")]
public float LinearDamping { get; set;}

[REDProp("angularDamping")]
public float AngularDamping { get; set;}

[REDProp("linearVelocityClamp")]
public float LinearVelocityClamp { get; set;}

[REDProp("destroyWay")]
public EDestroyWay DestroyWay { get; set;}

#endregion
}
}