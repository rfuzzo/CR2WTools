using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeNodeDecoratorLeadFormationDefinition : CBehTreeDecoratorSteeringGraphDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("steeringGraph")]
public CBehTreeValSteeringGraph SteeringGraph { get; set;}

[REDProp("formation")]
public CBehTreeValFormation Formation { get; set;}

[REDProp("reshapeOnMoveAction")]
public CBehTreeValBool ReshapeOnMoveAction { get; set;}

#endregion
}
}