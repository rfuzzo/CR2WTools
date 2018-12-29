using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ItemInfoPopupData : TextPopupData
{
#region RED Properties

[REDProp("invRef")]
public Handle<CInventoryComponent> InvRef { get; set;}

[REDProp("itemId")]
public SItemUniqueId ItemId { get; set;}

[REDProp("inventoryRef")]
public Handle<CR4InventoryMenu> InventoryRef { get; set;}

[REDProp("invComponent")]
public Handle<CInventoryComponent> InvComponent { get; set;}

#endregion
}
}