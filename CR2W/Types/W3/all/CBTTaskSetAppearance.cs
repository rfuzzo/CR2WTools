using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSetAppearance : IBehTreeTask
{
#region RED Properties

[REDProp("appearanceName")]
public CName AppearanceName { get; set;}

[REDProp("previousAppearance")]
public CName PreviousAppearance { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onSuccess")]
public bool OnSuccess { get; set;}

[REDProp("onAnimEvent")]
public bool OnAnimEvent { get; set;}

[REDProp("overrideForTask")]
public bool OverrideForTask { get; set;}

[REDProp("eventName")]
public CName EventName { get; set;}

#endregion
}
}