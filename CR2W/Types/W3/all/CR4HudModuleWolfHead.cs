using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleWolfHead : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetVitality")]
public Handle<CScriptedFlashFunction> M_fxSetVitality { get; set;}

[REDProp("m_fxSetStamina")]
public Handle<CScriptedFlashFunction> M_fxSetStamina { get; set;}

[REDProp("m_fxSetToxicity")]
public Handle<CScriptedFlashFunction> M_fxSetToxicity { get; set;}

[REDProp("m_fxSetExperience")]
public Handle<CScriptedFlashFunction> M_fxSetExperience { get; set;}

[REDProp("m_fxSetLockedToxicity")]
public Handle<CScriptedFlashFunction> M_fxSetLockedToxicity { get; set;}

[REDProp("m_fxSetDeadlyToxicity")]
public Handle<CScriptedFlashFunction> M_fxSetDeadlyToxicity { get; set;}

[REDProp("m_fxShowStaminaNeeded")]
public Handle<CScriptedFlashFunction> M_fxShowStaminaNeeded { get; set;}

[REDProp("m_fxSwitchWolfActivation")]
public Handle<CScriptedFlashFunction> M_fxSwitchWolfActivation { get; set;}

[REDProp("m_fxSetSignIconSFF")]
public Handle<CScriptedFlashFunction> M_fxSetSignIconSFF { get; set;}

[REDProp("m_fxSetSignTextSFF")]
public Handle<CScriptedFlashFunction> M_fxSetSignTextSFF { get; set;}

[REDProp("m_fxSetFocusPointsSFF")]
public Handle<CScriptedFlashFunction> M_fxSetFocusPointsSFF { get; set;}

[REDProp("m_fxSetFocusProgressSFF")]
public Handle<CScriptedFlashFunction> M_fxSetFocusProgressSFF { get; set;}

[REDProp("m_fxLockFocusPointsSFF")]
public Handle<CScriptedFlashFunction> M_fxLockFocusPointsSFF { get; set;}

[REDProp("m_fxSetCiriAsMainCharacter")]
public Handle<CScriptedFlashFunction> M_fxSetCiriAsMainCharacter { get; set;}

[REDProp("m_fxSetCoatOfArms")]
public Handle<CScriptedFlashFunction> M_fxSetCoatOfArms { get; set;}

[REDProp("m_fxSetShowNewLevelIndicator")]
public Handle<CScriptedFlashFunction> M_fxSetShowNewLevelIndicator { get; set;}

[REDProp("m_fxSetAlwaysDisplayed")]
public Handle<CScriptedFlashFunction> M_fxSetAlwaysDisplayed { get; set;}

[REDProp("m_fxshowMutationFeedback")]
public Handle<CScriptedFlashFunction> M_fxshowMutationFeedback { get; set;}

[REDProp("m_LastVitality")]
public float M_LastVitality { get; set;}

[REDProp("m_LastMaxVitality")]
public float M_LastMaxVitality { get; set;}

[REDProp("m_LastStamina")]
public float M_LastStamina { get; set;}

[REDProp("m_LastMaxStamina")]
public float M_LastMaxStamina { get; set;}

[REDProp("m_LastExperience")]
public float M_LastExperience { get; set;}

[REDProp("m_LastMaxExperience")]
public float M_LastMaxExperience { get; set;}

[REDProp("m_LastToxicity")]
public float M_LastToxicity { get; set;}

[REDProp("m_LastLockedToxicity")]
public float M_LastLockedToxicity { get; set;}

[REDProp("m_LastMaxToxicity")]
public float M_LastMaxToxicity { get; set;}

[REDProp("m_bLastDeadlyToxicity")]
public bool M_bLastDeadlyToxicity { get; set;}

[REDProp("m_medallionActivated")]
public bool M_medallionActivated { get; set;}

[REDProp("m_oveloadedIconVisible")]
public bool M_oveloadedIconVisible { get; set;}

[REDProp("m_focusPoints")]
public Int32 M_focusPoints { get; set;}

[REDProp("m_focusProgress")]
public float M_focusProgress { get; set;}

[REDProp("m_iCurrentPositiveEffectsSize")]
public Int32 M_iCurrentPositiveEffectsSize { get; set;}

[REDProp("m_iCurrentNegativeEffectsSize")]
public Int32 M_iCurrentNegativeEffectsSize { get; set;}

[REDProp("m_signIconName")]
public string M_signIconName { get; set;}

[REDProp("m_CurrentSelectedSign")]
public ESignType M_CurrentSelectedSign { get; set;}

[REDProp("m_IsPlayerCiri")]
public bool M_IsPlayerCiri { get; set;}

[REDProp("m_curToxicity")]
public float M_curToxicity { get; set;}

[REDProp("m_lockedToxicity")]
public float M_lockedToxicity { get; set;}

[REDProp("m_curVitality")]
public float M_curVitality { get; set;}

[REDProp("m_maxVitality")]
public float M_maxVitality { get; set;}

[REDProp("playStaminaSoundCue")]
public bool PlayStaminaSoundCue { get; set;}

#endregion
}
}