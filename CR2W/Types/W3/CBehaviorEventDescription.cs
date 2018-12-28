using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorEventDescription : CObject
{
#region RED Properties

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("isModifiableByEffect")]
public bool IsModifiableByEffect { get; set;}

#endregion
}
}