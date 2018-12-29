using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3EntitySpawner : W3UsableEntity
{
#region RED Properties

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("appearanceAfterSpawn")]
public CName AppearanceAfterSpawn { get; set;}

[REDProp("autoSpawn")]
public bool AutoSpawn { get; set;}

[REDProp("spawnDelay")]
public float SpawnDelay { get; set;}

[REDProp("numberOfUses")]
public Int32 NumberOfUses { get; set;}

[REDProp("spawnNearPlayer")]
public bool SpawnNearPlayer { get; set;}

[REDProp("avoidNodeWithTag")]
public CName AvoidNodeWithTag { get; set;}

#endregion
}
}