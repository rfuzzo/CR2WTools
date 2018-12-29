using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskWander : IBehTreeTask
{
#region RED Properties

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("minSpeed")]
public float MinSpeed { get; set;}

[REDProp("maxSpeed")]
public float MaxSpeed { get; set;}

[REDProp("absSpeed")]
public float AbsSpeed { get; set;}

[REDProp("headingChange")]
public float HeadingChange { get; set;}

[REDProp("heading")]
public float Heading { get; set;}

[REDProp("initialPosCheck")]
public bool InitialPosCheck { get; set;}

[REDProp("isMoving")]
public bool IsMoving { get; set;}

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("initialPos")]
public Vector InitialPos { get; set;}

[REDProp("newHeading")]
public Vector NewHeading { get; set;}

[REDProp("checkPos")]
public Vector CheckPos { get; set;}

#endregion
}
}