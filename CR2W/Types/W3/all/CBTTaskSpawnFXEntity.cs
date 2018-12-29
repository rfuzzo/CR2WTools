using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSpawnFXEntity : IBehTreeTask
{
#region RED Properties

[REDProp("attachToActor")]
public bool AttachToActor { get; set;}

[REDProp("useNodeWithTag")]
public bool UseNodeWithTag { get; set;}

[REDProp("referenceNodeTag")]
public CName ReferenceNodeTag { get; set;}

[REDProp("useOnlyOneFXEntity")]
public bool UseOnlyOneFXEntity { get; set;}

[REDProp("useTargetInsteadOfOwner")]
public bool UseTargetInsteadOfOwner { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("baseOffsetOnCasterRotation")]
public bool BaseOffsetOnCasterRotation { get; set;}

[REDProp("receiveRotationFromGameplayEvent")]
public bool ReceiveRotationFromGameplayEvent { get; set;}

[REDProp("rotateEntityToTarget")]
public bool RotateEntityToTarget { get; set;}

[REDProp("capRotationFromOwnerToTarget")]
public float CapRotationFromOwnerToTarget { get; set;}

[REDProp("zeroPitchAndRoll")]
public bool ZeroPitchAndRoll { get; set;}

[REDProp("attachToSlotName")]
public CName AttachToSlotName { get; set;}

[REDProp("teleportToComponentName")]
public CName TeleportToComponentName { get; set;}

[REDProp("toComponentOnWeapon")]
public bool ToComponentOnWeapon { get; set;}

[REDProp("teleportToBoneName")]
public CName TeleportToBoneName { get; set;}

[REDProp("continuousTeleport")]
public bool ContinuousTeleport { get; set;}

[REDProp("snapToGround")]
public bool SnapToGround { get; set;}

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("spawnAfter")]
public float SpawnAfter { get; set;}

[REDProp("spawnOnAnimEvent")]
public CName SpawnOnAnimEvent { get; set;}

[REDProp("spawnOnGameplayEvent")]
public CName SpawnOnGameplayEvent { get; set;}

[REDProp("delayEntitySpawn")]
public float DelayEntitySpawn { get; set;}

[REDProp("fxNameOnSpawn")]
public CName FxNameOnSpawn { get; set;}

[REDProp("continuousPlayEffectInInterval")]
public float ContinuousPlayEffectInInterval { get; set;}

[REDProp("fxEntityTag")]
public CName FxEntityTag { get; set;}

[REDProp("destroyEntityAfter")]
public float DestroyEntityAfter { get; set;}

[REDProp("destroyEntityOnAnimEvent")]
public CName DestroyEntityOnAnimEvent { get; set;}

[REDProp("destroyEntityOnDeact")]
public bool DestroyEntityOnDeact { get; set;}

[REDProp("stopAllEffectsOnDeact")]
public bool StopAllEffectsOnDeact { get; set;}

[REDProp("stopAllEffectsAfter")]
public float StopAllEffectsAfter { get; set;}

[REDProp("zToleranceFromActorRoot")]
public float ZToleranceFromActorRoot { get; set;}

[REDProp("offsetVector")]
public Vector OffsetVector { get; set;}

[REDProp("additionalRotation")]
public EulerAngles AdditionalRotation { get; set;}

[REDProp("attachedTo")]
public Handle<CEntity> AttachedTo { get; set;}

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("timeStamp")]
public float TimeStamp { get; set;}

[REDProp("fxRotation")]
public float FxRotation { get; set;}

[REDProp("spawned")]
public bool Spawned { get; set;}

[REDProp("eventReceived")]
public bool EventReceived { get; set;}

[REDProp("receivedRotationEvent")]
public bool ReceivedRotationEvent { get; set;}

[REDProp("stopped")]
public bool Stopped { get; set;}

[REDProp("boneIdx")]
public Int32 BoneIdx { get; set;}

#endregion
}
}