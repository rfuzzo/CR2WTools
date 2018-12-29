using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3NotificationData : CObject
{
#region RED Properties

[REDProp("messageText")]
public string MessageText { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("queue")]
public bool Queue { get; set;}

#endregion
}
}