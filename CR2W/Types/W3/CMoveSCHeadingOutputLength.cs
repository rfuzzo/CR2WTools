using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSCHeadingOutputLength : IMoveSteeringCondition
{
#region RED Properties

[REDProp("minOutputLength")]
public float MinOutputLength { get; set;}

[REDProp("considerSpeed")]
public bool ConsiderSpeed { get; set;}

#endregion
}
}