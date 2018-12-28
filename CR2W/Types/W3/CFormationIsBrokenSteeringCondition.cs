using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CFormationIsBrokenSteeringCondition : IFormationSteeringCondition
{
#region RED Properties

[REDProp("howMuchBroken")]
public float HowMuchBroken { get; set;}

#endregion
}
}