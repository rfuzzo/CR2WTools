using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_SpawnEntity : W3SwitchEvent
{
#region RED Properties

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("positionOffset")]
public Vector PositionOffset { get; set;}

[REDProp("randomOffset")]
public Vector RandomOffset { get; set;}

[REDProp("lifeTime")]
public float LifeTime { get; set;}

[REDProp("maxEntitiesAtATime")]
public Int32 MaxEntitiesAtATime { get; set;}

[REDProp("minDelayBetweenSpawns")]
public float MinDelayBetweenSpawns { get; set;}

[REDProp("spawnSnapToGround")]
public bool SpawnSnapToGround { get; set;}

[REDProp("m_spawnedEntities")]
public Array<Handle<CEntity>> M_spawnedEntities { get; set;}

#endregion
}
}