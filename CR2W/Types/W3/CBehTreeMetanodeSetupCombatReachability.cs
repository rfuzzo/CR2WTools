using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeMetanodeSetupCombatReachability : IBehTreeMetanodeOnSpawnDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("childNode")]
public Ptr<IBehTreeNodeDefinition> ChildNode { get; set;}

[REDProp("runWhenReattachedFromPool")]
public bool RunWhenReattachedFromPool { get; set;}

[REDProp("reachabilityTolerance")]
public CBehTreeValFloat ReachabilityTolerance { get; set;}

#endregion
}
}