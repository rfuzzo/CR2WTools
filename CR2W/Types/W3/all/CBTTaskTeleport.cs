using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskTeleport : TaskTeleportAction
{
#region RED Properties

[REDProp("vanish")]
public bool Vanish { get; set;}

[REDProp("forceInvisible")]
public bool ForceInvisible { get; set;}

[REDProp("disallowInPlayerFOV")]
public bool DisallowInPlayerFOV { get; set;}

[REDProp("slideInsteadOfTeleport")]
public bool SlideInsteadOfTeleport { get; set;}

[REDProp("cooldown")]
public float Cooldown { get; set;}

[REDProp("nextTeleTime")]
public float NextTeleTime { get; set;}

[REDProp("delayActivation")]
public float DelayActivation { get; set;}

[REDProp("delayReappearance")]
public float DelayReappearance { get; set;}

[REDProp("disableGameplayVisibility")]
public bool DisableGameplayVisibility { get; set;}

[REDProp("disableInvisibilityAfterReappearance")]
public bool DisableInvisibilityAfterReappearance { get; set;}

[REDProp("disableImmortalityAfterReappearance")]
public bool DisableImmortalityAfterReappearance { get; set;}

[REDProp("disappearfxName")]
public CName DisappearfxName { get; set;}

[REDProp("appearFXName")]
public CName AppearFXName { get; set;}

[REDProp("stopEffectAppearFXName")]
public bool StopEffectAppearFXName { get; set;}

[REDProp("additionalAppearFXName")]
public CName AdditionalAppearFXName { get; set;}

[REDProp("performPosCheckOnTeleportEventName")]
public bool PerformPosCheckOnTeleportEventName { get; set;}

[REDProp("performLastMomentPosCheck")]
public bool PerformLastMomentPosCheck { get; set;}

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("activationEventName")]
public CName ActivationEventName { get; set;}

[REDProp("teleportEventName")]
public CName TeleportEventName { get; set;}

[REDProp("raiseEventImmediately")]
public bool RaiseEventImmediately { get; set;}

[REDProp("raiseEventName")]
public CName RaiseEventName { get; set;}

[REDProp("appearRaiseEventName")]
public CName AppearRaiseEventName { get; set;}

[REDProp("enableCollisionAfterReappearance")]
public bool EnableCollisionAfterReappearance { get; set;}

[REDProp("enableCollisionsOnDeactivate")]
public bool EnableCollisionsOnDeactivate { get; set;}

[REDProp("appearFXPlayed")]
public bool AppearFXPlayed { get; set;}

[REDProp("shouldPlayHitAnim")]
public bool ShouldPlayHitAnim { get; set;}

[REDProp("sendRotationEventAboveTeleportDist")]
public float SendRotationEventAboveTeleportDist { get; set;}

[REDProp("appearRaiseEventNameOnFailure")]
public CName AppearRaiseEventNameOnFailure { get; set;}

[REDProp("setBehVarNameOnRaiseEvent")]
public CName SetBehVarNameOnRaiseEvent { get; set;}

[REDProp("setBehVarValueOnRaiseDisappearEvent")]
public float SetBehVarValueOnRaiseDisappearEvent { get; set;}

[REDProp("setBehVarValueOnRaiseAppearEvent")]
public float SetBehVarValueOnRaiseAppearEvent { get; set;}

[REDProp("cameraToPlayerDistance")]
public float CameraToPlayerDistance { get; set;}

[REDProp("heading")]
public Vector Heading { get; set;}

[REDProp("randVec")]
public Vector RandVec { get; set;}

[REDProp("playerPos")]
public Vector PlayerPos { get; set;}

[REDProp("whereTo")]
public Vector WhereTo { get; set;}

[REDProp("canBeStrafed")]
public bool CanBeStrafed { get; set;}

[REDProp("appearRaiseEventLaunched")]
public bool AppearRaiseEventLaunched { get; set;}

[REDProp("disappearRaiseEventLaunched")]
public bool DisappearRaiseEventLaunched { get; set;}

[REDProp("newPosition")]
public Vector NewPosition { get; set;}

[REDProp("rotated")]
public bool Rotated { get; set;}

#endregion
}
}