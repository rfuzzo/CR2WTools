using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Potion_VitalityRegen : W3RegenEffect
{
#region RED Properties

[REDProp("combatRegen")]
public SAbilityAttributeValue CombatRegen { get; set;}

[REDProp("nonCombatRegen")]
public SAbilityAttributeValue NonCombatRegen { get; set;}

[REDProp("playerTarget")]
public Handle<CR4Player> PlayerTarget { get; set;}

#endregion
}
}