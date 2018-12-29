using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateForcedAlchemy : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("ALCHEMY_GO_TO")]
public CName ALCHEMY_GO_TO { get; set;}

[REDProp("OPEN_MENU")]
public CName OPEN_MENU { get; set;}

#endregion
}
}