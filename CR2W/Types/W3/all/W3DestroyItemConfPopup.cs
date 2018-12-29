using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DestroyItemConfPopup : ConfirmationPopupData
{
#region RED Properties

[REDProp("menuRef")]
public Handle<CR4InventoryMenu> MenuRef { get; set;}

[REDProp("item")]
public SItemUniqueId Item { get; set;}

[REDProp("quantity")]
public Int32 Quantity { get; set;}

#endregion
}
}