using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSCWalkSideBySide : IMoveSteeringCondition
{
#region RED Properties

[REDProp("sideBySideDistance")]
public float SideBySideDistance { get; set;}

[REDProp("distanceLimit")]
public float DistanceLimit { get; set;}

#endregion
}
}