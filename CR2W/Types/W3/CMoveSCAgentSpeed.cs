using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSCAgentSpeed : IMoveSteeringCondition
{
#region RED Properties

[REDProp("rangeMin")]
public float RangeMin { get; set;}

[REDProp("rangeMax")]
public float RangeMax { get; set;}

#endregion
}
}