using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4LocomotionDirectController : CObject
{
#region RED Properties

[REDProp("agent")]
public Handle<CMovingAgentComponent> Agent { get; set;}

[REDProp("moveSpeed")]
public float MoveSpeed { get; set;}

[REDProp("moveRotation")]
public float MoveRotation { get; set;}

#endregion
}
}