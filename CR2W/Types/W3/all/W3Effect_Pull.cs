using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_Pull : W3ImmobilizeEffect
{
#region RED Properties

[REDProp("movementAdjustor")]
public Handle<CMovementAdjustor> MovementAdjustor { get; set;}

[REDProp("ticket")]
public SMovementAdjustmentRequestTicket Ticket { get; set;}

#endregion
}
}