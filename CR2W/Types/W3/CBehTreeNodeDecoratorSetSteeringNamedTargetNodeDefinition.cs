using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeDecoratorSetSteeringNamedTargetNodeDefinition : IBehTreeNodeDecoratorSteeringTargeterDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("targetName")]
public CName TargetName { get; set;}

[REDProp("combatTarget")]
public bool CombatTarget { get; set;}

#endregion
}
}