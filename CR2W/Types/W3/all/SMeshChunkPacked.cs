using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SMeshChunkPacked 
{
#region RED Properties

[REDProp("vertexType")]
public EMeshVertexType VertexType { get; set;}

[REDProp("materialID")]
public uint MaterialID { get; set;}

[REDProp("numBonesPerVertex")]
public byte NumBonesPerVertex { get; set;}

[REDProp("numVertices")]
public uint NumVertices { get; set;}

[REDProp("numIndices")]
public uint NumIndices { get; set;}

[REDProp("firstVertex")]
public uint FirstVertex { get; set;}

[REDProp("firstIndex")]
public uint FirstIndex { get; set;}

[REDProp("renderMask")]
public EMeshChunkRenderMask RenderMask { get; set;}

[REDProp("useForShadowmesh")]
public bool UseForShadowmesh { get; set;}

#endregion
}
}