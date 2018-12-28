using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SScenePersonalCameraDescription 
{
#region RED Properties

[REDProp("cameraName")]
public CName CameraName { get; set;}

[REDProp("cameraNumber")]
public uint CameraNumber { get; set;}

[REDProp("targetSlot")]
public uint TargetSlot { get; set;}

[REDProp("sourceSlot")]
public uint SourceSlot { get; set;}

[REDProp("cameraShots")]
public Array<SSceneCameraShotDescription> CameraShots { get; set;}

#endregion
}
}