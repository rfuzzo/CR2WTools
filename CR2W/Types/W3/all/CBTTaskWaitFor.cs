using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskWaitFor : IBehTreeTask
{
#region RED Properties

[REDProp("waitForTag")]
public CName WaitForTag { get; set;}

[REDProp("timeout")]
public float Timeout { get; set;}

[REDProp("testDistance")]
public float TestDistance { get; set;}

[REDProp("timeoutCounter")]
public float TimeoutCounter { get; set;}

#endregion
}
}