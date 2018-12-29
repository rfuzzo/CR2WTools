using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3GuiBaseInventoryComponent : CObject
{
#region RED Properties

[REDProp("autoCleanNewMark")]
public bool AutoCleanNewMark { get; set;}

[REDProp("_inv")]
public Handle<CInventoryComponent> _inv { get; set;}

[REDProp("highlightedItems")]
public Array<CName> HighlightedItems { get; set;}

[REDProp("ITEM_NEED_REPAIR_DISPLAY_VALUE")]
public Int32 ITEM_NEED_REPAIR_DISPLAY_VALUE { get; set;}

#endregion
}
}