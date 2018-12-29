using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class QuantityPopupData : SliderPopupData
{
#region RED Properties

[REDProp("itemId")]
public SItemUniqueId ItemId { get; set;}

[REDProp("itemCost")]
public float ItemCost { get; set;}

[REDProp("showPrice")]
public bool ShowPrice { get; set;}

[REDProp("actionType")]
public EQuantityTransferFunction ActionType { get; set;}

[REDProp("inventoryRef")]
public Handle<CR4InventoryMenu> InventoryRef { get; set;}

[REDProp("blacksmithRef")]
public Handle<CR4BlacksmithMenu> BlacksmithRef { get; set;}

[REDProp("craftingRef")]
public Handle<CR4CraftingMenu> CraftingRef { get; set;}

#endregion
}
}