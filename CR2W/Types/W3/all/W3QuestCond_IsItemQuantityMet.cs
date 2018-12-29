using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_IsItemQuantityMet : CQuestScriptedCondition
{
#region RED Properties

[REDProp("itemName")]
public CName ItemName { get; set;}

[REDProp("entityTag")]
public CName EntityTag { get; set;}

[REDProp("itemTag")]
public CName ItemTag { get; set;}

[REDProp("itemCategory")]
public CName ItemCategory { get; set;}

[REDProp("comparator")]
public ECompareOp Comparator { get; set;}

[REDProp("count")]
public Int32 Count { get; set;}

[REDProp("includeHorseInventory")]
public bool IncludeHorseInventory { get; set;}

[REDProp("ignoreTags")]
public Array<CName> IgnoreTags { get; set;}

[REDProp("inventory")]
public Handle<CInventoryComponent> Inventory { get; set;}

[REDProp("isFulfilled")]
public bool IsFulfilled { get; set;}

[REDProp("isTrophy")]
public bool IsTrophy { get; set;}

[REDProp("globalListener")]
public Handle<W3QuestCond_IsItemQuantityMet_GlobalListener> GlobalListener { get; set;}

[REDProp("inventoryListener")]
public Handle<W3QuestCond_IsItemQuantityMet_InventoryListener> InventoryListener { get; set;}

#endregion
}
}