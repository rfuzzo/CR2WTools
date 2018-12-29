using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class COnManageHudTimeOutEvent : CHudEvent
{
#region RED Properties

[REDProp("action")]
public EHudTimeOutAction Action { get; set;}

[REDProp("timeOut")]
public float TimeOut { get; set;}

#endregion
}
}