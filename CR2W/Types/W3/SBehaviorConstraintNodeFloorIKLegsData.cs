using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SBehaviorConstraintNodeFloorIKLegsData 
{
#region RED Properties

/*[REDProp("Min rel offset")]
public float Min rel offset { get; set;}

[REDProp("Max rel offset")]
public float Max rel offset { get; set;}

[REDProp("Min trace offset")]
public float Min trace offset { get; set;}

[REDProp("Max trace offset")]
public float Max trace offset { get; set;}*/

[REDProp("verticalOffsetBlendUpTime")]
public float VerticalOffsetBlendUpTime { get; set;}

[REDProp("verticalOffsetBlendDownTime")]
public float VerticalOffsetBlendDownTime { get; set;}

/*[REDProp("Max distance for trace update")]
public float Max distance for trace update { get; set;}*/

[REDProp("maxAngleOffUprightNormal")]
public float MaxAngleOffUprightNormal { get; set;}

[REDProp("maxAngleOffUprightNormalSide")]
public float MaxAngleOffUprightNormalSide { get; set;}

[REDProp("maxAngleOffUprightNormalToRevert")]
public float MaxAngleOffUprightNormalToRevert { get; set;}

#endregion
}
}