using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4LocomotionSwimToStop : CR4LocomotionDirectControllerScript
{
#region RED Properties

[REDProp("player")]
public Handle<CR4Player> Player { get; set;}

[REDProp("targetPoint")]
public Vector TargetPoint { get; set;}

[REDProp("closeEnough")]
public bool CloseEnough { get; set;}

#endregion
}
}