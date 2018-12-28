using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTKeepDistanceToTarget : IMoveTargetPositionSteeringTask
{
#region RED Properties

[REDProp("namedTarget")]
public CName NamedTarget { get; set;}

[REDProp("customPosition")]
public CName CustomPosition { get; set;}

[REDProp("importance")]
public float Importance { get; set;}

[REDProp("acceleration")]
public float Acceleration { get; set;}

[REDProp("moveSpeed")]
public float MoveSpeed { get; set;}

[REDProp("minRange")]
public float MinRange { get; set;}

[REDProp("maxRange")]
public float MaxRange { get; set;}

[REDProp("tolerance")]
public float Tolerance { get; set;}

[REDProp("brakeDistance")]
public float BrakeDistance { get; set;}

[REDProp("randomizationFrequency")]
public float RandomizationFrequency { get; set;}

#endregion
}
}