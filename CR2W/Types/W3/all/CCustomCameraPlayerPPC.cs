using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCustomCameraPlayerPPC : ICustomCameraPivotPositionController
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

#endregion
}
}