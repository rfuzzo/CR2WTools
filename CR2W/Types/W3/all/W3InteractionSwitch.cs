using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3InteractionSwitch : W3PhysicalSwitch
{
#region RED Properties

[REDProp("isActivatedByPlayer")]
public bool IsActivatedByPlayer { get; set;}

[REDProp("focusModeHighlight")]
public EFocusModeVisibility FocusModeHighlight { get; set;}

[REDProp("interactionActiveInState")]
public ESwitchState InteractionActiveInState { get; set;}

#endregion
}
}