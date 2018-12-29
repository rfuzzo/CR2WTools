using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeCombatTargetSelectionTaskDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("maxTargetDistance")]
public float MaxTargetDistance { get; set;}

[REDProp("playerPriority")]
public Int32 PlayerPriority { get; set;}

[REDProp("targetOnlyPlayer")]
public bool TargetOnlyPlayer { get; set;}

#endregion
}
}