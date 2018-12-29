using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ElevatorMechanism : CEntity
{
#region RED Properties

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("clockwiseRotation")]
public bool ClockwiseRotation { get; set;}

[REDProp("rotationSpeed")]
public float RotationSpeed { get; set;}

[REDProp("forwardDirection")]
public bool ForwardDirection { get; set;}

[REDProp("transformMatrix")]
public Matrix TransformMatrix { get; set;}

[REDProp("localRotation")]
public EulerAngles LocalRotation { get; set;}

#endregion
}
}