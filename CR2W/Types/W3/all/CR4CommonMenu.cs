using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4CommonMenu : CR4MenuBase
{
#region RED Properties

[REDProp("m_menuData")]
public Array<SMenuTab> M_menuData { get; set;}

[REDProp("m_subMenuData")]
public Array<SMenuTab> M_subMenuData { get; set;}

[REDProp("m_lastMenuName")]
public CName M_lastMenuName { get; set;}

[REDProp("m_hubEnabled")]
public bool M_hubEnabled { get; set;}

[REDProp("m_lockedInHub")]
public bool M_lockedInHub { get; set;}

[REDProp("m_lockedInMenu")]
public bool M_lockedInMenu { get; set;}

[REDProp("m_contextInputBlocked")]
public bool M_contextInputBlocked { get; set;}

[REDProp("m_fxSubMenuClosed")]
public Handle<CScriptedFlashFunction> M_fxSubMenuClosed { get; set;}

[REDProp("m_fxUpdateLevel")]
public Handle<CScriptedFlashFunction> M_fxUpdateLevel { get; set;}

[REDProp("m_fxUpdateMoney")]
public Handle<CScriptedFlashFunction> M_fxUpdateMoney { get; set;}

[REDProp("m_fxUpdateWeight")]
public Handle<CScriptedFlashFunction> M_fxUpdateWeight { get; set;}

[REDProp("m_fxNavigateNext")]
public Handle<CScriptedFlashFunction> M_fxNavigateNext { get; set;}

[REDProp("m_fxNavigatePrior")]
public Handle<CScriptedFlashFunction> M_fxNavigatePrior { get; set;}

[REDProp("m_fxSelectSubMenuTab")]
public Handle<CScriptedFlashFunction> M_fxSelectSubMenuTab { get; set;}

[REDProp("m_fxSetShopInventory")]
public Handle<CScriptedFlashFunction> M_fxSetShopInventory { get; set;}

[REDProp("m_fxUpdateTabEnabled")]
public Handle<CScriptedFlashFunction> M_fxUpdateTabEnabled { get; set;}

[REDProp("m_fxLockOpenTabNavigation")]
public Handle<CScriptedFlashFunction> M_fxLockOpenTabNavigation { get; set;}

[REDProp("m_fxBlockMenuClosing")]
public Handle<CScriptedFlashFunction> M_fxBlockMenuClosing { get; set;}

[REDProp("m_fxBlockHubClosing")]
public Handle<CScriptedFlashFunction> M_fxBlockHubClosing { get; set;}

[REDProp("m_fxSetInputFeedbackVisibility")]
public Handle<CScriptedFlashFunction> M_fxSetInputFeedbackVisibility { get; set;}

[REDProp("m_fxSetPlayerDefailsVis")]
public Handle<CScriptedFlashFunction> M_fxSetPlayerDefailsVis { get; set;}

[REDProp("m_fxSetMeditationBackgroundMode")]
public Handle<CScriptedFlashFunction> M_fxSetMeditationBackgroundMode { get; set;}

[REDProp("m_fxOnChildMenuConfigured")]
public Handle<CScriptedFlashFunction> M_fxOnChildMenuConfigured { get; set;}

[REDProp("m_fxUpdateMenuBackgroundImage")]
public Handle<CScriptedFlashFunction> M_fxUpdateMenuBackgroundImage { get; set;}

[REDProp("m_fxBlockBackNavigation")]
public Handle<CScriptedFlashFunction> M_fxBlockBackNavigation { get; set;}

[REDProp("m_fxSelectTab")]
public Handle<CScriptedFlashFunction> M_fxSelectTab { get; set;}

[REDProp("m_fxEnterCurrentTab")]
public Handle<CScriptedFlashFunction> M_fxEnterCurrentTab { get; set;}

[REDProp("m_defaultBindings")]
public Array<SKeyBinding> M_defaultBindings { get; set;}

[REDProp("m_contextBindings")]
public Array<SKeyBinding> M_contextBindings { get; set;}

[REDProp("m_GFxBindings")]
public Array<SKeyBinding> M_GFxBindings { get; set;}

[REDProp("m_contextManager")]
public Handle<W3ContextManager> M_contextManager { get; set;}

[REDProp("m_mode_meditation")]
public bool M_mode_meditation { get; set;}

[REDProp("m_had_meditation")]
public bool M_had_meditation { get; set;}

[REDProp("noSaveLock")]
public Int32 NoSaveLock { get; set;}

[REDProp("isCiri")]
public bool IsCiri { get; set;}

[REDProp("inventoryHotkey")]
public EInputKey InventoryHotkey { get; set;}

[REDProp("characterHotkey")]
public EInputKey CharacterHotkey { get; set;}

[REDProp("mapHotkey")]
public EInputKey MapHotkey { get; set;}

[REDProp("journalHotkey")]
public EInputKey JournalHotkey { get; set;}

[REDProp("alchemyHotkey")]
public EInputKey AlchemyHotkey { get; set;}

[REDProp("bestiaryHotkey")]
public EInputKey BestiaryHotkey { get; set;}

[REDProp("glossaryHotkey")]
public EInputKey GlossaryHotkey { get; set;}

[REDProp("meditationHotkey")]
public EInputKey MeditationHotkey { get; set;}

[REDProp("craftingHotkey")]
public EInputKey CraftingHotkey { get; set;}

[REDProp("isInNpcContext")]
public bool IsInNpcContext { get; set;}

[REDProp("isEnchantingAvailable")]
public bool IsEnchantingAvailable { get; set;}

[REDProp("isShopAvailable")]
public bool IsShopAvailable { get; set;}

[REDProp("isRepairAvailable")]
public bool IsRepairAvailable { get; set;}

[REDProp("isCraftingAvailable")]
public bool IsCraftingAvailable { get; set;}

[REDProp("isAlchemyAvailable")]
public bool IsAlchemyAvailable { get; set;}

[REDProp("isPlayerMeditatingInBed")]
public bool IsPlayerMeditatingInBed { get; set;}

#endregion
}
}