using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SR4PlayerTargetingPrecalcs 
{
#region RED Properties

[REDProp("playerPosition")]
public Vector PlayerPosition { get; set;}

[REDProp("playerHeading")]
public float PlayerHeading { get; set;}

[REDProp("playerHeadingVector")]
public Vector PlayerHeadingVector { get; set;}

[REDProp("playerRadius")]
public float PlayerRadius { get; set;}

[REDProp("cameraPosition")]
public Vector CameraPosition { get; set;}

[REDProp("cameraDirection")]
public Vector CameraDirection { get; set;}

[REDProp("cameraHeading")]
public float CameraHeading { get; set;}

[REDProp("cameraHeadingVector")]
public Vector CameraHeadingVector { get; set;}

#endregion
}
}