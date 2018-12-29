using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CNotifyBossIndicatorShownEvent : CHudEvent
{
#region RED Properties

[REDProp("enable")]
public bool Enable { get; set;}

[REDProp("bossTag")]
public CName BossTag { get; set;}

#endregion
}
}