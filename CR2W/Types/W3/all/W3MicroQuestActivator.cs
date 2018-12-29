using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MicroQuestActivator : CGameplayEntity
{
#region RED Properties

[REDProp("microQuestEntries")]
public Array<EncounterEntryDetails> MicroQuestEntries { get; set;}

[REDProp("selectedEntriesList")]
public Array<EncounterEntryDetails> SelectedEntriesList { get; set;}

[REDProp("chosenMicroQuestTag")]
public CName ChosenMicroQuestTag { get; set;}

[REDProp("isPlayerInArea")]
public bool IsPlayerInArea { get; set;}

#endregion
}
}