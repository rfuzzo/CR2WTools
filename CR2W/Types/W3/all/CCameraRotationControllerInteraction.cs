using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCameraRotationControllerInteraction : ICustomCameraScriptedPivotRotationController
{
#region RED Properties

[REDProp("pitchMaxSpeed")]
public float PitchMaxSpeed { get; set;}

[REDProp("blendTodesiredPitch")]
public bool BlendTodesiredPitch { get; set;}

[REDProp("desiredPitch")]
public float DesiredPitch { get; set;}

[REDProp("desiredPitchSpeed")]
public float DesiredPitchSpeed { get; set;}

[REDProp("yawMaxSpeed")]
public float YawMaxSpeed { get; set;}

#endregion
}
}