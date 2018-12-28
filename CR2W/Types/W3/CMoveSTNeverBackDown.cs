using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTNeverBackDown : IMoveTargetPositionSteeringTask
{
#region RED Properties

[REDProp("namedTarget")]
public CName NamedTarget { get; set;}

[REDProp("customPosition")]
public CName CustomPosition { get; set;}

[REDProp("maxAngleFromTarget")]
public float MaxAngleFromTarget { get; set;}

#endregion
}
}