using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleControlsFeedback : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetSwordTextSFF")]
public Handle<CScriptedFlashFunction> M_fxSetSwordTextSFF { get; set;}

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

[REDProp("m_currentInputContext")]
public CName M_currentInputContext { get; set;}

[REDProp("m_previousInputContext")]
public CName M_previousInputContext { get; set;}

[REDProp("m_currentPlayerWeapon")]
public EPlayerWeapon M_currentPlayerWeapon { get; set;}

[REDProp("m_displaySprint")]
public bool M_displaySprint { get; set;}

[REDProp("m_displayJump")]
public bool M_displayJump { get; set;}

[REDProp("m_displayCallHorse")]
public bool M_displayCallHorse { get; set;}

[REDProp("m_displayDiveDown")]
public bool M_displayDiveDown { get; set;}

[REDProp("m_displayGallop")]
public bool M_displayGallop { get; set;}

[REDProp("m_displayCanter")]
public bool M_displayCanter { get; set;}

[REDProp("m_movementLockType")]
public EPlayerMovementLockType M_movementLockType { get; set;}

[REDProp("m_lastUsedPCInput")]
public bool M_lastUsedPCInput { get; set;}

[REDProp("m_CurrentHorseComp")]
public Handle<W3HorseComponent> M_CurrentHorseComp { get; set;}

[REDProp("KEY_CONTROLS_FEEDBACK_LIST")]
public string KEY_CONTROLS_FEEDBACK_LIST { get; set;}

#endregion
}
}