using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeSendScaredEventDefinition : IBehTreeNodeDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("becomeScared")]
public bool BecomeScared { get; set;}

[REDProp("scaredTime")]
public CBehTreeValFloat ScaredTime { get; set;}

[REDProp("scaredTimeMax")]
public CBehTreeValFloat ScaredTimeMax { get; set;}

#endregion
}
}