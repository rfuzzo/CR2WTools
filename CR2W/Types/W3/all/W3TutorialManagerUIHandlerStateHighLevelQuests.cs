using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateHighLevelQuests : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("DESCRIPTION")]
public CName DESCRIPTION { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}