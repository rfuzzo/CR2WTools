using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskNervousStateDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("callFromQuestOnly")]
public bool CallFromQuestOnly { get; set;}

[REDProp("dangerRadius")]
public float DangerRadius { get; set;}

[REDProp("rearingChance")]
public float RearingChance { get; set;}

[REDProp("kickChance")]
public float KickChance { get; set;}

#endregion
}
}