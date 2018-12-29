using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFlashStep : IBehTreeTask
{
#region RED Properties

[REDProp("vanish")]
public bool Vanish { get; set;}

[REDProp("disallowInPlayerFOV")]
public bool DisallowInPlayerFOV { get; set;}

[REDProp("teleportOutsidePlayerFOV")]
public bool TeleportOutsidePlayerFOV { get; set;}

[REDProp("alreadyTeleported")]
public bool AlreadyTeleported { get; set;}

[REDProp("teleportType")]
public ETeleportType TeleportType { get; set;}

[REDProp("disappearfxName")]
public CName DisappearfxName { get; set;}

[REDProp("appearFXName")]
public CName AppearFXName { get; set;}

[REDProp("emptyName")]
public CName EmptyName { get; set;}

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("distFromLastTelePos")]
public float DistFromLastTelePos { get; set;}

[REDProp("cameraToPlayerDistance")]
public float CameraToPlayerDistance { get; set;}

[REDProp("cooldown")]
public float Cooldown { get; set;}

[REDProp("isTeleporting")]
public bool IsTeleporting { get; set;}

[REDProp("nextTeleTime")]
public float NextTeleTime { get; set;}

[REDProp("angle")]
public float Angle { get; set;}

[REDProp("heading")]
public Vector Heading { get; set;}

[REDProp("lastTelePos")]
public Vector LastTelePos { get; set;}

[REDProp("randVec")]
public Vector RandVec { get; set;}

[REDProp("whereTo")]
public Vector WhereTo { get; set;}

[REDProp("teleportEventName")]
public CName TeleportEventName { get; set;}

[REDProp("behEventName")]
public CName BehEventName { get; set;}

#endregion
}
}