using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CCustomCameraAutoAvoidanceCollisionController : ICustomCameraCollisionController
{
#region RED Properties

[REDProp("controllerName")]
public CName ControllerName { get; set;}

[REDProp("catchUpCurve")]
public Ptr<CCurve> CatchUpCurve { get; set;}

#endregion
}
}