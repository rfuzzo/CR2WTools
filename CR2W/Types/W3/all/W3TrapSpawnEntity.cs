using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TrapSpawnEntity : W3Trap
{
#region RED Properties

[REDProp("spawnOnlyOnAreaEnter")]
public bool SpawnOnlyOnAreaEnter { get; set;}

[REDProp("maxSpawns")]
public float MaxSpawns { get; set;}

[REDProp("entityToSpawn")]
public Handle<CEntityTemplate> EntityToSpawn { get; set;}

[REDProp("offsetVector")]
public Vector OffsetVector { get; set;}

[REDProp("excludedActorsTags")]
public Array<CName> ExcludedActorsTags { get; set;}

[REDProp("appearanceAfterFirstSpawn")]
public string AppearanceAfterFirstSpawn { get; set;}

[REDProp("m_Spawns")]
public Int32 M_Spawns { get; set;}

#endregion
}
}