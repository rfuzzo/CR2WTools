using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CCustomCameraDefaultPDC : ICustomCameraPivotDistanceController
{
#region RED Properties

[REDProp("controllerName")]
public CName ControllerName { get; set;}

[REDProp("minDist")]
public float MinDist { get; set;}

[REDProp("maxDist")]
public float MaxDist { get; set;}

[REDProp("dampFactor")]
public float DampFactor { get; set;}

#endregion
}
}