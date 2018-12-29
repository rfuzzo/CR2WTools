using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateBestiary : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("BESTIARY_DESCRIPTION")]
public CName BESTIARY_DESCRIPTION { get; set;}

[REDProp("BESTIARY_CLOSE")]
public CName BESTIARY_CLOSE { get; set;}

[REDProp("OPEN_BESTIARY")]
public CName OPEN_BESTIARY { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}