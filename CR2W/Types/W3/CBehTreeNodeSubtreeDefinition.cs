using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeSubtreeDefinition : IBehTreeMetanodeDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("treeName")]
public CName TreeName { get; set;}

[REDProp("data")]
public Handle<CAITree> Data { get; set;}

#endregion
}
}