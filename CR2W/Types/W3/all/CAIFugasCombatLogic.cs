using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIFugasCombatLogic : CAIMonsterCombatLogic
{
#region RED Properties

[REDProp("useFasterMovementToApproach")]
public bool UseFasterMovementToApproach { get; set;}

[REDProp("fireAttack")]
public bool FireAttack { get; set;}

#endregion
}
}