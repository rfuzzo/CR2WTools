using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskRiderAdjustToHorse : IBehTreeTask
{
#region RED Properties

[REDProp("riderData")]
public Handle<CAIStorageRiderData> RiderData { get; set;}

[REDProp("ticket")]
public SMovementAdjustmentRequestTicket Ticket { get; set;}

#endregion
}
}