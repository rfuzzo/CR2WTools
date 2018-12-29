using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeBaseAtomicPursueTargetDefinition : CBehTreeNodeAtomicActionDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("minDistance")]
public CBehTreeValFloat MinDistance { get; set;}

[REDProp("moveSpeed")]
public CBehTreeValFloat MoveSpeed { get; set;}

[REDProp("tolerance")]
public CBehTreeValFloat Tolerance { get; set;}

[REDProp("moveType")]
public CBehTreeValEMoveType MoveType { get; set;}

[REDProp("moveOutsideNavdata")]
public CBehTreeValBool MoveOutsideNavdata { get; set;}

#endregion
}
}