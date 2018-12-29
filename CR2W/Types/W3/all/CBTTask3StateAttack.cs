using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTask3StateAttack : CBTTaskAttack
{
#region RED Properties

[REDProp("loopTime")]
public float LoopTime { get; set;}

[REDProp("endTaskWhenOwnerGoesPastTarget")]
public bool EndTaskWhenOwnerGoesPastTarget { get; set;}

[REDProp("endLoopOnDistance")]
public bool EndLoopOnDistance { get; set;}

[REDProp("distanceToTarget")]
public float DistanceToTarget { get; set;}

[REDProp("stopRotatingWhenTargetIsBehind")]
public bool StopRotatingWhenTargetIsBehind { get; set;}

[REDProp("playFXOnLoopStart")]
public CName PlayFXOnLoopStart { get; set;}

[REDProp("playLoopFXInterval")]
public float PlayLoopFXInterval { get; set;}

[REDProp("raiseEventName")]
public CName RaiseEventName { get; set;}

[REDProp("startDeactivationEventName")]
public CName StartDeactivationEventName { get; set;}

[REDProp("endDeactivationEventName")]
public CName EndDeactivationEventName { get; set;}

[REDProp("startPos")]
public Vector StartPos { get; set;}

[REDProp("lastFXTime")]
public float LastFXTime { get; set;}

#endregion
}
}