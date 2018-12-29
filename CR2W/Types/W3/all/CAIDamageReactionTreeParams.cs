using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIDamageReactionTreeParams : CAISubTreeParameters
{
#region RED Properties

[REDProp("completeTaskAfterDisablingHitReaction")]
public bool CompleteTaskAfterDisablingHitReaction { get; set;}

[REDProp("enableTeleportOnHit")]
public bool EnableTeleportOnHit { get; set;}

#endregion
}
}