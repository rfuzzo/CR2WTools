using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSCHeadingToGoalAngle : IMoveSteeringCondition
{
#region RED Properties

[REDProp("acceptableDiff")]
public float AcceptableDiff { get; set;}

#endregion
}
}