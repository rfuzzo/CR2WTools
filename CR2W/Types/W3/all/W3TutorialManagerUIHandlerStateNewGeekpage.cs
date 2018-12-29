using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateNewGeekpage : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("STATS")]
public CName STATS { get; set;}

[REDProp("SUBSTATS")]
public CName SUBSTATS { get; set;}

[REDProp("CONTROLS")]
public CName CONTROLS { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}