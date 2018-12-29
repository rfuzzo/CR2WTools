using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskRiderWaitForDismount : IBehTreeTask
{
#region RED Properties

[REDProp("rider")]
public Handle<CActor> Rider { get; set;}

[REDProp("actionResult")]
public bool ActionResult { get; set;}

[REDProp("activate")]
public bool Activate { get; set;}

#endregion
}
}