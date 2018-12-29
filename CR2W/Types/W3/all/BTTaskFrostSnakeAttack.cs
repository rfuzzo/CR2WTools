using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskFrostSnakeAttack : CBTTaskAttack
{
#region RED Properties

[REDProp("useActionTarget")]
public bool UseActionTarget { get; set;}

[REDProp("spawnedEntityTemplates")]
public Array<Handle<CEntityTemplate>> SpawnedEntityTemplates { get; set;}

[REDProp("duration")]
public SRangeF Duration { get; set;}

[REDProp("clampDurationWhenTargetReached")]
public float ClampDurationWhenTargetReached { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("spawnAtOnce")]
public SRange SpawnAtOnce { get; set;}

[REDProp("spawnAttackDelay")]
public SRangeF SpawnAttackDelay { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("abortAttackOnTargetReached")]
public bool AbortAttackOnTargetReached { get; set;}

[REDProp("ThreeStateAttack")]
public bool ThreeStateAttack { get; set;}

[REDProp("loopHeadFX")]
public bool LoopHeadFX { get; set;}

[REDProp("waitForAnimEventToSummon")]
public CName WaitForAnimEventToSummon { get; set;}

[REDProp("snakeHeadTemplate")]
public Handle<CEntityTemplate> SnakeHeadTemplate { get; set;}

[REDProp("playEffectOnOwner")]
public CName PlayEffectOnOwner { get; set;}

[REDProp("additionalSnakeHeadFXName")]
public CName AdditionalSnakeHeadFXName { get; set;}

[REDProp("destroyEffectDelay")]
public float DestroyEffectDelay { get; set;}

[REDProp("canTriggerFrenzySlowmo")]
public bool CanTriggerFrenzySlowmo { get; set;}

[REDProp("m_Npc")]
public Handle<CNewNPC> M_Npc { get; set;}

[REDProp("m_SnakeHead")]
public Handle<CEntity> M_SnakeHead { get; set;}

[REDProp("m_SnakeHeadPos")]
public Vector M_SnakeHeadPos { get; set;}

[REDProp("m_LastSnakeHeadPos")]
public Vector M_LastSnakeHeadPos { get; set;}

[REDProp("m_effectDummyComp")]
public Handle<CEffectDummyComponent> M_effectDummyComp { get; set;}

[REDProp("m_PlayEffect")]
public bool M_PlayEffect { get; set;}

[REDProp("m_CanStartSummon")]
public bool M_CanStartSummon { get; set;}

#endregion
}
}