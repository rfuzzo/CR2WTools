using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
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