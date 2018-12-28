using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMovingAgentComponent : CAnimatedComponent
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

[REDProp("ragdollRadius")]
public float RagdollRadius { get; set;}

[REDProp("steeringBehavior")]
public Handle<CMoveSteeringBehavior> SteeringBehavior { get; set;}

[REDProp("steeringControlledMovement")]
public bool SteeringControlledMovement { get; set;}

[REDProp("snapToNavigableSpace")]
public bool SnapToNavigableSpace { get; set;}

[REDProp("physicalRepresentation")]
public bool PhysicalRepresentation { get; set;}

[REDProp("movementAdjustor")]
public Ptr<CMovementAdjustor> MovementAdjustor { get; set;}

[REDProp("triggerAutoActivator")]
public bool TriggerAutoActivator { get; set;}

[REDProp("triggerActivatorRadius")]
public float TriggerActivatorRadius { get; set;}

[REDProp("triggerActivatorHeight")]
public float TriggerActivatorHeight { get; set;}

[REDProp("triggerChannels")]
public ETriggerChannel TriggerChannels { get; set;}

[REDProp("triggerEnableCCD")]
public bool TriggerEnableCCD { get; set;}

[REDProp("triggerMaxSingleFrameDistance")]
public float TriggerMaxSingleFrameDistance { get; set;}

#endregion
}
}