using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskLeshyGrabAttack : IBehTreeTask
{
#region RED Properties

[REDProp("attackType")]
public EAttackType AttackType { get; set;}

[REDProp("stopTaskAfterDealingDmg")]
public bool StopTaskAfterDealingDmg { get; set;}

[REDProp("useDirectionalAttacks")]
public bool UseDirectionalAttacks { get; set;}

[REDProp("fxOnDamageInstigated")]
public CName FxOnDamageInstigated { get; set;}

[REDProp("slave")]
public Handle<CActor> Slave { get; set;}

[REDProp("slaveComponent")]
public Handle<CEffectDummyComponent> SlaveComponent { get; set;}

#endregion
}
}