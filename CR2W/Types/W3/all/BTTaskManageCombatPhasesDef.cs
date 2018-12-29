using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageCombatPhasesDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("rangedCombatPhaseParameters")]
public SCombatPhaseParameters RangedCombatPhaseParameters { get; set;}

[REDProp("closeCombatPhaseParameters")]
public SCombatPhaseParameters CloseCombatPhaseParameters { get; set;}

[REDProp("nonCombatPhaseParameters")]
public SCombatPhaseParameters NonCombatPhaseParameters { get; set;}

[REDProp("setBehVariableName")]
public CName SetBehVariableName { get; set;}

#endregion
}
}