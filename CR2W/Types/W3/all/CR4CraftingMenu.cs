using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4CraftingMenu : CR4ListBaseMenu
{
#region RED Properties

[REDProp("m_definitionsManager")]
public Handle<CDefinitionsManagerAccessor> M_definitionsManager { get; set;}

[REDProp("bCouldCraft")]
public bool BCouldCraft { get; set;}

[REDProp("_inv")]
public Handle<CInventoryComponent> _inv { get; set;}

[REDProp("_playerInv")]
public Handle<W3GuiPlayerInventoryComponent> _playerInv { get; set;}

[REDProp("m_craftingManager")]
public Handle<W3CraftingManager> M_craftingManager { get; set;}

[REDProp("m_schematicList")]
public Array<CName> M_schematicList { get; set;}

[REDProp("m_npc")]
public Handle<CNewNPC> M_npc { get; set;}

[REDProp("m_npcInventory")]
public Handle<CInventoryComponent> M_npcInventory { get; set;}

[REDProp("m_shopInvComponent")]
public Handle<W3GuiShopInventoryComponent> M_shopInvComponent { get; set;}

[REDProp("m_lastSelectedTag")]
public CName M_lastSelectedTag { get; set;}

[REDProp("_craftsmanComponent")]
public Handle<W3CraftsmanComponent> _craftsmanComponent { get; set;}

[REDProp("_quantityPopupData")]
public Handle<QuantityPopupData> _quantityPopupData { get; set;}

[REDProp("m_fxSetCraftingEnabled")]
public Handle<CScriptedFlashFunction> M_fxSetCraftingEnabled { get; set;}

[REDProp("m_fxSetCraftedItem")]
public Handle<CScriptedFlashFunction> M_fxSetCraftedItem { get; set;}

[REDProp("m_fxHideContent")]
public Handle<CScriptedFlashFunction> M_fxHideContent { get; set;}

[REDProp("m_fxSetFilters")]
public Handle<CScriptedFlashFunction> M_fxSetFilters { get; set;}

[REDProp("m_fxSetPinnedRecipe")]
public Handle<CScriptedFlashFunction> M_fxSetPinnedRecipe { get; set;}

[REDProp("m_fxSetMerchantCheck")]
public Handle<CScriptedFlashFunction> M_fxSetMerchantCheck { get; set;}

[REDProp("itemsQuantity")]
public Array<Int32> ItemsQuantity { get; set;}

#endregion
}
}