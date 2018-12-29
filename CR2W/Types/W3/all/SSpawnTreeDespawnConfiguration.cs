using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SSpawnTreeDespawnConfiguration 
{
#region RED Properties

[REDProp("canDespawnOnSight")]
public bool CanDespawnOnSight { get; set;}

[REDProp("minDespawnRange")]
public float MinDespawnRange { get; set;}

[REDProp("forceDespawnRange")]
public float ForceDespawnRange { get; set;}

[REDProp("despawnDelayMin")]
public float DespawnDelayMin { get; set;}

[REDProp("despawnDelayMax")]
public float DespawnDelayMax { get; set;}

[REDProp("despawnTime")]
public float DespawnTime { get; set;}

#endregion
}
}