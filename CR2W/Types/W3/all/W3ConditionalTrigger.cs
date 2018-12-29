using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ConditionalTrigger : CEntity
{
#region RED Properties

[REDProp("conditionClass")]
public Handle<W3Condition> ConditionClass { get; set;}

[REDProp("effectorClasses")]
public Array<Handle<IPerformableAction>> EffectorClasses { get; set;}

[REDProp("affectsPlayer")]
public bool AffectsPlayer { get; set;}

#endregion
}
}