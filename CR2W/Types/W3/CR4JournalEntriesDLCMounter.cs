using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4JournalEntriesDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("journalEntriesFilePath")]
public Soft<CJournalInitialEntriesResource> JournalEntriesFilePath { get; set;}

#endregion
}
}