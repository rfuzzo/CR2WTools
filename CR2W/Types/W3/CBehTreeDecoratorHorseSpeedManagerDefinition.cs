using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeDecoratorHorseSpeedManagerDefinition : IBehTreeNodeDecoratorSteeringTargeterDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("moveType")]
public CBehTreeValEHorseMoveType MoveType { get; set;}

#endregion
}
}