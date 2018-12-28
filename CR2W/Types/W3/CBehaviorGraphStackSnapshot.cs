using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphStackSnapshot : CObject
{
#region RED Properties

[REDProp("instanceSnapshots")]
public Array<Ptr<CBehaviorGraphInstanceSnapshot>> InstanceSnapshots { get; set;}

#endregion
}
}