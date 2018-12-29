using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ActorLatentActionFollowPlayer : IPresetActorLatentAction
{
#region RED Properties

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("keepDistance")]
public bool KeepDistance { get; set;}

[REDProp("followDistance")]
public float FollowDistance { get; set;}

[REDProp("moveSpeed")]
public float MoveSpeed { get; set;}

[REDProp("teleportToCatchup")]
public bool TeleportToCatchup { get; set;}

[REDProp("cachupDistance")]
public float CachupDistance { get; set;}

#endregion
}
}