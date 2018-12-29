using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateRunewords : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("RUNEWORDS2")]
public CName RUNEWORDS2 { get; set;}

[REDProp("ITEMS")]
public CName ITEMS { get; set;}

[REDProp("ENCHANTS")]
public CName ENCHANTS { get; set;}

[REDProp("ENCHANT_DESC")]
public CName ENCHANT_DESC { get; set;}

[REDProp("LEVEL")]
public CName LEVEL { get; set;}

[REDProp("UI")]
public CName UI { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

[REDProp("LEFT_X")]
public float LEFT_X { get; set;}

[REDProp("LEFT_Y")]
public float LEFT_Y { get; set;}

[REDProp("RIGHT_X")]
public float RIGHT_X { get; set;}

[REDProp("RIGHT_Y")]
public float RIGHT_Y { get; set;}

#endregion
}
}