using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleRadialMenu : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

[REDProp("m_fxBlockRadialMenuSFF")]
public Handle<CScriptedFlashFunction> M_fxBlockRadialMenuSFF { get; set;}

[REDProp("m_fxShowRadialMenuSFF")]
public Handle<CScriptedFlashFunction> M_fxShowRadialMenuSFF { get; set;}

[REDProp("m_fxUpdateItemIconSFF")]
public Handle<CScriptedFlashFunction> M_fxUpdateItemIconSFF { get; set;}

[REDProp("m_fxUpdateFieldEquippedStateSFF")]
public Handle<CScriptedFlashFunction> M_fxUpdateFieldEquippedStateSFF { get; set;}

[REDProp("m_fxSetDesaturatedSFF")]
public Handle<CScriptedFlashFunction> M_fxSetDesaturatedSFF { get; set;}

[REDProp("m_fxSetCiriRadialSFF")]
public Handle<CScriptedFlashFunction> M_fxSetCiriRadialSFF { get; set;}

[REDProp("m_fxSetCiriItemSFF")]
public Handle<CScriptedFlashFunction> M_fxSetCiriItemSFF { get; set;}

[REDProp("m_fxSetMeditationButtonEnabledSFF")]
public Handle<CScriptedFlashFunction> M_fxSetMeditationButtonEnabledSFF { get; set;}

[REDProp("m_fxSetSelectedItem")]
public Handle<CScriptedFlashFunction> M_fxSetSelectedItem { get; set;}

[REDProp("m_fxSetArabicAligmentMode")]
public Handle<CScriptedFlashFunction> M_fxSetArabicAligmentMode { get; set;}

[REDProp("m_fxUpdateInputMode")]
public Handle<CScriptedFlashFunction> M_fxUpdateInputMode { get; set;}

[REDProp("m_shown")]
public bool M_shown { get; set;}

[REDProp("m_IsPlayerCiri")]
public bool M_IsPlayerCiri { get; set;}

[REDProp("m_isDesaturated")]
public bool M_isDesaturated { get; set;}

[REDProp("m_HasBlink")]
public bool M_HasBlink { get; set;}

[REDProp("m_HasCharge")]
public bool M_HasCharge { get; set;}

[REDProp("m_allowAutoRotationReturnValue")]
public bool M_allowAutoRotationReturnValue { get; set;}

[REDProp("m_swappedAcceptCancel")]
public bool M_swappedAcceptCancel { get; set;}

[REDProp("m_tutorialsHidden")]
public bool M_tutorialsHidden { get; set;}

[REDProp("_currentSelection")]
public string _currentSelection { get; set;}

#endregion
}
}