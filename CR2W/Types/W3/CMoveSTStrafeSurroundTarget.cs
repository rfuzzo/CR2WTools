using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMoveSTStrafeSurroundTarget : IMoveTargetSteeringTask
{
#region RED Properties

[REDProp("namedTarget")]
public CName NamedTarget { get; set;}

[REDProp("importance")]
public float Importance { get; set;}

[REDProp("acceleration")]
public float Acceleration { get; set;}

[REDProp("moveSpeed")]
public float MoveSpeed { get; set;}

[REDProp("desiredSeparationAngle")]
public float DesiredSeparationAngle { get; set;}

[REDProp("toleranceAngle")]
public float ToleranceAngle { get; set;}

[REDProp("smoothAngle")]
public float SmoothAngle { get; set;}

[REDProp("strafingRing")]
public int StrafingRing { get; set;}

[REDProp("gravityToSeparationAngle")]
public bool GravityToSeparationAngle { get; set;}

#endregion
}
}