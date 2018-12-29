using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodePredefinedPathWithCompanionDefinition : CBehTreeNodePredefinedPathDefinition
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

[REDProp("pathName")]
public CBehTreeValCName PathName { get; set;}

[REDProp("upThePath")]
public CBehTreeValBool UpThePath { get; set;}

[REDProp("pathMargin")]
public CBehTreeValFloat PathMargin { get; set;}

[REDProp("tolerance")]
public CBehTreeValFloat Tolerance { get; set;}

[REDProp("arrivalDistance")]
public CBehTreeValFloat ArrivalDistance { get; set;}

[REDProp("useExplorations")]
public CBehTreeValBool UseExplorations { get; set;}

[REDProp("companionTag")]
public CBehTreeValCName CompanionTag { get; set;}

[REDProp("maxDistance")]
public CBehTreeValFloat MaxDistance { get; set;}

[REDProp("minDistance")]
public CBehTreeValFloat MinDistance { get; set;}

[REDProp("progressWhenCompanionIsAhead")]
public CBehTreeValBool ProgressWhenCompanionIsAhead { get; set;}

[REDProp("progressOnlyWhenCompanionIsAhead")]
public CBehTreeValBool ProgressOnlyWhenCompanionIsAhead { get; set;}

[REDProp("matchCompanionSpeed")]
public CBehTreeValBool MatchCompanionSpeed { get; set;}

[REDProp("companionOffset")]
public CBehTreeValFloat CompanionOffset { get; set;}

[REDProp("keepMovingWhenMaxDistanceReached")]
public CBehTreeValBool KeepMovingWhenMaxDistanceReached { get; set;}

[REDProp("moveTypeAfterMaxDistanceReached")]
public CBehTreeValEMoveType MoveTypeAfterMaxDistanceReached { get; set;}

#endregion
}
}