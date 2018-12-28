using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CCustomCameraSimplePositionController : ICustomCameraPositionController
{
#region RED Properties

[REDProp("controllerName")]
public CName ControllerName { get; set;}

[REDProp("enableAutoCollisionAvoidance")]
public bool EnableAutoCollisionAvoidance { get; set;}

[REDProp("enableScreenSpaceCorrections")]
public bool EnableScreenSpaceCorrections { get; set;}

[REDProp("collisionController")]
public Ptr<ICustomCameraCollisionController> CollisionController { get; set;}

[REDProp("collisionController2")]
public Ptr<ICustomCameraCollisionController> CollisionController2 { get; set;}

#endregion
}
}