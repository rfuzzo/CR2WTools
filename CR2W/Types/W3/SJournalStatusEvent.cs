using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SJournalStatusEvent : SJournalEvent
{
#region RED Properties

[REDProp("oldStatus")]
public EJournalStatus OldStatus { get; set;}

[REDProp("newStatus")]
public EJournalStatus NewStatus { get; set;}

[REDProp("silent")]
public bool Silent { get; set;}

#endregion
}
}