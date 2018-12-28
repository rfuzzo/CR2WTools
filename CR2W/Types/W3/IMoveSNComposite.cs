using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class IMoveSNComposite : IMoveSteeringNode
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("children")]
public Array<Ptr<IMoveSteeringNode>> Children { get; set;}

#endregion
}
}