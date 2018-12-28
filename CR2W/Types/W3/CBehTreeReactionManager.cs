using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeReactionManager : CObject
{
#region RED Properties

[REDProp("reactionScens")]
public Array<Handle<CReactionScene>> ReactionScens { get; set;}

[REDProp("reactionEvents")]
public Array<Ptr<CBehTreeReactionEventData>> ReactionEvents { get; set;}

#endregion
}
}