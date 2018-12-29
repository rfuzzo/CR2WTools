using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskChangePriorityDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("priorityWhileActive")]
public Int32 PriorityWhileActive { get; set;}

[REDProp("defaultPriority")]
public Int32 DefaultPriority { get; set;}

#endregion
}
}