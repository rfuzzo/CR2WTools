using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3YrdenEntityStateYrdenShock : W3SignEntityStateActive
{
#region RED Properties

[REDProp("usedShockAreaName")]
public CName UsedShockAreaName { get; set;}

[REDProp("traceFrom")]
public Vector TraceFrom { get; set;}

[REDProp("traceTo")]
public Vector TraceTo { get; set;}

#endregion
}
}