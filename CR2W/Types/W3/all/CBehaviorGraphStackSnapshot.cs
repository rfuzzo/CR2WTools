using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphStackSnapshot : CObject
{
#region RED Properties

[REDProp("instanceSnapshots")]
public Array<Ptr<CBehaviorGraphInstanceSnapshot>> InstanceSnapshots { get; set;}

#endregion
}
}