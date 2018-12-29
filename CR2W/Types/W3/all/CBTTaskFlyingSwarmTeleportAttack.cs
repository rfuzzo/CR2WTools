using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFlyingSwarmTeleportAttack : CBTTaskFlyingSwarmTeleport
{
#region RED Properties

[REDProp("boidRequestCompletedEvents")]
public Int32 BoidRequestCompletedEvents { get; set;}

[REDProp("despawnAfterAttackTime")]
public float DespawnAfterAttackTime { get; set;}

[REDProp("attackCompleted")]
public bool AttackCompleted { get; set;}

[REDProp("res2")]
public bool Res2 { get; set;}

[REDProp("attackTimeStamp")]
public float AttackTimeStamp { get; set;}

#endregion
}
}