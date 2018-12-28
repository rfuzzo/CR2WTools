using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CNavmesh : CResource
{
#region RED Properties

[REDProp("vertexCount")]
public UInt16 VertexCount { get; set;}

[REDProp("triangleCount")]
public UInt16 TriangleCount { get; set;}

[REDProp("phantomEdgesCount")]
public UInt16 PhantomEdgesCount { get; set;}

[REDProp("binariesVersion")]
public UInt16 BinariesVersion { get; set;}

[REDProp("centralPoint")]
public Vector CentralPoint { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("bbox")]
public Box Bbox { get; set;}

#endregion
}
}