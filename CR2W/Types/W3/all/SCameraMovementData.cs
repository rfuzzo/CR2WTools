using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SCameraMovementData 
{
#region RED Properties

[REDProp("camera")]
public Handle<CCustomCamera> Camera { get; set;}

[REDProp("pivotPositionController")]
public Handle<ICustomCameraPivotPositionController> PivotPositionController { get; set;}

[REDProp("pivotRotationController")]
public Handle<ICustomCameraPivotRotationController> PivotRotationController { get; set;}

[REDProp("pivotDistanceController")]
public Handle<ICustomCameraPivotDistanceController> PivotDistanceController { get; set;}

[REDProp("pivotPositionValue")]
public Vector PivotPositionValue { get; set;}

[REDProp("pivotPositionVelocity")]
public Vector PivotPositionVelocity { get; set;}

[REDProp("pivotRotationValue")]
public EulerAngles PivotRotationValue { get; set;}

[REDProp("pivotRotationVelocity")]
public EulerAngles PivotRotationVelocity { get; set;}

[REDProp("pivotDistanceValue")]
public float PivotDistanceValue { get; set;}

[REDProp("pivotDistanceVelocity")]
public float PivotDistanceVelocity { get; set;}

[REDProp("cameraLocalSpaceOffset")]
public Vector CameraLocalSpaceOffset { get; set;}

[REDProp("cameraLocalSpaceOffsetVel")]
public Vector CameraLocalSpaceOffsetVel { get; set;}

[REDProp("cameraOffset")]
public Vector CameraOffset { get; set;}

#endregion
}
}