using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateNewInventory : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("TAB_CRAFTING")]
public CName TAB_CRAFTING { get; set;}

[REDProp("TAB_QUEST")]
public CName TAB_QUEST { get; set;}

[REDProp("TAB_MISC")]
public CName TAB_MISC { get; set;}

[REDProp("TAB_ALCHEMY")]
public CName TAB_ALCHEMY { get; set;}

[REDProp("TAB_WEAPONS")]
public CName TAB_WEAPONS { get; set;}

[REDProp("TOOLTIPS")]
public CName TOOLTIPS { get; set;}

[REDProp("PREVIEW")]
public CName PREVIEW { get; set;}

[REDProp("PREVIEW2")]
public CName PREVIEW2 { get; set;}

[REDProp("SORTING")]
public CName SORTING { get; set;}

[REDProp("GEEKPAGE")]
public CName GEEKPAGE { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}