using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4JournalQuestMenu : CR4ListBaseMenu
{
#region RED Properties

[REDProp("allQuests")]
public Array<Handle<CJournalQuest>> AllQuests { get; set;}

[REDProp("currentObjectives")]
public Array<Handle<CJournalQuestObjective>> CurrentObjectives { get; set;}

[REDProp("initialTrackedQuest")]
public Handle<CJournalQuest> InitialTrackedQuest { get; set;}

[REDProp("bDisplayCompleted")]
public bool BDisplayCompleted { get; set;}

[REDProp("m_initSelection")]
public bool M_initSelection { get; set;}

[REDProp("lastSelectedQuestTag")]
public CName LastSelectedQuestTag { get; set;}

[REDProp("m_fxSetTrackedQuest")]
public Handle<CScriptedFlashFunction> M_fxSetTrackedQuest { get; set;}

[REDProp("m_fxSetTrackedObj")]
public Handle<CScriptedFlashFunction> M_fxSetTrackedObj { get; set;}

[REDProp("m_fxSetTitle")]
public Handle<CScriptedFlashFunction> M_fxSetTitle { get; set;}

[REDProp("m_fxSetText")]
public Handle<CScriptedFlashFunction> M_fxSetText { get; set;}

[REDProp("m_fxSetExpansionTexture")]
public Handle<CScriptedFlashFunction> M_fxSetExpansionTexture { get; set;}

[REDProp("m_fxUpdateExpansionIcon")]
public Handle<CScriptedFlashFunction> M_fxUpdateExpansionIcon { get; set;}

#endregion
}
}