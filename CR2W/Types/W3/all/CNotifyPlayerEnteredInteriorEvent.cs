using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CNotifyPlayerEnteredInteriorEvent : CHudEvent
{
#region RED Properties

[REDProp("areaPos")]
public Vector AreaPos { get; set;}

[REDProp("areaYaw")]
public float AreaYaw { get; set;}

[REDProp("texture")]
public string Texture { get; set;}

#endregion
}
}