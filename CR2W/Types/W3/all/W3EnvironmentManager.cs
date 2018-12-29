using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3EnvironmentManager : CObject
{
#region RED Properties

[REDProp("m_envId")]
public Int32 M_envId { get; set;}

[REDProp("lunation")]
public Int32 Lunation { get; set;}

[REDProp("dayStart")]
public Int32 DayStart { get; set;}

[REDProp("nightStart")]
public Int32 NightStart { get; set;}

[REDProp("redMoonPeriod")]
public Int32 RedMoonPeriod { get; set;}

[REDProp("hourToSwitchEnv")]
public Int32 HourToSwitchEnv { get; set;}

#endregion
}
}