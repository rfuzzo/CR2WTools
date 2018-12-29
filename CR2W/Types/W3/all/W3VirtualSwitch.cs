using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3VirtualSwitch : W3Switch
{
#region RED Properties

[REDProp("requiredSwitches")]
public Array<SRequiredSwitch> RequiredSwitches { get; set;}

#endregion
}
}