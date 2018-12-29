using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcActiveIdle : CAIIdleTree
{
#region RED Properties

[REDProp("params")]
public Handle<CAINpcActiveIdleParams> Params { get; set;}

[REDProp("delayWorkOnFailure")]
public float DelayWorkOnFailure { get; set;}

[REDProp("delayWorkOnSuccess")]
public float DelayWorkOnSuccess { get; set;}

[REDProp("delayWorkOnInterruption")]
public float DelayWorkOnInterruption { get; set;}

#endregion
}
}