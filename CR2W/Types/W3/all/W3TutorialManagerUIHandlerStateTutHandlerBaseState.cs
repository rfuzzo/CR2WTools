using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateTutHandlerBaseState : CScriptableState
{
#region RED Properties

[REDProp("defaultTutorialMessage")]
public STutorialMessage DefaultTutorialMessage { get; set;}

[REDProp("currentlyShownHint")]
public CName CurrentlyShownHint { get; set;}

[REDProp("POS_INVENTORY_X")]
public float POS_INVENTORY_X { get; set;}

[REDProp("POS_INVENTORY_Y")]
public float POS_INVENTORY_Y { get; set;}

[REDProp("POS_ALCHEMY_X")]
public float POS_ALCHEMY_X { get; set;}

[REDProp("POS_ALCHEMY_Y")]
public float POS_ALCHEMY_Y { get; set;}

[REDProp("POS_CHAR_DEV_X")]
public float POS_CHAR_DEV_X { get; set;}

[REDProp("POS_CHAR_DEV_Y")]
public float POS_CHAR_DEV_Y { get; set;}

[REDProp("POS_MUTATIONS_X")]
public float POS_MUTATIONS_X { get; set;}

[REDProp("POS_MUTATIONS_Y")]
public float POS_MUTATIONS_Y { get; set;}

[REDProp("POS_MAP_X")]
public float POS_MAP_X { get; set;}

[REDProp("POS_MAP_Y")]
public float POS_MAP_Y { get; set;}

[REDProp("POS_QUESTS_X")]
public float POS_QUESTS_X { get; set;}

[REDProp("POS_QUESTS_Y")]
public float POS_QUESTS_Y { get; set;}

[REDProp("POS_GEEKPAGE_X")]
public float POS_GEEKPAGE_X { get; set;}

[REDProp("POS_GEEKPAGE_Y")]
public float POS_GEEKPAGE_Y { get; set;}

[REDProp("POS_DISMANTLE_X")]
public float POS_DISMANTLE_X { get; set;}

[REDProp("POS_DISMANTLE_Y")]
public float POS_DISMANTLE_Y { get; set;}

[REDProp("POS_RADIAL_X")]
public float POS_RADIAL_X { get; set;}

[REDProp("POS_RADIAL_Y")]
public float POS_RADIAL_Y { get; set;}

#endregion
}
}