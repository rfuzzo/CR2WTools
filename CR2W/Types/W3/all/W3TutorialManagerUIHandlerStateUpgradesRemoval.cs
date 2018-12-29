using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateUpgradesRemoval : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("DESCRIPTION")]
public CName DESCRIPTION { get; set;}

[REDProp("ITEMS")]
public CName ITEMS { get; set;}

[REDProp("UPGRADES")]
public CName UPGRADES { get; set;}

[REDProp("COST")]
public CName COST { get; set;}

[REDProp("REMOVING")]
public CName REMOVING { get; set;}

[REDProp("POS_X")]
public float POS_X { get; set;}

[REDProp("POS_Y")]
public float POS_Y { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}