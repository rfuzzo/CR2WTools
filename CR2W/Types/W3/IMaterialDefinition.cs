using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class IMaterialDefinition : IMaterial
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

#endregion
}
}