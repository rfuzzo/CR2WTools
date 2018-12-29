using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSpawnFXEntityDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("attachToActor")]
public bool AttachToActor { get; set;}

[REDProp("useNodeWithTag")]
public bool UseNodeWithTag { get; set;}

[REDProp("useOnlyOneFXEntity")]
public bool UseOnlyOneFXEntity { get; set;}

[REDProp("referenceNodeTag")]
public CName ReferenceNodeTag { get; set;}

[REDProp("useTargetInsteadOfOwner")]
public bool UseTargetInsteadOfOwner { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("attachToSlotName")]
public CName AttachToSlotName { get; set;}

[REDProp("teleportToBoneName")]
public CName TeleportToBoneName { get; set;}

[REDProp("teleportToComponentName")]
public CName TeleportToComponentName { get; set;}

[REDProp("toComponentOnWeapon")]
public bool ToComponentOnWeapon { get; set;}

[REDProp("snapToGround")]
public bool SnapToGround { get; set;}

[REDProp("continuousTeleport")]
public bool ContinuousTeleport { get; set;}

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

[REDProp("baseOffsetOnCasterRotation")]
public bool BaseOffsetOnCasterRotation { get; set;}

[REDProp("rotateEntityToTarget")]
public bool RotateEntityToTarget { get; set;}

[REDProp("capRotationFromOwnerToTarget")]
public float CapRotationFromOwnerToTarget { get; set;}

[REDProp("receiveRotationFromGameplayEvent")]
public bool ReceiveRotationFromGameplayEvent { get; set;}

[REDProp("zeroPitchAndRoll")]
public bool ZeroPitchAndRoll { get; set;}

#endregion
}
}