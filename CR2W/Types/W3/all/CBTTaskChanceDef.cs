using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskChanceDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("chance")]
public CBehTreeValInt Chance { get; set;}

[REDProp("frequency")]
public float Frequency { get; set;}

[REDProp("scaleWithNumberOfOpponents")]
public bool ScaleWithNumberOfOpponents { get; set;}

[REDProp("chancePerOpponent")]
public Int32 ChancePerOpponent { get; set;}

#endregion
}
}