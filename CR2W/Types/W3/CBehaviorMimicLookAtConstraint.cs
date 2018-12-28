using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorMimicLookAtConstraint : IBehaviorMimicConstraint
{
#region RED Properties

[REDProp("cachedTargetNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedTargetNode { get; set;}

[REDProp("cachedControlVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

[REDProp("cachedControlEyesDataNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedControlEyesDataNode { get; set;}

[REDProp("eyeHorLLeftTrack")]
public string EyeHorLLeftTrack { get; set;}

[REDProp("eyeHorRLeftTrack")]
public string EyeHorRLeftTrack { get; set;}

[REDProp("eyeHorLRightTrack")]
public string EyeHorLRightTrack { get; set;}

[REDProp("eyeHorRRightTrack")]
public string EyeHorRRightTrack { get; set;}

[REDProp("eyeVerULeftTrack")]
public string EyeVerULeftTrack { get; set;}

[REDProp("eyeVerDLeftTrack")]
public string EyeVerDLeftTrack { get; set;}

[REDProp("eyeVerURightTrack")]
public string EyeVerURightTrack { get; set;}

[REDProp("eyeVerDRightTrack")]
public string EyeVerDRightTrack { get; set;}

[REDProp("eyeLeftPlacerBone")]
public string EyeLeftPlacerBone { get; set;}

[REDProp("eyeRightPlacerBone")]
public string EyeRightPlacerBone { get; set;}

[REDProp("eyeHorMax")]
public float EyeHorMax { get; set;}

[REDProp("eyeVerMin")]
public float EyeVerMin { get; set;}

[REDProp("eyeVerMax")]
public float EyeVerMax { get; set;}

[REDProp("eyeVerOffset")]
public float EyeVerOffset { get; set;}

[REDProp("eyesTrackClamp")]
public float EyesTrackClamp { get; set;}

[REDProp("dampTime")]
public float DampTime { get; set;}

[REDProp("blinkAnimName")]
public CName BlinkAnimName { get; set;}

[REDProp("blinkTimeOffset")]
public float BlinkTimeOffset { get; set;}

[REDProp("blinkSpeed")]
public float BlinkSpeed { get; set;}

#endregion
}
}