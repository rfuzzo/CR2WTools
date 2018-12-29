using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskChangeSummonedEntityMovementDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("speed")]
public float Speed { get; set;}

[REDProp("stopDistance")]
public float StopDistance { get; set;}

[REDProp("fallBackSpeed")]
public float FallBackSpeed { get; set;}

[REDProp("normalSpeed")]
public float NormalSpeed { get; set;}

[REDProp("verticalSpeed")]
public float VerticalSpeed { get; set;}

[REDProp("speedOscilation")]
public SRangeF SpeedOscilation { get; set;}

[REDProp("normalSpeedOscilation")]
public SRangeF NormalSpeedOscilation { get; set;}

[REDProp("verticalOscilation")]
public SRangeF VerticalOscilation { get; set;}

[REDProp("speedOscilationSpeed")]
public float SpeedOscilationSpeed { get; set;}

[REDProp("normalSpeedOscilationSpeed")]
public float NormalSpeedOscilationSpeed { get; set;}

[REDProp("verticalOscilationSpeed")]
public float VerticalOscilationSpeed { get; set;}

#endregion
}
}