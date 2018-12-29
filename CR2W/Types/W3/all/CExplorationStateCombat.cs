using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateCombat : CExplorationStateAbstract
{
#region RED Properties

[REDProp("m_TimeToSlideNeededF")]
public float M_TimeToSlideNeededF { get; set;}

[REDProp("m_TimeToSlideCurF")]
public float M_TimeToSlideCurF { get; set;}

[REDProp("m_FallHasToWaitForCombatAction")]
public bool M_FallHasToWaitForCombatAction { get; set;}

[REDProp("m_SlideHasToWaitForCombatAction")]
public bool M_SlideHasToWaitForCombatAction { get; set;}

[REDProp("m_FallHorizontalImpulseCancelF")]
public float M_FallHorizontalImpulseCancelF { get; set;}

[REDProp("m_FallHorizontalImpulseF")]
public float M_FallHorizontalImpulseF { get; set;}

[REDProp("m_FallExtraVerticalImpulseF")]
public float M_FallExtraVerticalImpulseF { get; set;}

[REDProp("m_TurnAdjustTimeSprintF")]
public float M_TurnAdjustTimeSprintF { get; set;}

#endregion
}
}