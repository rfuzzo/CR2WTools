using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIArachasCombatLogicParams : CAIMonsterCombatLogicParams
{
#region RED Properties

[REDProp("minChargeDist")]
public float MinChargeDist { get; set;}

[REDProp("maxChargeDist")]
public float MaxChargeDist { get; set;}

#endregion
}
}