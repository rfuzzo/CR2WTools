using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeAtomicMoveToActionPointDefinition : CBehTreeNodeAtomicMoveToDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("steeringGraph")]
public CBehTreeValSteeringGraph SteeringGraph { get; set;}

[REDProp("maxDistance")]
public CBehTreeValFloat MaxDistance { get; set;}

[REDProp("moveSpeed")]
public CBehTreeValFloat MoveSpeed { get; set;}

[REDProp("pathfindingTolerance")]
public CBehTreeValFloat PathfindingTolerance { get; set;}

[REDProp("moveType")]
public CBehTreeValEMoveType MoveType { get; set;}

[REDProp("angularTolerance")]
public float AngularTolerance { get; set;}

[REDProp("keepPreviousMoveData")]
public CBehTreeValBool KeepPreviousMoveData { get; set;}

[REDProp("rotateAfterwards")]
public CBehTreeValBool RotateAfterwards { get; set;}

[REDProp("preciseArrival")]
public CBehTreeValBool PreciseArrival { get; set;}

#endregion
}
}