using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_ItemAmmo : CQuestScriptedCondition
{
#region RED Properties

[REDProp("itemName")]
public CName ItemName { get; set;}

[REDProp("ammoQuantity")]
public Int32 AmmoQuantity { get; set;}

[REDProp("comparator")]
public ECompareOp Comparator { get; set;}

[REDProp("isFulfilled")]
public bool IsFulfilled { get; set;}

[REDProp("ammoListener")]
public Handle<W3QuestCond_ItemAmmo_AmmoListener> AmmoListener { get; set;}

[REDProp("inventoryListener")]
public Handle<W3QuestCond_ItemAmmo_InventoryListener> InventoryListener { get; set;}

#endregion
}
}