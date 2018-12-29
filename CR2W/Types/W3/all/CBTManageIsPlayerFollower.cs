using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTManageIsPlayerFollower : IBehTreeTask
{
#region RED Properties

[REDProp("targetTagCondition")]
public CName TargetTagCondition { get; set;}

[REDProp("overrideForThisTask")]
public bool OverrideForThisTask { get; set;}

[REDProp("disable")]
public bool Disable { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("targetTagCompare")]
public CName TargetTagCompare { get; set;}

#endregion
}
}