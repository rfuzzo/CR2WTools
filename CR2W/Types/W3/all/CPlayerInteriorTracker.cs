using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPlayerInteriorTracker : CObject
{
#region RED Properties

[REDProp("sprintLocker")]
public Handle<CActionLockerByCounter> SprintLocker { get; set;}

[REDProp("runLocker")]
public Handle<CActionLockerByCounter> RunLocker { get; set;}

[REDProp("currentInterior")]
public Handle<CNode> CurrentInterior { get; set;}

#endregion
}
}