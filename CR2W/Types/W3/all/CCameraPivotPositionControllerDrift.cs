using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCameraPivotPositionControllerDrift : ICustomCameraScriptedPivotPositionController
{
#region RED Properties

[REDProp("zOffset")]
public float ZOffset { get; set;}

[REDProp("originalPosition")]
public Vector OriginalPosition { get; set;}

[REDProp("blendSpeed")]
public float BlendSpeed { get; set;}

[REDProp("blendOutMult")]
public float BlendOutMult { get; set;}

[REDProp("sideDistance")]
public float SideDistance { get; set;}

[REDProp("backDistance")]
public float BackDistance { get; set;}

[REDProp("upDistance")]
public float UpDistance { get; set;}

[REDProp("sideDistanceCur")]
public float SideDistanceCur { get; set;}

[REDProp("backDistanceCur")]
public float BackDistanceCur { get; set;}

[REDProp("upDistanceCur")]
public float UpDistanceCur { get; set;}

[REDProp("sideDistanceBlendSpeed")]
public float SideDistanceBlendSpeed { get; set;}

[REDProp("backDistanceBlendSpeed")]
public float BackDistanceBlendSpeed { get; set;}

[REDProp("upDistanceBlendSpeed")]
public float UpDistanceBlendSpeed { get; set;}

[REDProp("timeToDispMax")]
public float TimeToDispMax { get; set;}

[REDProp("timeOfsetCur")]
public float TimeOfsetCur { get; set;}

[REDProp("timeCur")]
public float TimeCur { get; set;}

#endregion
}
}