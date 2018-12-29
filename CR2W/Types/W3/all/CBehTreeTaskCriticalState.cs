using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskCriticalState : IBehTreeTask
{
#region RED Properties

[REDProp("activate")]
public bool Activate { get; set;}

[REDProp("activateTimeStamp")]
public float ActivateTimeStamp { get; set;}

[REDProp("forceActivate")]
public bool ForceActivate { get; set;}

[REDProp("currentCS")]
public ECriticalStateType CurrentCS { get; set;}

#endregion
}
}