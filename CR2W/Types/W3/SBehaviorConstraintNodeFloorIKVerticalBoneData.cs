using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SBehaviorConstraintNodeFloorIKVerticalBoneData 
{
#region RED Properties

[REDProp("bone")]
public CName Bone { get; set;}

/*[REDProp("Min offset")]
public float Min offset { get; set;}

[REDProp("Max offset")]
public float Max offset { get; set;}*/

[REDProp("offsetToDesiredBlendTime")]
public float OffsetToDesiredBlendTime { get; set;}

[REDProp("verticalOffsetBlendTime")]
public float VerticalOffsetBlendTime { get; set;}

[REDProp("stiffness")]
public float Stiffness { get; set;}

#endregion
}
}