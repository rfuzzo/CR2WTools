using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcHoldGroundTacticTreeParams : CAINpcTacticTreeParams
{
#region RED Properties

[REDProp("holdPositionTag")]
public CName HoldPositionTag { get; set;}

[REDProp("engageDist")]
public float EngageDist { get; set;}

[REDProp("maxDistanceToHoldGroundPosition")]
public float MaxDistanceToHoldGroundPosition { get; set;}

#endregion
}
}