using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CTicketConfigurationParam : CGameplayEntityParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("overrideInherited")]
public bool OverrideInherited { get; set;}

[REDProp("tickets")]
public Array<CTicketSourceConfiguration> Tickets { get; set;}

#endregion
}
}