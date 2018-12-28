using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorSyncMethodEventStart : IBehaviorSyncMethodEvent
{
#region RED Properties

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("startAtRandomEvent")]
public bool StartAtRandomEvent { get; set;}

#endregion
}
}