using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskKillEntityByTag : IBehTreeTask
{
#region RED Properties

[REDProp("npc")]
public Array<Handle<CNewNPC>> Npc { get; set;}

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

#endregion
}
}