using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskForceSetStat : IBehTreeTask
{
#region RED Properties

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("percent")]
public Int32 Percent { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

#endregion
}
}