using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCombatStyleDodge : CBTTaskDodge
{
#region RED Properties

[REDProp("parentCombatStyle")]
public EBehaviorGraph ParentCombatStyle { get; set;}

[REDProp("humanCombatDataStorage")]
public Handle<CHumanAICombatStorage> HumanCombatDataStorage { get; set;}

#endregion
}
}