using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CScheduledUsableEntity : CUsableEntity
{
#region RED Properties

[REDProp("bUseSwitchingSchedule")]
public bool BUseSwitchingSchedule { get; set;}

[REDProp("switchOnHour")]
public Int32 SwitchOnHour { get; set;}

[REDProp("switchOffHour")]
public Int32 SwitchOffHour { get; set;}

#endregion
}
}