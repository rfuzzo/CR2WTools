using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeStrafingAlgorithmFastSurroundDefinition : CBehTreeStrafingAlgorithmDefinition
{
#region RED Properties

[REDProp("usageDelay")]
public CBehTreeValFloat UsageDelay { get; set;}

[REDProp("distanceToActivate")]
public CBehTreeValFloat DistanceToActivate { get; set;}

[REDProp("speedMinToActivate")]
public CBehTreeValFloat SpeedMinToActivate { get; set;}

[REDProp("distanceToBreak")]
public CBehTreeValFloat DistanceToBreak { get; set;}

[REDProp("verticalHeadingLimitToBreak")]
public CBehTreeValFloat VerticalHeadingLimitToBreak { get; set;}

[REDProp("speedMinLimitToBreak")]
public CBehTreeValFloat SpeedMinLimitToBreak { get; set;}

[REDProp("surroundMoveType")]
public CBehTreeValEMoveType SurroundMoveType { get; set;}

#endregion
}
}