using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleDialog : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSentenceSetSFF")]
public Handle<CScriptedFlashFunction> M_fxSentenceSetSFF { get; set;}

[REDProp("m_fxPreviousSentenceSetSFF")]
public Handle<CScriptedFlashFunction> M_fxPreviousSentenceSetSFF { get; set;}

[REDProp("m_fxPreviousSentenceHideSFF")]
public Handle<CScriptedFlashFunction> M_fxPreviousSentenceHideSFF { get; set;}

[REDProp("m_fxSentenceHideSFF")]
public Handle<CScriptedFlashFunction> M_fxSentenceHideSFF { get; set;}

[REDProp("m_fxChoiceTimeoutSetSFF")]
public Handle<CScriptedFlashFunction> M_fxChoiceTimeoutSetSFF { get; set;}

[REDProp("m_fxChoiceTimeoutHideSFF")]
public Handle<CScriptedFlashFunction> M_fxChoiceTimeoutHideSFF { get; set;}

[REDProp("m_fxSkipConfirmShowSFF")]
public Handle<CScriptedFlashFunction> M_fxSkipConfirmShowSFF { get; set;}

[REDProp("m_fxSkipConfirmHideSFF")]
public Handle<CScriptedFlashFunction> M_fxSkipConfirmHideSFF { get; set;}

[REDProp("m_fxSetBarValueSFF")]
public Handle<CScriptedFlashFunction> M_fxSetBarValueSFF { get; set;}

[REDProp("m_fxSetCanBeSkipped")]
public Handle<CScriptedFlashFunction> M_fxSetCanBeSkipped { get; set;}

[REDProp("m_fxSetAlternativeDialogOptionView")]
public Handle<CScriptedFlashFunction> M_fxSetAlternativeDialogOptionView { get; set;}

[REDProp("monsterBarganingPopupMenu")]
public Handle<CR4MenuPopup> MonsterBarganingPopupMenu { get; set;}

[REDProp("m_guiManager")]
public Handle<CR4GuiManager> M_guiManager { get; set;}

[REDProp("m_LastNegotiationResult")]
public ENegotiationResult M_LastNegotiationResult { get; set;}

[REDProp("currentRewardName")]
public CName CurrentRewardName { get; set;}

[REDProp("currentRewardMultiply")]
public float CurrentRewardMultiply { get; set;}

[REDProp("isBet")]
public bool IsBet { get; set;}

[REDProp("isReverseHaggling")]
public bool IsReverseHaggling { get; set;}

[REDProp("isPopupOpened")]
public bool IsPopupOpened { get; set;}

[REDProp("isGwentMode")]
public bool IsGwentMode { get; set;}

[REDProp("anger")]
public float Anger { get; set;}

[REDProp("currentReward")]
public Int32 CurrentReward { get; set;}

[REDProp("minimalHagglingReward")]
public Int32 MinimalHagglingReward { get; set;}

[REDProp("maxHaggleValue")]
public Int32 MaxHaggleValue { get; set;}

[REDProp("NPCsPrettyClose")]
public float NPCsPrettyClose { get; set;}

[REDProp("NPCsTooMuch")]
public float NPCsTooMuch { get; set;}

[REDProp("LowestPriceControlFact")]
public string LowestPriceControlFact { get; set;}

[REDProp("lastSetChoices")]
public Array<SSceneChoice> LastSetChoices { get; set;}

#endregion
}
}