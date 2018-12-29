using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSorceressAttacksBoid : CBTTaskMagicMeleeAttack
{
#region RED Properties

[REDProp("attackAngle")]
public float AttackAngle { get; set;}

[REDProp("attackDist")]
public float AttackDist { get; set;}

#endregion
}
}