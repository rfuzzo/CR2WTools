using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateContinentMap : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("TO_CONTINENT")]
public CName TO_CONTINENT { get; set;}

[REDProp("BACK_TO_HUB")]
public CName BACK_TO_HUB { get; set;}

[REDProp("TO_ANY_HUB")]
public CName TO_ANY_HUB { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}