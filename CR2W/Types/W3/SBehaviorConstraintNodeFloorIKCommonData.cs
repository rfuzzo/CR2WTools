using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SBehaviorConstraintNodeFloorIKCommonData 
{
#region RED Properties

[REDProp("gravityCentreBone")]
public CName GravityCentreBone { get; set;}

[REDProp("rootRotationBlendTime")]
public float RootRotationBlendTime { get; set;}

[REDProp("verticalVelocityOffsetUpBlendTime")]
public float VerticalVelocityOffsetUpBlendTime { get; set;}

[REDProp("verticalVelocityOffsetDownBlendTime")]
public float VerticalVelocityOffsetDownBlendTime { get; set;}

[REDProp("slidingOnSlopeBlendTime")]
public float SlidingOnSlopeBlendTime { get; set;}

#endregion
}
}