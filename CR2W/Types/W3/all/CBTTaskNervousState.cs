using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskNervousState : IBehTreeTask
{
#region RED Properties

[REDProp("dangerRadius")]
public float DangerRadius { get; set;}

[REDProp("rearingChance")]
public float RearingChance { get; set;}

[REDProp("kickChance")]
public float KickChance { get; set;}

[REDProp("callFromQuestOnly")]
public bool CallFromQuestOnly { get; set;}

[REDProp("force")]
public bool Force { get; set;}

[REDProp("called")]
public bool Called { get; set;}

[REDProp("dangerNode")]
public Handle<CNode> DangerNode { get; set;}

#endregion
}
}