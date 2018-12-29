using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SSceneMasterCameraDescription 
{
#region RED Properties

[REDProp("cameraName")]
public CName CameraName { get; set;}

[REDProp("cameraNumber")]
public uint CameraNumber { get; set;}

[REDProp("cameraShots")]
public Array<SSceneCameraShotDescription> CameraShots { get; set;}

#endregion
}
}