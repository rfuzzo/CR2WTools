using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIWalkToTargetWaitingForActorAction : IAIActionTree
{
#region RED Properties

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("moveSpeed")]
public float MoveSpeed { get; set;}

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("waitForTag")]
public CName WaitForTag { get; set;}

[REDProp("timeout")]
public float Timeout { get; set;}

[REDProp("testDistance")]
public float TestDistance { get; set;}

#endregion
}
}