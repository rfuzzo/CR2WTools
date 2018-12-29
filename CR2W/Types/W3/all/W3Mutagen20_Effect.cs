using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Mutagen20_Effect : W3Mutagen_Effect
{
#region RED Properties

[REDProp("burningPoints")]
public SAbilityAttributeValue BurningPoints { get; set;}

[REDProp("burningPercents")]
public SAbilityAttributeValue BurningPercents { get; set;}

[REDProp("poisonPoints")]
public SAbilityAttributeValue PoisonPoints { get; set;}

[REDProp("poisonPercents")]
public SAbilityAttributeValue PoisonPercents { get; set;}

[REDProp("bleedingPoints")]
public SAbilityAttributeValue BleedingPoints { get; set;}

[REDProp("bleedingPercents")]
public SAbilityAttributeValue BleedingPercents { get; set;}

[REDProp("burningResistanceCounter")]
public float BurningResistanceCounter { get; set;}

[REDProp("poisonResistanceCounter")]
public float PoisonResistanceCounter { get; set;}

[REDProp("bleedingResistanceCounter")]
public float BleedingResistanceCounter { get; set;}

[REDProp("player")]
public Handle<CR4Player> Player { get; set;}

#endregion
}
}