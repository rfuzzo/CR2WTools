using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CApexDestructionResource : CApexResource
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

[REDProp("maxDepth")]
public uint MaxDepth { get; set;}

[REDProp("originalMaxDepth")]
public uint OriginalMaxDepth { get; set;}

[REDProp("supportDepth")]
public uint SupportDepth { get; set;}

[REDProp("neighborPadding")]
public float NeighborPadding { get; set;}

[REDProp("initialAllowance")]
public uint InitialAllowance { get; set;}

[REDProp("formExtendedStructures")]
public bool FormExtendedStructures { get; set;}

[REDProp("useAssetSupport")]
public bool UseAssetSupport { get; set;}

[REDProp("useWorldSupport")]
public bool UseWorldSupport { get; set;}

[REDProp("chunkDepthMaterials")]
public Array<CName> ChunkDepthMaterials { get; set;}

[REDProp("unfracturedDensityScaler")]
public float UnfracturedDensityScaler { get; set;}

[REDProp("fracturedDensityScaler")]
public float FracturedDensityScaler { get; set;}

[REDProp("fractureSoundEvent")]
public StringAnsi FractureSoundEvent { get; set;}

[REDProp("fxName")]
public CName FxName { get; set;}

#endregion
}
}