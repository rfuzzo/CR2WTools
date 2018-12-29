using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCondReactionEvent : IBehTreeTask
{
#region RED Properties

[REDProp("reactionEventName")]
public CName ReactionEventName { get; set;}

[REDProp("eventReceived")]
public bool EventReceived { get; set;}

#endregion
}
}