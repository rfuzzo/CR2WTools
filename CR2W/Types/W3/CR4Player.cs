using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CR4Player : CPlayer
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("transformParent")]
public Ptr<CHardAttachment> TransformParent { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("components")]
public Array<Ptr<CComponent>> Components { get; set;}

[REDProp("template")]
public Handle<CEntityTemplate> Template { get; set;}

[REDProp("streamingDataBuffer")]
public SharedDataBuffer StreamingDataBuffer { get; set;}

[REDProp("streamingDistance")]
public byte StreamingDistance { get; set;}

[REDProp("entityStaticFlags")]
public EEntityStaticFlags EntityStaticFlags { get; set;}

[REDProp("autoPlayEffectName")]
public CName AutoPlayEffectName { get; set;}

[REDProp("entityFlags")]
public byte EntityFlags { get; set;}

[REDProp("idTag")]
public IdTag IdTag { get; set;}

[REDProp("isSaveable")]
public bool IsSaveable { get; set;}

[REDProp("propertyAnimationSet")]
public Ptr<CPropertyAnimationSet> PropertyAnimationSet { get; set;}

[REDProp("displayName")]
public LocalizedString DisplayName { get; set;}

[REDProp("stats")]
public Ptr<CCharacterStats> Stats { get; set;}

[REDProp("isInteractionActivator")]
public bool IsInteractionActivator { get; set;}

[REDProp("aimVector")]
public Vector AimVector { get; set;}

[REDProp("gameplayFlags")]
public uint GameplayFlags { get; set;}

[REDProp("focusModeVisibility")]
public EFocusModeVisibility FocusModeVisibility { get; set;}

[REDProp("actorGroups")]
public EPathEngineAgentType ActorGroups { get; set;}

[REDProp("aimOffset")]
public float AimOffset { get; set;}

[REDProp("barOffset")]
public float BarOffset { get; set;}

[REDProp("isAttackableByPlayer")]
public bool IsAttackableByPlayer { get; set;}

[REDProp("losTestBoneIndex")]
public int LosTestBoneIndex { get; set;}

[REDProp("attackTarget")]
public Handle<CActor> AttackTarget { get; set;}

[REDProp("attackTargetSetTime")]
public EngineTime AttackTargetSetTime { get; set;}

[REDProp("frontPushAnim")]
public CName FrontPushAnim { get; set;}

[REDProp("backPushAnim")]
public CName BackPushAnim { get; set;}

[REDProp("isCollidable")]
public bool IsCollidable { get; set;}

[REDProp("isVisibileFromFar")]
public bool IsVisibileFromFar { get; set;}

[REDProp("voiceTag")]
public CName VoiceTag { get; set;}

[REDProp("voiceToRandomize")]
public Array<StringAnsi> VoiceToRandomize { get; set;}

[REDProp("behTreeMachine")]
public Ptr<CBehTreeMachine> BehTreeMachine { get; set;}

[REDProp("useHiResShadows")]
public bool UseHiResShadows { get; set;}

[REDProp("isInFFMiniGame")]
public bool IsInFFMiniGame { get; set;}

[REDProp("pelvisBoneName")]
public CName PelvisBoneName { get; set;}

[REDProp("torsoBoneName")]
public CName TorsoBoneName { get; set;}

[REDProp("headBoneName")]
public CName HeadBoneName { get; set;}

[REDProp("useAnimationEventFilter")]
public bool UseAnimationEventFilter { get; set;}

[REDProp("soundListenerOverride")]
public string SoundListenerOverride { get; set;}

[REDProp("encounterGroupUsedToSpawn")]
public int EncounterGroupUsedToSpawn { get; set;}

[REDProp("npcVoicesetCooldown")]
public float NpcVoicesetCooldown { get; set;}

[REDProp("presenceInterestPoint")]
public Ptr<CInterestPoint> PresenceInterestPoint { get; set;}

[REDProp("slowMovementInterestPoint")]
public Ptr<CInterestPoint> SlowMovementInterestPoint { get; set;}

[REDProp("fastMovementInterestPoint")]
public Ptr<CInterestPoint> FastMovementInterestPoint { get; set;}

[REDProp("weaponDrawnInterestPoint")]
public Ptr<CInterestPoint> WeaponDrawnInterestPoint { get; set;}

[REDProp("weaponDrawMomentInterestPoint")]
public Ptr<CInterestPoint> WeaponDrawMomentInterestPoint { get; set;}

[REDProp("visionInterestPoint")]
public Ptr<CInterestPoint> VisionInterestPoint { get; set;}

[REDProp("isMovable")]
public bool IsMovable { get; set;}

[REDProp("enemyUpscaling")]
public bool EnemyUpscaling { get; set;}

[REDProp("uselessProp")]
public EAsyncCheckResult UselessProp { get; set;}

[REDProp("horseWithInventory")]
public EntityHandle HorseWithInventory { get; set;}

#endregion
}
}