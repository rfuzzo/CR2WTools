using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSteeringBehavior : CResource
{
#region RED Properties

[REDProp("root")]
public Ptr<IMoveSteeringNode> Root { get; set;}

#endregion
}
}