using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHorsePlayAnimWithRiderDef : IBehTreeHorseTaskDefinition
{
#region RED Properties

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("deactivationEventName")]
public CName DeactivationEventName { get; set;}

#endregion
}
}