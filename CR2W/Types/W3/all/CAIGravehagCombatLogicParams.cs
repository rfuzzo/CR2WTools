using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIGravehagCombatLogicParams : CAIMonsterCombatLogicParams
{
#region RED Properties

[REDProp("mistForm")]
public bool MistForm { get; set;}

[REDProp("mudThrow")]
public bool MudThrow { get; set;}

[REDProp("witchSpecialAttack")]
public bool WitchSpecialAttack { get; set;}

#endregion
}
}