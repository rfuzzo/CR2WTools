using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSpawnTreeActionPointSpawner 
{
#region RED Properties

[REDProp("visibility")]
public ESpawnTreeSpawnVisibility Visibility { get; set;}

[REDProp("spawnpointDelay")]
public float SpawnpointDelay { get; set;}

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("categories")]
public Array<CName> Categories { get; set;}

#endregion
}
}