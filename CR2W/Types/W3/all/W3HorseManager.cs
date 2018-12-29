using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3HorseManager : CPeristentEntity
{
#region RED Properties

[REDProp("inv")]
public Handle<CInventoryComponent> Inv { get; set;}

[REDProp("horseAbilities")]
public Array<CName> HorseAbilities { get; set;}

[REDProp("itemSlots")]
public Array<SItemUniqueId> ItemSlots { get; set;}

[REDProp("wasSpawned")]
public bool WasSpawned { get; set;}

[REDProp("horseMode")]
public EHorseMode HorseMode { get; set;}

#endregion
}
}