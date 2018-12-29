using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PreparationMenu : CR4MenuBase
{
#region RED Properties

[REDProp("_gridInv")]
public Handle<W3GuiPreparationInventoryComponent> _gridInv { get; set;}

[REDProp("_inv")]
public Handle<CInventoryComponent> _inv { get; set;}

#endregion
}
}