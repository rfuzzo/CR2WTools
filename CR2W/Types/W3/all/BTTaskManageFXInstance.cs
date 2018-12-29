using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageFXInstance : IBehTreeTask
{
#region RED Properties

[REDProp("hasAbilityCondition")]
public CName HasAbilityCondition { get; set;}

[REDProp("fxName")]
public CName FxName { get; set;}

[REDProp("fxTickets")]
public Int32 FxTickets { get; set;}

[REDProp("distanceToAnotherFx")]
public float DistanceToAnotherFx { get; set;}

[REDProp("fxInstanceCheckInterval")]
public float FxInstanceCheckInterval { get; set;}

[REDProp("stopFxAfterDeath")]
public bool StopFxAfterDeath { get; set;}

[REDProp("npcPos")]
public Vector NpcPos { get; set;}

[REDProp("fxInstances")]
public Int32 FxInstances { get; set;}

#endregion
}
}