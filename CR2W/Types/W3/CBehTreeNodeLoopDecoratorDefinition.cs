using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeLoopDecoratorDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("onCompleted")]
public EBTLoopMode OnCompleted { get; set;}

[REDProp("onFailed")]
public EBTLoopMode OnFailed { get; set;}

[REDProp("maxIterations")]
public CBehTreeValInt MaxIterations { get; set;}

[REDProp("reactivationDelay")]
public float ReactivationDelay { get; set;}

#endregion
}
}