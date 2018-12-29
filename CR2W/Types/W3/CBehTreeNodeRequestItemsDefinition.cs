using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeRequestItemsDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("LeftItemType")]
public CBehTreeValCName LeftItemType { get; set;}

[REDProp("RightItemType")]
public CBehTreeValCName RightItemType { get; set;}

[REDProp("chooseSilverIfPossible")]
public CBehTreeValBool ChooseSilverIfPossible { get; set;}

[REDProp("behaviorGraphVarName")]
public CName BehaviorGraphVarName { get; set;}

#endregion
}
}