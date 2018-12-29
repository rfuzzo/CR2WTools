using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCameraRotationControllerJump : ICustomCameraScriptedPivotRotationController
{
#region RED Properties

[REDProp("pitchTotal")]
public float PitchTotal { get; set;}

[REDProp("pitchBase")]
public float PitchBase { get; set;}

[REDProp("yawAcceleration")]
public float YawAcceleration { get; set;}

[REDProp("yawMaxSpeed")]
public float YawMaxSpeed { get; set;}

[REDProp("timeCur")]
public float TimeCur { get; set;}

[REDProp("timeStart")]
public float TimeStart { get; set;}

[REDProp("timeComplete")]
public float TimeComplete { get; set;}

[REDProp("blendSpeed")]
public float BlendSpeed { get; set;}

[REDProp("pitchCurve")]
public Handle<CCurve> PitchCurve { get; set;}

#endregion
}
}