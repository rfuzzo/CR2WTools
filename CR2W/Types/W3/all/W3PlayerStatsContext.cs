using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PlayerStatsContext : W3UIContext
{
#region RED Properties

[REDProp("invMenuRef")]
public Handle<CR4InventoryMenu> InvMenuRef { get; set;}

[REDProp("statName")]
public CName StatName { get; set;}

#endregion
}
}