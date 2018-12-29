using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SHorseStateOffsets 
{
#region RED Properties

[REDProp("speedValue")]
public float SpeedValue { get; set;}

[REDProp("maxValue")]
public float MaxValue { get; set;}

[REDProp("legFY")]
public float LegFY { get; set;}

[REDProp("legFZ")]
public float LegFZ { get; set;}

[REDProp("legBY")]
public float LegBY { get; set;}

[REDProp("legBZ")]
public float LegBZ { get; set;}

[REDProp("pelvisY")]
public float PelvisY { get; set;}

[REDProp("pelvisZ")]
public float PelvisZ { get; set;}

[REDProp("headFirstAngle")]
public float HeadFirstAngle { get; set;}

[REDProp("headSecondAngle")]
public float HeadSecondAngle { get; set;}

[REDProp("headThirdAngle")]
public float HeadThirdAngle { get; set;}

#endregion
}
}