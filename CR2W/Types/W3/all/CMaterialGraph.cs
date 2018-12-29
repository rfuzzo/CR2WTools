using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMaterialGraph : IMaterialDefinition
{
#region RED Properties

[REDProp("pixelParamBlockSize")]
public uint PixelParamBlockSize { get; set;}

[REDProp("vertexParamBlockSize")]
public uint VertexParamBlockSize { get; set;}

[REDProp("compileAllTechniques")]
public bool CompileAllTechniques { get; set;}

[REDProp("canUseOnMeshes")]
public bool CanUseOnMeshes { get; set;}

[REDProp("canUseOnDestructionMeshes")]
public bool CanUseOnDestructionMeshes { get; set;}

[REDProp("canUseOnApexMeshes")]
public bool CanUseOnApexMeshes { get; set;}

[REDProp("canUseOnParticles")]
public bool CanUseOnParticles { get; set;}

[REDProp("canUseOnCollapsableObjects")]
public bool CanUseOnCollapsableObjects { get; set;}

[REDProp("canUseSkinning")]
public bool CanUseSkinning { get; set;}

[REDProp("canUseSkinnedInstancing")]
public bool CanUseSkinnedInstancing { get; set;}

[REDProp("canUseOnMorphMeshes")]
public bool CanUseOnMorphMeshes { get; set;}

[REDProp("sortGroup")]
public ERenderingSortGroup SortGroup { get; set;}

[REDProp("blendMode")]
public ERenderingBlendMode BlendMode { get; set;}

[REDProp("offset")]
public Vector Offset { get; set;}

[REDProp("blocks")]
public Array<Ptr<CGraphBlock>> Blocks { get; set;}

[REDProp("pixelParameterBlocks")]
public Array<Ptr<CMaterialParameter>> PixelParameterBlocks { get; set;}

[REDProp("vertexParameterBlocks")]
public Array<Ptr<CMaterialParameter>> VertexParameterBlocks { get; set;}

[REDProp("paramMask")]
public uint ParamMask { get; set;}

[REDProp("isTwoSided")]
public bool IsTwoSided { get; set;}

[REDProp("isEmissive")]
public bool IsEmissive { get; set;}

[REDProp("isMasked")]
public bool IsMasked { get; set;}

[REDProp("canOverrideMasked")]
public bool CanOverrideMasked { get; set;}

[REDProp("isForward")]
public bool IsForward { get; set;}

[REDProp("isAccumulativelyRefracted")]
public bool IsAccumulativelyRefracted { get; set;}

[REDProp("isReflectiveMasked")]
public bool IsReflectiveMasked { get; set;}

[REDProp("isEye")]
public bool IsEye { get; set;}

[REDProp("isMimicMaterial")]
public bool IsMimicMaterial { get; set;}

#endregion
}
}