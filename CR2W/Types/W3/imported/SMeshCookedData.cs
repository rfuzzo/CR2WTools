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
public class SMeshCookedData 
{
#region RED Properties

[REDProp("collisionInitPositionOffset")]
public Vector CollisionInitPositionOffset { get; set;}

[REDProp("dropOffset")]
public Vector DropOffset { get; set;}

[REDProp("bonePositions", 46,0)]
public Array<Vector> BonePositions { get; set;}

[REDProp("renderLODs", 46,0)]
public Array<float> RenderLODs { get; set;}

[REDProp("renderChunks", 46,0)]
public Array<byte> RenderChunks { get; set;}

[REDProp("renderBuffer")]
public DeferredDataBuffer RenderBuffer { get; set;}

[REDProp("quantizationScale")]
public Vector QuantizationScale { get; set;}

[REDProp("quantizationOffset")]
public Vector QuantizationOffset { get; set;}

[REDProp("vertexBufferSize")]
public UInt32 VertexBufferSize { get; set;}

[REDProp("indexBufferSize")]
public UInt32 IndexBufferSize { get; set;}

[REDProp("indexBufferOffset")]
public UInt32 IndexBufferOffset { get; set;}

#endregion
}
}