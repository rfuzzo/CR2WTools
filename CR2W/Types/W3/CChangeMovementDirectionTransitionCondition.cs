using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CChangeMovementDirectionTransitionCondition : IBehaviorStateTransitionCondition
{
#region RED Properties

[REDProp("angleDiffThreshold")]
public float AngleDiffThreshold { get; set;}

[REDProp("startCheckingAfterTime")]
public float StartCheckingAfterTime { get; set;}

[REDProp("requestedMovementDirectionWSVariableName")]
public CName RequestedMovementDirectionWSVariableName { get; set;}

[REDProp("currentMovementDirectionMSInternalVariableName")]
public CName CurrentMovementDirectionMSInternalVariableName { get; set;}

#endregion
}
}