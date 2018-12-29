using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMoveSCTargetsCount : IMoveSteeringCondition
{
#region RED Properties

[REDProp("count")]
public uint Count { get; set;}

#endregion
}
}