using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateFood : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("SELECT_TAB")]
public CName SELECT_TAB { get; set;}

[REDProp("SELECT_FOOD")]
public CName SELECT_FOOD { get; set;}

[REDProp("EQUIP_FOOD")]
public CName EQUIP_FOOD { get; set;}

[REDProp("USAGE")]
public CName USAGE { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}