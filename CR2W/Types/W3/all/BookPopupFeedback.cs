using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BookPopupFeedback : TextPopupData
{
#region RED Properties

[REDProp("bookItemId")]
public SItemUniqueId BookItemId { get; set;}

[REDProp("inventoryRef")]
public Handle<CR4InventoryMenu> InventoryRef { get; set;}

[REDProp("singleBookMode")]
public bool SingleBookMode { get; set;}

[REDProp("curInventory")]
public Handle<CInventoryComponent> CurInventory { get; set;}

#endregion
}
}