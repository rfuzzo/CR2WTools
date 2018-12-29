using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Petard : CThrowable
{
#region RED Properties

[REDProp("cameraShakeStrMin")]
public float CameraShakeStrMin { get; set;}

[REDProp("cameraShakeStrMax")]
public float CameraShakeStrMax { get; set;}

[REDProp("cameraShakeRange")]
public float CameraShakeRange { get; set;}

[REDProp("hitReactionType")]
public EHitReactionType HitReactionType { get; set;}

[REDProp("noLoopEffectIfHitWater")]
public bool NoLoopEffectIfHitWater { get; set;}

[REDProp("dismemberOnKill")]
public bool DismemberOnKill { get; set;}

[REDProp("componentsEnabledOnLoop")]
public Array<CName> ComponentsEnabledOnLoop { get; set;}

[REDProp("friendlyFire")]
public bool FriendlyFire { get; set;}

[REDProp("impactParams")]
public SPetardParams ImpactParams { get; set;}

[REDProp("loopParams")]
public SPetardParams LoopParams { get; set;}

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

[REDProp("audioImpactName")]
public CName AudioImpactName { get; set;}

[REDProp("ignoreBombSkills")]
public bool IgnoreBombSkills { get; set;}

[REDProp("enableTrailFX")]
public bool EnableTrailFX { get; set;}

[REDProp("alignToNormal")]
public bool AlignToNormal { get; set;}

[REDProp("FX_TRAIL")]
public CName FX_TRAIL { get; set;}

[REDProp("FX_CLUSTER")]
public CName FX_CLUSTER { get; set;}

[REDProp("itemName")]
public CName ItemName { get; set;}

[REDProp("targetPos")]
public Vector TargetPos { get; set;}

[REDProp("isProximity")]
public bool IsProximity { get; set;}

[REDProp("isInWater")]
public bool IsInWater { get; set;}

[REDProp("isInDeepWater")]
public bool IsInDeepWater { get; set;}

[REDProp("isStuck")]
public bool IsStuck { get; set;}

[REDProp("isCluster")]
public bool IsCluster { get; set;}

[REDProp("justPlayingFXs")]
public Array<CName> JustPlayingFXs { get; set;}

[REDProp("loopDuration")]
public float LoopDuration { get; set;}

[REDProp("snapCollisionGroupNames")]
public Array<CName> SnapCollisionGroupNames { get; set;}

[REDProp("stopCollisions")]
public bool StopCollisions { get; set;}

[REDProp("previousTargets")]
public Array<Handle<CGameplayEntity>> PreviousTargets { get; set;}

[REDProp("targetsSinceLastCheck")]
public Array<Handle<CGameplayEntity>> TargetsSinceLastCheck { get; set;}

[REDProp("wasInTutorialTrigger")]
public bool WasInTutorialTrigger { get; set;}

[REDProp("decalRemainingTimes")]
public Array<SPetardShownDecals> DecalRemainingTimes { get; set;}

[REDProp("impactNormal")]
public Vector ImpactNormal { get; set;}

[REDProp("hasImpactFireDamage")]
public bool HasImpactFireDamage { get; set;}

[REDProp("hasImpactFrostDamage")]
public bool HasImpactFrostDamage { get; set;}

[REDProp("hasLoopFireDamage")]
public bool HasLoopFireDamage { get; set;}

[REDProp("hasLoopFrostDamage")]
public bool HasLoopFrostDamage { get; set;}

#endregion
}
}