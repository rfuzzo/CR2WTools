using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorMimicHeadConstraint : IBehaviorMimicConstraint
{
#region RED Properties

[REDProp("cachedControlVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

[REDProp("headTrack")]
public string HeadTrack { get; set;}

#endregion
}
}