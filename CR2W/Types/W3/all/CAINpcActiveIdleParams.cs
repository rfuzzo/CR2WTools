using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcActiveIdleParams : CAIIdleParameters
{
#region RED Properties

[REDProp("wanderTree")]
public Handle<CAIWanderTree> WanderTree { get; set;}

[REDProp("workTree")]
public Handle<CAINpcWork> WorkTree { get; set;}

#endregion
}
}