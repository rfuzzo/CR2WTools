using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMoveSTAvoidObstacles : IMoveSteeringTask
{
#region RED Properties

[REDProp("avoidObstaclesImportance")]
public float AvoidObstaclesImportance { get; set;}

[REDProp("timeToChooseNextObstacle")]
public float TimeToChooseNextObstacle { get; set;}

[REDProp("maxDistanceToObstacle")]
public float MaxDistanceToObstacle { get; set;}

[REDProp("furthestImpactTime")]
public float FurthestImpactTime { get; set;}

[REDProp("overrideValues")]
public bool OverrideValues { get; set;}

[REDProp("modifyRotation")]
public bool ModifyRotation { get; set;}

[REDProp("modifyHeading")]
public bool ModifyHeading { get; set;}

[REDProp("modifySpeed")]
public bool ModifySpeed { get; set;}

#endregion
}
}