using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SPartyWaypointData 
{
#region RED Properties

[REDProp("position")]
public Vector3 Position { get; set;}

[REDProp("rotation")]
public float Rotation { get; set;}

[REDProp("memberName")]
public CName MemberName { get; set;}

#endregion
}
}