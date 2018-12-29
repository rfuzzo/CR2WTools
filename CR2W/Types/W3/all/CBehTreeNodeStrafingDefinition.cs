using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeNodeStrafingDefinition : CBehTreeNodeCustomSteeringDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("steeringGraph")]
public CBehTreeValSteeringGraph SteeringGraph { get; set;}

[REDProp("moveType")]
public CBehTreeValEMoveType MoveType { get; set;}

[REDProp("moveSpeed")]
public CBehTreeValFloat MoveSpeed { get; set;}

[REDProp("updateFrequency")]
public CBehTreeValFloat UpdateFrequency { get; set;}

[REDProp("steeringSpeed")]
public CBehTreeValFloat SteeringSpeed { get; set;}

[REDProp("steeringImportance")]
public CBehTreeValFloat SteeringImportance { get; set;}

[REDProp("accelerationRate")]
public CBehTreeValFloat AccelerationRate { get; set;}

[REDProp("strafingWeight")]
public CBehTreeValFloat StrafingWeight { get; set;}

[REDProp("keepDistanceWeight")]
public CBehTreeValFloat KeepDistanceWeight { get; set;}

[REDProp("randomStrafeWeight")]
public CBehTreeValFloat RandomStrafeWeight { get; set;}

[REDProp("randomizationFrequency")]
public CBehTreeValFloat RandomizationFrequency { get; set;}

[REDProp("minRange")]
public CBehTreeValFloat MinRange { get; set;}

[REDProp("maxRange")]
public CBehTreeValFloat MaxRange { get; set;}

[REDProp("desiredSeparationAngle")]
public CBehTreeValFloat DesiredSeparationAngle { get; set;}

[REDProp("gravityToSeparationAngle")]
public CBehTreeValBool GravityToSeparationAngle { get; set;}

[REDProp("lockOrientation")]
public CBehTreeValBool LockOrientation { get; set;}

[REDProp("strafingRing")]
public CBehTreeValInt StrafingRing { get; set;}

[REDProp("customAlgorithm")]
public Ptr<CBehTreeStrafingAlgorithmDefinition> CustomAlgorithm { get; set;}

#endregion
}
}