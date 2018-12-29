using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskMiscreantCrying : IBehTreeTask
{
#region RED Properties

[REDProp("miscreantName")]
public CName MiscreantName { get; set;}

[REDProp("miscreant")]
public Handle<CActor> Miscreant { get; set;}

[REDProp("isAvailable")]
public bool IsAvailable { get; set;}

[REDProp("cryStartEventName")]
public CName CryStartEventName { get; set;}

[REDProp("cryStopEventName")]
public CName CryStopEventName { get; set;}

#endregion
}
}