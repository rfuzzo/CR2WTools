using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_Container : CQuestScriptedCondition
{
#region RED Properties

[REDProp("containerTag")]
public CName ContainerTag { get; set;}

[REDProp("contents")]
public EContainerMode Contents { get; set;}

[REDProp("inventory")]
public Handle<CInventoryComponent> Inventory { get; set;}

[REDProp("isFulfilled")]
public bool IsFulfilled { get; set;}

[REDProp("globalListener")]
public Handle<W3QuestCond_Container_GlobalListener> GlobalListener { get; set;}

[REDProp("inventoryListener")]
public Handle<W3QuestCond_Container_InventoryListener> InventoryListener { get; set;}

#endregion
}
}