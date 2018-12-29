using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIGolemCombatLogicParams : CAIMonsterCombatLogicParams
{
#region RED Properties

[REDProp("projectileTemplate")]
public Handle<CEntityTemplate> ProjectileTemplate { get; set;}

[REDProp("attackRange")]
public float AttackRange { get; set;}

#endregion
}
}