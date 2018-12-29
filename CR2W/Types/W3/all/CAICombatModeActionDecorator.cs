using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAICombatModeActionDecorator : IActionDecorator
{
#region RED Properties

[REDProp("drawWeaponOnStart")]
public bool DrawWeaponOnStart { get; set;}

[REDProp("LeftItemType")]
public CName LeftItemType { get; set;}

[REDProp("RightItemType")]
public CName RightItemType { get; set;}

[REDProp("changeBehaviorGraphOnStart")]
public bool ChangeBehaviorGraphOnStart { get; set;}

[REDProp("behGraph")]
public EBehaviorGraph BehGraph { get; set;}

[REDProp("changeBahviorGraphToExplorationOnDeacitvate")]
public bool ChangeBahviorGraphToExplorationOnDeacitvate { get; set;}

[REDProp("forceCombatModeOnPLAYER")]
public bool ForceCombatModeOnPLAYER { get; set;}

#endregion
}
}