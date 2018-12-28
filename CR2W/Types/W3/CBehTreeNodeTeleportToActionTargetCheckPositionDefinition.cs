using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeTeleportToActionTargetCheckPositionDefinition : CBehTreeNodeTeleportToActionTargetDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("queryDelay")]
public CBehTreeValFloat QueryDelay { get; set;}

[REDProp("filter")]
public SPositioningFilter Filter { get; set;}

#endregion
}
}