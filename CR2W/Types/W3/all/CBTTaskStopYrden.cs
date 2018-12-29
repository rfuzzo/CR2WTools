using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskStopYrden : IBehTreeTask
{
#region RED Properties

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("yrden")]
public Handle<W3YrdenEntity> Yrden { get; set;}

[REDProp("yrdenIsActionTarget")]
public bool YrdenIsActionTarget { get; set;}

[REDProp("range")]
public float Range { get; set;}

[REDProp("useYrdenRadiusAsRange")]
public bool UseYrdenRadiusAsRange { get; set;}

[REDProp("maxResults")]
public Int32 MaxResults { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onAnimEvent")]
public bool OnAnimEvent { get; set;}

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("stopYrdenShock")]
public bool StopYrdenShock { get; set;}

#endregion
}
}