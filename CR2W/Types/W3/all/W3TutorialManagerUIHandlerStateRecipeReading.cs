using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateRecipeReading : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("OPEN_INVENTORY")]
public CName OPEN_INVENTORY { get; set;}

[REDProp("SELECT_TAB")]
public CName SELECT_TAB { get; set;}

[REDProp("SELECT_BOOK")]
public CName SELECT_BOOK { get; set;}

[REDProp("USE")]
public CName USE { get; set;}

[REDProp("READ")]
public CName READ { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}