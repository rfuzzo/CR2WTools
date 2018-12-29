using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SJobTreeSettings 
{
#region RED Properties

[REDProp("leftRemoveAtEnd")]
public bool LeftRemoveAtEnd { get; set;}

[REDProp("leftDropOnBreak")]
public bool LeftDropOnBreak { get; set;}

[REDProp("rightRemoveAtEnd")]
public bool RightRemoveAtEnd { get; set;}

[REDProp("rightDropOnBreak")]
public bool RightDropOnBreak { get; set;}

[REDProp("ignoreHardReactions")]
public bool IgnoreHardReactions { get; set;}

[REDProp("needsPrecision")]
public bool NeedsPrecision { get; set;}

[REDProp("isConscious")]
public bool IsConscious { get; set;}

[REDProp("altJobTreeRes")]
public Handle<CJobTree> AltJobTreeRes { get; set;}

[REDProp("globalBreakingBlendOutTime")]
public float GlobalBreakingBlendOutTime { get; set;}

[REDProp("forceKeepIKactive")]
public bool ForceKeepIKactive { get; set;}

[REDProp("jobTreeType")]
public int JobTreeType { get; set;}

#endregion
}
}