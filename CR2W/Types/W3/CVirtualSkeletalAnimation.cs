using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CVirtualSkeletalAnimation : CSkeletalAnimation
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

[REDProp("virtualAnimations")]
public Array<VirtualAnimation> VirtualAnimations { get; set;}

[REDProp("virtualAnimationsOverride")]
public Array<VirtualAnimation> VirtualAnimationsOverride { get; set;}

[REDProp("virtualAnimationsAdditive")]
public Array<VirtualAnimation> VirtualAnimationsAdditive { get; set;}

[REDProp("virtualMotions")]
public Array<VirtualAnimationMotion> VirtualMotions { get; set;}

[REDProp("virtualFKs")]
public Array<VirtualAnimationPoseFK> VirtualFKs { get; set;}

[REDProp("virtualIKs")]
public Array<VirtualAnimationPoseIK> VirtualIKs { get; set;}

#endregion
}
}