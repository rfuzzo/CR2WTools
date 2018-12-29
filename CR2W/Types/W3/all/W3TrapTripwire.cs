using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TrapTripwire : W3Trap
{
#region RED Properties

[REDProp("eventOnTripped")]
public Array<Handle<IPerformableAction>> EventOnTripped { get; set;}

[REDProp("maxUseCount")]
public Int32 MaxUseCount { get; set;}

[REDProp("excludedActorsTags")]
public Array<CName> ExcludedActorsTags { get; set;}

#endregion
}
}