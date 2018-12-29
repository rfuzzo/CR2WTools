using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateMutationsEquippedAfter : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("EQUIPPING_ONLY_ONE")]
public CName EQUIPPING_ONLY_ONE { get; set;}

[REDProp("MASTER")]
public CName MASTER { get; set;}

[REDProp("CHAR_PANEL")]
public CName CHAR_PANEL { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

[REDProp("activated")]
public bool Activated { get; set;}

#endregion
}
}