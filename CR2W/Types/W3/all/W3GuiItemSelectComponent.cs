using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3GuiItemSelectComponent : W3GuiPlayerInventoryComponent
{
#region RED Properties

[REDProp("_filterData")]
public Handle<W3ItemSelectMenuInitData> _filterData { get; set;}

#endregion
}
}