using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SpawnMarker : CGameplayEntity
{
#region RED Properties

[REDProp("spawnDelay")]
public float SpawnDelay { get; set;}

[REDProp("destroyDelay")]
public float DestroyDelay { get; set;}

[REDProp("entitiesToSpawn")]
public Array<Handle<CEntityTemplate>> EntitiesToSpawn { get; set;}

[REDProp("spawnOnGround")]
public bool SpawnOnGround { get; set;}

[REDProp("m_summonedEntityCmp")]
public Handle<W3SummonedEntityComponent> M_summonedEntityCmp { get; set;}

#endregion
}
}