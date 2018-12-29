using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateMapPins : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("PLACE_PINS")]
public CName PLACE_PINS { get; set;}

[REDProp("CUSTOM_PINS")]
public CName CUSTOM_PINS { get; set;}

[REDProp("PINS_MAX_COUNT")]
public CName PINS_MAX_COUNT { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}