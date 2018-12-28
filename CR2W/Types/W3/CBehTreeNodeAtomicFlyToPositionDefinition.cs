using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeAtomicFlyToPositionDefinition : IBehTreeNodeAtomicFlyToBaseDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("skipHeightCheck")]
public bool SkipHeightCheck { get; set;}

[REDProp("useAbsoluteHeightDifference")]
public bool UseAbsoluteHeightDifference { get; set;}

[REDProp("checkDistanceWithoutOffsets")]
public bool CheckDistanceWithoutOffsets { get; set;}

[REDProp("distanceOffset")]
public CBehTreeValFloat DistanceOffset { get; set;}

[REDProp("heightOffset")]
public CBehTreeValFloat HeightOffset { get; set;}

[REDProp("min2DDistance")]
public CBehTreeValFloat Min2DDistance { get; set;}

[REDProp("minHeight")]
public CBehTreeValFloat MinHeight { get; set;}

#endregion
}
}