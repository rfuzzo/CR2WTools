using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskBiesCharge : CBTTask3StateAttack
{
#region RED Properties

[REDProp("endStuck")]
public EAttackType EndStuck { get; set;}

[REDProp("endHit")]
public EAttackType EndHit { get; set;}

[REDProp("bCollisionWithObstacle")]
public bool BCollisionWithObstacle { get; set;}

[REDProp("bCollisionWithActor")]
public bool BCollisionWithActor { get; set;}

[REDProp("stuckTime")]
public float StuckTime { get; set;}

[REDProp("loopStart")]
public bool LoopStart { get; set;}

[REDProp("cameraIndex")]
public Int32 CameraIndex { get; set;}

[REDProp("isEnding")]
public bool IsEnding { get; set;}

[REDProp("collidedActor")]
public Handle<CActor> CollidedActor { get; set;}

#endregion
}
}