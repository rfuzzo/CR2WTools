using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PressureSwitch : W3PhysicalSwitch
{
#region RED Properties

[REDProp("autoSwitchOnLeave")]
public bool AutoSwitchOnLeave { get; set;}

[REDProp("entities")]
public Array<Handle<CEntity>> Entities { get; set;}

[REDProp("delayedTurnOffEntity")]
public Handle<CEntity> DelayedTurnOffEntity { get; set;}

[REDProp("delayedTurnOnEntity")]
public Handle<CEntity> DelayedTurnOnEntity { get; set;}

#endregion
}
}