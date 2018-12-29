using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3CriticalStateTrap : CInteractiveEntity
{
#region RED Properties

[REDProp("effectOnSpawn")]
public CName EffectOnSpawn { get; set;}

[REDProp("effectToPlayOnActivation")]
public CName EffectToPlayOnActivation { get; set;}

[REDProp("durationFrom")]
public Int32 DurationFrom { get; set;}

[REDProp("durationTo")]
public Int32 DurationTo { get; set;}

[REDProp("areasActive")]
public bool AreasActive { get; set;}

[REDProp("movementAdjustorActive")]
public bool MovementAdjustorActive { get; set;}

[REDProp("params")]
public SCustomEffectParams Params { get; set;}

[REDProp("movementAdjustor")]
public Handle<CMovementAdjustor> MovementAdjustor { get; set;}

[REDProp("ticket")]
public SMovementAdjustmentRequestTicket Ticket { get; set;}

[REDProp("ticketRot")]
public SMovementAdjustmentRequestTicket TicketRot { get; set;}

[REDProp("lifeTime")]
public Int32 LifeTime { get; set;}

[REDProp("l_effectDuration")]
public Int32 L_effectDuration { get; set;}

[REDProp("startTimestamp")]
public float StartTimestamp { get; set;}

[REDProp("enterTimestamp")]
public float EnterTimestamp { get; set;}

#endregion
}
}