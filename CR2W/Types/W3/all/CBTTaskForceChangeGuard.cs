using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskForceChangeGuard : IBehTreeTask
{
#region RED Properties

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDectivate")]
public bool OnDectivate { get; set;}

[REDProp("raiseGuard")]
public bool RaiseGuard { get; set;}

[REDProp("lowerGuard")]
public bool LowerGuard { get; set;}

#endregion
}
}