using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateRadial : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("SELECT_ITEMS")]
public CName SELECT_ITEMS { get; set;}

[REDProp("SELECT_BOLTS")]
public CName SELECT_BOLTS { get; set;}

[REDProp("BUFFS")]
public CName BUFFS { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}