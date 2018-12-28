using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTSetFlags : IMoveSteeringTask
{
#region RED Properties

[REDProp("movementFlags")]
public EMovementFlags MovementFlags { get; set;}

[REDProp("bitOperation")]
public EBitOperation BitOperation { get; set;}

#endregion
}
}