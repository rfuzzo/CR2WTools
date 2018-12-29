using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_ManageFocusArea : W3SwitchEvent
{
#region RED Properties

[REDProp("focusAreaTag")]
public CName FocusAreaTag { get; set;}

[REDProp("enable")]
public bool Enable { get; set;}

[REDProp("focuAreaEntity")]
public Handle<W3FocusAreaTrigger> FocuAreaEntity { get; set;}

#endregion
}
}