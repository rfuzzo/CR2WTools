using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDealDamageToOwner : CBTTaskPlayAnimationEventDecorator
{
#region RED Properties

[REDProp("owner")]
public Handle<CNewNPC> Owner { get; set;}

[REDProp("attacker")]
public Handle<CActor> Attacker { get; set;}

[REDProp("damageValue")]
public float DamageValue { get; set;}

[REDProp("action")]
public Handle<W3Action_Attack> Action { get; set;}

[REDProp("attackName")]
public CName AttackName { get; set;}

[REDProp("skillName")]
public CName SkillName { get; set;}

[REDProp("onAnimEventName")]
public CName OnAnimEventName { get; set;}

#endregion
}
}