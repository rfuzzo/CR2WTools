using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeTemplateDefinition : IBehTreeMetanodeDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("res")]
public Handle<CBehTree> Res { get; set;}

[REDProp("aiParameters")]
public Handle<IAIParameters> AiParameters { get; set;}

#endregion
}
}