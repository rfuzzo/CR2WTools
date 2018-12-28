using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SPartyWaypointHandle 
{
#region RED Properties

[REDProp("partyMemberName")]
public CName PartyMemberName { get; set;}

[REDProp("entityHandle")]
public EntityHandle EntityHandle { get; set;}

[REDProp("componentName")]
public string ComponentName { get; set;}

#endregion
}
}