using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleJournalUpdate : CR4HudModuleBase
{
#region RED Properties

[REDProp("_bDuringDisplay")]
public bool _bDuringDisplay { get; set;}

[REDProp("m_fxShowJournalUpdateSFF")]
public Handle<CScriptedFlashFunction> M_fxShowJournalUpdateSFF { get; set;}

[REDProp("m_fxSetJournalUpdateStatusSFF")]
public Handle<CScriptedFlashFunction> M_fxSetJournalUpdateStatusSFF { get; set;}

[REDProp("m_fxSetJournalUpdateStatusTextSFF")]
public Handle<CScriptedFlashFunction> M_fxSetJournalUpdateStatusTextSFF { get; set;}

[REDProp("m_fxClearJournalUpdateSFF")]
public Handle<CScriptedFlashFunction> M_fxClearJournalUpdateSFF { get; set;}

[REDProp("m_fxSetIconSFF")]
public Handle<CScriptedFlashFunction> M_fxSetIconSFF { get; set;}

[REDProp("m_fxHideItemInfo")]
public Handle<CScriptedFlashFunction> M_fxHideItemInfo { get; set;}

[REDProp("m_fxPauseShowTimer")]
public Handle<CScriptedFlashFunction> M_fxPauseShowTimer { get; set;}

[REDProp("questsUpdates")]
public Array<Handle<CJournalQuest>> QuestsUpdates { get; set;}

[REDProp("journalUpdates")]
public Array<SJournalUpdate> JournalUpdates { get; set;}

[REDProp("manager")]
public Handle<CWitcherJournalManager> Manager { get; set;}

[REDProp("m_guiManager")]
public Handle<CR4GuiManager> M_guiManager { get; set;}

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

[REDProp("m_defaultInputBindings")]
public Array<SKeyBinding> M_defaultInputBindings { get; set;}

[REDProp("m_bookItemId")]
public SItemUniqueId M_bookItemId { get; set;}

[REDProp("m_bookPopupData")]
public Handle<BookPopupFeedback> M_bookPopupData { get; set;}

[REDProp("m_paintingPopupData")]
public Handle<PaintingPopup> M_paintingPopupData { get; set;}

[REDProp("bShowTimerStopped")]
public bool BShowTimerStopped { get; set;}

[REDProp("bWasRemoved")]
public bool BWasRemoved { get; set;}

[REDProp("defaultDisplayTime")]
public float DefaultDisplayTime { get; set;}

[REDProp("defaultBookInfoDisplayTime")]
public float DefaultBookInfoDisplayTime { get; set;}

[REDProp("defaultTrackableDisplayTime")]
public float DefaultTrackableDisplayTime { get; set;}

#endregion
}
}