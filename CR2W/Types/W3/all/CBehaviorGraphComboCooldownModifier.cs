using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphComboCooldownModifier : IBehaviorGraphComboModifier
{
#region RED Properties

[REDProp("cooldown")]
public float Cooldown { get; set;}

#endregion
}
}