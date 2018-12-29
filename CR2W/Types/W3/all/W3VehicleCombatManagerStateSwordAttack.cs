using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3VehicleCombatManagerStateSwordAttack : CScriptableState
{
#region RED Properties

[REDProp("rider")]
public Handle<CR4Player> Rider { get; set;}

[REDProp("horizontalVal")]
public float HorizontalVal { get; set;}

[REDProp("speedMultCasuserId")]
public Int32 SpeedMultCasuserId { get; set;}

[REDProp("slowMoSpeedCurrVal")]
public float SlowMoSpeedCurrVal { get; set;}

[REDProp("slowMoVelocityCurrVal")]
public float SlowMoVelocityCurrVal { get; set;}

[REDProp("isSlowMoOn")]
public bool IsSlowMoOn { get; set;}

[REDProp("ATTACK_TIMEOUT")]
public float ATTACK_TIMEOUT { get; set;}

[REDProp("ATTACK_STAMINA_PER_SEC")]
public float ATTACK_STAMINA_PER_SEC { get; set;}

[REDProp("ATTACK_COOLDOWN")]
public float ATTACK_COOLDOWN { get; set;}

[REDProp("CHANGE_SIDE_THRESHOLD")]
public float CHANGE_SIDE_THRESHOLD { get; set;}

[REDProp("attackInProgress")]
public bool AttackInProgress { get; set;}

[REDProp("FIRST_SWEEP_DELAY")]
public float FIRST_SWEEP_DELAY { get; set;}

[REDProp("SECOND_SWEEP_DELAY")]
public float SECOND_SWEEP_DELAY { get; set;}

[REDProp("BASE_DAMAGE")]
public float BASE_DAMAGE { get; set;}

#endregion
}
}