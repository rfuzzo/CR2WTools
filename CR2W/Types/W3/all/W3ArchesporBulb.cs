using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ArchesporBulb : CNewNPC
{
#region RED Properties

[REDProp("parentEntity")]
public Handle<CNewNPC> ParentEntity { get; set;}

[REDProp("entitiesInRange")]
public Array<Handle<CGameplayEntity>> EntitiesInRange { get; set;}

[REDProp("isDestroyed")]
public bool IsDestroyed { get; set;}

[REDProp("hitsTaken")]
public Int32 HitsTaken { get; set;}

[REDProp("lastHitTimestamp")]
public float LastHitTimestamp { get; set;}

[REDProp("hitCooldown")]
public float HitCooldown { get; set;}

[REDProp("damageRadius")]
public float DamageRadius { get; set;}

[REDProp("damageVal")]
public float DamageVal { get; set;}

[REDProp("hitsToDeath")]
public Int32 HitsToDeath { get; set;}

#endregion
}
}