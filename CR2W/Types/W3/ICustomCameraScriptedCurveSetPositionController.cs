using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class ICustomCameraScriptedCurveSetPositionController : ICustomCameraScriptedPositionController
{
#region RED Properties

[REDProp("controllerName")]
public CName ControllerName { get; set;}

[REDProp("enableAutoCollisionAvoidance")]
public bool EnableAutoCollisionAvoidance { get; set;}

[REDProp("enableScreenSpaceCorrections")]
public bool EnableScreenSpaceCorrections { get; set;}

[REDProp("curveSet")]
public Array<Ptr<CCurve>> CurveSet { get; set;}

[REDProp("curveNames")]
public Array<CName> CurveNames { get; set;}

#endregion
}
}