using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeNodeAlreadyAtWorkDefinition : CBehTreeNodeCompleteImmediatelyDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("reportSuccess")]
public bool ReportSuccess { get; set;}

[REDProp("acceptDistance")]
public CBehTreeValFloat AcceptDistance { get; set;}

[REDProp("acceptRotationRequired")]
public CBehTreeValFloat AcceptRotationRequired { get; set;}

#endregion
}
}