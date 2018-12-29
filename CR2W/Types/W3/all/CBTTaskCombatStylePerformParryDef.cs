using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCombatStylePerformParryDef : CBTTaskPerformParryDef
{
#region RED Properties

[REDProp("parentCombatStyle")]
public Handle<CBTEnumBehaviorGraph> ParentCombatStyle { get; set;}

#endregion
}
}