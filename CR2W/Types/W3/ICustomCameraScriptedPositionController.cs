using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class ICustomCameraScriptedPositionController : ICustomCameraPositionController
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