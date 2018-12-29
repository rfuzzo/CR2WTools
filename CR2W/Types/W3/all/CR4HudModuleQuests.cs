using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleQuests : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_systemQuest")]
public Handle<CJournalQuest> M_systemQuest { get; set;}

[REDProp("m_systemObjectives")]
public Array<SJournalQuestObjectiveData> M_systemObjectives { get; set;}

[REDProp("m_userObjectives")]
public Array<SJournalQuestObjectiveData> M_userObjectives { get; set;}

[REDProp("m_updateEvents")]
public Array<SUpdateEvent> M_updateEvents { get; set;}

[REDProp("manager")]
public Handle<CWitcherJournalManager> Manager { get; set;}

[REDProp("m_fxShowTrackedQuestSFF")]
public Handle<CScriptedFlashFunction> M_fxShowTrackedQuestSFF { get; set;}

[REDProp("m_fxUpdateObjectiveCounterSFF")]
public Handle<CScriptedFlashFunction> M_fxUpdateObjectiveCounterSFF { get; set;}

[REDProp("m_fxUpdateObjectiveHighlightSFF")]
public Handle<CScriptedFlashFunction> M_fxUpdateObjectiveHighlightSFF { get; set;}

[REDProp("m_fxUpdateObjectiveUnhighlightAllSFF")]
public Handle<CScriptedFlashFunction> M_fxUpdateObjectiveUnhighlightAllSFF { get; set;}

[REDProp("m_fxSetSystemQuestInfo")]
public Handle<CScriptedFlashFunction> M_fxSetSystemQuestInfo { get; set;}

[REDProp("m_guiManager")]
public Handle<CR4GuiManager> M_guiManager { get; set;}

[REDProp("m_hud")]
public Handle<CR4ScriptedHud> M_hud { get; set;}

[REDProp("_highlightedObjective")]
public Handle<CJournalQuestObjective> _highlightedObjective { get; set;}

#endregion
}
}