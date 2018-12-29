using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SJournalQuestObjectiveData 
{
#region RED Properties

[REDProp("status")]
public EJournalStatus Status { get; set;}

[REDProp("objectiveEntry")]
public Handle<CJournalQuestObjective> ObjectiveEntry { get; set;}

#endregion
}
}