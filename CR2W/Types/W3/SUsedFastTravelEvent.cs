using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SUsedFastTravelEvent 
{
#region RED Properties

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("onStart")]
public bool OnStart { get; set;}

#endregion
}
}