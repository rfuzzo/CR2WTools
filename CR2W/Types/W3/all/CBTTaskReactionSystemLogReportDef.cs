using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskReactionSystemLogReportDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("reactionName")]
public string ReactionName { get; set;}

[REDProp("message")]
public string Message { get; set;}

#endregion
}
}