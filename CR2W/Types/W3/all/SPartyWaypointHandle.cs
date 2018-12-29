using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
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