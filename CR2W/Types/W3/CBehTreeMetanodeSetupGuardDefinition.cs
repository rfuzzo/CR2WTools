using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeMetanodeSetupGuardDefinition : IBehTreeMetanodeOnSpawnDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("childNode")]
public Ptr<IBehTreeNodeDefinition> ChildNode { get; set;}

[REDProp("runWhenReattachedFromPool")]
public bool RunWhenReattachedFromPool { get; set;}

#endregion
}
}