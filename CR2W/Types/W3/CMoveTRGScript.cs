using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveTRGScript : CObject
{
#region RED Properties

[REDProp("agent")]
public Handle<CMovingAgentComponent> Agent { get; set;}

[REDProp("timeDelta")]
public float TimeDelta { get; set;}

#endregion
}
}