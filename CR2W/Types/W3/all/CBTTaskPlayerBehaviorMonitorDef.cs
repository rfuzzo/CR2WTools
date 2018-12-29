using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPlayerBehaviorMonitorDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("eventNameToRaise")]
public CName EventNameToRaise { get; set;}

[REDProp("scanningCooldown")]
public float ScanningCooldown { get; set;}

#endregion
}
}