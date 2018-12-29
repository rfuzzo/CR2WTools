using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeUseExplorationActionDefinition : CBehTreeNodeAtomicActionDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("explorationType")]
public CBehTreeValEExplorationType ExplorationType { get; set;}

[REDProp("entityTag")]
public CBehTreeValCName EntityTag { get; set;}

#endregion
}
}