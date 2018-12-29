using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSearchForRift : IBehTreeTask
{
#region RED Properties

[REDProp("selectedObject")]
public Handle<CNode> SelectedObject { get; set;}

[REDProp("range")]
public float Range { get; set;}

[REDProp("searchOnlyForActiveRifts")]
public bool SearchOnlyForActiveRifts { get; set;}

#endregion
}
}