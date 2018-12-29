using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ISpawnTreeSpawnAroundNodeInitializer : ISpawnTreeScriptedInitializer
{
#region RED Properties

[REDProp("spawnRadiousMin")]
public float SpawnRadiousMin { get; set;}

[REDProp("spawnRadiousMAx")]
public float SpawnRadiousMAx { get; set;}

[REDProp("spawnNodeTag")]
public CName SpawnNodeTag { get; set;}

[REDProp("spawnNode")]
public Handle<CNode> SpawnNode { get; set;}

#endregion
}
}