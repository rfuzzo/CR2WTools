using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphComboTransitionInterface : CObject
{
#region RED Properties

[REDProp("modifiers")]
public Array<Ptr<IBehaviorGraphComboModifier>> Modifiers { get; set;}

#endregion
}
}