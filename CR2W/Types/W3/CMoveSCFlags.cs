using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMoveSCFlags : IMoveSteeringCondition
{
#region RED Properties

[REDProp("movementFlags")]
public EMovementFlags MovementFlags { get; set;}

#endregion
}
}