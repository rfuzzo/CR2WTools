using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskWaitForDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("waitForTag")]
public CBehTreeValCName WaitForTag { get; set;}

[REDProp("timeout")]
public CBehTreeValFloat Timeout { get; set;}

[REDProp("testDistance")]
public CBehTreeValFloat TestDistance { get; set;}

#endregion
}
}