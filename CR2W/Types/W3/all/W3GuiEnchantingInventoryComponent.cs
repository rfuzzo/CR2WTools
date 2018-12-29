using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3GuiEnchantingInventoryComponent : W3GuiBaseInventoryComponent
{
#region RED Properties

[REDProp("REQUIRED_SLOTS_COUNTS")]
public Int32 REQUIRED_SLOTS_COUNTS { get; set;}

#endregion
}
}