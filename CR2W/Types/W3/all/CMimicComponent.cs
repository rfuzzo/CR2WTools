using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMimicComponent : CAnimatedComponent
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("transformParent")]
public Ptr<CHardAttachment> TransformParent { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("isStreamed")]
public bool IsStreamed { get; set;}

[REDProp("ragdoll")]
public Handle<CRagdoll> Ragdoll { get; set;}

[REDProp("ragdollCollisionType")]
public CPhysicalCollision RagdollCollisionType { get; set;}

[REDProp("skeleton")]
public Handle<CSkeleton> Skeleton { get; set;}

[REDProp("physicsRepresentation")]
public Ptr<CAnimatedComponentPhysicsRepresentation> PhysicsRepresentation { get; set;}

[REDProp("animationSets")]
public Array<Handle<CSkeletalAnimationSet>> AnimationSets { get; set;}

[REDProp("behaviorInstanceSlots")]
public Array<SBehaviorGraphInstanceSlot> BehaviorInstanceSlots { get; set;}

[REDProp("useExtractedMotion")]
public bool UseExtractedMotion { get; set;}

[REDProp("stickRagdollToCapsule")]
public bool StickRagdollToCapsule { get; set;}

[REDProp("includedInAllAppearances")]
public bool IncludedInAllAppearances { get; set;}

[REDProp("savable")]
public bool Savable { get; set;}

[REDProp("defaultBehaviorAnimationSlotNode")]
public CName DefaultBehaviorAnimationSlotNode { get; set;}

[REDProp("isFrozenOnStart")]
public bool IsFrozenOnStart { get; set;}

[REDProp("defaultSpeedConfigKey")]
public CName DefaultSpeedConfigKey { get; set;}

[REDProp("overrideBudgetedTickDistance")]
public float OverrideBudgetedTickDistance { get; set;}

[REDProp("overrideDisableTickDistance")]
public float OverrideDisableTickDistance { get; set;}

[REDProp("runtimeBehaviorInstanceSlots")]
public Array<SBehaviorGraphInstanceSlot> RuntimeBehaviorInstanceSlots { get; set;}

[REDProp("mimicFace")]
public Handle<CMimicFace> MimicFace { get; set;}

[REDProp("categoryMimics")]
public Handle<CMimicFace> CategoryMimics { get; set;}

[REDProp("attachmentSlotName")]
public CName AttachmentSlotName { get; set;}

#endregion
}
}