using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskChangeCaranthirStaff : IBehTreeTask
{
#region RED Properties

[REDProp("wasActivated")]
public bool WasActivated { get; set;}

[REDProp("startEffect")]
public bool StartEffect { get; set;}

#endregion
}
}