using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskShootDef : CBTTaskPlayAnimationEventDecoratorDef
{
#region RED Properties

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("attackRange")]
public CBehTreeValFloat AttackRange { get; set;}

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

[REDProp("setArrowOnFire")]
public CBehTreeValBool SetArrowOnFire { get; set;}

#endregion
}
}