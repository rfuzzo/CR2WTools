using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ElevatorSwitch : W3InteractionSwitch
{
#region RED Properties

[REDProp("elevator")]
public EntityHandle Elevator { get; set;}

[REDProp("switchType")]
public EElevatorSwitchType SwitchType { get; set;}

[REDProp("interactionComponent")]
public Handle<CInteractionComponent> InteractionComponent { get; set;}

[REDProp("switchRegistered")]
public bool SwitchRegistered { get; set;}

#endregion
}
}