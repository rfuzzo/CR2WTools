using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PlayerMode : CObject
{
#region RED Properties

[REDProp("player")]
public Handle<CPlayer> Player { get; set;}

[REDProp("currentMode")]
public EPlayerMode CurrentMode { get; set;}

[REDProp("safeMode")]
public bool SafeMode { get; set;}

[REDProp("combatMode")]
public bool CombatMode { get; set;}

[REDProp("combatDataComponent")]
public Handle<CCombatDataComponent> CombatDataComponent { get; set;}

[REDProp("combatModeTimer")]
public float CombatModeTimer { get; set;}

[REDProp("combatModeDelay")]
public float CombatModeDelay { get; set;}

[REDProp("forceCombatMode")]
public Int32 ForceCombatMode { get; set;}

[REDProp("combatModeBlockedActions")]
public Array<EInputActionBlock> CombatModeBlockedActions { get; set;}

[REDProp("safeModeBlockedActions")]
public Array<EInputActionBlock> SafeModeBlockedActions { get; set;}

#endregion
}
}