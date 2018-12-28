using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBPCPoseLookAtCurveTrajModifier : IBehaviorPoseConstraintPoseLookAtModifier
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("axis")]
public EAxis Axis { get; set;}

[REDProp("curve")]
public Ptr<CCurve> Curve { get; set;}

[REDProp("maxAngle")]
public float MaxAngle { get; set;}

[REDProp("maxValue")]
public float MaxValue { get; set;}

#endregion
}
}