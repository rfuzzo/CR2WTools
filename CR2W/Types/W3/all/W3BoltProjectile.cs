using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3BoltProjectile : W3ArrowProjectile
{
#region RED Properties

[REDProp("dismemberOnKill")]
public bool DismemberOnKill { get; set;}

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

[REDProp("projectiles")]
public Array<Handle<W3BoltProjectile>> Projectiles { get; set;}

[REDProp("targetPos")]
public Vector TargetPos { get; set;}

[REDProp("crossbowId")]
public SItemUniqueId CrossbowId { get; set;}

[REDProp("collisionGroups")]
public Array<CName> CollisionGroups { get; set;}

[REDProp("hitVictims")]
public Array<Handle<CActor>> HitVictims { get; set;}

[REDProp("wasShotUnderWater")]
public bool WasShotUnderWater { get; set;}

[REDProp("visibility")]
public bool Visibility { get; set;}

#endregion
}
}