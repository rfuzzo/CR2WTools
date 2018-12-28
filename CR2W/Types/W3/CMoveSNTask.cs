using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSNTask : IMoveSteeringNode
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("task")]
public Ptr<IMoveSteeringTask> Task { get; set;}

#endregion
}
}