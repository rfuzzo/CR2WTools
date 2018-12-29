using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMoveSTMatchHeadingOrientation : IMoveSteeringTask
{
#region RED Properties

[REDProp("limitSpeedOnTurns")]
public bool LimitSpeedOnTurns { get; set;}

[REDProp("maxAngleNotLimitingSpeed")]
public float MaxAngleNotLimitingSpeed { get; set;}

[REDProp("speedLimitOnRotation")]
public float SpeedLimitOnRotation { get; set;}

#endregion
}
}