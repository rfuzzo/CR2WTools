using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskToadYrden : IBehTreeTask
{
#region RED Properties

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("leftYrden")]
public bool LeftYrden { get; set;}

[REDProp("leaveAfter")]
public float LeaveAfter { get; set;}

[REDProp("enterTimestamp")]
public float EnterTimestamp { get; set;}

[REDProp("l_effect")]
public bool L_effect { get; set;}

#endregion
}
}