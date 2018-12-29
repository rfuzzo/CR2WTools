using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphPointCloudLookAtTransition_Vertical : IBehaviorGraphPointCloudLookAtTransition_Vector
{
#region RED Properties

[REDProp("maxAngleDiffDeg")]
public float MaxAngleDiffDeg { get; set;}

[REDProp("scale")]
public float Scale { get; set;}

[REDProp("minAngle")]
public float MinAngle { get; set;}

[REDProp("maxAngle")]
public float MaxAngle { get; set;}

[REDProp("curve")]
public Ptr<CCurve> Curve { get; set;}

#endregion
}
}