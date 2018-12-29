using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskChangeInteractionPriority : IBehTreeTask
{
#region RED Properties

[REDProp("previousInteractionPriority")]
public EInteractionPriority PreviousInteractionPriority { get; set;}

[REDProp("priorityChanged")]
public bool PriorityChanged { get; set;}

#endregion
}
}