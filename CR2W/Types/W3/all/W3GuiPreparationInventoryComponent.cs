using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3GuiPreparationInventoryComponent : W3GuiPlayerInventoryComponent
{
#region RED Properties

[REDProp("_equippedFilter")]
public bool _equippedFilter { get; set;}

[REDProp("_categoryFilter")]
public bool _categoryFilter { get; set;}

[REDProp("_categoryFilterValue")]
public EPreporationItemType _categoryFilterValue { get; set;}

#endregion
}
}