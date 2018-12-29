using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcWork : CAISubTree
{
#region RED Properties

[REDProp("actionPointSelector")]
public Handle<CActionPointSelector> ActionPointSelector { get; set;}

[REDProp("spawnToWork")]
public bool SpawnToWork { get; set;}

[REDProp("params")]
public Handle<CAINpcWorkParams> Params { get; set;}

#endregion
}
}