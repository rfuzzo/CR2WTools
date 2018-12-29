using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CDamageAreaEntity : CInteractiveEntity
{
#region RED Properties

[REDProp("owner")]
public Handle<CActor> Owner { get; set;}

[REDProp("buff")]
public EEffectType Buff { get; set;}

[REDProp("buffDuration")]
public float BuffDuration { get; set;}

[REDProp("customDamageValuePerSec")]
public SAbilityAttributeValue CustomDamageValuePerSec { get; set;}

[REDProp("effectOnSpawn")]
public CName EffectOnSpawn { get; set;}

[REDProp("activeFor")]
public float ActiveFor { get; set;}

[REDProp("stopSpawnEffectDelay")]
public float StopSpawnEffectDelay { get; set;}

[REDProp("dealDamagePerc")]
public Int32 DealDamagePerc { get; set;}

[REDProp("range")]
public float Range { get; set;}

[REDProp("isActive")]
public bool IsActive { get; set;}

[REDProp("actorsInRange")]
public Array<Handle<CActor>> ActorsInRange { get; set;}

[REDProp("buffParams")]
public SCustomEffectParams BuffParams { get; set;}

[REDProp("interaction")]
public Handle<CInteractionComponent> Interaction { get; set;}

#endregion
}
}