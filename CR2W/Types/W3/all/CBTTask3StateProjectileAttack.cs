using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTask3StateProjectileAttack : CBTTask3StateAttack
{
#region RED Properties

[REDProp("attackRange")]
public float AttackRange { get; set;}

[REDProp("projEntity")]
public Handle<CEntityTemplate> ProjEntity { get; set;}

[REDProp("projectileName")]
public CName ProjectileName { get; set;}

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

[REDProp("useLookatTarget")]
public bool UseLookatTarget { get; set;}

[REDProp("dontShootAboveAngleDistanceToTarget")]
public float DontShootAboveAngleDistanceToTarget { get; set;}

[REDProp("projectiles")]
public Array<Handle<W3AdvancedProjectile>> Projectiles { get; set;}

[REDProp("collisionGroups")]
public Array<CName> CollisionGroups { get; set;}

#endregion
}
}