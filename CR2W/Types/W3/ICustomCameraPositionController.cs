using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class ICustomCameraPositionController : ICustomCameraBaseController
{
#region RED Properties

[REDProp("controllerName")]
public CName ControllerName { get; set;}

[REDProp("enableAutoCollisionAvoidance")]
public bool EnableAutoCollisionAvoidance { get; set;}

[REDProp("enableScreenSpaceCorrections")]
public bool EnableScreenSpaceCorrections { get; set;}

#endregion
}
}