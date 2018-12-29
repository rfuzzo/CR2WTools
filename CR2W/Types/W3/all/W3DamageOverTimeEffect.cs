using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DamageOverTimeEffect : CBaseGameplayEffect
{
#region RED Properties

[REDProp("damages")]
public Array<SDoTDamage> Damages { get; set;}

[REDProp("powerStatType")]
public ECharacterPowerStats PowerStatType { get; set;}

[REDProp("isEnvironment")]
public bool IsEnvironment { get; set;}

[REDProp("hpRegenPauseStrength")]
public SAbilityAttributeValue HpRegenPauseStrength { get; set;}

[REDProp("hpRegenPauseExtraDuration")]
public float HpRegenPauseExtraDuration { get; set;}

#endregion
}
}