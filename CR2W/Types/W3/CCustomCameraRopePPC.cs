using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CCustomCameraRopePPC : ICustomCameraPivotPositionController
{
#region RED Properties

[REDProp("controllerName")]
public CName ControllerName { get; set;}

[REDProp("offsetZ")]
public float OffsetZ { get; set;}

[REDProp("pivotZSmoothTime")]
public float PivotZSmoothTime { get; set;}

[REDProp("dampFactor")]
public float DampFactor { get; set;}

[REDProp("smoothZ")]
public float SmoothZ { get; set;}

[REDProp("ropeLength")]
public float RopeLength { get; set;}

#endregion
}
}