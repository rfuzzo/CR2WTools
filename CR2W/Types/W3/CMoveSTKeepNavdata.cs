using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTKeepNavdata : IMoveSteeringTask
{
#region RED Properties

[REDProp("slidingRate")]
public float SlidingRate { get; set;}

[REDProp("maxSlidingRange")]
public float MaxSlidingRange { get; set;}

[REDProp("maxTeleportationRange")]
public float MaxTeleportationRange { get; set;}

[REDProp("applyStandardConditions")]
public bool ApplyStandardConditions { get; set;}

#endregion
}
}