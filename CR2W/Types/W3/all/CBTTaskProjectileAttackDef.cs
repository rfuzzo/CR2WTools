using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskProjectileAttackDef : CBTTaskAttackDef
{
#region RED Properties

[REDProp("attackRange")]
public CBehTreeValFloat AttackRange { get; set;}

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("depotPathInsteadOfAlias")]
public bool DepotPathInsteadOfAlias { get; set;}

[REDProp("depotPath")]
public string DepotPath { get; set;}

[REDProp("parametrizedResourceName")]
public CBehTreeValCName ParametrizedResourceName { get; set;}

[REDProp("homingProjectile")]
public bool HomingProjectile { get; set;}

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

[REDProp("shootOnGround")]
public bool ShootOnGround { get; set;}

[REDProp("useLookatTarget")]
public bool UseLookatTarget { get; set;}

[REDProp("startPosFrontOffset")]
public float StartPosFrontOffset { get; set;}

[REDProp("playFXOnShootProjectile")]
public CName PlayFXOnShootProjectile { get; set;}

[REDProp("shootOnEventName")]
public CName ShootOnEventName { get; set;}

[REDProp("useCustomCollisionGroups")]
public bool UseCustomCollisionGroups { get; set;}

[REDProp("collideWithRagdoll")]
public bool CollideWithRagdoll { get; set;}

[REDProp("collideWithTerrain")]
public bool CollideWithTerrain { get; set;}

[REDProp("collideWithStatic")]
public bool CollideWithStatic { get; set;}

[REDProp("collideWithWater")]
public bool CollideWithWater { get; set;}

[REDProp("useCustomTargetWithTag")]
public bool UseCustomTargetWithTag { get; set;}

[REDProp("tagToFind")]
public CName TagToFind { get; set;}

[REDProp("projEntity")]
public Handle<CEntityTemplate> ProjEntity { get; set;}

#endregion
}
}