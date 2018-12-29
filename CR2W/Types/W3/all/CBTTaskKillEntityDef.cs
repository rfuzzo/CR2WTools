using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskKillEntityDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("entity")]
public Handle<CNewNPC> Entity { get; set;}

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

#endregion
}
}