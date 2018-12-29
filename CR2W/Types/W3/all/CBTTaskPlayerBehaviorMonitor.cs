using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPlayerBehaviorMonitor : IBehTreeTask
{
#region RED Properties

[REDProp("eventNameToRaise")]
public CName EventNameToRaise { get; set;}

[REDProp("scanningCooldown")]
public float ScanningCooldown { get; set;}

[REDProp("extraWindow")]
public float ExtraWindow { get; set;}

[REDProp("sendEvent")]
public bool SendEvent { get; set;}

#endregion
}
}