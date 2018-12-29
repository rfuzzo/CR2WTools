using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3InventoryItemContext : W3UIContext
{
#region RED Properties

[REDProp("currentItemId")]
public SItemUniqueId CurrentItemId { get; set;}

[REDProp("currentSlot")]
public EEquipmentSlots CurrentSlot { get; set;}

[REDProp("invMenuRef")]
public Handle<CR4InventoryMenu> InvMenuRef { get; set;}

[REDProp("invComponentRef")]
public Handle<CInventoryComponent> InvComponentRef { get; set;}

[REDProp("invSecondComponentRef")]
public Handle<CInventoryComponent> InvSecondComponentRef { get; set;}

[REDProp("contextMenuPosition_x")]
public float ContextMenuPosition_x { get; set;}

[REDProp("contextMenuPosition_y")]
public float ContextMenuPosition_y { get; set;}

#endregion
}
}