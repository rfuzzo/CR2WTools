using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSetAttitude : IBehTreeTask
{
#region RED Properties

[REDProp("towardsActionTarget")]
public bool TowardsActionTarget { get; set;}

[REDProp("attitude")]
public EAIAttitude Attitude { get; set;}

[REDProp("currentAttitude")]
public EAIAttitude CurrentAttitude { get; set;}

[REDProp("sender")]
public Handle<CActor> Sender { get; set;}

[REDProp("petard")]
public Handle<W3Petard> Petard { get; set;}

[REDProp("reactionDataStorage")]
public Handle<CAIStorageReactionData> ReactionDataStorage { get; set;}

#endregion
}
}