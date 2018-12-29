using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ICustomCameraScriptedCurveSetPivotDistanceController : ICustomCameraScriptedPivotDistanceController
{
#region RED Properties

[REDProp("controllerName")]
public CName ControllerName { get; set;}

[REDProp("minDist")]
public float MinDist { get; set;}

[REDProp("maxDist")]
public float MaxDist { get; set;}

[REDProp("curveSet")]
public Array<Ptr<CCurve>> CurveSet { get; set;}

[REDProp("curveNames")]
public Array<CName> CurveNames { get; set;}

#endregion
}
}