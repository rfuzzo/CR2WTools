using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeNodeEvaluatingChoiceDefinition : CBehTreeNodeChoiceDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("children")]
public Array<Ptr<IBehTreeNodeDefinition>> Children { get; set;}

[REDProp("useScoring")]
public bool UseScoring { get; set;}

[REDProp("selectRandom")]
public bool SelectRandom { get; set;}

[REDProp("forwardChildrenCompletness")]
public bool ForwardChildrenCompletness { get; set;}

#endregion
}
}