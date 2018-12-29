using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class ICustomCameraPivotRotationController : ICustomCameraBaseController
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

#endregion
}
}