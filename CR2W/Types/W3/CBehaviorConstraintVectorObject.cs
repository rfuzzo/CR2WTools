using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorConstraintVectorObject : IBehaviorConstraintObject
{
#region RED Properties

[REDProp("localPositionOffset")]
public Vector LocalPositionOffset { get; set;}

[REDProp("localRotationOffset")]
public EulerAngles LocalRotationOffset { get; set;}

[REDProp("cachedTargetPositionNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedTargetPositionNode { get; set;}

[REDProp("cachedTargetRotationNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedTargetRotationNode { get; set;}

#endregion
}
}