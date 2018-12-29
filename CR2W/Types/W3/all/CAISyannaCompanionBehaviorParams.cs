using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAISyannaCompanionBehaviorParams : IAIActionParameters
{
#region RED Properties

[REDProp("targetTag")]
public CName TargetTag { get; set;}

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("keepDistance")]
public bool KeepDistance { get; set;}

[REDProp("followDistance")]
public float FollowDistance { get; set;}

[REDProp("moveSpeed")]
public float MoveSpeed { get; set;}

[REDProp("followTargetSelection")]
public bool FollowTargetSelection { get; set;}

[REDProp("teleportToCatchup")]
public bool TeleportToCatchup { get; set;}

[REDProp("cachupDistance")]
public float CachupDistance { get; set;}

[REDProp("rotateToWhenAtTarget")]
public bool RotateToWhenAtTarget { get; set;}

[REDProp("idleTimeToPlaySlotAnim")]
public float IdleTimeToPlaySlotAnim { get; set;}

[REDProp("slotAnimCooldown")]
public float SlotAnimCooldown { get; set;}

[REDProp("slotName")]
public CName SlotName { get; set;}

[REDProp("animName_1_start")]
public CName AnimName_1_start { get; set;}

[REDProp("animName_1_loop")]
public CName AnimName_1_loop { get; set;}

[REDProp("animName_1_stop")]
public CName AnimName_1_stop { get; set;}

[REDProp("animName_2_start")]
public CName AnimName_2_start { get; set;}

[REDProp("animName_2_loop")]
public CName AnimName_2_loop { get; set;}

[REDProp("animName_2_stop")]
public CName AnimName_2_stop { get; set;}

[REDProp("animName_3_start")]
public CName AnimName_3_start { get; set;}

[REDProp("animName_3_loop")]
public CName AnimName_3_loop { get; set;}

[REDProp("animName_3_stop")]
public CName AnimName_3_stop { get; set;}

[REDProp("animName_4_start")]
public CName AnimName_4_start { get; set;}

[REDProp("animName_4_loop")]
public CName AnimName_4_loop { get; set;}

[REDProp("animName_4_stop")]
public CName AnimName_4_stop { get; set;}

#endregion
}
}