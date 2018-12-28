using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SCustomNode 
{
#region RED Properties

[REDProp("nodeName")]
public CName NodeName { get; set;}

[REDProp("attributes")]
public Array<SCustomNodeAttribute> Attributes { get; set;}

[REDProp("values")]
public Array<CName> Values { get; set;}

[REDProp("subNodes")]
public Array<SCustomNode> SubNodes { get; set;}

#endregion
}
}