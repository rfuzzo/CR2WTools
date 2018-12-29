using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMoveSTMaintainTargetSpeed : IManageSpeedSteeringTask
{
#region RED Properties

[REDProp("speedImportance")]
public float SpeedImportance { get; set;}

[REDProp("allowedDiffPerSecond")]
public float AllowedDiffPerSecond { get; set;}

[REDProp("stopSpeedThreshold")]
public float StopSpeedThreshold { get; set;}

[REDProp("distanceCoefficient")]
public float DistanceCoefficient { get; set;}

#endregion
}
}