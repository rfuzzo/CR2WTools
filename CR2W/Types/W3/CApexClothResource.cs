using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CApexClothResource : CApexResource
{
#region RED Properties

[REDProp("materials")]
public Array<Handle<IMaterial>> Materials { get; set;}

[REDProp("boundingBox")]
public Box BoundingBox { get; set;}

[REDProp("autoHideDistance")]
public float AutoHideDistance { get; set;}

[REDProp("isTwoSided")]
public bool IsTwoSided { get; set;}

[REDProp("apexBinaryAsset")]
public Array<byte> ApexBinaryAsset { get; set;}

[REDProp("apexMaterialNames")]
public Array<string> ApexMaterialNames { get; set;}

[REDProp("shadowDistance")]
public float ShadowDistance { get; set;}

[REDProp("boneCount")]
public uint BoneCount { get; set;}

[REDProp("boneNames")]
public Array<CName> BoneNames { get; set;}

[REDProp("boneMatrices")]
public Array<Matrix> BoneMatrices { get; set;}

[REDProp("simThickness")]
public float SimThickness { get; set;}

[REDProp("simVirtualParticleDensity")]
public float SimVirtualParticleDensity { get; set;}

[REDProp("simDisableCCD")]
public bool SimDisableCCD { get; set;}

[REDProp("mtlMassScale")]
public float MtlMassScale { get; set;}

[REDProp("mtlFriction")]
public float MtlFriction { get; set;}

[REDProp("mtlGravityScale")]
public float MtlGravityScale { get; set;}

[REDProp("mtlBendingStiffness")]
public float MtlBendingStiffness { get; set;}

[REDProp("mtlShearingStiffness")]
public float MtlShearingStiffness { get; set;}

[REDProp("mtlTetherStiffness")]
public float MtlTetherStiffness { get; set;}

[REDProp("mtlTetherLimit")]
public float MtlTetherLimit { get; set;}

[REDProp("mtlDamping")]
public float MtlDamping { get; set;}

[REDProp("mtlDrag")]
public float MtlDrag { get; set;}

[REDProp("mtlInertiaScale")]
public float MtlInertiaScale { get; set;}

[REDProp("mtlMaxDistanceBias")]
public float MtlMaxDistanceBias { get; set;}

[REDProp("mtlSelfcollisionThickness")]
public float MtlSelfcollisionThickness { get; set;}

[REDProp("mtlSelfcollisionStiffness")]
public float MtlSelfcollisionStiffness { get; set;}

[REDProp("mtlHardStretchLimitation")]
public float MtlHardStretchLimitation { get; set;}

[REDProp("mtlComDamping")]
public bool MtlComDamping { get; set;}

/*[REDProp("graphicalLodLevelInfo")]
public Array<SMeshTypeResourceLODLevel> GraphicalLodLevelInfo { get; set;}*/ //FIXME

#endregion
}
}