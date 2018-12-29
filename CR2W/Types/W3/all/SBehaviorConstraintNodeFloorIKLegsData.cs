using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBehaviorConstraintNodeFloorIKLegsData 
{
#region RED Properties

[REDProp("verticalOffsetBlendUpTime")]
public float VerticalOffsetBlendUpTime { get; set;}

[REDProp("verticalOffsetBlendDownTime")]
public float VerticalOffsetBlendDownTime { get; set;}

[REDProp("maxAngleOffUprightNormal")]
public float MaxAngleOffUprightNormal { get; set;}

[REDProp("maxAngleOffUprightNormalSide")]
public float MaxAngleOffUprightNormalSide { get; set;}

[REDProp("maxAngleOffUprightNormalToRevert")]
public float MaxAngleOffUprightNormalToRevert { get; set;}

#endregion
}
}