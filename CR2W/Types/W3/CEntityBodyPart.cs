using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEntityBodyPart 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("states")]
public Array<CEntityBodyPartState> States { get; set;}

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

#endregion
}
}