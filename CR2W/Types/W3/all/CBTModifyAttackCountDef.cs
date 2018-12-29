using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTModifyAttackCountDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("attackName")]
public CName AttackName { get; set;}

[REDProp("incrementAttackCount")]
public bool IncrementAttackCount { get; set;}

[REDProp("resetAttackCount")]
public bool ResetAttackCount { get; set;}

#endregion
}
}