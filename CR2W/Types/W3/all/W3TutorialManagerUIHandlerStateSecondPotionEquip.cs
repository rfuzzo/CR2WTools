using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateSecondPotionEquip : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("CAN_EQUIP")]
public CName CAN_EQUIP { get; set;}

[REDProp("SELECT_TAB")]
public CName SELECT_TAB { get; set;}

[REDProp("EQUIP_POTION")]
public CName EQUIP_POTION { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}