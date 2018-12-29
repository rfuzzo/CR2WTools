using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskChangePriorityTillAnimEvent : IBehTreeTask
{
#region RED Properties

[REDProp("highPriority")]
public Int32 HighPriority { get; set;}

[REDProp("defaultPriority")]
public Int32 DefaultPriority { get; set;}

[REDProp("animEventName")]
public CName AnimEventName { get; set;}

[REDProp("allowBlend")]
public bool AllowBlend { get; set;}

#endregion
}
}