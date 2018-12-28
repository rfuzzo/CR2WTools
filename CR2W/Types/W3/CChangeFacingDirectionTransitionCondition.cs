using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CChangeFacingDirectionTransitionCondition : IBehaviorStateTransitionCondition
{
#region RED Properties

[REDProp("side")]
public EChangeFacingDirectionSide Side { get; set;}

[REDProp("angleDiffMin")]
public float AngleDiffMin { get; set;}

[REDProp("angleDiffMax")]
public float AngleDiffMax { get; set;}

[REDProp("startCheckingAfterTime")]
public float StartCheckingAfterTime { get; set;}

[REDProp("requestedFacingDirectionWSVariableName")]
public CName RequestedFacingDirectionWSVariableName { get; set;}

[REDProp("dontChange")]
public bool DontChange { get; set;}

#endregion
}
}