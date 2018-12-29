using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateMap : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("OPEN_MAP")]
public CName OPEN_MAP { get; set;}

[REDProp("DESCRIPTION")]
public CName DESCRIPTION { get; set;}

[REDProp("JUMP_TO_OBJECTIVE")]
public CName JUMP_TO_OBJECTIVE { get; set;}

[REDProp("NAVIGATE")]
public CName NAVIGATE { get; set;}

[REDProp("QUEST_PINS")]
public CName QUEST_PINS { get; set;}

[REDProp("OBJECTIVES")]
public CName OBJECTIVES { get; set;}

[REDProp("AREA_MAP")]
public CName AREA_MAP { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}