using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeDecoratorChangeBehaviorGraphDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("behGraphNameActivate")]
public CBehTreeValCName BehGraphNameActivate { get; set;}

[REDProp("behGraphNameDeactivate")]
public CBehTreeValCName BehGraphNameDeactivate { get; set;}

[REDProp("activateIfBehaviorUnavailable")]
public bool ActivateIfBehaviorUnavailable { get; set;}

#endregion
}
}