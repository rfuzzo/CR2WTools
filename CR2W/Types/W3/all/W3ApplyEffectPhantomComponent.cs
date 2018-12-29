using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ApplyEffectPhantomComponent : CPhantomComponent
{
#region RED Properties

[REDProp("effectToApply")]
public EEffectType EffectToApply { get; set;}

[REDProp("effectDuration")]
public float EffectDuration { get; set;}

[REDProp("requiredAbilities")]
public Array<CName> RequiredAbilities { get; set;}

[REDProp("onlyWhenAlive")]
public bool OnlyWhenAlive { get; set;}

[REDProp("onlyToHostiles")]
public bool OnlyToHostiles { get; set;}

[REDProp("onlyToTag")]
public CName OnlyToTag { get; set;}

[REDProp("ignoreIfHasEffect")]
public bool IgnoreIfHasEffect { get; set;}

[REDProp("useCustomValue")]
public bool UseCustomValue { get; set;}

[REDProp("customValue")]
public SAbilityAttributeValue CustomValue { get; set;}

[REDProp("forcedDamage")]
public float ForcedDamage { get; set;}

[REDProp("minRelativeSpeed")]
public float MinRelativeSpeed { get; set;}

[REDProp("decreasePlayerDmgBy")]
public float DecreasePlayerDmgBy { get; set;}

[REDProp("playFXonCollisionEnter")]
public CName PlayFXonCollisionEnter { get; set;}

[REDProp("stopFXonCollisionExit")]
public bool StopFXonCollisionExit { get; set;}

[REDProp("objectAttached")]
public bool ObjectAttached { get; set;}

#endregion
}
}