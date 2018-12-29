using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskTeleportDef : TaskTeleportActionDef
{
#region RED Properties

[REDProp("cooldown")]
public float Cooldown { get; set;}

[REDProp("delayActivation")]
public float DelayActivation { get; set;}

[REDProp("delayReappearance")]
public float DelayReappearance { get; set;}

[REDProp("slideInsteadOfTeleport")]
public bool SlideInsteadOfTeleport { get; set;}

[REDProp("forceInvisible")]
public bool ForceInvisible { get; set;}

[REDProp("disableGameplayVisibility")]
public bool DisableGameplayVisibility { get; set;}

[REDProp("disableInvisibilityAfterReappearance")]
public bool DisableInvisibilityAfterReappearance { get; set;}

[REDProp("disableImmortalityAfterReappearance")]
public bool DisableImmortalityAfterReappearance { get; set;}

[REDProp("enableCollisionAfterReappearance")]
public bool EnableCollisionAfterReappearance { get; set;}

[REDProp("enableCollisionsOnDeactivate")]
public bool EnableCollisionsOnDeactivate { get; set;}

[REDProp("disallowInPlayerFOV")]
public bool DisallowInPlayerFOV { get; set;}

[REDProp("performPosCheckOnTeleportEventName")]
public bool PerformPosCheckOnTeleportEventName { get; set;}

[REDProp("performLastMomentPosCheck")]
public bool PerformLastMomentPosCheck { get; set;}

[REDProp("activationEventName")]
public CName ActivationEventName { get; set;}

[REDProp("teleportEventName")]
public CName TeleportEventName { get; set;}

[REDProp("appearRaiseEventName")]
public CName AppearRaiseEventName { get; set;}

[REDProp("appearRaiseEventNameOnFailure")]
public CName AppearRaiseEventNameOnFailure { get; set;}

[REDProp("setBehVarNameOnRaiseEvent")]
public CName SetBehVarNameOnRaiseEvent { get; set;}

[REDProp("setBehVarValueOnRaiseDisappearEvent")]
public float SetBehVarValueOnRaiseDisappearEvent { get; set;}

[REDProp("setBehVarValueOnRaiseAppearEvent")]
public float SetBehVarValueOnRaiseAppearEvent { get; set;}

[REDProp("disappearfxName")]
public CName DisappearfxName { get; set;}

[REDProp("appearFXName")]
public CName AppearFXName { get; set;}

[REDProp("stopEffectAppearFXName")]
public bool StopEffectAppearFXName { get; set;}

[REDProp("additionalAppearFXName")]
public CName AdditionalAppearFXName { get; set;}

[REDProp("raiseEventName")]
public CName RaiseEventName { get; set;}

[REDProp("raiseEventImmediately")]
public bool RaiseEventImmediately { get; set;}

[REDProp("shouldPlayHitAnim")]
public bool ShouldPlayHitAnim { get; set;}

[REDProp("sendRotationEventAboveTeleportDist")]
public float SendRotationEventAboveTeleportDist { get; set;}

#endregion
}
}