using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleItemInfo : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_currentItemSelected")]
public SItemUniqueId M_currentItemSelected { get; set;}

[REDProp("m_currentItemOnSlot1")]
public SItemUniqueId M_currentItemOnSlot1 { get; set;}

[REDProp("m_currentItemOnSlot2")]
public SItemUniqueId M_currentItemOnSlot2 { get; set;}

[REDProp("m_currentItemOnSlot3")]
public SItemUniqueId M_currentItemOnSlot3 { get; set;}

[REDProp("m_currentItemOnSlot4")]
public SItemUniqueId M_currentItemOnSlot4 { get; set;}

[REDProp("m_lastBoltItem")]
public SItemUniqueId M_lastBoltItem { get; set;}

[REDProp("m_currentItemSelectedAmmo")]
public Int32 M_currentItemSelectedAmmo { get; set;}

[REDProp("m_currentItemOnSlot1Ammo")]
public Int32 M_currentItemOnSlot1Ammo { get; set;}

[REDProp("m_currentItemOnSlot2Ammo")]
public Int32 M_currentItemOnSlot2Ammo { get; set;}

[REDProp("m_currentItemOnSlot3Ammo")]
public Int32 M_currentItemOnSlot3Ammo { get; set;}

[REDProp("m_currentItemOnSlot4Ammo")]
public Int32 M_currentItemOnSlot4Ammo { get; set;}

[REDProp("m_fxEnableSFF")]
public Handle<CScriptedFlashFunction> M_fxEnableSFF { get; set;}

[REDProp("m_fxUpdateElementSFF")]
public Handle<CScriptedFlashFunction> M_fxUpdateElementSFF { get; set;}

[REDProp("m_fxHideSlotsSFF")]
public Handle<CScriptedFlashFunction> M_fxHideSlotsSFF { get; set;}

[REDProp("m_fxSetAlwaysDisplayed")]
public Handle<CScriptedFlashFunction> M_fxSetAlwaysDisplayed { get; set;}

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

[REDProp("m_fxSetItemInfo")]
public Handle<CScriptedFlashFunction> M_fxSetItemInfo { get; set;}

[REDProp("m_fxSwitchAnimation")]
public Handle<CScriptedFlashFunction> M_fxSwitchAnimation { get; set;}

[REDProp("m_fxShowButtonHints")]
public Handle<CScriptedFlashFunction> M_fxShowButtonHints { get; set;}

[REDProp("m_IsPlayerCiri")]
public bool M_IsPlayerCiri { get; set;}

[REDProp("m_runword6Applied")]
public bool M_runword6Applied { get; set;}

[REDProp("m_previousShowButtonHints")]
public Int32 M_previousShowButtonHints { get; set;}

[REDProp("m_previousSetItemInfo")]
public Array<SHudItemInfo> M_previousSetItemInfo { get; set;}

#endregion
}
}