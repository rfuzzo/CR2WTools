using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeCombatTargetSelectionTask : IBehTreeTask
{
#region RED Properties

[REDProp("maxTargetDistance")]
public float MaxTargetDistance { get; set;}

[REDProp("testMaxFrequency")]
public float TestMaxFrequency { get; set;}

[REDProp("nextTestDelay")]
public float NextTestDelay { get; set;}

[REDProp("nextTarget")]
public Handle<CActor> NextTarget { get; set;}

[REDProp("playerPriority")]
public Int32 PlayerPriority { get; set;}

[REDProp("targetOnlyPlayer")]
public bool TargetOnlyPlayer { get; set;}

[REDProp("ForceTarget")]
public Handle<CActor> ForceTarget { get; set;}

#endregion
}
}