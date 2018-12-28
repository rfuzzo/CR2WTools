using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSCDistanceToDestination : IMoveSteeringCondition
{
#region RED Properties

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("considerGoalTolerance")]
public bool ConsiderGoalTolerance { get; set;}

#endregion
}
}