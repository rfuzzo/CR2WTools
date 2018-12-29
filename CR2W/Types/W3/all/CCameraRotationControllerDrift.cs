using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCameraRotationControllerDrift : ICustomCameraScriptedPivotRotationController
{
#region RED Properties

[REDProp("fixedPitch")]
public float FixedPitch { get; set;}

[REDProp("rollBase")]
public float RollBase { get; set;}

[REDProp("rollExtraTurn")]
public float RollExtraTurn { get; set;}

[REDProp("yawTotal")]
public float YawTotal { get; set;}

[REDProp("timeCur")]
public float TimeCur { get; set;}

[REDProp("blendSpeedRoll")]
public float BlendSpeedRoll { get; set;}

[REDProp("blendSpeedYaw")]
public float BlendSpeedYaw { get; set;}

[REDProp("turnLast")]
public float TurnLast { get; set;}

#endregion
}
}