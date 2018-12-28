using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQCIsOpenedJournalEntry : IUIConditionType
{
#region RED Properties

[REDProp("journalEntryToBeOpened")]
public Handle<CJournalPath> JournalEntryToBeOpened { get; set;}

#endregion
}
}