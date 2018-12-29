using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PlayerWitcherStateApproachInteractionState : CR4PlayerStateExtendedMovable
{
#region RED Properties

[REDProp("objectPointHeading")]
public float ObjectPointHeading { get; set;}

[REDProp("objectHeadingSet")]
public bool ObjectHeadingSet { get; set;}

[REDProp("stopRequested")]
public bool StopRequested { get; set;}

[REDProp("objectEntity")]
public Handle<CEntity> ObjectEntity { get; set;}

[REDProp("switchOn")]
public bool SwitchOn { get; set;}

[REDProp("switchAnimationType")]
public PhysicalSwitchAnimationType SwitchAnimationType { get; set;}

#endregion
}
}