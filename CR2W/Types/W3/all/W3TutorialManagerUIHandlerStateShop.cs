using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateShop : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("DESCRIPTION")]
public CName DESCRIPTION { get; set;}

[REDProp("BUY")]
public CName BUY { get; set;}

[REDProp("CLOSE")]
public CName CLOSE { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

[REDProp("SHOP_POS_CLOSE_X")]
public float SHOP_POS_CLOSE_X { get; set;}

[REDProp("SHOP_POS_CLOSE_Y")]
public float SHOP_POS_CLOSE_Y { get; set;}

[REDProp("SHOP_POS_X")]
public float SHOP_POS_X { get; set;}

[REDProp("SHOP_POS_Y")]
public float SHOP_POS_Y { get; set;}

#endregion
}
}