using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class ICustomCameraScriptedCurveSetPivotPositionController : ICustomCameraScriptedPivotPositionController
{
#region RED Properties

[REDProp("controllerName")]
public CName ControllerName { get; set;}

[REDProp("offsetZ")]
public float OffsetZ { get; set;}

[REDProp("pivotZSmoothTime")]
public float PivotZSmoothTime { get; set;}

[REDProp("curveSet")]
public Array<Ptr<CCurve>> CurveSet { get; set;}

[REDProp("curveNames")]
public Array<CName> CurveNames { get; set;}

#endregion
}
}