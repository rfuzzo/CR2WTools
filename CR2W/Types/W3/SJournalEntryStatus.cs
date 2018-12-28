using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SJournalEntryStatus 
{
#region RED Properties

[REDProp("entry")]
public Ptr<CJournalBase> Entry { get; set;}

[REDProp("status")]
public EJournalStatus Status { get; set;}

[REDProp("unread")]
public bool Unread { get; set;}

#endregion
}
}