using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTask3StateCharge : CBTTask3StateAttack
{
#region RED Properties

[REDProp("differentChargeEndings")]
public bool DifferentChargeEndings { get; set;}

[REDProp("bCollisionWithActor")]
public bool BCollisionWithActor { get; set;}

[REDProp("loopStart")]
public bool LoopStart { get; set;}

[REDProp("isEnding")]
public bool IsEnding { get; set;}

[REDProp("attached")]
public bool Attached { get; set;}

[REDProp("cameraIndex")]
public Int32 CameraIndex { get; set;}

[REDProp("collidedActor")]
public Handle<CActor> CollidedActor { get; set;}

#endregion
}
}