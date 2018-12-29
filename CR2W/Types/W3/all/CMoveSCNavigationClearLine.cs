using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMoveSCNavigationClearLine : IMoveSteeringCondition
{
#region RED Properties

[REDProp("destinationForward")]
public float DestinationForward { get; set;}

[REDProp("destinationLeft")]
public float DestinationLeft { get; set;}

[REDProp("testRadius")]
public float TestRadius { get; set;}

[REDProp("useCharacterOrientation")]
public bool UseCharacterOrientation { get; set;}

[REDProp("useSteeringOutput")]
public bool UseSteeringOutput { get; set;}

[REDProp("useGoalDirection")]
public bool UseGoalDirection { get; set;}

#endregion
}
}