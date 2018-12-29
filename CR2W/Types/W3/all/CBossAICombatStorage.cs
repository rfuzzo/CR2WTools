using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBossAICombatStorage : CHumanAICombatStorage
{
#region RED Properties

[REDProp("isLightbringerAvailable")]
public bool IsLightbringerAvailable { get; set;}

[REDProp("isMeteoritesAvailable")]
public bool IsMeteoritesAvailable { get; set;}

[REDProp("isIceSpikesAvailable")]
public bool IsIceSpikesAvailable { get; set;}

[REDProp("isBlinkComboAvailable")]
public bool IsBlinkComboAvailable { get; set;}

[REDProp("isSpecialAttackAvailable")]
public bool IsSpecialAttackAvailable { get; set;}

[REDProp("isParryAvailable")]
public bool IsParryAvailable { get; set;}

[REDProp("isSiphonAvailable")]
public bool IsSiphonAvailable { get; set;}

[REDProp("isDodgeAvailable")]
public bool IsDodgeAvailable { get; set;}

[REDProp("isStaminaRegenAvailable")]
public bool IsStaminaRegenAvailable { get; set;}

[REDProp("isPhaseChangeAvailable")]
public bool IsPhaseChangeAvailable { get; set;}

[REDProp("inInSpecialAttack")]
public bool InInSpecialAttack { get; set;}

#endregion
}
}