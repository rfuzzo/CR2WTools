using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondThreatLevelDifference : IBehTreeTask
{
#region RED Properties

[REDProp("operator")]
public EOperator Operator { get; set;}

[REDProp("value")]
public Int32 Value { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("useNamedTarget")]
public CName UseNamedTarget { get; set;}

[REDProp("saveTargetOnGameplayEvent")]
public CName SaveTargetOnGameplayEvent { get; set;}

[REDProp("m_Target")]
public Handle<CNode> M_Target { get; set;}

#endregion
}
}