using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIFrostAttackActionTree : IAICustomActionTree
{
#region RED Properties

[REDProp("targetTag")]
public CName TargetTag { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("clampDurationWhenTargetReached")]
public float ClampDurationWhenTargetReached { get; set;}

#endregion
}
}