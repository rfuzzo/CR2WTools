using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateMapFilters : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("SELECT")]
public CName SELECT { get; set;}

[REDProp("CUSTOMIZE")]
public CName CUSTOMIZE { get; set;}

[REDProp("PIN_JUMPING")]
public CName PIN_JUMPING { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}