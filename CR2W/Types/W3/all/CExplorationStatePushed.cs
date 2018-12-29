using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStatePushed : CExplorationStateAbstract
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("pushDirection")]
public Vector PushDirection { get; set;}

[REDProp("pushDirectionOther")]
public Vector PushDirectionOther { get; set;}

[REDProp("pushSide")]
public EPushSide PushSide { get; set;}

[REDProp("pushAngle")]
public float PushAngle { get; set;}

[REDProp("extraTurnAngle")]
public float ExtraTurnAngle { get; set;}

[REDProp("behCanEnd")]
public CName BehCanEnd { get; set;}

[REDProp("behSide")]
public CName BehSide { get; set;}

[REDProp("safetyEndTimeMax")]
public float SafetyEndTimeMax { get; set;}

[REDProp("safetyEndTimeCur")]
public float SafetyEndTimeCur { get; set;}

[REDProp("recheckTimeMin")]
public float RecheckTimeMin { get; set;}

[REDProp("recheckTimeCur")]
public float RecheckTimeCur { get; set;}

[REDProp("ticket")]
public SMovementAdjustmentRequestTicket Ticket { get; set;}

[REDProp("rotatedToCollider")]
public bool RotatedToCollider { get; set;}

[REDProp("movedLeft")]
public bool MovedLeft { get; set;}

#endregion
}
}