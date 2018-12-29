using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSirenTakeOff : IBehTreeTask
{
#region RED Properties

[REDProp("eventReceived")]
public bool EventReceived { get; set;}

#endregion
}
}