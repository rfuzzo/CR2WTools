using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3WeakeningAura : W3Effect_Aura
{
#region RED Properties

[REDProp("usedVictim")]
public Handle<CActor> UsedVictim { get; set;}

[REDProp("timeSinceLastApply")]
public float TimeSinceLastApply { get; set;}

[REDProp("hasSelectedVictim")]
public bool HasSelectedVictim { get; set;}

[REDProp("applicationDelay")]
public float ApplicationDelay { get; set;}

[REDProp("targetCount")]
public Int32 TargetCount { get; set;}

[REDProp("BUFF_DURATION")]
public float BUFF_DURATION { get; set;}

#endregion
}
}