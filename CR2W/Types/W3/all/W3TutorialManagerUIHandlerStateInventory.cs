using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateInventory : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("PAPERDOLL")]
public CName PAPERDOLL { get; set;}

[REDProp("BAG")]
public CName BAG { get; set;}

[REDProp("TABS")]
public CName TABS { get; set;}

[REDProp("STATS")]
public CName STATS { get; set;}

[REDProp("STATS_DETAILS")]
public CName STATS_DETAILS { get; set;}

[REDProp("EQUIPPING")]
public CName EQUIPPING { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}