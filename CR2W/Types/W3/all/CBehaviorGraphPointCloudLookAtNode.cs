using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphPointCloudLookAtNode : CBehaviorGraphBaseNode
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("activateNotification")]
public CName ActivateNotification { get; set;}

[REDProp("deactivateNotification")]
public CName DeactivateNotification { get; set;}

[REDProp("generateEditorFragments")]
public bool GenerateEditorFragments { get; set;}

[REDProp("id")]
public uint Id { get; set;}

[REDProp("cachedInputNode")]
public Ptr<CBehaviorGraphNode> CachedInputNode { get; set;}

[REDProp("lookAtName")]
public CName LookAtName { get; set;}

[REDProp("boneName")]
public string BoneName { get; set;}

[REDProp("animationA")]
public CName AnimationA { get; set;}

[REDProp("animationB")]
public CName AnimationB { get; set;}

[REDProp("additiveMode")]
public bool AdditiveMode { get; set;}

[REDProp("additiveType")]
public EAdditiveType AdditiveType { get; set;}

[REDProp("writeToPoseLikeAdditiveNode")]
public bool WriteToPoseLikeAdditiveNode { get; set;}

[REDProp("convertAnimationToAdditiveFlagA")]
public bool ConvertAnimationToAdditiveFlagA { get; set;}

[REDProp("convertAnimationToAdditiveRefFrameNumA")]
public int ConvertAnimationToAdditiveRefFrameNumA { get; set;}

[REDProp("convertAnimationToAdditiveFlagB")]
public bool ConvertAnimationToAdditiveFlagB { get; set;}

[REDProp("convertAnimationToAdditiveRefFrameNumB")]
public int ConvertAnimationToAdditiveRefFrameNumB { get; set;}

[REDProp("targetWeightCurve")]
public Ptr<CCurve> TargetWeightCurve { get; set;}

[REDProp("targetWeightCurve2")]
public Ptr<CCurve> TargetWeightCurve2 { get; set;}

[REDProp("headDownCurve")]
public Ptr<CCurve> HeadDownCurve { get; set;}

[REDProp("headProgressCurve")]
public Ptr<CCurve> HeadProgressCurve { get; set;}

[REDProp("handL")]
public string HandL { get; set;}

[REDProp("handR")]
public string HandR { get; set;}

[REDProp("handDragCurve")]
public Ptr<CCurve> HandDragCurve { get; set;}

[REDProp("useBlendInsteadOfTargetTransition")]
public bool UseBlendInsteadOfTargetTransition { get; set;}

[REDProp("transition")]
public Ptr<IBehaviorGraphPointCloudLookAtTransition> Transition { get; set;}

[REDProp("useTransitionWeightPred")]
public bool UseTransitionWeightPred { get; set;}

[REDProp("transitionBonesPred")]
public Array<CName> TransitionBonesPred { get; set;}

[REDProp("transitionPredCurve")]
public Ptr<CCurve> TransitionPredCurve { get; set;}

[REDProp("secondaryMotion")]
public Ptr<CBehaviorGraphPointCloudLookAtSecMotion> SecondaryMotion { get; set;}

[REDProp("cachedTargetNodeA")]
public Ptr<CBehaviorGraphVectorValueNode> CachedTargetNodeA { get; set;}

[REDProp("cachedTargetNodeB")]
public Ptr<CBehaviorGraphVectorValueNode> CachedTargetNodeB { get; set;}

[REDProp("cachedFallbackNode")]
public Ptr<CBehaviorGraphNode> CachedFallbackNode { get; set;}

[REDProp("cachedProgressNode")]
public Ptr<CBehaviorGraphValueNode> CachedProgressNode { get; set;}

[REDProp("cachedWeightANode")]
public Ptr<CBehaviorGraphValueNode> CachedWeightANode { get; set;}

[REDProp("cachedWeightBNode")]
public Ptr<CBehaviorGraphValueNode> CachedWeightBNode { get; set;}

[REDProp("cachedUseSecBlendANode")]
public Ptr<CBehaviorGraphValueNode> CachedUseSecBlendANode { get; set;}

[REDProp("cachedUseSecBlendBNode")]
public Ptr<CBehaviorGraphValueNode> CachedUseSecBlendBNode { get; set;}

[REDProp("cachedDurationNode")]
public Ptr<CBehaviorGraphValueNode> CachedDurationNode { get; set;}

#endregion
}
}