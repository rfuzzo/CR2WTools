using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeSelectTargetByTagInAreaDecoratorDefinition : CBehTreeNodeSelectTargetByTagDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("tag")]
public CBehTreeValCName Tag { get; set;}

[REDProp("allowActivationWhenNoTarget")]
public bool AllowActivationWhenNoTarget { get; set;}

[REDProp("areaSelection")]
public SBehTreeAreaSelection AreaSelection { get; set;}

[REDProp("getClosest")]
public CBehTreeValBool GetClosest { get; set;}

[REDProp("reselectOnActivate")]
public CBehTreeValBool ReselectOnActivate { get; set;}

#endregion
}
}