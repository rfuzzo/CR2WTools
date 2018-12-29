using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SSceneCustomCameraDescription 
{
#region RED Properties

[REDProp("cameraName")]
public CName CameraName { get; set;}

[REDProp("fov")]
public float Fov { get; set;}

[REDProp("cameraTransform")]
public EngineTransform CameraTransform { get; set;}

#endregion
}
}