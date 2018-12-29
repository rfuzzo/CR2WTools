using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskBruxaSpawnDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("useNodeWithTag")]
public bool UseNodeWithTag { get; set;}

[REDProp("referenceNodeTag")]
public CName ReferenceNodeTag { get; set;}

[REDProp("useTargetInsteadOfOwner")]
public bool UseTargetInsteadOfOwner { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("baseOffsetOnCasterRotation")]
public bool BaseOffsetOnCasterRotation { get; set;}

[REDProp("rotateEntityToTarget")]
public bool RotateEntityToTarget { get; set;}

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("spawnEntityOnDeathName")]
public CBehTreeValCName SpawnEntityOnDeathName { get; set;}

[REDProp("spawnAfter")]
public float SpawnAfter { get; set;}

[REDProp("validateSpawnPosition")]
public bool ValidateSpawnPosition { get; set;}

[REDProp("spawnOnAnimEvent")]
public CName SpawnOnAnimEvent { get; set;}

[REDProp("spawnOnGameplayEvent")]
public CName SpawnOnGameplayEvent { get; set;}

[REDProp("fxNameOnSpawnEntity")]
public CName FxNameOnSpawnEntity { get; set;}

[REDProp("fxNameOnSpawnOwner")]
public CName FxNameOnSpawnOwner { get; set;}

[REDProp("fxNameAfterSpawnOwner")]
public CName FxNameAfterSpawnOwner { get; set;}

[REDProp("fxNameAfterSpawnDelay")]
public float FxNameAfterSpawnDelay { get; set;}

[REDProp("connectFxAfterSpawnWithEntity")]
public bool ConnectFxAfterSpawnWithEntity { get; set;}

[REDProp("bruxaEntityTag")]
public CName BruxaEntityTag { get; set;}

[REDProp("inheritTagsFromOwner")]
public bool InheritTagsFromOwner { get; set;}

[REDProp("setBehVarOnSpawn")]
public CName SetBehVarOnSpawn { get; set;}

[REDProp("setBehVarValue")]
public float SetBehVarValue { get; set;}

[REDProp("setAppearanceOnSpawn")]
public CName SetAppearanceOnSpawn { get; set;}

[REDProp("setEntityAsActionTarget")]
public bool SetEntityAsActionTarget { get; set;}

[REDProp("disableGameplayVisibility")]
public bool DisableGameplayVisibility { get; set;}

[REDProp("disableVisibility")]
public bool DisableVisibility { get; set;}

[REDProp("disableCollisionOnSpawn")]
public bool DisableCollisionOnSpawn { get; set;}

[REDProp("stopAllEffectsAfter")]
public float StopAllEffectsAfter { get; set;}

[REDProp("activeDuration")]
public float ActiveDuration { get; set;}

[REDProp("teleportInterval")]
public float TeleportInterval { get; set;}

[REDProp("minTeleportDistFromTarget")]
public float MinTeleportDistFromTarget { get; set;}

[REDProp("maxTeleportDistFromTarget")]
public float MaxTeleportDistFromTarget { get; set;}

#endregion
}
}