using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskCSEffect : IBehTreeTask
{
#region RED Properties

[REDProp("CSType")]
public ECriticalStateType CSType { get; set;}

[REDProp("requestedCSType")]
public ECriticalStateType RequestedCSType { get; set;}

[REDProp("buffType")]
public EEffectType BuffType { get; set;}

[REDProp("buff")]
public Handle<CBaseGameplayEffect> Buff { get; set;}

[REDProp("finisherAnimName")]
public CName FinisherAnimName { get; set;}

[REDProp("hasBuff")]
public bool HasBuff { get; set;}

[REDProp("allowBlend")]
public bool AllowBlend { get; set;}

[REDProp("hitReactionDisabled")]
public bool HitReactionDisabled { get; set;}

[REDProp("waitForDropItem")]
public bool WaitForDropItem { get; set;}

[REDProp("isInAir")]
public bool IsInAir { get; set;}

[REDProp("heightDiff")]
public float HeightDiff { get; set;}

[REDProp("isInPotentialRagdoll")]
public bool IsInPotentialRagdoll { get; set;}

[REDProp("guardOpen")]
public bool GuardOpen { get; set;}

[REDProp("criticalStatesToResist")]
public Int32 CriticalStatesToResist { get; set;}

[REDProp("resistCriticalStateChance")]
public Int32 ResistCriticalStateChance { get; set;}

[REDProp("combatDataStorage")]
public Handle<CBaseAICombatStorage> CombatDataStorage { get; set;}

[REDProp("reactionDataStorage")]
public Handle<CAIStorageReactionData> ReactionDataStorage { get; set;}

[REDProp("finisherEnabled")]
public bool FinisherEnabled { get; set;}

[REDProp("forceFinisherActivation")]
public bool ForceFinisherActivation { get; set;}

[REDProp("finisherDisabled")]
public bool FinisherDisabled { get; set;}

[REDProp("pullToNavRadiusMult")]
public float PullToNavRadiusMult { get; set;}

[REDProp("m_storedInteractionPri")]
public EInteractionPriority M_storedInteractionPri { get; set;}

[REDProp("armored")]
public bool Armored { get; set;}

[REDProp("hitAnim")]
public bool HitAnim { get; set;}

[REDProp("unstoppable")]
public bool Unstoppable { get; set;}

[REDProp("ragdollPullingEventReceived")]
public bool RagdollPullingEventReceived { get; set;}

[REDProp("distanceFromRootToBone")]
public float DistanceFromRootToBone { get; set;}

[REDProp("boneIndex")]
public Int32 BoneIndex { get; set;}

[REDProp("hitsToRaiseGuard")]
public float HitsToRaiseGuard { get; set;}

[REDProp("raiseGuardChance")]
public float RaiseGuardChance { get; set;}

[REDProp("hitsToCounter")]
public float HitsToCounter { get; set;}

[REDProp("counterChance")]
public float CounterChance { get; set;}

[REDProp("counterStaminaCost")]
public float CounterStaminaCost { get; set;}

[REDProp("canCounter")]
public bool CanCounter { get; set;}

[REDProp("counterRequested")]
public bool CounterRequested { get; set;}

[REDProp("counterRequestTimeStamp")]
public float CounterRequestTimeStamp { get; set;}

[REDProp("counterType")]
public ECriticalEffectCounterType CounterType { get; set;}

[REDProp("startAirPos")]
public Vector StartAirPos { get; set;}

[REDProp("endAirPos")]
public Vector EndAirPos { get; set;}

[REDProp("cachedInAir")]
public bool CachedInAir { get; set;}

[REDProp("airStartTime")]
public float AirStartTime { get; set;}

[REDProp("screamPlayed")]
public bool ScreamPlayed { get; set;}

[REDProp("fallingDamage")]
public float FallingDamage { get; set;}

[REDProp("maxFallingHeightDiff")]
public float MaxFallingHeightDiff { get; set;}

#endregion
}
}