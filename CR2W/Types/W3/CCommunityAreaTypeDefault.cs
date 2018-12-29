using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CCommunityAreaTypeDefault : CCommunityAreaType
{
#region RED Properties

[REDProp("areaSpawnRadius")]
public float AreaSpawnRadius { get; set;}

[REDProp("areaDespawnRadius")]
public float AreaDespawnRadius { get; set;}

[REDProp("spawnRadius")]
public float SpawnRadius { get; set;}

[REDProp("despawnRadius")]
public float DespawnRadius { get; set;}

[REDProp("dontRestore")]
public bool DontRestore { get; set;}

#endregion
}
}