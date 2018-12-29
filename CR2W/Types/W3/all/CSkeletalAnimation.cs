using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSkeletalAnimation : ISerializable
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("streamingType")]
public ESkeletalAnimationStreamingType StreamingType { get; set;}

[REDProp("hasBundingBox")]
public bool HasBundingBox { get; set;}

[REDProp("boundingBox")]
public Box BoundingBox { get; set;}

[REDProp("id")]
public uint Id { get; set;}

[REDProp("motionExtraction")]
public Ptr<IMotionExtraction> MotionExtraction { get; set;}

[REDProp("compressedPose")]
public int CompressedPose { get; set;}

[REDProp("animBuffer")]
public Ptr<IAnimationBuffer> AnimBuffer { get; set;}

[REDProp("framesPerSecond")]
public float FramesPerSecond { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

#endregion
}
}