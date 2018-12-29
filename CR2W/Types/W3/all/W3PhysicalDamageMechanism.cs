using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PhysicalDamageMechanism : CGameplayEntity
{
#region RED Properties

[REDProp("dmgValue")]
public float DmgValue { get; set;}

[REDProp("hitReactionType")]
public EHitReactionType HitReactionType { get; set;}

[REDProp("reactivationTimer")]
public float ReactivationTimer { get; set;}

[REDProp("animName")]
public CName AnimName { get; set;}

[REDProp("shouldRewind")]
public bool ShouldRewind { get; set;}

[REDProp("isActive")]
public bool IsActive { get; set;}

[REDProp("isMoving")]
public bool IsMoving { get; set;}

#endregion
}
}