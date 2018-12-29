using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4MeditationClockMenu : CR4MenuBase
{
#region RED Properties

[REDProp("m_fxSetBlockMeditation")]
public Handle<CScriptedFlashFunction> M_fxSetBlockMeditation { get; set;}

[REDProp("m_fxSetCanMeditate")]
public Handle<CScriptedFlashFunction> M_fxSetCanMeditate { get; set;}

[REDProp("m_fxSetBonusMeditationTime")]
public Handle<CScriptedFlashFunction> M_fxSetBonusMeditationTime { get; set;}

[REDProp("m_fxSetGeraltBackgroundVisible")]
public Handle<CScriptedFlashFunction> M_fxSetGeraltBackgroundVisible { get; set;}

[REDProp("m_fxSet24HRFormat")]
public Handle<CScriptedFlashFunction> M_fxSet24HRFormat { get; set;}

[REDProp("canMeditateWait")]
public bool CanMeditateWait { get; set;}

[REDProp("isGameTimePaused")]
public bool IsGameTimePaused { get; set;}

[REDProp("BONUS_MEDITATION_TIME")]
public Int32 BONUS_MEDITATION_TIME { get; set;}

#endregion
}
}