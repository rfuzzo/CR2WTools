using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MeditationCameraRotationController : ICustomCameraScriptedPivotRotationController
{
#region RED Properties

[REDProp("fixedPitch")]
public float FixedPitch { get; set;}

[REDProp("fixedYaw")]
public float FixedYaw { get; set;}

[REDProp("fixedRoll")]
public float FixedRoll { get; set;}

[REDProp("baseSmooth")]
public float BaseSmooth { get; set;}

[REDProp("desiredYaw")]
public float DesiredYaw { get; set;}

[REDProp("desired")]
public bool Desired { get; set;}

[REDProp("smooth")]
public float Smooth { get; set;}

#endregion
}
}