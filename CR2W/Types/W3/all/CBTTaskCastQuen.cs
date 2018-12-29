using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCastQuen : CBTTaskCastSign
{
#region RED Properties

[REDProp("completeAfterHit")]
public bool CompleteAfterHit { get; set;}

[REDProp("alternateFireMode")]
public bool AlternateFireMode { get; set;}

[REDProp("processQuenOnCounterActivation")]
public bool ProcessQuenOnCounterActivation { get; set;}

[REDProp("hitEventReceived")]
public bool HitEventReceived { get; set;}

[REDProp("hitEntity")]
public Handle<CEntity> HitEntity { get; set;}

[REDProp("hitEntityTemplate")]
public Handle<CEntityTemplate> HitEntityTemplate { get; set;}

[REDProp("ownerBoneIndex")]
public Int32 OwnerBoneIndex { get; set;}

[REDProp("shieldActive")]
public bool ShieldActive { get; set;}

[REDProp("humanCombatDataStorage")]
public Handle<CHumanAICombatStorage> HumanCombatDataStorage { get; set;}

[REDProp("playEffectTimeStamp")]
public float PlayEffectTimeStamp { get; set;}

#endregion
}
}