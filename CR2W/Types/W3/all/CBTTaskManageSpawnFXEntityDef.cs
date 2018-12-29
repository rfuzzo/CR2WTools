using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskManageSpawnFXEntityDef : CBTTaskSpawnFXEntityDef
{
#region RED Properties

[REDProp("activateOnAnimEvent")]
public CName ActivateOnAnimEvent { get; set;}

[REDProp("activateOnGameplayEvent")]
public CName ActivateOnGameplayEvent { get; set;}

[REDProp("activeDuration")]
public float ActiveDuration { get; set;}

[REDProp("activationCooldown")]
public float ActivationCooldown { get; set;}

[REDProp("teleportFXEntityOnAnimEvent")]
public CName TeleportFXEntityOnAnimEvent { get; set;}

[REDProp("teleportFXEntityOnGameplayEvent")]
public CName TeleportFXEntityOnGameplayEvent { get; set;}

[REDProp("teleportInRandomDirection")]
public bool TeleportInRandomDirection { get; set;}

[REDProp("randomPositionPattern")]
public ESpawnPositionPattern RandomPositionPattern { get; set;}

[REDProp("randomTeleportMinRange")]
public float RandomTeleportMinRange { get; set;}

[REDProp("randomTeleportMaxRange")]
public float RandomTeleportMaxRange { get; set;}

[REDProp("randomTeleportInterval")]
public float RandomTeleportInterval { get; set;}

[REDProp("teleportZAxisOffsetMin")]
public float TeleportZAxisOffsetMin { get; set;}

[REDProp("teleportZAxisOffsetMax")]
public float TeleportZAxisOffsetMax { get; set;}

[REDProp("fxNameOnRandomTeleportOnNPC")]
public CName FxNameOnRandomTeleportOnNPC { get; set;}

[REDProp("fxNameOnRandomTeleportOnFXEntity")]
public CName FxNameOnRandomTeleportOnFXEntity { get; set;}

[REDProp("fxNameOnTeleportToTargetOnNPC")]
public CName FxNameOnTeleportToTargetOnNPC { get; set;}

[REDProp("fxNameOnTeleportToTargetOnFXEntity")]
public CName FxNameOnTeleportToTargetOnFXEntity { get; set;}

[REDProp("connectFXWithTarget")]
public bool ConnectFXWithTarget { get; set;}

[REDProp("destroyEntityOnCombatEnd")]
public bool DestroyEntityOnCombatEnd { get; set;}

#endregion
}
}