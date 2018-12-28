using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CAnimationBufferBitwiseCompressed : IAnimationBuffer
{
#region RED Properties

[REDProp("version")]
public uint Version { get; set;}

[REDProp("bones")]
public Array<SAnimationBufferBitwiseCompressedBoneTrack> Bones { get; set;}

[REDProp("tracks")]
public Array<SAnimationBufferBitwiseCompressedData> Tracks { get; set;}

[REDProp("data")]
public Array<sbyte> Data { get; set;}

[REDProp("fallbackData")]
public Array<sbyte> FallbackData { get; set;}

[REDProp("deferredData")]
public DeferredDataBuffer DeferredData { get; set;}

[REDProp("orientationCompressionMethod")]
public SAnimationBufferOrientationCompressionMethod OrientationCompressionMethod { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("numFrames")]
public uint NumFrames { get; set;}

[REDProp("dt")]
public float Dt { get; set;}

[REDProp("streamingOption")]
public SAnimationBufferStreamingOption StreamingOption { get; set;}

[REDProp("nonStreamableBones")]
public uint NonStreamableBones { get; set;}

[REDProp("hasRefIKBones")]
public bool HasRefIKBones { get; set;}

#endregion
}
}