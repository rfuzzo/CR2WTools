using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIWitch2CombatLogic : CAIMonsterCombatLogic
{
#region RED Properties

[REDProp("Phase1")]
public bool Phase1 { get; set;}

[REDProp("Phase2")]
public bool Phase2 { get; set;}

[REDProp("PhaseReset")]
public bool PhaseReset { get; set;}

[REDProp("bileAttack")]
public bool BileAttack { get; set;}

[REDProp("prePursueTaunt")]
public bool PrePursueTaunt { get; set;}

#endregion
}
}