using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondThreatLevelDifferenceDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("operator")]
public EOperator Operator { get; set;}

[REDProp("value")]
public Int32 Value { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("useNamedTarget")]
public CBehTreeValCName UseNamedTarget { get; set;}

[REDProp("saveTargetOnGameplayEvent")]
public CBehTreeValCName SaveTargetOnGameplayEvent { get; set;}

#endregion
}
}