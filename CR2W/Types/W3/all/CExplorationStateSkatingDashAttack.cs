using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateSkatingDashAttack : CExplorationStateSkatingDash
{
#region RED Properties

[REDProp("attacked")]
public bool Attacked { get; set;}

[REDProp("afterAttackTime")]
public float AfterAttackTime { get; set;}

[REDProp("timeToEndCur")]
public float TimeToEndCur { get; set;}

[REDProp("behParamAttackName")]
public CName BehParamAttackName { get; set;}

[REDProp("afterAttackImpulse")]
public float AfterAttackImpulse { get; set;}

#endregion
}
}