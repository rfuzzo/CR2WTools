using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SEncounterGroupLimit 
{
#region RED Properties

[REDProp("groupName")]
public CName GroupName { get; set;}

[REDProp("limit")]
public uint Limit { get; set;}

#endregion
}
}