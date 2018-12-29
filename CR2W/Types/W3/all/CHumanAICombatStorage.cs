using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CHumanAICombatStorage : CBaseAICombatStorage
{
#region RED Properties

[REDProp("parryCount")]
public Int32 ParryCount { get; set;}

[REDProp("activeStyle")]
public EBehaviorGraph ActiveStyle { get; set;}

[REDProp("preferedStyle")]
public EBehaviorGraph PreferedStyle { get; set;}

[REDProp("leaveCurrentStyle")]
public bool LeaveCurrentStyle { get; set;}

[REDProp("processingItems")]
public bool ProcessingItems { get; set;}

[REDProp("processingRequiresIdle")]
public bool ProcessingRequiresIdle { get; set;}

[REDProp("mutlipleProjectiles")]
public Array<Handle<W3AdvancedProjectile>> MutlipleProjectiles { get; set;}

[REDProp("currProjectile")]
public Handle<W3AdvancedProjectile> CurrProjectile { get; set;}

[REDProp("protectedByQuen")]
public bool ProtectedByQuen { get; set;}

[REDProp("followerAttackCooldown")]
public float FollowerAttackCooldown { get; set;}

[REDProp("followerKeepDistanceToPlayer")]
public bool FollowerKeepDistanceToPlayer { get; set;}

[REDProp("isAFollower")]
public bool IsAFollower { get; set;}

#endregion
}
}