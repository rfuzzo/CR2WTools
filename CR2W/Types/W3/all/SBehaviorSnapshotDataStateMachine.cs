using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBehaviorSnapshotDataStateMachine 
{
#region RED Properties

[REDProp("stateMachineId")]
public uint StateMachineId { get; set;}

[REDProp("currentStateId")]
public uint CurrentStateId { get; set;}

[REDProp("currentStateTime")]
public float CurrentStateTime { get; set;}

#endregion
}
}