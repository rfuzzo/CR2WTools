using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTModifyAttackCount : IBehTreeTask
{
#region RED Properties

[REDProp("combatDataStorage")]
public Handle<CExtendedAICombatStorage> CombatDataStorage { get; set;}

[REDProp("attackName")]
public CName AttackName { get; set;}

[REDProp("resetAttackCount")]
public bool ResetAttackCount { get; set;}

[REDProp("incrementAttackCount")]
public bool IncrementAttackCount { get; set;}

#endregion
}
}