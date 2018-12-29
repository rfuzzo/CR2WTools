using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CDressMeshComponent : CMeshComponent
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

[REDProp("skeleton")]
public Handle<CSkeleton> Skeleton { get; set;}

[REDProp("thighBoneWeight")]
public float ThighBoneWeight { get; set;}

[REDProp("shinBoneWeight")]
public float ShinBoneWeight { get; set;}

[REDProp("kneeRollBoneWeight")]
public float KneeRollBoneWeight { get; set;}

[REDProp("ofweight")]
public float Ofweight { get; set;}

[REDProp("p1")]
public Vector P1 { get; set;}

[REDProp("p2")]
public Vector P2 { get; set;}

[REDProp("p3")]
public Vector P3 { get; set;}

[REDProp("r1")]
public Vector R1 { get; set;}

[REDProp("r2")]
public Vector R2 { get; set;}

[REDProp("r3")]
public Vector R3 { get; set;}

#endregion
}
}