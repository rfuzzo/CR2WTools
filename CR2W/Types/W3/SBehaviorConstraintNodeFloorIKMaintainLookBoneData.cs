using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SBehaviorConstraintNodeFloorIKMaintainLookBoneData 
{
#region RED Properties

[REDProp("bone")]
public CName Bone { get; set;}

[REDProp("amountOfRotation")]
public float AmountOfRotation { get; set;}

#endregion
}
}