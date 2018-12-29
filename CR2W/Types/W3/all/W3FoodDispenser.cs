using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FoodDispenser : CGameplayEntity
{
#region RED Properties

[REDProp("foodEntity")]
public Handle<CEntityTemplate> FoodEntity { get; set;}

[REDProp("maxSpawnedFood")]
public Int32 MaxSpawnedFood { get; set;}

[REDProp("spawnedFood")]
public Array<Handle<CEntity>> SpawnedFood { get; set;}

#endregion
}
}