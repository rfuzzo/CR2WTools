using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CActionBroadcastEvent : IEntityTargetingAction
{
#region RED Properties

[REDProp("entitySelectionType")]
public EEntityTargetingActionMechanism EntitySelectionType { get; set;}

[REDProp("entityHandle")]
public EntityHandle EntityHandle { get; set;}

[REDProp("eventToBrodecast")]
public CName EventToBrodecast { get; set;}

#endregion
}
}