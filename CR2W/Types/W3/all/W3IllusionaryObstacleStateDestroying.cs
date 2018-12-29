using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3IllusionaryObstacleStateDestroying : CScriptableState
{
#region RED Properties

[REDProp("items")]
public Array<SItemUniqueId> Items { get; set;}

[REDProp("medallion")]
public SItemUniqueId Medallion { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

#endregion
}
}