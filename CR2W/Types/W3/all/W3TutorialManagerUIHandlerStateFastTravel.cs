using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateFastTravel : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("FAST_TRAVEL")]
public CName FAST_TRAVEL { get; set;}

[REDProp("INTERACTION")]
public CName INTERACTION { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}