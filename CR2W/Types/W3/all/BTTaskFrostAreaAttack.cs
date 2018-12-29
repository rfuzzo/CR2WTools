using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskFrostAreaAttack : IBehTreeTask
{
#region RED Properties

[REDProp("duration")]
public SRangeF Duration { get; set;}

[REDProp("spreadingSpeed")]
public float SpreadingSpeed { get; set;}

[REDProp("maxRadius")]
public float MaxRadius { get; set;}

[REDProp("spawnAtOnce")]
public SRange SpawnAtOnce { get; set;}

[REDProp("createArena")]
public bool CreateArena { get; set;}

[REDProp("arenaAngle")]
public float ArenaAngle { get; set;}

[REDProp("scaleSpawnQuantityWithRadius")]
public bool ScaleSpawnQuantityWithRadius { get; set;}

[REDProp("spawnAttackDelay")]
public SRangeF SpawnAttackDelay { get; set;}

[REDProp("spawnAttackOnTargetDelay")]
public SRangeF SpawnAttackOnTargetDelay { get; set;}

[REDProp("spawnedEntityTemplates")]
public Array<Handle<CEntityTemplate>> SpawnedEntityTemplates { get; set;}

[REDProp("frostWallReloadDelay")]
public float FrostWallReloadDelay { get; set;}

[REDProp("m_Npc")]
public Handle<CNewNPC> M_Npc { get; set;}

[REDProp("m_MinAttackRange")]
public float M_MinAttackRange { get; set;}

[REDProp("m_FrostRange")]
public float M_FrostRange { get; set;}

[REDProp("m_TimeToAttackOnTarget")]
public float M_TimeToAttackOnTarget { get; set;}

[REDProp("m_PostFxOnGroundCmp")]
public Handle<W3PostFXOnGroundComponent> M_PostFxOnGroundCmp { get; set;}

#endregion
}
}