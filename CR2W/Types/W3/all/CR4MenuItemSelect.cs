using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4MenuItemSelect : CR4OverlayMenu
{
#region RED Properties

[REDProp("_itemsInv")]
public Handle<W3GuiItemSelectComponent> _itemsInv { get; set;}

[REDProp("_invComponent")]
public Handle<CInventoryComponent> _invComponent { get; set;}

[REDProp("_initData")]
public Handle<W3ItemSelectMenuInitData> _initData { get; set;}

#endregion
}
}