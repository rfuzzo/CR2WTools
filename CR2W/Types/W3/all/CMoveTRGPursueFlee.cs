using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMoveTRGPursueFlee : CMoveTRGScript
{
#region RED Properties

[REDProp("dangerNode")]
public Handle<CNode> DangerNode { get; set;}

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("flee")]
public bool Flee { get; set;}

#endregion
}
}