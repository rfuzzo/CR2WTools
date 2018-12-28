using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphBlendMultipleCondNode_Transition : CObject
{
#region RED Properties

[REDProp("condition")]
public Ptr<IBehaviorGraphBlendMultipleCondNode_Condition> Condition { get; set;}

[REDProp("transitionDuration")]
public float TransitionDuration { get; set;}

[REDProp("synchronize")]
public bool Synchronize { get; set;}

[REDProp("syncMethod")]
public Ptr<IBehaviorSyncMethod> SyncMethod { get; set;}

[REDProp("blockEvents")]
public bool BlockEvents { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

#endregion
}
}