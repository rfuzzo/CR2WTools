using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class COnTrackedQuestObjectiveHighlightedEvent : CHudEvent
{
#region RED Properties

[REDProp("journalObjective")]
public Handle<CJournalQuestObjective> JournalObjective { get; set;}

[REDProp("journalObjectiveIndex")]
public Int32 JournalObjectiveIndex { get; set;}

#endregion
}
}