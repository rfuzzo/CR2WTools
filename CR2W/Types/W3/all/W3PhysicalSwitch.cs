using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PhysicalSwitch : W3Switch
{
#region RED Properties

[REDProp("switchOnAnimationType")]
public PhysicalSwitchAnimationType SwitchOnAnimationType { get; set;}

[REDProp("switchOffAnimationType")]
public PhysicalSwitchAnimationType SwitchOffAnimationType { get; set;}

[REDProp("showActorAnimation")]
public bool ShowActorAnimation { get; set;}

#endregion
}
}