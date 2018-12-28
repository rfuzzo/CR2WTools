using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeFlightIdleDynamicRootDefinition : CBehTreeNodeBaseIdleDynamicRootDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("defaultIdleTree")]
public Handle<CAITree> DefaultIdleTree { get; set;}

#endregion
}
}