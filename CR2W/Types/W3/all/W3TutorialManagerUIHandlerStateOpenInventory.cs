using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateOpenInventory : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("OPEN_FAST_MENU")]
public CName OPEN_FAST_MENU { get; set;}

[REDProp("OPEN_INVENTORY")]
public CName OPEN_INVENTORY { get; set;}

#endregion
}
}