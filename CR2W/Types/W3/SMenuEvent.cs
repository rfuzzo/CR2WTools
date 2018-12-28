using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SMenuEvent 
{
#region RED Properties

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("openedMenu")]
public CName OpenedMenu { get; set;}

[REDProp("openedJournalEntry")]
public Handle<CJournalBase> OpenedJournalEntry { get; set;}

#endregion
}
}