using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PlayerAiming : CObject
{
#region RED Properties

[REDProp("owner")]
public Handle<CR4Player> Owner { get; set;}

[REDProp("throwable")]
public Handle<CThrowable> Throwable { get; set;}

[REDProp("aimType")]
public EAimType AimType { get; set;}

[REDProp("throwPos")]
public Vector ThrowPos { get; set;}

[REDProp("sweptFriendly")]
public Handle<CEntity> SweptFriendly { get; set;}

[REDProp("sweptActors")]
public Array<Handle<CActor>> SweptActors { get; set;}

[REDProp("tracePosFrom")]
public Vector TracePosFrom { get; set;}

[REDProp("thrownBombImpactRadius")]
public float ThrownBombImpactRadius { get; set;}

[REDProp("aimedTarget")]
public Handle<CActor> AimedTarget { get; set;}

[REDProp("collisionGroupsNames")]
public Array<CName> CollisionGroupsNames { get; set;}

#endregion
}
}