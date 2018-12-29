using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCustomCameraBlendPPC : ICustomCameraPivotPositionController
{
#region RED Properties

[REDProp("controllerName")]
public CName ControllerName { get; set;}

[REDProp("offsetZ")]
public float OffsetZ { get; set;}

[REDProp("pivotZSmoothTime")]
public float PivotZSmoothTime { get; set;}

[REDProp("from")]
public Ptr<ICustomCameraPivotPositionController> From { get; set;}

[REDProp("to")]
public Ptr<ICustomCameraPivotPositionController> To { get; set;}

#endregion
}
}