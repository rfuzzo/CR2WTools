using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4ReactionManager : CBehTreeReactionManager
{
#region RED Properties

[REDProp("reactionScens")]
public Array<Handle<CReactionScene>> ReactionScens { get; set;}

[REDProp("reactionEvents")]
public Array<Ptr<CBehTreeReactionEventData>> ReactionEvents { get; set;}

[REDProp("rainReactionsEnabled")]
public bool RainReactionsEnabled { get; set;}

[REDProp("rainEventParams")]
public Handle<CBehTreeReactionEventData> RainEventParams { get; set;}

#endregion
}
}