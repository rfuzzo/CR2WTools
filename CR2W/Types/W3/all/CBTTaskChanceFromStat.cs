using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskChanceFromStat : IBehTreeTask
{
#region RED Properties

[REDProp("ifNot")]
public bool IfNot { get; set;}

[REDProp("statName")]
public CName StatName { get; set;}

[REDProp("frequency")]
public float Frequency { get; set;}

[REDProp("scaleWithNumberOfOpponents")]
public bool ScaleWithNumberOfOpponents { get; set;}

[REDProp("chancePerOpponent")]
public Int32 ChancePerOpponent { get; set;}

[REDProp("lastRollTime")]
public float LastRollTime { get; set;}

#endregion
}
}