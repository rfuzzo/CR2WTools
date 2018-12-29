using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3VirtualSwitch_Sequence : W3VirtualSwitch
{
#region RED Properties

[REDProp("nextSwitchIndex")]
public Int32 NextSwitchIndex { get; set;}

#endregion
}
}