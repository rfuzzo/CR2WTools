using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskFrostSnakeAttackDef : CBTTaskAttackDef
{
#region RED Properties

[REDProp("useActionTarget")]
public bool UseActionTarget { get; set;}

[REDProp("spawnedEntityTemplates")]
public Array<Handle<CEntityTemplate>> SpawnedEntityTemplates { get; set;}

[REDProp("clampDurationWhenTargetReached")]
public CBehTreeValFloat ClampDurationWhenTargetReached { get; set;}

[REDProp("duration")]
public SRangeF Duration { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("spawnAtOnce")]
public SRange SpawnAtOnce { get; set;}

[REDProp("spawnAttackDelay")]
public SRangeF SpawnAttackDelay { get; set;}

[REDProp("snakeHeadTemplate")]
public Handle<CEntityTemplate> SnakeHeadTemplate { get; set;}

[REDProp("additionalSnakeHeadFXName")]
public CName AdditionalSnakeHeadFXName { get; set;}

[REDProp("playEffectOnOwner")]
public CName PlayEffectOnOwner { get; set;}

[REDProp("ThreeStateAttack")]
public bool ThreeStateAttack { get; set;}

[REDProp("loopHeadFX")]
public bool LoopHeadFX { get; set;}

[REDProp("destroyEffectDelay")]
public float DestroyEffectDelay { get; set;}

[REDProp("waitForAnimEventToSummon")]
public CName WaitForAnimEventToSummon { get; set;}

[REDProp("canTriggerFrenzySlowmo")]
public bool CanTriggerFrenzySlowmo { get; set;}

#endregion
}
}