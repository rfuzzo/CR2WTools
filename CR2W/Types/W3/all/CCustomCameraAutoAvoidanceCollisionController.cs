using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
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