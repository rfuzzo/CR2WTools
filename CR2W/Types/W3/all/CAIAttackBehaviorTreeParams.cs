using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIAttackBehaviorTreeParams : CAICombatActionParameters
{
#region RED Properties

[REDProp("chargeAction")]
public bool ChargeAction { get; set;}

[REDProp("approachAction")]
public bool ApproachAction { get; set;}

[REDProp("throwBomb")]
public bool ThrowBomb { get; set;}

[REDProp("teleportAction")]
public bool TeleportAction { get; set;}

[REDProp("attackAction")]
public Handle<CAIAttackActionTree> AttackAction { get; set;}

[REDProp("attackActionRange")]
public CName AttackActionRange { get; set;}

[REDProp("farAttackAction")]
public Handle<CAIAttackActionTree> FarAttackAction { get; set;}

[REDProp("farAttackActionRange")]
public CName FarAttackActionRange { get; set;}

#endregion
}
}