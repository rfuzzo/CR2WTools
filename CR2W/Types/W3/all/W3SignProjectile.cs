using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SignProjectile : CProjectileTrajectory
{
#region RED Properties

[REDProp("projData")]
public SSignProjectile ProjData { get; set;}

[REDProp("owner")]
public Handle<W3SignOwner> Owner { get; set;}

[REDProp("action")]
public Handle<W3DamageAction> Action { get; set;}

[REDProp("signSkill")]
public ESkill SignSkill { get; set;}

[REDProp("wantedTarget")]
public Handle<CGameplayEntity> WantedTarget { get; set;}

[REDProp("signEntity")]
public Handle<W3SignEntity> SignEntity { get; set;}

[REDProp("hitEntities")]
public Array<Handle<CGameplayEntity>> HitEntities { get; set;}

[REDProp("attackRange")]
public Handle<CAIAttackRange> AttackRange { get; set;}

[REDProp("isReusable")]
public bool IsReusable { get; set;}

#endregion
}
}