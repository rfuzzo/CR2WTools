using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ISpawnTreeAddItemInitializer : ISpawnTreeScriptedInitializer
{
#region RED Properties

[REDProp("items")]
public Array<SItemExt> Items { get; set;}

[REDProp("randomize")]
public bool Randomize { get; set;}

[REDProp("equip")]
public bool Equip { get; set;}

[REDProp("checkIfItemsAlreadyAdded")]
public bool CheckIfItemsAlreadyAdded { get; set;}

[REDProp("inventory")]
public Handle<CInventoryComponent> Inventory { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

[REDProp("rand")]
public Int32 Rand { get; set;}

[REDProp("randRange")]
public Int32 RandRange { get; set;}

[REDProp("itemsIDs")]
public Array<SItemUniqueId> ItemsIDs { get; set;}

[REDProp("possesedItemsCount")]
public Int32 PossesedItemsCount { get; set;}

[REDProp("itemsToAddCount")]
public Int32 ItemsToAddCount { get; set;}

#endregion
}
}