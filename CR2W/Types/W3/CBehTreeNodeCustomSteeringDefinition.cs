using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeCustomSteeringDefinition : CBehTreeNodeAtomicActionDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("steeringGraph")]
public CBehTreeValSteeringGraph SteeringGraph { get; set;}

[REDProp("moveType")]
public CBehTreeValEMoveType MoveType { get; set;}

[REDProp("moveSpeed")]
public CBehTreeValFloat MoveSpeed { get; set;}

#endregion
}
}