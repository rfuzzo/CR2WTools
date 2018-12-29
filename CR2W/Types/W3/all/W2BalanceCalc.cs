using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W2BalanceCalc : CObject
{
#region RED Properties

[REDProp("abilities")]
public Array<CName> Abilities { get; set;}

[REDProp("petards")]
public Array<SItemUniqueId> Petards { get; set;}

[REDProp("cost")]
public float Cost { get; set;}

[REDProp("statVitality")]
public float StatVitality { get; set;}

[REDProp("statCurrentVitality")]
public float StatCurrentVitality { get; set;}

[REDProp("statEssence")]
public float StatEssence { get; set;}

[REDProp("statCurrentEssence")]
public float StatCurrentEssence { get; set;}

[REDProp("statStamina")]
public float StatStamina { get; set;}

[REDProp("statCurrentStamina")]
public float StatCurrentStamina { get; set;}

[REDProp("statFocus")]
public float StatFocus { get; set;}

[REDProp("statToxicity")]
public float StatToxicity { get; set;}

[REDProp("statMorale")]
public float StatMorale { get; set;}

[REDProp("statSickness")]
public float StatSickness { get; set;}

[REDProp("statParryChance")]
public float StatParryChance { get; set;}

[REDProp("statDodgeChance")]
public float StatDodgeChance { get; set;}

[REDProp("statVitalityRegen")]
public float StatVitalityRegen { get; set;}

[REDProp("statEssenceRegen")]
public float StatEssenceRegen { get; set;}

[REDProp("statStaminaRegen")]
public float StatStaminaRegen { get; set;}

[REDProp("statFocusRegen")]
public float StatFocusRegen { get; set;}

[REDProp("statToxicityRegen")]
public float StatToxicityRegen { get; set;}

[REDProp("statMoraleRegen")]
public float StatMoraleRegen { get; set;}

[REDProp("statSicknessRegen")]
public float StatSicknessRegen { get; set;}

[REDProp("statAttackPower")]
public float StatAttackPower { get; set;}

[REDProp("statSpellPower")]
public float StatSpellPower { get; set;}

[REDProp("statEffectDuration")]
public float StatEffectDuration { get; set;}

[REDProp("statVitalityDmg")]
public float StatVitalityDmg { get; set;}

[REDProp("statEssenceDmg")]
public float StatEssenceDmg { get; set;}

[REDProp("statSpellDmg")]
public float StatSpellDmg { get; set;}

[REDProp("statRange")]
public float StatRange { get; set;}

[REDProp("statRadius")]
public float StatRadius { get; set;}

[REDProp("statPhysicalRes")]
public float StatPhysicalRes { get; set;}

[REDProp("statFireRes")]
public float StatFireRes { get; set;}

[REDProp("statFrostRes")]
public float StatFrostRes { get; set;}

[REDProp("statShockRes")]
public float StatShockRes { get; set;}

[REDProp("statPoisonRes")]
public float StatPoisonRes { get; set;}

[REDProp("statBleedingRes")]
public float StatBleedingRes { get; set;}

[REDProp("statIncinerationRes")]
public float StatIncinerationRes { get; set;}

[REDProp("costVitality")]
public float CostVitality { get; set;}

[REDProp("costEssence")]
public float CostEssence { get; set;}

[REDProp("costStamina")]
public float CostStamina { get; set;}

[REDProp("costFocus")]
public float CostFocus { get; set;}

[REDProp("costToxicity")]
public float CostToxicity { get; set;}

[REDProp("costMorale")]
public float CostMorale { get; set;}

[REDProp("costDrunkenness")]
public float CostDrunkenness { get; set;}

[REDProp("costSickness")]
public float CostSickness { get; set;}

[REDProp("costParryChance")]
public float CostParryChance { get; set;}

[REDProp("costDodgeChance")]
public float CostDodgeChance { get; set;}

[REDProp("costVitalityRegen")]
public float CostVitalityRegen { get; set;}

[REDProp("costEssenceRegen")]
public float CostEssenceRegen { get; set;}

[REDProp("costStaminaRegen")]
public float CostStaminaRegen { get; set;}

[REDProp("costFocusRegen")]
public float CostFocusRegen { get; set;}

[REDProp("costToxicityRegen")]
public float CostToxicityRegen { get; set;}

[REDProp("costMoraleRegen")]
public float CostMoraleRegen { get; set;}

[REDProp("costDrunkennessRegen")]
public float CostDrunkennessRegen { get; set;}

[REDProp("costSicknessRegen")]
public float CostSicknessRegen { get; set;}

[REDProp("costAttackPower")]
public float CostAttackPower { get; set;}

[REDProp("costSpellPower")]
public float CostSpellPower { get; set;}

[REDProp("costEffectDuration")]
public float CostEffectDuration { get; set;}

[REDProp("costVitalityDmg")]
public float CostVitalityDmg { get; set;}

[REDProp("costEssenceDmg")]
public float CostEssenceDmg { get; set;}

[REDProp("costSpellDmg")]
public float CostSpellDmg { get; set;}

[REDProp("costRange")]
public float CostRange { get; set;}

[REDProp("costRadius")]
public float CostRadius { get; set;}

[REDProp("costPhysicalRes")]
public float CostPhysicalRes { get; set;}

[REDProp("costFireRes")]
public float CostFireRes { get; set;}

[REDProp("costFrostRes")]
public float CostFrostRes { get; set;}

[REDProp("costShockRes")]
public float CostShockRes { get; set;}

[REDProp("costPoisonRes")]
public float CostPoisonRes { get; set;}

[REDProp("costBleedingRes")]
public float CostBleedingRes { get; set;}

[REDProp("costIncinerationRes")]
public float CostIncinerationRes { get; set;}

[REDProp("costconstVitality")]
public float CostconstVitality { get; set;}

[REDProp("costconstEssence")]
public float CostconstEssence { get; set;}

[REDProp("costconstStamina")]
public float CostconstStamina { get; set;}

[REDProp("costconstFocus")]
public float CostconstFocus { get; set;}

[REDProp("costconstToxicity")]
public float CostconstToxicity { get; set;}

[REDProp("costconstMorale")]
public float CostconstMorale { get; set;}

[REDProp("costconstDrunkenness")]
public float CostconstDrunkenness { get; set;}

[REDProp("costconstSickness")]
public float CostconstSickness { get; set;}

[REDProp("costconstParryChance")]
public float CostconstParryChance { get; set;}

[REDProp("costconstDodgeChance")]
public float CostconstDodgeChance { get; set;}

[REDProp("costconstVitalityRegen")]
public float CostconstVitalityRegen { get; set;}

[REDProp("costconstEssenceRegen")]
public float CostconstEssenceRegen { get; set;}

[REDProp("costconstStaminaRegen")]
public float CostconstStaminaRegen { get; set;}

[REDProp("costconstFocusRegen")]
public float CostconstFocusRegen { get; set;}

[REDProp("costconstToxicityRegen")]
public float CostconstToxicityRegen { get; set;}

[REDProp("costconstMoraleRegen")]
public float CostconstMoraleRegen { get; set;}

[REDProp("costconstDrunkennessRegen")]
public float CostconstDrunkennessRegen { get; set;}

[REDProp("costconstSicknessRegen")]
public float CostconstSicknessRegen { get; set;}

[REDProp("costconstAttackPower")]
public float CostconstAttackPower { get; set;}

[REDProp("costconstSpellPower")]
public float CostconstSpellPower { get; set;}

[REDProp("costconstEffectDuration")]
public float CostconstEffectDuration { get; set;}

[REDProp("costconstVitalityDmg")]
public float CostconstVitalityDmg { get; set;}

[REDProp("costconstEssenceDmg")]
public float CostconstEssenceDmg { get; set;}

[REDProp("costconstSpellDmg")]
public float CostconstSpellDmg { get; set;}

[REDProp("costconstRange")]
public float CostconstRange { get; set;}

[REDProp("costconstRadius")]
public float CostconstRadius { get; set;}

[REDProp("costconstPhysicalRes")]
public float CostconstPhysicalRes { get; set;}

[REDProp("costconstFireRes")]
public float CostconstFireRes { get; set;}

[REDProp("costconstFrostRes")]
public float CostconstFrostRes { get; set;}

[REDProp("costconstShockRes")]
public float CostconstShockRes { get; set;}

[REDProp("costconstPoisonRes")]
public float CostconstPoisonRes { get; set;}

[REDProp("costconstBleedingRes")]
public float CostconstBleedingRes { get; set;}

[REDProp("costconstIncinerationRes")]
public float CostconstIncinerationRes { get; set;}

#endregion
}
}