using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3NewDoor : W3LockableEntity
{
#region RED Properties

[REDProp("openAngle")]
public float OpenAngle { get; set;}

[REDProp("initiallyOpened")]
public bool InitiallyOpened { get; set;}

[REDProp("factOnPlayerDoorOpen")]
public CName FactOnPlayerDoorOpen { get; set;}

[REDProp("openedByHorse")]
public bool OpenedByHorse { get; set;}

[REDProp("doorsCmp")]
public Handle<CDoorComponent> DoorsCmp { get; set;}

[REDProp("lockedCmp")]
public Handle<CInteractionComponent> LockedCmp { get; set;}

[REDProp("unlockCmp")]
public Handle<CInteractionComponent> UnlockCmp { get; set;}

[REDProp("lockedDA")]
public Handle<CDeniedAreaComponent> LockedDA { get; set;}

[REDProp("rigidMeshCmp")]
public Handle<CRigidMeshComponent> RigidMeshCmp { get; set;}

[REDProp("updateDuration")]
public float UpdateDuration { get; set;}

[REDProp("updateTimeLeft")]
public float UpdateTimeLeft { get; set;}

[REDProp("playerInsideTrapdoorTrigger")]
public bool PlayerInsideTrapdoorTrigger { get; set;}

[REDProp("enableDeniedAreaInCombat")]
public bool EnableDeniedAreaInCombat { get; set;}

#endregion
}
}