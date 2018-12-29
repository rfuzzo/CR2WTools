using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3WhaleArea : CEntity
{
#region RED Properties

[REDProp("whaleSpawnPointTag")]
public CName WhaleSpawnPointTag { get; set;}

[REDProp("whaleSpawnOffsetY")]
public float WhaleSpawnOffsetY { get; set;}

[REDProp("minSpawnDistance")]
public float MinSpawnDistance { get; set;}

[REDProp("maxSpawnDistance")]
public float MaxSpawnDistance { get; set;}

[REDProp("spawnFrequencyMin")]
public float SpawnFrequencyMin { get; set;}

[REDProp("spawnFrequencyMax")]
public float SpawnFrequencyMax { get; set;}

[REDProp("movementPatern")]
public EWhaleMovementPatern MovementPatern { get; set;}

[REDProp("whaleTemplate")]
public Handle<CEntityTemplate> WhaleTemplate { get; set;}

#endregion
}
}