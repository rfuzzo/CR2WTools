using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SMeshChunkPacked 
{
#region RED Properties

[REDProp("vertexType")]
public EMeshVertexType VertexType { get; set;}

[REDProp("materialID")]
public UInt32 MaterialID { get; set;}

[REDProp("numBonesPerVertex")]
public byte NumBonesPerVertex { get; set;}

[REDProp("numVertices")]
public UInt32 NumVertices { get; set;}

[REDProp("numIndices")]
public UInt32 NumIndices { get; set;}

[REDProp("firstVertex")]
public UInt32 FirstVertex { get; set;}

[REDProp("firstIndex")]
public UInt32 FirstIndex { get; set;}

[REDProp("renderMask")]
public EMeshChunkRenderMask RenderMask { get; set;}

[REDProp("useForShadowmesh")]
public bool UseForShadowmesh { get; set;}

#endregion
}
}