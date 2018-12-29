using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSearchForThrowable : IBehTreeTask
{
#region RED Properties

[REDProp("range")]
public float Range { get; set;}

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("selectedObject")]
public Handle<CNode> SelectedObject { get; set;}

[REDProp("physicalComponent")]
public Handle<CComponent> PhysicalComponent { get; set;}

[REDProp("activate")]
public bool Activate { get; set;}

[REDProp("findTime")]
public float FindTime { get; set;}

#endregion
}
}