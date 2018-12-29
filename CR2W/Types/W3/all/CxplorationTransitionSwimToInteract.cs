using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CxplorationTransitionSwimToInteract : CExplorationStateTransitionAbstract
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("transitionReadyToEnd")]
public bool TransitionReadyToEnd { get; set;}

[REDProp("timeToTransition")]
public float TimeToTransition { get; set;}

[REDProp("requireAngle")]
public bool RequireAngle { get; set;}

[REDProp("timeToStopTrying")]
public float TimeToStopTrying { get; set;}

[REDProp("locomotionSegment")]
public Handle<CR4LocomotionSwimToStop> LocomotionSegment { get; set;}

[REDProp("animEventToBeReady")]
public CName AnimEventToBeReady { get; set;}

#endregion
}
}