using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_IsItemQuantityMet_InventoryListener : IInventoryScriptedListener
{
#region RED Properties

[REDProp("condition")]
public Handle<W3QuestCond_IsItemQuantityMet> Condition { get; set;}

#endregion
}
}