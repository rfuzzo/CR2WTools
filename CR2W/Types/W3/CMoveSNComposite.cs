using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSNComposite : IMoveSNComposite
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("children")]
public Array<Ptr<IMoveSteeringNode>> Children { get; set;}

[REDProp("groupName")]
public string GroupName { get; set;}

#endregion
}
}