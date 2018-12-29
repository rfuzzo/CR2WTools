using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTask3StateProjectileAttackDef : CBTTask3StateAttackDef
{
#region RED Properties

[REDProp("attackRange")]
public float AttackRange { get; set;}

[REDProp("projectileName")]
public CName ProjectileName { get; set;}

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

[REDProp("useLookatTarget")]
public bool UseLookatTarget { get; set;}

[REDProp("dontShootAboveAngleDistanceToTarget")]
public float DontShootAboveAngleDistanceToTarget { get; set;}

#endregion
}
}