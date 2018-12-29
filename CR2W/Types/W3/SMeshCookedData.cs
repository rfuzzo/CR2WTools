using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SMeshCookedData 
{
#region RED Properties

[REDProp("collisionInitPositionOffset")]
public Vector CollisionInitPositionOffset { get; set;}

[REDProp("dropOffset")]
public Vector DropOffset { get; set;}

[REDProp("bonePositions")]
public Array<Vector> BonePositions { get; set;}

[REDProp("renderLODs")]
public Array<float> RenderLODs { get; set;}

[REDProp("renderChunks")]
public Array<byte> RenderChunks { get; set;}

[REDProp("renderBuffer")]
public DeferredDataBuffer RenderBuffer { get; set;}

[REDProp("quantizationScale")]
public Vector QuantizationScale { get; set;}

[REDProp("quantizationOffset")]
public Vector QuantizationOffset { get; set;}

[REDProp("vertexBufferSize")]
public uint VertexBufferSize { get; set;}

[REDProp("indexBufferSize")]
public uint IndexBufferSize { get; set;}

[REDProp("indexBufferOffset")]
public uint IndexBufferOffset { get; set;}

#endregion
}
}