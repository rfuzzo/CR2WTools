using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SBehaviorComboDistance 
{
#region RED Properties

[REDProp("animations")]
public Array<SBehaviorComboAnimation> Animations { get; set;}

#endregion
}
}