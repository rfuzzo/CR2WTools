using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondStaminaLowerThan : IBehTreeTask
{
#region RED Properties

[REDProp("baseStatType")]
public EBaseCharacterStats BaseStatType { get; set;}

[REDProp("statName")]
public CName StatName { get; set;}

[REDProp("getStat")]
public bool GetStat { get; set;}

[REDProp("statValue")]
public float StatValue { get; set;}

#endregion
}
}