using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskTeleportPlayerToNode : IBehTreeTask
{
#region RED Properties

[REDProp("nodeToFind")]
public CName NodeToFind { get; set;}

[REDProp("shouldComplete")]
public bool ShouldComplete { get; set;}

[REDProp("node")]
public Handle<CNode> Node { get; set;}

[REDProp("pos")]
public Vector Pos { get; set;}

[REDProp("rot")]
public EulerAngles Rot { get; set;}

#endregion
}
}