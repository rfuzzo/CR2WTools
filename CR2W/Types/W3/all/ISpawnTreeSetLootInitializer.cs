using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ISpawnTreeSetLootInitializer : ISpawnTreeScriptedInitializer
{
#region RED Properties

[REDProp("lootDefinitions")]
public Array<SR4LootNameProperty> LootDefinitions { get; set;}

[REDProp("overrideLoot")]
public bool OverrideLoot { get; set;}

[REDProp("randomize")]
public bool Randomize { get; set;}

[REDProp("inventory")]
public Handle<CInventoryComponent> Inventory { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

[REDProp("rand")]
public Int32 Rand { get; set;}

[REDProp("randRange")]
public Int32 RandRange { get; set;}

#endregion
}
}