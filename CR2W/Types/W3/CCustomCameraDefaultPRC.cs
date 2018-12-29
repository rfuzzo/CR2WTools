using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CCustomCameraDefaultPRC : ICustomCameraPivotRotationController
{
#region RED Properties

[REDProp("controllerName")]
public CName ControllerName { get; set;}

[REDProp("minPitch")]
public float MinPitch { get; set;}

[REDProp("maxPitch")]
public float MaxPitch { get; set;}

[REDProp("sensitivityPreset")]
public EInputSensitivityPreset SensitivityPreset { get; set;}

[REDProp("dampYawFactor")]
public float DampYawFactor { get; set;}

[REDProp("dampPitchFactor")]
public float DampPitchFactor { get; set;}

[REDProp("yawMaxVelocity")]
public float YawMaxVelocity { get; set;}

[REDProp("yawAcceleration")]
public float YawAcceleration { get; set;}

[REDProp("pitchAcceleration")]
public float PitchAcceleration { get; set;}

[REDProp("pitchMaxVelocity")]
public float PitchMaxVelocity { get; set;}

#endregion
}
}