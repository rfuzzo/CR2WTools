using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleStatBars : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetVitalitySFF")]
public Handle<CScriptedFlashFunction> M_fxSetVitalitySFF { get; set;}

[REDProp("m_fxSetStaminaSFF")]
public Handle<CScriptedFlashFunction> M_fxSetStaminaSFF { get; set;}

[REDProp("m_fxSetToxicitySFF")]
public Handle<CScriptedFlashFunction> M_fxSetToxicitySFF { get; set;}

[REDProp("m_fxSetExperienceSFF")]
public Handle<CScriptedFlashFunction> M_fxSetExperienceSFF { get; set;}

[REDProp("m_fxSetLevelUpVisibleSFF")]
public Handle<CScriptedFlashFunction> M_fxSetLevelUpVisibleSFF { get; set;}

[REDProp("m_fxStartHeavyAttackIndicatorAnimationSFF")]
public Handle<CScriptedFlashFunction> M_fxStartHeavyAttackIndicatorAnimationSFF { get; set;}

[REDProp("m_fxStopHeavyAttackIndicatorAnimationSFF")]
public Handle<CScriptedFlashFunction> M_fxStopHeavyAttackIndicatorAnimationSFF { get; set;}

[REDProp("m_fxShowStatbarsGlowSFF")]
public Handle<CScriptedFlashFunction> M_fxShowStatbarsGlowSFF { get; set;}

[REDProp("m_fxHideStatbarsGlowSFF")]
public Handle<CScriptedFlashFunction> M_fxHideStatbarsGlowSFF { get; set;}

[REDProp("m_fxShowStaminaIndicatorSFF")]
public Handle<CScriptedFlashFunction> M_fxShowStaminaIndicatorSFF { get; set;}

[REDProp("_vitality")]
public float _vitality { get; set;}

[REDProp("_stamina")]
public float _stamina { get; set;}

[REDProp("_toxicity")]
public float _toxicity { get; set;}

[REDProp("_experience")]
public Int32 _experience { get; set;}

[REDProp("_maxVitality")]
public float _maxVitality { get; set;}

[REDProp("_maxStamina")]
public float _maxStamina { get; set;}

[REDProp("_maxToxicity")]
public float _maxToxicity { get; set;}

[REDProp("_maxExperience")]
public Int32 _maxExperience { get; set;}

[REDProp("_showLevelUp")]
public bool _showLevelUp { get; set;}

[REDProp("_currentLevel")]
public Int32 _currentLevel { get; set;}

[REDProp("_heavyAttackIndicatorSpeed")]
public Int32 _heavyAttackIndicatorSpeed { get; set;}

[REDProp("_heavyAttackGlowDurration")]
public Int32 _heavyAttackGlowDurration { get; set;}

[REDProp("_heavyAttackSecondLevelIndicatorSpeed")]
public Int32 _heavyAttackSecondLevelIndicatorSpeed { get; set;}

[REDProp("_heavyAttackSecondLevelGlowDurration")]
public Int32 _heavyAttackSecondLevelGlowDurration { get; set;}

[REDProp("_duringHeavyAttackAnimation")]
public bool _duringHeavyAttackAnimation { get; set;}

[REDProp("_bHeavyAttackFirstLevel")]
public bool _bHeavyAttackFirstLevel { get; set;}

#endregion
}
}