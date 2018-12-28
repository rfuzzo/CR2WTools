using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSCGoalChannel : IMoveSteeringCondition
{
#region RED Properties

[REDProp("orientationRequired")]
public bool OrientationRequired { get; set;}

[REDProp("headingRequired")]
public bool HeadingRequired { get; set;}

#endregion
}
}