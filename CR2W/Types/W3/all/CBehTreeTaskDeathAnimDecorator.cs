using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskDeathAnimDecorator : IBehTreeTask
{
#region RED Properties

[REDProp("disableThisBranch")]
public bool DisableThisBranch { get; set;}

[REDProp("enabledRagdoll")]
public bool EnabledRagdoll { get; set;}

[REDProp("disableCollisionOnAnim")]
public bool DisableCollisionOnAnim { get; set;}

[REDProp("ignoreForceFinisher")]
public bool IgnoreForceFinisher { get; set;}

[REDProp("disableCollisionOnAnimDelay")]
public float DisableCollisionOnAnimDelay { get; set;}

[REDProp("completeTimer")]
public float CompleteTimer { get; set;}

[REDProp("playFXOnActivate")]
public CName PlayFXOnActivate { get; set;}

[REDProp("playFXOnDeactivate")]
public CName PlayFXOnDeactivate { get; set;}

[REDProp("stopFXOnActivate")]
public CName StopFXOnActivate { get; set;}

[REDProp("stopFXOnDeactivate")]
public CName StopFXOnDeactivate { get; set;}

[REDProp("playSFXOnActivate")]
public CName PlaySFXOnActivate { get; set;}

[REDProp("syncInstance")]
public Handle<CAnimationManualSlotSyncInstance> SyncInstance { get; set;}

[REDProp("finisherEnabled")]
public bool FinisherEnabled { get; set;}

#endregion
}
}