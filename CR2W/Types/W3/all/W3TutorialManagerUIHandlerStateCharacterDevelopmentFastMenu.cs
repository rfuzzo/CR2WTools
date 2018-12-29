using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateCharacterDevelopmentFastMenu : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("PANEL")]
public CName PANEL { get; set;}

[REDProp("CHAR_DEV_OPEN")]
public CName CHAR_DEV_OPEN { get; set;}

#endregion
}
}