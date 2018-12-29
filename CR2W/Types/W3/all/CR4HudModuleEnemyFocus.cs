using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleEnemyFocus : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetEnemyName")]
public Handle<CScriptedFlashFunction> M_fxSetEnemyName { get; set;}

[REDProp("m_fxSetEnemyLevel")]
public Handle<CScriptedFlashFunction> M_fxSetEnemyLevel { get; set;}

[REDProp("m_fxSetAttitude")]
public Handle<CScriptedFlashFunction> M_fxSetAttitude { get; set;}

[REDProp("m_fxSetEnemyHealth")]
public Handle<CScriptedFlashFunction> M_fxSetEnemyHealth { get; set;}

[REDProp("m_fxSetEnemyStamina")]
public Handle<CScriptedFlashFunction> M_fxSetEnemyStamina { get; set;}

[REDProp("m_fxSetEssenceBarVisibility")]
public Handle<CScriptedFlashFunction> M_fxSetEssenceBarVisibility { get; set;}

[REDProp("m_fxSetStaminaVisibility")]
public Handle<CScriptedFlashFunction> M_fxSetStaminaVisibility { get; set;}

[REDProp("m_fxSetNPCQuestIcon")]
public Handle<CScriptedFlashFunction> M_fxSetNPCQuestIcon { get; set;}

[REDProp("m_fxSetDodgeFeedback")]
public Handle<CScriptedFlashFunction> M_fxSetDodgeFeedback { get; set;}

[REDProp("m_fxSetBossOrDead")]
public Handle<CScriptedFlashFunction> M_fxSetBossOrDead { get; set;}

[REDProp("m_fxSetShowHardLock")]
public Handle<CScriptedFlashFunction> M_fxSetShowHardLock { get; set;}

[REDProp("m_fxSetDamageText")]
public Handle<CScriptedFlashFunction> M_fxSetDamageText { get; set;}

[REDProp("m_fxHideDamageText")]
public Handle<CScriptedFlashFunction> M_fxHideDamageText { get; set;}

[REDProp("m_fxSetGeneralVisibility")]
public Handle<CScriptedFlashFunction> M_fxSetGeneralVisibility { get; set;}

[REDProp("m_fxSetMutationEightVisibility")]
public Handle<CScriptedFlashFunction> M_fxSetMutationEightVisibility { get; set;}

[REDProp("m_mcNPCFocus")]
public Handle<CScriptedFlashSprite> M_mcNPCFocus { get; set;}

[REDProp("m_lastTarget")]
public Handle<CGameplayEntity> M_lastTarget { get; set;}

[REDProp("m_lastTargetAttitude")]
public EAIAttitude M_lastTargetAttitude { get; set;}

[REDProp("m_lastHealthPercentage")]
public Int32 M_lastHealthPercentage { get; set;}

[REDProp("m_wasAxiied")]
public bool M_wasAxiied { get; set;}

[REDProp("m_lastStaminaPercentage")]
public Int32 M_lastStaminaPercentage { get; set;}

[REDProp("m_nameInterval")]
public float M_nameInterval { get; set;}

[REDProp("m_lastEnemyDifferenceLevel")]
public string M_lastEnemyDifferenceLevel { get; set;}

[REDProp("m_lastEnemyLevelString")]
public string M_lastEnemyLevelString { get; set;}

[REDProp("m_lastDodgeFeedbackTarget")]
public Handle<CActor> M_lastDodgeFeedbackTarget { get; set;}

[REDProp("m_lastEnemyName")]
public string M_lastEnemyName { get; set;}

[REDProp("m_lastUseMutation8Icon")]
public bool M_lastUseMutation8Icon { get; set;}

#endregion
}
}