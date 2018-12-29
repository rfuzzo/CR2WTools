using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSetUnstoppable : IBehTreeTask
{
#region RED Properties

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onSuccess")]
public bool OnSuccess { get; set;}

[REDProp("overrideForThisTask")]
public bool OverrideForThisTask { get; set;}

[REDProp("makeUnpushable")]
public bool MakeUnpushable { get; set;}

[REDProp("enable")]
public bool Enable { get; set;}

[REDProp("m_savedPriority")]
public EInteractionPriority M_savedPriority { get; set;}

#endregion
}
}