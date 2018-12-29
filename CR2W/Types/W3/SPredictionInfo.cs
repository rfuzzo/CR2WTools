using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SPredictionInfo 
{
#region RED Properties

[REDProp("distanceToCollision")]
public float DistanceToCollision { get; set;}

[REDProp("normalYaw")]
public float NormalYaw { get; set;}

[REDProp("turnAngle")]
public float TurnAngle { get; set;}

[REDProp("leftGroundLevel")]
public float LeftGroundLevel { get; set;}

[REDProp("frontGroundLevel")]
public float FrontGroundLevel { get; set;}

[REDProp("rightGroundLevel")]
public float RightGroundLevel { get; set;}

#endregion
}
}