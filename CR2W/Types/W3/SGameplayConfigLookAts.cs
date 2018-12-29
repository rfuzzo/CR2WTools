using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SGameplayConfigLookAts 
{
#region RED Properties

[REDProp("reactionDebugType")]
public int ReactionDebugType { get; set;}

[REDProp("lookAtDurationGlance")]
public float LookAtDurationGlance { get; set;}

[REDProp("lookAtDurationLook")]
public float LookAtDurationLook { get; set;}

[REDProp("lookAtDurationGaze")]
public float LookAtDurationGaze { get; set;}

[REDProp("lookAtDurationStare")]
public float LookAtDurationStare { get; set;}

[REDProp("lookAtDurationRandGlance")]
public float LookAtDurationRandGlance { get; set;}

[REDProp("lookAtDurationRandLook")]
public float LookAtDurationRandLook { get; set;}

[REDProp("lookAtDurationRandGaze")]
public float LookAtDurationRandGaze { get; set;}

[REDProp("lookAtDurationRandStare")]
public float LookAtDurationRandStare { get; set;}

[REDProp("lookAtRangeGlance")]
public float LookAtRangeGlance { get; set;}

[REDProp("lookAtRangeLook")]
public float LookAtRangeLook { get; set;}

[REDProp("lookAtRangeGaze")]
public float LookAtRangeGaze { get; set;}

[REDProp("lookAtRangeStare")]
public float LookAtRangeStare { get; set;}

[REDProp("lookAtSpeedGlance")]
public float LookAtSpeedGlance { get; set;}

[REDProp("lookAtSpeedLook")]
public float LookAtSpeedLook { get; set;}

[REDProp("lookAtSpeedGaze")]
public float LookAtSpeedGaze { get; set;}

[REDProp("lookAtSpeedStare")]
public float LookAtSpeedStare { get; set;}

[REDProp("lookAtSpeedRandGlance")]
public float LookAtSpeedRandGlance { get; set;}

[REDProp("lookAtSpeedRandLook")]
public float LookAtSpeedRandLook { get; set;}

[REDProp("lookAtSpeedRandGaze")]
public float LookAtSpeedRandGaze { get; set;}

[REDProp("lookAtSpeedRandStare")]
public float LookAtSpeedRandStare { get; set;}

[REDProp("lookAtAutoLimitGlance")]
public bool LookAtAutoLimitGlance { get; set;}

[REDProp("lookAtAutoLimitLook")]
public bool LookAtAutoLimitLook { get; set;}

[REDProp("lookAtAutoLimitGaze")]
public bool LookAtAutoLimitGaze { get; set;}

[REDProp("lookAtAutoLimitStare")]
public bool LookAtAutoLimitStare { get; set;}

[REDProp("lookAtDelay")]
public float LookAtDelay { get; set;}

[REDProp("lookAtDelayDialog")]
public float LookAtDelayDialog { get; set;}

#endregion
}
}