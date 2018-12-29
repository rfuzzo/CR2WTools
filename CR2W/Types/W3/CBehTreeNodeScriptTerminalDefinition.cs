using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeScriptTerminalDefinition : IBehTreeNodeDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("taskOrigin")]
public Handle<IBehTreeTaskDefinition> TaskOrigin { get; set;}

[REDProp("skipIfActive")]
public bool SkipIfActive { get; set;}

[REDProp("runMainOnActivation")]
public bool RunMainOnActivation { get; set;}

#endregion
}
}