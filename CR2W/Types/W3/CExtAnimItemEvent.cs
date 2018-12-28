using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CExtAnimItemEvent : CExtAnimEvent
{
#region RED Properties

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("startTime")]
public float StartTime { get; set;}

[REDProp("reportToScript")]
public bool ReportToScript { get; set;}

[REDProp("reportToScriptMinWeight")]
public float ReportToScriptMinWeight { get; set;}

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("category")]
public CName Category { get; set;}

[REDProp("itemName_optional")]
public CName ItemName_optional { get; set;}

[REDProp("action")]
public EItemAction Action { get; set;}

[REDProp("ignoreItemsWithTag")]
public CName IgnoreItemsWithTag { get; set;}

[REDProp("itemGetting")]
public EGettingItem ItemGetting { get; set;}

#endregion
}
}