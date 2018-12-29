using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMoveSCArrival : IMoveSteeringCondition
{
#region RED Properties

[REDProp("arrivalDistance")]
public float ArrivalDistance { get; set;}

[REDProp("acceptableAngleToGoal")]
public float AcceptableAngleToGoal { get; set;}

#endregion
}
}