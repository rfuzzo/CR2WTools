using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskManageBlindCreatureDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("forgetTargetIfNPCSpeedLowerThan")]
public float ForgetTargetIfNPCSpeedLowerThan { get; set;}

[REDProp("remberTargetIfCloserThan")]
public float RemberTargetIfCloserThan { get; set;}

[REDProp("ignoreNoiseLowerThanWhenSprinting")]
public float IgnoreNoiseLowerThanWhenSprinting { get; set;}

[REDProp("prioritizePlayerAsTarget")]
public CBehTreeValBool PrioritizePlayerAsTarget { get; set;}

#endregion
}
}