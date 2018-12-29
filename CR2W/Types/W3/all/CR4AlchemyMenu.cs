using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4AlchemyMenu : CR4ListBaseMenu
{
#region RED Properties

[REDProp("m_alchemyManager")]
public Handle<W3AlchemyManager> M_alchemyManager { get; set;}

[REDProp("m_recipeList")]
public Array<SAlchemyRecipe> M_recipeList { get; set;}

[REDProp("m_definitionsManager")]
public Handle<CDefinitionsManagerAccessor> M_definitionsManager { get; set;}

[REDProp("bCouldCraft")]
public bool BCouldCraft { get; set;}

[REDProp("_inv")]
public Handle<CInventoryComponent> _inv { get; set;}

[REDProp("_playerInv")]
public Handle<W3GuiPlayerInventoryComponent> _playerInv { get; set;}

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

[REDProp("itemsQuantity")]
public Array<Int32> ItemsQuantity { get; set;}

#endregion
}
}