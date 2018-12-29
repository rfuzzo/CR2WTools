using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4EnchantingMenu : CR4MenuBase
{
#region RED Properties

[REDProp("m_fxEnableRemovingEnchantment")]
public Handle<CScriptedFlashFunction> M_fxEnableRemovingEnchantment { get; set;}

[REDProp("m_fxEnableEnchantment")]
public Handle<CScriptedFlashFunction> M_fxEnableEnchantment { get; set;}

[REDProp("m_fxSetFilters")]
public Handle<CScriptedFlashFunction> M_fxSetFilters { get; set;}

[REDProp("m_fxSetLocalization")]
public Handle<CScriptedFlashFunction> M_fxSetLocalization { get; set;}

[REDProp("m_fxStartApplying")]
public Handle<CScriptedFlashFunction> M_fxStartApplying { get; set;}

[REDProp("m_fxStartRemoving")]
public Handle<CScriptedFlashFunction> M_fxStartRemoving { get; set;}

[REDProp("m_fxSelectFirstEnchantment")]
public Handle<CScriptedFlashFunction> M_fxSelectFirstEnchantment { get; set;}

[REDProp("m_fxSetPinnedRecipe")]
public Handle<CScriptedFlashFunction> M_fxSetPinnedRecipe { get; set;}

[REDProp("m_definitionsManager")]
public Handle<CDefinitionsManagerAccessor> M_definitionsManager { get; set;}

[REDProp("m_tooltipDataProvider")]
public Handle<W3TooltipComponent> M_tooltipDataProvider { get; set;}

[REDProp("m_playerInvComponent")]
public Handle<W3GuiEnchantingInventoryComponent> M_playerInvComponent { get; set;}

[REDProp("m_playerInventory")]
public Handle<CInventoryComponent> M_playerInventory { get; set;}

[REDProp("m_enchanterInventory")]
public Handle<CInventoryComponent> M_enchanterInventory { get; set;}

[REDProp("m_enchanterNpc")]
public Handle<CNewNPC> M_enchanterNpc { get; set;}

[REDProp("m_craftsmanComponent")]
public Handle<W3CraftsmanComponent> M_craftsmanComponent { get; set;}

[REDProp("m_enchantmentManager")]
public Handle<W3EnchantmentManager> M_enchantmentManager { get; set;}

[REDProp("m_runewordsList")]
public Array<CName> M_runewordsList { get; set;}

[REDProp("m_glyphwordsList")]
public Array<CName> M_glyphwordsList { get; set;}

[REDProp("m_allWordsList")]
public Array<CName> M_allWordsList { get; set;}

[REDProp("m_runewordsData")]
public Handle<CScriptedFlashArray> M_runewordsData { get; set;}

[REDProp("m_glyphwordsData")]
public Handle<CScriptedFlashArray> M_glyphwordsData { get; set;}

[REDProp("m_allwordsData")]
public Handle<CScriptedFlashArray> M_allwordsData { get; set;}

[REDProp("m_initDataConfirmation")]
public Handle<EnchantingConfirmationPopupData> M_initDataConfirmation { get; set;}

[REDProp("m_selectedEnchantment")]
public CName M_selectedEnchantment { get; set;}

[REDProp("m_readonly")]
public bool M_readonly { get; set;}

[REDProp("m_notEnoughSlots")]
public bool M_notEnoughSlots { get; set;}

[REDProp("m_prevItem")]
public SItemUniqueId M_prevItem { get; set;}

[REDProp("TYPE_RUNEWORD")]
public Int32 TYPE_RUNEWORD { get; set;}

[REDProp("TYPE_GLYPHWORD")]
public Int32 TYPE_GLYPHWORD { get; set;}

[REDProp("tutorialTriggered")]
public bool TutorialTriggered { get; set;}

#endregion
}
}