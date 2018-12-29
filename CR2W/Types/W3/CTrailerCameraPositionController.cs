using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CTrailerCameraPositionController : ICustomCameraPositionController
{
#region RED Properties

[REDProp("controllerName")]
public CName ControllerName { get; set;}

[REDProp("enableAutoCollisionAvoidance")]
public bool EnableAutoCollisionAvoidance { get; set;}

[REDProp("enableScreenSpaceCorrections")]
public bool EnableScreenSpaceCorrections { get; set;}

[REDProp("defaultPitch")]
public float DefaultPitch { get; set;}

[REDProp("defaultZOffset")]
public float DefaultZOffset { get; set;}

[REDProp("offsetSmoothTime")]
public float OffsetSmoothTime { get; set;}

[REDProp("collisionController")]
public Ptr<ICustomCameraCollisionController> CollisionController { get; set;}

[REDProp("defaultCollisionOriginOffset")]
public Vector DefaultCollisionOriginOffset { get; set;}

#endregion
}
}