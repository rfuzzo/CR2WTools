using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTChangeSpeed : IMoveSteeringTask
{
#region RED Properties

[REDProp("speedType")]
public EMoveType SpeedType { get; set;}

[REDProp("absSpeed")]
public float AbsSpeed { get; set;}

#endregion
}
}